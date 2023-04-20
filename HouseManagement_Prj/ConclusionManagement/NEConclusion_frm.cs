using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseManagement_Prj
{
    public partial class NEConclusion_frm : Form
    {
        public NEConclusion_frm()
        {
            InitializeComponent();
        }

        public int NewOrEditConclusion, CncluID, HouseID;
        public string FileNo, PriceHAll, PriceM, PriceR;
        private int MaxConclusionID;
        private string FileNoHolder, CncluNoHolder;
        DataClassesSecondDataContext DCMD = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void NEConclusion_frm_Load(object sender, EventArgs e)
        {
            SetDefault_NEConclusion();
        }

        private void SetDefault_NEConclusion()
        {
            label_Mny1.Text = Global_Cls.Money_Unit;
            label_Mny2.Text = label_Mny1.Text;

            try
            {
                var MaxID = (from prd in DCMD.Tbl_HouseConclusions
                             select prd.ConclusionID).Max();
                MaxConclusionID = MaxID;
            }
            catch
            {
                MaxConclusionID = 0;
            }


            if (NewOrEditConclusion == 2)
            {
                try
                {
                    Tbl_HouseConclusion tbhc = DCMD.Tbl_HouseConclusions.First(thfr => thfr.ConclusionID.Equals(CncluID));

                    //date
                    string DateStr = Global_Cls.MiladiDateToShamsi(tbhc.Hc_Date.Value);
                    comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                    //textBox_Date.Text = Global_Cls.MiladiDateToShamsi(tbhc.Hc_Date.Value);

                    textBox_CncluNo.Text = tbhc.Hc_No; CncluNoHolder = tbhc.Hc_No;
                    textBox_FileNo.Text = tbhc.HF_FileNo; FileNoHolder = tbhc.HF_FileNo;
                    comboBox_Type.Text = tbhc.Hc_Type;

                    textBox_LName.Text = tbhc.Hc_LName;
                    textBox_LFamily.Text = tbhc.Hc_LFamily;
                    textBox_LFatherN.Text = tbhc.Hc_LFathername;
                    textBox_LMelliCode.Text = tbhc.Hc_LMelicode;

                    textBox_CName.Text = tbhc.Hc_CName;
                    textBox_CFamily.Text = tbhc.Hc_CFamily;
                    textBox_CFatherN.Text = tbhc.Hc_CFathername;
                    textBox_CMelliCode.Text = tbhc.Hc_CMelicode;

                    textBox_CostPrice.Text = Global_Cls.DigitSeparator(tbhc.Hc_CostPrice.ToString());
                    textBox_CostMtg.Text = Global_Cls.DigitSeparator(tbhc.Hc_CostMtg.ToString());
                    textBox_CostRent.Text = Global_Cls.DigitSeparator(tbhc.Hc_CostRent.ToString());
                    nUpDown_RentMonth.Value = tbhc.Hc_RentMonth.Value;

                    textBox_ComCost.Text = Global_Cls.DigitSeparator(tbhc.Hc_CommissionCost.ToString());
                    textBox_DutyCost.Text = Global_Cls.DigitSeparator(tbhc.Hc_DutyCost.ToString());
                    textBox_InterceptionCode.Text = tbhc.Interception_Code;
                    textBox_Desc.Text = tbhc.Hc_Description;

                }
                catch
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!");
                }
            }
            else if (NewOrEditConclusion == 1)
            {
                //date
                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                //textBox_Date.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                textBox_CncluNo.Text = (MaxConclusionID + 1).ToString();
                textBox_FileNo.Text = FileNo.ToString();
                textBox_CostPrice.Text = PriceHAll.ToString();
                textBox_CostMtg.Text = PriceM.ToString();
                textBox_CostRent.Text = PriceR.ToString();
                textBox_FileNo.ReadOnly = true;
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_CncluNo.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "شماره برگه قرارداد را وارد نمایید!"); textBox_CncluNo.Focus(); return; }
            if (textBox_FileNo.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "شماره فایل را وارد نمایید!"); textBox_FileNo.Focus(); return; }
            if (comboBox_Type.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نوع قرارداد را مشخص نمایید!"); comboBox_Type.Focus(); return; }
            if (textBox_LFamily.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نام خانواگی مالک را وارد نمایید!"); textBox_LFamily.Focus(); return; }
            if (textBox_CFamily.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نام خانواگی متقاضی را وارد نمایید!"); textBox_CFamily.Focus(); return; }
            panel_CDate1_Leave(this, null);

            if (NewOrEditConclusion == 2)
            {
                if (textBox_CncluNo.Text != CncluNoHolder)
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "آیا مایلید شماره برگه قرارداد تغییر کند؟"))
                    { textBox_CncluNo.Focus(); return; }

                if (textBox_FileNo.Text != FileNoHolder)
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "آیا مایلید شماره فایل تغییر کند؟"))
                    { textBox_FileNo.Focus(); return; }
            }

            string MsgStr = "";
            if (NewOrEditConclusion == 1) MsgStr = "آیا به ثبت این قرارداد اطمینان دارید؟";
            else MsgStr = "آیا مایلید تفییرات ذخیره شوند؟";
            if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, MsgStr))
                if (OKFunction())
                {
                    if (checkBox_ListConclusion.Checked) Global_Cls.MainForm.buttonItem_ListConclusion_Click(this, null);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
        }

        private bool OKFunction()
        {
            if (NewOrEditConclusion == 1)
                try
                {
                    Tbl_HouseConclusion THC = new Tbl_HouseConclusion
                    {
                        Hc_Date = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text),//textBox_Date.Text),
                        Hc_No = textBox_CncluNo.Text,
                        HF_FileNo = textBox_FileNo.Text,
                        Hc_Type = comboBox_Type.Text,

                        Hc_LName = textBox_LName.Text,
                        Hc_LFamily = textBox_LFamily.Text,
                        Hc_LFathername = textBox_LFatherN.Text,
                        Hc_LMelicode = textBox_LMelliCode.Text,
                        
                        Hc_CName = textBox_CName.Text,
                        Hc_CFamily = textBox_CFamily.Text,
                        Hc_CFathername = textBox_CFatherN.Text,
                        Hc_CMelicode = textBox_CMelliCode.Text,

                        Hc_CostPrice = (Int64)((textBox_CostPrice.Text == "") ? 0 : Int64.Parse(textBox_CostPrice.Text.Replace(",", ""))),
                        Hc_CostMtg = (Int64)((textBox_CostMtg.Text == "") ? 0 : Int64.Parse(textBox_CostMtg.Text.Replace(",", ""))),
                        Hc_CostRent = (Int64)((textBox_CostRent.Text == "") ? 0 : Int64.Parse(textBox_CostRent.Text.Replace(",", ""))),
                        Hc_RentMonth = Convert.ToInt32( nUpDown_RentMonth.Value ),

                        Hc_CommissionCost = (Int64)((textBox_ComCost.Text == "") ? 0 : Int64.Parse(textBox_ComCost.Text.Replace(",", ""))),
                        Hc_DutyCost = (Int64)((textBox_DutyCost.Text == "") ? 0 : Int64.Parse(textBox_DutyCost.Text.Replace(",", ""))),
                        Interception_Code = textBox_InterceptionCode.Text,
                        User_Code = Global_Cls.UserCode_Exist,
                        Hc_Description = textBox_Desc.Text,

                        HouseId = HouseID,
                    };
                    DCMD.Tbl_HouseConclusions.InsertOnSubmit(THC);
                    DCMD.SubmitChanges();
                }
                catch
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!");
                    return false;
                }
            else
                if (NewOrEditConclusion == 2)
                    try
                    {
                        Tbl_HouseConclusion tbhc = DCMD.Tbl_HouseConclusions.First(thfh => thfh.ConclusionID.Equals(CncluID));

                        tbhc.Hc_Date = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text);//textBox_Date.Text);
                        tbhc.Hc_No = textBox_CncluNo.Text;
                        tbhc.HF_FileNo = textBox_FileNo.Text;
                        tbhc.Hc_Type = comboBox_Type.Text;

                        tbhc.Hc_LName = textBox_LName.Text;
                        tbhc.Hc_LFamily = textBox_LFamily.Text;
                        tbhc.Hc_LFathername = textBox_LFatherN.Text;
                        tbhc.Hc_LMelicode = textBox_LMelliCode.Text;

                        tbhc.Hc_CName = textBox_CName.Text;
                        tbhc.Hc_CFamily = textBox_CFamily.Text;
                        tbhc.Hc_CFathername = textBox_CFatherN.Text;
                        tbhc.Hc_CMelicode = textBox_CMelliCode.Text;

                        tbhc.Hc_CostPrice = (Int64)((textBox_CostPrice.Text == "") ? 0 : Int64.Parse(textBox_CostPrice.Text.Replace(",", "")));
                        tbhc.Hc_CostMtg = (Int64)((textBox_CostMtg.Text == "") ? 0 : Int64.Parse(textBox_CostMtg.Text.Replace(",", "")));
                        tbhc.Hc_CostRent = (Int64)((textBox_CostRent.Text == "") ? 0 : Int64.Parse(textBox_CostRent.Text.Replace(",", "")));
                        tbhc.Hc_RentMonth = Convert.ToInt32( nUpDown_RentMonth.Value );

                        tbhc.Hc_CommissionCost = (Int64)((textBox_ComCost.Text == "") ? 0 : Int64.Parse(textBox_ComCost.Text.Replace(",", "")));
                        tbhc.Hc_DutyCost = (Int64)((textBox_DutyCost.Text == "") ? 0 : Int64.Parse(textBox_DutyCost.Text.Replace(",", "")));

                        tbhc.Interception_Code = textBox_InterceptionCode.Text;
                        tbhc.User_Code = Global_Cls.UserCode_Exist;
                        tbhc.Hc_Description = textBox_Desc.Text.ToString();

                        DCMD.SubmitChanges();
                    }
                    catch
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!");
                        return false;
                    }

            return true;
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Other
        TextBox tx = new TextBox();
        private void textBox_CostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            { e.KeyChar = '\0'; return; }

            if (e.KeyChar == (char)Keys.Space)
            {
                tx = (TextBox)sender;
                if (tx.Text.Length < 18) tx.Text = tx.Text + "000";
                tx.SelectionStart = tx.Text.Length;
            }
        }

        private void textBox_CostPrice_TextChanged(object sender, EventArgs e)
        {
            tx = (TextBox)sender;
            string str = tx.Text;
            int ts = tx.SelectionStart;
            if (tx.Text != "")
            {
                try
                {
                    str = System.String.Format("{0:###,###}", System.Int64.Parse(str, System.Globalization.NumberStyles.Number));
                }
                catch
                {
                    str = str.Replace(",", "");
                }
                tx.Text = str.Replace(" ", "");
                tx.SelectionStart = ts + 1;
            }

        }

        private void panel_CDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }
        #endregion
    }
}

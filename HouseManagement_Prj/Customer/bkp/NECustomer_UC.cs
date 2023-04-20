using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseManagement_Prj
{
    public partial class NECustomer_UC : UserControl
    {
        public NECustomer_UC()
        {
            InitializeComponent();
        }

        public int NewOrEditCustomer, CtID;
        private int MaxRequestID;
        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext();

        #region Data OK
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (OKFunction())
                Global_Cls.MainForm.DeleteTabFromTabControl(Global_Cls.MainForm.tabControl_Main.SelectedTab);
        }

        private void buttonItem_OkNext_Click(object sender, EventArgs e)
        {
            if (OKFunction())
            {
                Global_Cls.MainForm.DeleteTabFromTabControl(Global_Cls.MainForm.tabControl_Main.SelectedTab);
                Global_Cls.MainForm.NewCustomer_Function();
            }
        }

        private bool OKFunction()
        {
            if (NewOrEditCustomer == 1)
            try
            {
                TBL_HouseRequest THR = new TBL_HouseRequest
                {
                    RequestDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text,comboBox_Month1.Text,comboBox_day1.Text),//textBox_RDate.Text),
                    Customer_Name = textBox_CName.Text,
                    Customer_Family = textBox_CFamilly.Text,
                    Customer_Tel = textBox_CTel.Text,
                    Customer_Mobile = textBox_CMobile.Text,
                    Customer_Email = textBox_CEmail.Text,
                    Approach_Type = radioButton_Facing.Checked,

                    TR_Buy = checkBox_Buy.Checked,
                    TR_Rent = checkBox_Rent.Checked,
                    TR_Mortgage = checkBox_Mortgage.Checked,
                    TR_PreBuy = checkBox_PreBuy.Checked,
                    TR_Participation = checkBox_Prtpc.Checked,
                    THR_Apartment = radioButton_Apartmnt.Checked,
                    THR_Tenement = radioButton_Tent.Checked,
                    THR_Vila = radioButton_Villa.Checked,
                    THR_DilapiDated = radioButton_Dila.Checked,
                    THR_Land = radioButton_Ln.Checked,
                    THR_PartialLand = radioButton_PLn.Checked,
                    THR_StoreRoom = radioButton_SR.Checked,
                    THR_WorkRoom = radioButton_WR.Checked,
                    THR_Shop = radioButton_Shop.Checked,
                    THR_Suit = radioButton_St.Checked,
                    THR_Garden = radioButton_Garden.Checked,
                    THR_SmallGarden = radioButton_SGarden.Checked,
                    PR_Northern = radioButton_North.Checked,
                    PR_Southern = radioButton_Soutern.Checked,
                    PR_Western = radioButton_West.Checked,
                    PR_Eastern = radioButton_East.Checked,

                    Type_Document = comboBox_DocType.Text,
                    Type_Use = comboBox_UseType.Text,
                    Request_Use = comboBox_ReqUse.Text,
                    TypeGive_Buy = comboBox_TGBuy.Text,
                    Req_SubMeter = Convert.ToDouble(textBox_Subbuild.Text),
                    User_Code = Global_Cls.UserCode_Exist,

                    Description = textBox_Desc.Text,
                    FewPerson_Rent = Convert.ToInt16(nUpDown_FewPerson.Value),

                    Bodget_Buy = Convert.ToInt64(textBox_BBuy.Text.Replace(",", "")),
                    Bodget_Rent = Convert.ToInt64(textBox_BRent.Text.Replace(",", "")),
                    Bodget_Mortgage = Convert.ToInt64(textBox_BMrtg.Text.Replace(",", "")),

                    PartRequest1 = Convert.ToInt32(comboBox_Part1.SelectedValue),
                    PartRequest2 = Convert.ToInt32(comboBox_Part2.SelectedValue),
                    PartRequest3 = Convert.ToInt32(comboBox_Part3.SelectedValue),
                    PartRequest4 = Convert.ToInt32(comboBox_Part4.SelectedValue),

                    Expired_Date = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_day2.Text),
                    Document_Exist = checkBox_DocExist.Checked
                };
                DCMD.TBL_HouseRequests.InsertOnSubmit(THR);
                DCMD.SubmitChanges();
                MaxRequestID++;
        
            }
            catch
            {
                //MessageBox.Show("");
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در ثبت");
                return false;
            }
            else
                if (NewOrEditCustomer == 2)
                    try
                    {
                        TBL_HouseRequest tbhr = DCMD.TBL_HouseRequests.First(thfh => thfh.RequestID.Equals(CtID));

                        tbhr.RequestDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text);//textBox_RDate.Text);
                        tbhr.Customer_Name = textBox_CName.Text;
                        tbhr.Customer_Family = textBox_CFamilly.Text;
                        tbhr.Customer_Tel = textBox_CTel.Text;
                        tbhr.Customer_Mobile = textBox_CMobile.Text;
                        tbhr.Customer_Email = textBox_CEmail.Text;
                        tbhr.Approach_Type = radioButton_Facing.Checked;

                        tbhr.TR_Buy = checkBox_Buy.Checked;
                        tbhr.TR_Rent = checkBox_Rent.Checked;
                        tbhr.TR_Mortgage = checkBox_Mortgage.Checked;
                        tbhr.TR_PreBuy = checkBox_PreBuy.Checked;
                        tbhr.TR_Participation = checkBox_Prtpc.Checked;
                        tbhr.THR_Apartment = radioButton_Apartmnt.Checked;
                        tbhr.THR_Tenement = radioButton_Tent.Checked;
                        tbhr.THR_Vila = radioButton_Villa.Checked;
                        tbhr.THR_DilapiDated = radioButton_Dila.Checked;
                        tbhr.THR_Land = radioButton_Ln.Checked;
                        tbhr.THR_PartialLand = radioButton_PLn.Checked;
                        tbhr.THR_StoreRoom = radioButton_SR.Checked;
                        tbhr.THR_WorkRoom = radioButton_WR.Checked;
                        tbhr.THR_Shop = radioButton_Shop.Checked;
                        tbhr.THR_Suit = radioButton_St.Checked;
                        tbhr.THR_Garden = radioButton_Garden.Checked;
                        tbhr.THR_SmallGarden = radioButton_SGarden.Checked;
                        tbhr.PR_Northern = radioButton_North.Checked;
                        tbhr.PR_Southern = radioButton_Soutern.Checked;
                        tbhr.PR_Western = radioButton_West.Checked;
                        tbhr.PR_Eastern = radioButton_East.Checked;

                        tbhr.Type_Document = comboBox_DocType.Text;
                        tbhr.Type_Use = comboBox_UseType.Text;
                        tbhr.Request_Use = comboBox_ReqUse.Text;
                        tbhr.TypeGive_Buy = comboBox_TGBuy.Text;
                        tbhr.Req_SubMeter = Convert.ToDouble(textBox_Subbuild.Text);
                        tbhr.User_Code = Global_Cls.UserCode_Exist;

                        tbhr.Description = textBox_Desc.Text;
                        tbhr.FewPerson_Rent = Convert.ToInt16(nUpDown_FewPerson.Value);

                        tbhr.Bodget_Buy = Convert.ToInt64(textBox_BBuy.Text.Replace(",", ""));
                        tbhr.Bodget_Rent = Convert.ToInt64(textBox_BRent.Text.Replace(",", ""));
                        tbhr.Bodget_Mortgage = Convert.ToInt64(textBox_BMrtg.Text.Replace(",", ""));

                        tbhr.PartRequest1 = Convert.ToInt32(comboBox_Part1.SelectedValue);
                        tbhr.PartRequest2 = Convert.ToInt32(comboBox_Part2.SelectedValue);
                        tbhr.PartRequest3 = Convert.ToInt32(comboBox_Part3.SelectedValue);
                        tbhr.PartRequest4 = Convert.ToInt32(comboBox_Part4.SelectedValue);

                        tbhr.Expired_Date = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_day2.Text);
                        tbhr.Document_Exist = checkBox_DocExist.Checked;

                        DCMD.SubmitChanges();
                    }
                    catch //(Exception ex)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در ثبت");
                        return false;
                    }

            //اضافه به دفتر تلفن
            if (checkBox_AddTelNotebookCu.Checked)
                if (!Global_Cls.InsertPerTelMob(textBox_CName.Text, textBox_CFamilly.Text, textBox_CTel.Text, textBox_CMobile.Text, textBox_CEmail.Text, "", ""))
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "این فرد در دفتر تلفن موجود می باشد!");
            
            return true;
        }
        #endregion



        #region Load Data
        public void SetDefault_NECustomer()
        {
            try
            {
                var MaxID = (from prd in DCMD.TBL_HouseRequests
                             select prd.RequestID).Max();
                MaxRequestID = MaxID;
            }
            catch
            {
                MaxRequestID = 0;
            }


            if (NewOrEditCustomer == 2)
            {
                try
                {
                    TBL_HouseRequest tbhr = DCMD.TBL_HouseRequests.First(thfr => thfr.RequestID.Equals(CtID));

                    textBox_RN.Text = tbhr.RequestID.ToString();
//                    textBox_RDate.Text = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhr.RequestDate));
                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhr.RequestDate));
                    comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString(); 
                    comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_CName.Text = tbhr.Customer_Name;
                    textBox_CFamilly.Text = tbhr.Customer_Family;
                    textBox_CTel.Text = tbhr.Customer_Tel;
                    textBox_CMobile.Text = tbhr.Customer_Mobile;
                    textBox_CEmail.Text = tbhr.Customer_Email;
                    radioButton_Facing.Checked = tbhr.Approach_Type.Value;
                    radioButton_NoFacing.Checked = !tbhr.Approach_Type.Value;

                    checkBox_Buy.Checked = tbhr.TR_Buy.Value;
                    checkBox_Rent.Checked = tbhr.TR_Rent.Value;
                    checkBox_Mortgage.Checked = tbhr.TR_Mortgage.Value;
                    checkBox_PreBuy.Checked = tbhr.TR_PreBuy.Value;
                    checkBox_Prtpc.Checked = tbhr.TR_Participation.Value;
                    radioButton_Apartmnt.Checked = tbhr.THR_Apartment.Value;
                    radioButton_Tent.Checked = tbhr.THR_Tenement.Value;
                    radioButton_Villa.Checked = tbhr.THR_Vila.Value;
                    radioButton_Dila.Checked = tbhr.THR_DilapiDated.Value;
                    radioButton_Ln.Checked = tbhr.THR_Land.Value;
                    radioButton_PLn.Checked = tbhr.THR_PartialLand.Value;
                    radioButton_SR.Checked = tbhr.THR_StoreRoom.Value;
                    radioButton_WR.Checked = tbhr.THR_WorkRoom.Value;
                    radioButton_Shop.Checked = tbhr.THR_Shop.Value;
                    radioButton_St.Checked = tbhr.THR_Suit.Value;
                    radioButton_Garden.Checked = tbhr.THR_Garden.Value;
                    radioButton_SGarden.Checked = tbhr.THR_SmallGarden.Value;
                    radioButton_North.Checked = tbhr.PR_Northern.Value;
                    radioButton_Soutern.Checked = tbhr.PR_Southern.Value;
                    radioButton_West.Checked = tbhr.PR_Western.Value;
                    radioButton_East.Checked = tbhr.PR_Eastern.Value;

                    comboBox_DocType.Text = tbhr.Type_Document;
                    comboBox_UseType.Text = tbhr.Type_Use;
                    comboBox_TGBuy.Text = tbhr.TypeGive_Buy;
                    comboBox_ReqUse.Text = tbhr.Request_Use;
                    textBox_Subbuild.Text = tbhr.Req_SubMeter.ToString();

                    nUpDown_FewPerson.Value = tbhr.FewPerson_Rent.Value;

                    textBox_BBuy.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Buy.ToString());
                    textBox_BRent.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Rent.ToString());
                    textBox_BMrtg.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Mortgage.ToString());

                    int prtreq = 0;
                    if (tbhr.PartRequest1 != 0) prtreq = tbhr.PartRequest1.Value;
                    if (tbhr.PartRequest2 != 0) prtreq = tbhr.PartRequest2.Value;
                    if (tbhr.PartRequest3 != 0) prtreq = tbhr.PartRequest3.Value;
                    if (tbhr.PartRequest4 != 0) prtreq = tbhr.PartRequest4.Value;

                    if (prtreq != 0)
                    {
                        CntID = Convert.ToInt32(prtreq.ToString().Substring(0, 1));
                        StID = Convert.ToInt32(prtreq.ToString().Substring(0, 3));
                        CyID = Convert.ToInt32(prtreq.ToString().Substring(0, 5));
                        PrtID1 = tbhr.PartRequest1.Value;
                        PrtID2 = tbhr.PartRequest2.Value;
                        PrtID3 = tbhr.PartRequest3.Value;
                        PrtID4 = tbhr.PartRequest4.Value;
                    }

                    //TextBox_ExpireDate.Text = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhr.Expired_Date));
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhr.Expired_Date));
                    comboBox_Year2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_Month2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    checkBox_DocExist.Checked = tbhr.Document_Exist.Value;

                    textBox_Desc.Text = tbhr.Description;
                }
                catch
                {
                    //                    MessageBox.Show("");
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در لود");
                }
            }
            else if (NewOrEditCustomer == 1)
            {
                //textBox_RDate.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                //TextBox_ExpireDate.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(30));
                DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(30));
                comboBox_Year2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_Month2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_day2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                textBox_RN.Text = (MaxRequestID+1).ToString();
            }
        }
        #endregion



        #region  Select Part
        private int CntID, StID, CyID, PrtID1, PrtID2, PrtID3, PrtID4;
        private void comboBox_Country_Enter(object sender, EventArgs e)
        {
            var hh = from prd in DCMD.TBL_Countries
                     select prd;
            comboBox_Country.DataSource = hh;
        }

        private void comboBox_Country_Leave(object sender, EventArgs e)
        {
            CntID = Convert.ToInt32(comboBox_Country.SelectedValue);
        }

        private void comboBox_State_Enter(object sender, EventArgs e)
        {
            var hh = from prd in DCMD.TBL_States
                     where prd.CountryID == CntID
                     select prd;
            comboBox_State.DataSource = hh;
        }

        private void comboBox_State_Leave(object sender, EventArgs e)
        {
            StID = Convert.ToInt32(comboBox_State.SelectedValue);
        }

        private void comboBox_City_Enter(object sender, EventArgs e)
        {
            var hh = from prd in DCMD.TBL_Cities
                     where prd.StateID == StID
                     select prd;
            comboBox_City.DataSource = hh;
        }

        private void comboBox_City_Leave(object sender, EventArgs e)
        {
            CyID = Convert.ToInt32(comboBox_City.SelectedValue);
        }

        private void comboBox_Part1_Enter(object sender, EventArgs e)
        {
            var hh = from prd in DCMD.TBL_Parts
                     where prd.CityID == CyID
                     select prd;
            comboBox_Part1.DataSource = hh;
        }

        private void comboBox_Part2_Enter(object sender, EventArgs e)
        {
            var hh = from prd in DCMD.TBL_Parts
                     where prd.CityID == CyID
                     select prd;
            comboBox_Part2.DataSource = hh;
        }

        private void comboBox_Part3_Enter(object sender, EventArgs e)
        {
            var hh = from prd in DCMD.TBL_Parts
                     where prd.CityID == CyID
                     select prd;
            comboBox_Part3.DataSource = hh;
        }

        private void comboBox_Part4_Enter(object sender, EventArgs e)
        {
            var hh = from prd in DCMD.TBL_Parts
                     where prd.CityID == CyID
                     select prd;
            comboBox_Part4.DataSource = hh;
        }

        #endregion



        #region Other

        TextBox tx = new TextBox();
        private void textBox_Subbuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar != '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }

        private void textBox_BBuy_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_BBuy_TextChanged(object sender, EventArgs e)
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
                tx.Text = str;
                tx.SelectionStart = ts + 1;
            }
        }

        MaskedTextBox de = new MaskedTextBox();
        private void textBox_RDate_Leave(object sender, EventArgs e)
        {
            de = (MaskedTextBox)sender;
            if (de.Text == "" || de.Text == "0000/00/00") return;

            if (!Global_Cls.CheckShamsiDate(de.Text)) de.Focus();
        }

        #endregion

        private void NECustomer_UC_Load(object sender, EventArgs e)
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(checkBox_AddTelNotebookCu.Name)) checkBox_AddTelNotebookCu.Enabled = false;
            }
        }

        private void panel_Date_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }

        private void panel_ExpDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month2.Text) > 6 && Convert.ToInt16(comboBox_day2.Text) == 31) comboBox_day2.Text = "30";
            if (Convert.ToInt16(comboBox_Month2.Text) == 12 && (Convert.ToInt16(comboBox_day2.Text) == 31 || Convert.ToInt16(comboBox_day2.Text) == 30)) comboBox_day2.Text = "29";
        }

    }
}

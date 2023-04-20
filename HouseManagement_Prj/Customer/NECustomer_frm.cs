using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;
using System.Data.SqlClient;
using System.Data.Linq;

namespace HouseManagement_Prj
{
    public partial class NECustomer_frm : Form
    {
        public NECustomer_frm()
        {
            InitializeComponent();
        }
        public int NewOrEditCustomer, CtID;
        private int MaxRequestID, MaxRequestNO;

        private bool CloseOK = false;
        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Data OK
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            //codeing
            if (Global_Cls.SoftwareCode == "Trial" && !Function_Cls.CheckTrialVersion(2)) return;
            //codeing

            if (OKFunction()) { CloseOK = true; Close(); }
            //    Global_Cls.MainForm.DeleteTabFromTabControl(Global_Cls.MainForm.tabControl_Main.SelectedTab);
        }

        private void buttonItem_OkNext_Click(object sender, EventArgs e)
        {
            //codeing
            if (Global_Cls.SoftwareCode == "Trial" && !Function_Cls.CheckTrialVersion(2)) return;
            //codeing

            if (OKFunction())
            {
                //Global_Cls.MainForm.DeleteTabFromTabControl(Global_Cls.MainForm.tabControl_Main.SelectedTab);
                CloseOK = true;
                Close(); Hide();
                Global_Cls.MainForm.NewCustomer_Function();
            }
        }

        private bool OKFunction()
        {
            panel_Date_Leave(this, null);
            panel_ExpDate_Leave(this, null);

            if (textBox_CFamilly.Text == "") 
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام خانوادگی متقاضی را وارد نمایید"); textBox_CFamilly.Focus(); return false; }
            if (textBox_CTel.Text == "" && textBox_CMobile.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "تلفن ثابت و یا موبایل متقاضی را وارد نمایید"); textBox_CMobile.Focus(); return false; }

            //اضافه به دفتر تلفن
            if (checkBox_AddTelNotebookCu.Checked)
            {

                try
                {
                    NETelMob_frm TMf = new NETelMob_frm();

                    TMf.textBox_Name.Text = textBox_CName.Text;
                    TMf.textBox_Family.Text = textBox_CName.Text;
                    TMf.textBox_Tel.Text = textBox_CTel.Text;
                    TMf.textBox_Mobile.Text = textBox_CMobile.Text;
                    TMf.textBox_Email.Text = textBox_CEmail.Text;
                    TMf.textBox_Address.Text = "";
                    TMf.textBox_Desc.Text = "";

                    TMf.UseFormInInsertOrEditMode(1);
                }
                catch { }

                //int a = Global_Cls.InsertPerTelMob(textBox_CName.Text, textBox_CFamilly.Text, textBox_CTel.Text, textBox_CMobile.Text, textBox_CEmail.Text, "", "");
                //if (a != 0 && a != 2)
                //    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, true, "مشخصات این فرد در دفتر تلفن موجود می باشد! آیا ادامه می دهید؟"))
                //    { return false; }
            }

            DataClasses_MainDataContext DMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (NewOrEditCustomer == 1)
                try
                {
                    // Test Re FileNo
                    var FN = (from prd in DCMD.TBL_HouseRequests
                              where prd.Request_NO == textBox_RN.Text
                              select prd).Count();
                    if (FN > 0)
                        if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "شماره درخواست ورودی تکراری است! آیا ثبت شود؟"))
                        {
                            textBox_RN.Focus();
                            return false;
                        }

                    //new
                    string TypeHouseReqStr = "", HouseReqForStr = "";
                    for (int i = 0; i < itemPanel_TypeReqHouse.Items.Count; i++)
                        if ((itemPanel_TypeReqHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        { TypeHouseReqStr = itemPanel_TypeReqHouse.Items[i].Text; break; }

                    for (int i = 0; i < itemPanel_ReqFor.Items.Count; i++)
                        if ((itemPanel_ReqFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                        { HouseReqForStr = itemPanel_ReqFor.Items[i].Text; break; }
                    //new


                    TBL_HouseRequest THR = new TBL_HouseRequest
                    {
                        RequestDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text),//textBox_RDate.Text),
                        Request_NO = textBox_RN.Text,
                        Customer_Name = textBox_CName.Text,
                        Customer_Family = textBox_CFamilly.Text,
                        Customer_Tel = textBox_CTel.Text,
                        Customer_Mobile = textBox_CMobile.Text,
                        Customer_Email = textBox_CEmail.Text,
                        Approach_Type = radioButton_Facing.Checked,

                        //new
                        HouseReqFor = HouseReqForStr,
                        TypeHouseReq = TypeHouseReqStr,
                        /*TR_Buy = checkBox_Buy.Checked,
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
                        THR_SmallGarden = radioButton_SGarden.Checked,*/
                        //new
                        PR_Northern = radioButton_North.Checked,
                        PR_Southern = radioButton_Soutern.Checked,
                        PR_Western = radioButton_West.Checked,
                        PR_Eastern = radioButton_East.Checked,

                        Type_Document = comboBox_DocType.Text,
                        Type_Use = comboBox_UseType.Text,
                        Request_Use = comboBox_ReqUse.Text,
                        TypeGive_Buy = comboBox_TGBuy.Text,
                        Req_SubMeter1 = Convert.ToDouble(textBox_CSubBuild1.Text),
                        Req_SubMeter2 = Convert.ToDouble(textBox_CSubBuild2.Text),
                        User_Code = Global_Cls.UserCode_Exist,

                        Description = textBox_Desc.Text,
                        FewPerson_Rent = Convert.ToInt16(nUpDown_FewPerson.Value),

                        Bodget_Buy1 = Convert.ToInt64((string)((textBox_BodgetBuy1.Text == "") ? "0" : (textBox_BodgetBuy1.Text)).Replace(",", "")),
                        Bodget_Buy2 = Convert.ToInt64((string)((textBox_BodgetBuy2.Text == "") ? "0" : (textBox_BodgetBuy2.Text)).Replace(",", "")),
                        Bodget_Rent1 = Convert.ToInt64((string)((textBox_BodgetRent1.Text == "") ? "0" : (textBox_BodgetRent1.Text)).Replace(",", "")),
                        Bodget_Rent2 = Convert.ToInt64((string)((textBox_BodgetRent2.Text == "") ? "0" : (textBox_BodgetRent2.Text)).Replace(",", "")),
                        Bodget_Mortgage1 = Convert.ToInt64((string)((textBox_BodgetMtg1.Text == "") ? "0" : (textBox_BodgetMtg1.Text)).Replace(",", "")),
                        Bodget_Mortgage2 = Convert.ToInt64((string)((textBox_BodgetMtg2.Text == "") ? "0" : (textBox_BodgetMtg2.Text)).Replace(",", "")),

                        PartRequest1 = Convert.ToInt32(comboBox_Part1.SelectedValue),
                        PartRequest2 = Convert.ToInt32(comboBox_Part2.SelectedValue),
                        PartRequest3 = Convert.ToInt32(comboBox_Part3.SelectedValue),
                        PartRequest4 = Convert.ToInt32(comboBox_Part4.SelectedValue),

                        Expired_Date = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_day2.Text),
                        Document_Exist = checkBox_DocExist.Checked
                    };
                    DMD.TBL_HouseRequests.InsertOnSubmit(THR);
                    DMD.SubmitChanges();
                    MaxRequestID++;
                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                       Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                    else
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.ToString());

                    return false;
                }
            else
                if (NewOrEditCustomer == 2)
                    try
                    {

                        TBL_HouseRequest tbhr = DMD.TBL_HouseRequests.First(thfh => thfh.RequestID.Equals(CtID));

                        tbhr.RequestDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text);//textBox_RDate.Text);
                        tbhr.Request_NO = textBox_RN.Text; 
                        tbhr.Customer_Name = textBox_CName.Text;
                        tbhr.Customer_Family = textBox_CFamilly.Text;
                        tbhr.Customer_Tel = textBox_CTel.Text;
                        tbhr.Customer_Mobile = textBox_CMobile.Text;
                        tbhr.Customer_Email = textBox_CEmail.Text;
                        tbhr.Approach_Type = radioButton_Facing.Checked;

                        //new
                        for (int i = 0; i < itemPanel_TypeReqHouse.Items.Count; i++)
                            if ((itemPanel_TypeReqHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                            { tbhr.TypeHouseReq = itemPanel_TypeReqHouse.Items[i].Text; break; }
                        
                        for (int i = 0; i < itemPanel_ReqFor.Items.Count; i++)
                            if ((itemPanel_ReqFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                            { tbhr.HouseReqFor = itemPanel_ReqFor.Items[i].Text; break; }

                        /*tbhr.TR_Buy = checkBox_Buy.Checked;
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
                        */
//new

                        tbhr.PR_Northern = radioButton_North.Checked;
                        tbhr.PR_Southern = radioButton_Soutern.Checked;
                        tbhr.PR_Western = radioButton_West.Checked;
                        tbhr.PR_Eastern = radioButton_East.Checked;

                        tbhr.Type_Document = comboBox_DocType.Text;
                        tbhr.Type_Use = comboBox_UseType.Text;
                        tbhr.Request_Use = comboBox_ReqUse.Text;
                        tbhr.TypeGive_Buy = comboBox_TGBuy.Text;
                        tbhr.Req_SubMeter1 = Convert.ToDouble(textBox_CSubBuild1.Text);
                        tbhr.Req_SubMeter2 = Convert.ToDouble(textBox_CSubBuild2.Text);
                        tbhr.User_Code = Global_Cls.UserCode_Exist;

                        tbhr.Description = textBox_Desc.Text;
                        tbhr.FewPerson_Rent = Convert.ToInt16(nUpDown_FewPerson.Value);

                        tbhr.Bodget_Buy1 = Convert.ToInt64((string)((textBox_BodgetBuy1.Text == "") ? "0" : (textBox_BodgetBuy1.Text)).Replace(",", ""));
                        tbhr.Bodget_Buy2 = Convert.ToInt64((string)((textBox_BodgetBuy2.Text == "") ? "0" : (textBox_BodgetBuy2.Text)).Replace(",", ""));
                        tbhr.Bodget_Rent1 = Convert.ToInt64((string)((textBox_BodgetRent1.Text == "") ? "0" : (textBox_BodgetRent1.Text)).Replace(",", ""));
                        tbhr.Bodget_Rent2 = Convert.ToInt64((string)((textBox_BodgetRent2.Text == "") ? "0" : (textBox_BodgetRent2.Text)).Replace(",", ""));
                        tbhr.Bodget_Mortgage1 = Convert.ToInt64((string)((textBox_BodgetMtg1.Text == "") ? "0" : (textBox_BodgetMtg1.Text)).Replace(",", ""));
                        tbhr.Bodget_Mortgage2 = Convert.ToInt64((string)((textBox_BodgetMtg2.Text == "") ? "0" : (textBox_BodgetMtg2.Text)).Replace(",", ""));

                        tbhr.PartRequest1 = Convert.ToInt32(comboBox_Part1.SelectedValue);
                        tbhr.PartRequest2 = Convert.ToInt32(comboBox_Part2.SelectedValue);
                        tbhr.PartRequest3 = Convert.ToInt32(comboBox_Part3.SelectedValue);
                        tbhr.PartRequest4 = Convert.ToInt32(comboBox_Part4.SelectedValue);

                        tbhr.Expired_Date = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_day2.Text);
                        tbhr.Document_Exist = checkBox_DocExist.Checked;

                        DMD.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                        else
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.ToString());

                        return false;
                    }

            //customers
            if (checkBoxItem_ListHouse.Checked) SearchToListHouses_AndShow();

            return true;
        }

        //customers
        private void SearchToListHouses_AndShow()
        { 
                        //new
            string TypeHouseReqStr = "", HouseReqForStr = "";
            for (int i = 0; i < itemPanel_TypeReqHouse.Items.Count; i++)
                if ((itemPanel_TypeReqHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { TypeHouseReqStr = itemPanel_TypeReqHouse.Items[i].Text; break; }

            for (int i = 0; i < itemPanel_ReqFor.Items.Count; i++)
                if ((itemPanel_ReqFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { HouseReqForStr = itemPanel_ReqFor.Items[i].Text;
                if (HouseReqForStr.Contains("خرید")) HouseReqForStr = HouseReqForStr.Replace("خرید", "فروش"); break;
                }

            string ListWhereSearch = "";

            ListWhereSearch += " And (HouseFor = N'" + HouseReqForStr + "')";
            ListWhereSearch += " And (TypeHouse = N'" + TypeHouseReqStr + "')";

            if (textBox_BodgetBuy2.Text != "0" && textBox_BodgetBuy2.Text != "")
                ListWhereSearch += " And (Price_HouseAll >= " + (string)((textBox_BodgetBuy1.Text == "") ? "0" : (textBox_BodgetBuy1.Text)).Replace(",", "") + ") And (Price_HouseAll <= " + textBox_BodgetBuy2.Text.Replace(",", "") + ")";
            if (textBox_BodgetMtg2.Text != "0" && textBox_BodgetMtg2.Text != "")
                ListWhereSearch += " And (Price_Mortgage >= " + (string)((textBox_BodgetMtg1.Text == "") ? "0" : (textBox_BodgetMtg1.Text)).Replace(",", "") + ") And (Price_Mortgage <= " + textBox_BodgetMtg2.Text.Replace(",", "") + ")";
            if (textBox_BodgetRent2.Text != "0" && textBox_BodgetRent2.Text != "")
                ListWhereSearch += " And (Price_Rent >= " + (string)((textBox_BodgetRent1.Text == "") ? "0" : (textBox_BodgetRent1.Text)).Replace(",", "") + ") And (Price_Rent <= " + textBox_BodgetRent2.Text.Replace(",", "") + ")";

            if (textBox_CSubBuild2.Text != "0" && textBox_CSubBuild2.Text != "")
                ListWhereSearch += " And (FH_Submeter >= " + (string)((textBox_CSubBuild1.Text == "") ? "0" : (textBox_CSubBuild1.Text)) + ") And (FH_Submeter <= " + textBox_CSubBuild2.Text + ")";

            /*if (comboBox_Part.Text != "")
            {
                ListWhereSearch += " And (1<>1 ";
                ListWhereSearch += " Or PartRequest1 = " + comboBox_Part.SelectedValue.ToString();
                ListWhereSearch += " Or PartRequest2 = " + comboBox_Part.SelectedValue.ToString();
                ListWhereSearch += " Or PartRequest3 = " + comboBox_Part.SelectedValue.ToString();
                ListWhereSearch += " Or PartRequest4 = " + comboBox_Part.SelectedValue.ToString();

                ListWhereSearch += " ) ";
            }*/

            try
            {
                string StrConn = Global_Cls.ConnectionStr;

                SqlConnection SqConn = new SqlConnection(StrConn);
                SqConn.Open();

                SqlCommand SqCmd = new SqlCommand();
                SqCmd.Connection = SqConn;

                SqCmd.CommandText = " SELECT * "
                       + " FROM     dbo.TBL_HouseFile Where (1=1)"
                       + ListWhereSearch;
                SqlDataReader da = SqCmd.ExecuteReader();
                da.Read();
                if (!da.HasRows) 
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "هیچ ملکی یافت نشد");
                    SqConn.Close();
                    return;
                }
                SqConn.Close();
            }
            catch { }


            try
            {
                ListHouse_UC Uc = new ListHouse_UC();
                Uc.SearchOrNo = -1;
                Uc.ListWhereSearch = ListWhereSearch;
                
                Global_Cls.MainForm.AddTabToTabControl("ListHouse" + DateTime.Now.ToLocalTime().ToString(), "لیست املاک "+textBox_RN.Text, Uc);
            }
            catch { }

        }

        
        #endregion



        #region Load Data

        private void NECustomer_UC_Load(object sender, EventArgs e)
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(checkBox_AddTelNotebookCu.Name)) checkBox_AddTelNotebookCu.Enabled = false;
            }
        }

        public void SetDefault_NECustomer()
        {
            label_Mny1.Text = Global_Cls.Money_Unit;
            label_Mny2.Text = label_Mny1.Text;
            label_Mny3.Text = label_Mny1.Text;
            //new
            for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
            {
                DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                Ch.Name = i.ToString();
                Ch.Text = Global_Cls.TypeHouseAllCases[i];
                Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
                Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
                if (i == 0) Ch.Checked = true;
                itemPanel_TypeReqHouse.Items.Add(Ch, i);
                itemPanel_TypeReqHouse.Refresh();
            }
            for (int i = 0; i < Global_Cls.RequestFor.Count; i++)
            {
                DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                Ch.Name = i.ToString();
                Ch.Text = Global_Cls.RequestFor[i];
                Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
                Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
                if (i == 0) Ch.Checked = true;
                itemPanel_ReqFor.Items.Add(Ch, i);
                itemPanel_ReqFor.Refresh();
            }
            //new

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

            try
            {
                var MaxRNO = (from prd in DCMD.TBL_HouseRequests
                              select Convert.ToInt32(prd.Request_NO)).Max();
                MaxRequestNO = MaxRNO + 1;
            }
            catch
            {
                MaxRequestNO = MaxRequestID;
            }


            if (NewOrEditCustomer == 2)
            {
                buttonItem_OkNext.Visible = false;

                try
                {
                    TBL_HouseRequest tbhr = DCMD.TBL_HouseRequests.First(thfr => thfr.RequestID.Equals(CtID));

                    textBox_RN.Text = tbhr.Request_NO.ToString();
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

//new
                    for (int i = 0; i < itemPanel_TypeReqHouse.Items.Count; i++)
                        if (tbhr.TypeHouseReq == itemPanel_TypeReqHouse.Items[i].Text)
                        { (itemPanel_TypeReqHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked = true; break; }
                    
                    for (int i = 0; i < itemPanel_ReqFor.Items.Count; i++)
                        if (tbhr.HouseReqFor == itemPanel_ReqFor.Items[i].Text)
                        { (itemPanel_ReqFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked = true; break; }
//new
                    
                    radioButton_North.Checked = tbhr.PR_Northern.Value;
                    radioButton_Soutern.Checked = tbhr.PR_Southern.Value;
                    radioButton_West.Checked = tbhr.PR_Western.Value;
                    radioButton_East.Checked = tbhr.PR_Eastern.Value;

                    comboBox_DocType.Text = tbhr.Type_Document;
                    comboBox_UseType.Text = tbhr.Type_Use;
                    comboBox_TGBuy.Text = tbhr.TypeGive_Buy;
                    comboBox_ReqUse.Text = tbhr.Request_Use;
                    textBox_CSubBuild1.Text = tbhr.Req_SubMeter1.ToString();
                    textBox_CSubBuild2.Text = tbhr.Req_SubMeter2.ToString();

                    nUpDown_FewPerson.Value = tbhr.FewPerson_Rent.Value;

                    textBox_BodgetBuy1.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Buy1.ToString());
                    textBox_BodgetBuy2.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Buy2.ToString());
                    textBox_BodgetRent1.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Rent1.ToString());
                    textBox_BodgetRent2.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Rent2.ToString());
                    textBox_BodgetMtg1.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Mortgage1.ToString());
                    textBox_BodgetMtg2.Text = Global_Cls.DigitSeparator(tbhr.Bodget_Mortgage2.ToString());

                    PartFill(tbhr);

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
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در لود");
                }
            }
            else if (NewOrEditCustomer == 1)
            {
                textBox_RN.Text = MaxRequestNO.ToString();
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

                textBox_RN.Text = (MaxRequestID + 1).ToString();
            }
        }

        private void PartFill(TBL_HouseRequest tbhr)
        {
            //new
            int PrtReq = 0;
            if (tbhr.PartRequest1 != 0) PrtReq = tbhr.PartRequest1.Value;
            if (tbhr.PartRequest2 != 0) PrtReq = tbhr.PartRequest2.Value;
            if (tbhr.PartRequest3 != 0) PrtReq = tbhr.PartRequest3.Value;
            if (tbhr.PartRequest4 != 0) PrtReq = tbhr.PartRequest4.Value;

            if (PrtReq != 0)
            {
                comboBox_Country_Enter(this, null);
                comboBox_Country.SelectedValue = Convert.ToInt32(PrtReq.ToString().Substring(0, 1));
                comboBox_Country_Leave(this, null);

                comboBox_State_Enter(this, null);
                comboBox_State.SelectedValue = Convert.ToInt32(PrtReq.ToString().Substring(0, 3));
                comboBox_State_Leave(this, null);

                comboBox_City_Enter(this, null);
                comboBox_City.SelectedValue = Convert.ToInt32(PrtReq.ToString().Substring(0, 5));
                comboBox_City_Leave(this, null);

                comboBox_Part1_Enter(this, null);
                comboBox_Part1.SelectedValue = tbhr.PartRequest1.Value;
                comboBox_Part2_Enter(this, null);
                comboBox_Part2.SelectedValue = tbhr.PartRequest2.Value;
                comboBox_Part3_Enter(this, null);
                comboBox_Part3.SelectedValue = tbhr.PartRequest3.Value;
                comboBox_Part4_Enter(this, null);
                comboBox_Part4.SelectedValue = tbhr.PartRequest4.Value;
            }
            //new
        }

        private void NECustomer_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }


        #endregion



        #region  Select Part
        private int CntID, StID, CyID;
        private void comboBox_Country_Enter(object sender, EventArgs e)
        {
            if (comboBox_Country.DataSource == null)
            {
                var hh = from prd in DCMD.TBL_Countries
                         select prd;
                comboBox_Country.DataSource = hh;
            }
        }

        private void comboBox_Country_Leave(object sender, EventArgs e)
        {
            CntID = Convert.ToInt32(comboBox_Country.SelectedValue);
        }

        private void comboBox_State_Enter(object sender, EventArgs e)
        {
            if (!comboBox_State.Tag.Equals(CntID))
            {
                comboBox_State.Tag = CntID;
                var hh = from prd in DCMD.TBL_States
                         where prd.CountryID == CntID
                         select prd;
                comboBox_State.DataSource = hh;
            }
        }

        private void comboBox_State_Leave(object sender, EventArgs e)
        {
            StID = Convert.ToInt32(comboBox_State.SelectedValue);
        }

        private void comboBox_City_Enter(object sender, EventArgs e)
        {
            if (!comboBox_City.Tag.Equals(StID))
            {
                comboBox_City.Tag = StID;
                var hh = from prd in DCMD.TBL_Cities
                         where prd.StateID == StID
                         select prd;
                comboBox_City.DataSource = hh;
            }
        }

        private void comboBox_City_Leave(object sender, EventArgs e)
        {
            CyID = Convert.ToInt32(comboBox_City.SelectedValue);
        }

        private void comboBox_Part1_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Part1.Tag.Equals(CyID))
            {
                comboBox_Part1.Tag = CyID;
                var h1 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_Part1.DataSource = h1;
            }
        }

        private void comboBox_Part2_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Part2.Tag.Equals(CyID))
            {
                comboBox_Part2.Tag = CyID;
                var h2 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_Part2.DataSource = h2;
            }
        }

        private void comboBox_Part3_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Part3.Tag.Equals(CyID))
            {
                comboBox_Part3.Tag = CyID;
                var h3 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_Part3.DataSource = h3;
            }
        }

        private void comboBox_Part4_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Part4.Tag.Equals(CyID))
            {
                comboBox_Part4.Tag = CyID;
                var h4 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_Part4.DataSource = h4;
            }
        }
        #endregion



        #region Other

        TextBox tx = new TextBox();
        private void textBox_Subbuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar == '.')
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
                tx.Text = str.Replace(" ", "");
                tx.SelectionStart = ts + 1;
            }
        }

        /*MaskedTextBox de = new MaskedTextBox();
        private void textBox_RDate_Leave(object sender, EventArgs e)
        {
            de = (MaskedTextBox)sender;
            if (de.Text == "" || de.Text == "0000/00/00") return;

            if (!Global_Cls.CheckShamsiDate(de.Text)) de.Focus();
        }*/

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

        private void checkBoxItem_ListHouse_Click(object sender, EventArgs e)
        {
            label_StarHT.Visible = checkBoxItem_ListHouse.Checked;
            label_StarNT.Visible = checkBoxItem_ListHouse.Checked;
            label_StarRF.Visible = checkBoxItem_ListHouse.Checked;
        }

        private void NECustomer_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }

        private void textBox_RN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back))
            { e.KeyChar = '\0'; return; }
        }
        #endregion


    }
}

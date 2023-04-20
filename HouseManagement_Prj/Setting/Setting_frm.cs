using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Data.SqlClient;

namespace HouseManagement_Prj
{
    public partial class Setting_frm : Form
    {
        public Setting_frm()
        {
            InitializeComponent();
        }

        string CityPicFilter, AgencyLogoFilter;
        DataClasses_MainDataContext DMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DSDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        DataClasses_WebServiceDataContext DWDC = new DataClasses_WebServiceDataContext(Global_Cls.ConnectionStr);
        private bool CloseOK = false;


        #region Load & UI
        private void Setting_frm_Load(object sender, EventArgs e)
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains("buttonItem_FirstSet")) treeView_Setting.Nodes["Node_FSet"].Remove();
                if (UPer.Contains("buttonItem_AgencySet")) treeView_Setting.Nodes["Node_SetAgency"].Remove();
                if (UPer.Contains("buttonItem_BkpRstSet")) treeView_Setting.Nodes["Node_SetBkpRst"].Remove();
                if (UPer.Contains("buttonItem_SetSystem")) treeView_Setting.Nodes["Node_SetSystem"].Remove();
                if (UPer.Contains("buttonItem_OtherSet")) treeView_Setting.Nodes["Node_SetOther"].Remove();
            }

            treeView_Setting.ExpandAll();
            TreeNodeMouseClickEventArgs a = new TreeNodeMouseClickEventArgs(treeView_Setting.SelectedNode, MouseButtons.Left, 1, 0, 0);
            treeView_Setting_NodeMouseClick(this, a);



            //sms start
            InitializeComboBoxSMS();

            cmbPort.Text = Global_Cls.SMSPort.ToString();
            cmbBaudRate.Text = Global_Cls.SMSBaudRate.ToString();
            cmbDataBits.Text = Global_Cls.SMSDataBits.ToString();
            cmbParity.SelectedIndex = Global_Cls.SMSParity;
            cmbStopBits.SelectedIndex = Global_Cls.SMSStopBits - 1;
            cmbFlowControl.SelectedIndex = Global_Cls.SMSFlowControl;
            cmbTimeOut.Text = Global_Cls.SMSTimeOut.ToString();

            cmbEncoding.SelectedIndex = Global_Cls.SMSEncoding;
            cmbLongMsg.SelectedIndex = Global_Cls.SMSLongMsg;
            chkDeliveryReport.Checked = Global_Cls.SMSDeliveryReport;

            //sms end 

            //Agancy start
            textBox_AgancyName.Text = Global_Cls.Agancy_Name;
            textBox_AdminAgName.Text = Global_Cls.AgancyAdmin_Name;
            textBox_AgancyTel.Text = Global_Cls.Agancy_Tel;
            textBox_AgancyMobile.Text = Global_Cls.Agancy_Mobile;
            textBox_AgencyAddress.Text = Global_Cls.Agancy_Address;
            textBox_AgEmail.Text = Global_Cls.Agancy_Email;

            try
            {
                AgencyLogoFilter = Global_Cls.Agancy_LogoName;
                AgencyLogoFilter = AgencyLogoFilter.Substring(AgencyLogoFilter.IndexOf("."), AgencyLogoFilter.Length - AgencyLogoFilter.IndexOf("."));
                pictureBox_AgencyLogo.Load(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName);
            }
            catch { }

            try
            {
                CityPicFilter = Global_Cls.CityPic_Name;
                CityPicFilter = CityPicFilter.Substring(CityPicFilter.IndexOf("."), CityPicFilter.Length - CityPicFilter.IndexOf("."));
                pictureBox_CityPic.Load(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.CityPic_Name);
            }
            catch { }
            //Agancy end

            //BkpRst start
            label_BkpAuto.Text = Global_Cls.BkpAutoRoot;
            radioButton_BkpAuto.Checked = (Global_Cls.BkpExitType == 2);
            radioButton_BkpNonAuto.Checked = (Global_Cls.BkpExitType == 1);
            radioButton_BkpNo.Checked = (Global_Cls.BkpExitType == 0);
            checkBox_BRPicFilm.Checked = Global_Cls.BkpRstPicsFilms;
            checkBox_BRDesignRep.Checked = Global_Cls.BkpRstDesignReport;
            //BkpRst end

            //NonActive Alarm start
            nUpDown_OnNonActive.Value = Global_Cls.NonActive_Day;
            radioButton_OffNonActive.Checked = (!Global_Cls.NonActiveOn_Off);
            radioButton_OnNonActive.Checked = (Global_Cls.NonActiveOn_Off);
            //NonActive Alarm end


            //Advertisment start
            //dgLH
            if (Global_Cls.Adver_FieldName.Contains("TypeHouse")) CheckBox_typehouse.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("HouseFor")) CheckBox_housefor.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("FH_Submeter")) CheckBox_Submeter.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("Few_estate")) CheckBox_Fewestate.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("FH_estateNo")) CheckBox_estateNo.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("Price_HouseAllStr")) CheckBox_PriceHouseAll.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("Price_MR")) CheckBox_PriceMR.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("PartName_Fa")) checkBox_PartName.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("Few_unitAll")) checkBox_AllUnits.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("FH_BedRoomFew")) checkBox_FewBedR.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("RH_Bldage")) checkBox_BldAge.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("RH_UseType")) checkBox_UseType.Checked = true;
            if (Global_Cls.Adver_FieldName.Contains("FH_UnitNo")) checkBox_UnitNo.Checked = true;

            comboBox_separator.Text = Global_Cls.Adver_separator;
            //Advertisment end

            //Default value for HouseFile Start
            //new
            for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
            {
                comboBox_TypeHouse.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                /*DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                Ch.Name = i.ToString();
                Ch.Text = Global_Cls.TypeHouseAllCases[i];
                Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
                Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
                if (i == 0) Ch.Checked = true;
                itemPanel_TypeHouse.Items.Add(Ch, i);
                itemPanel_TypeHouse.Refresh();*/
            }
            for (int i = 0; i < Global_Cls.HouseForPrm.Count; i++)//new
            {
                comboBox_HouseFor.Items.Add(Global_Cls.HouseForPrm[i]);//new
                /*DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                Ch.Name = i.ToString();
                Ch.Text = Global_Cls.HouseFor[i];
                Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
                Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
                if (i == 0) Ch.Checked = true;
                itemPanel_HouseFor.Items.Add(Ch, i);
                itemPanel_HouseFor.Refresh();*/
            }
            //new

            checkBox_IsDefaltValue.Checked = Global_Cls.IsDefaultValue;

            checkBoxItem_Print.Checked = Global_Cls.HouseFile_Print;
            checkBoxItem_ListCuHouse.Checked = Global_Cls.HouseFile_CustomerList;
            checkBox_AddTelNotebook.Checked = Global_Cls.HouseFile_TelNtBook;
            checkBox_HoldData.Checked = Global_Cls.HouseFile_DataHolder;

            try
            {
                try { PartFill(Global_Cls.DefaultValueHouseFile[0]); }
                catch { }
                nUpDown_KitchenFew.Value = Convert.ToInt16(Global_Cls.DefaultValueHouseFile[1]);
                nUpDown_FBed.Value = Convert.ToInt16(Global_Cls.DefaultValueHouseFile[2]);
                nUpDown_FRoom.Value = Convert.ToInt16(Global_Cls.DefaultValueHouseFile[3]);
                comboBox_BedRoom.Text = Global_Cls.DefaultValueHouseFile[4];
                comboBox_RcRoom.Text = Global_Cls.DefaultValueHouseFile[5];
                comboBox_BldLow.Text = Global_Cls.DefaultValueHouseFile[6];
                comboBox_MK.Text = Global_Cls.DefaultValueHouseFile[7];
                comboBox_CT.Text = Global_Cls.DefaultValueHouseFile[8];
                comboBox_DocType.Text = Global_Cls.DefaultValueHouseFile[9];
                comboBox_Priority.Text = Global_Cls.DefaultValueHouseFile[10];
                try
                {
                    string DateStr = Global_Cls.DefaultValueHouseFile[11];
                    comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                }
                catch
                {
                    string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(30));
                    comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                }



                //new
                comboBox_TypeHouse.Text = Global_Cls.DefaultValueHouseFile[12];
                comboBox_HouseFor.Text = Global_Cls.DefaultValueHouseFile[13];

                /*for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
                    if (Global_Cls.DefaultValueHouseFile[12] == itemPanel_TypeHouse.Items[i].Text)
                    { (itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked = true; break; }

                for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
                    if (Global_Cls.DefaultValueHouseFile[13] == itemPanel_HouseFor.Items[i].Text)
                    { (itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked = true; break; }

                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Sale")) checkBox_Sale.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Rent")) checkBox_Rent.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Mortgage")) checkBox_Mortgage.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_PreSale")) checkBox_PreSale.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Prtpc")) checkBox_Prtpc.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_Apartmnt")) radioButton_Apartmnt.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_Tent")) radioButton_Tent.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_Villa")) radioButton_Villa.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_Dila")) radioButton_Dila.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_Ln")) radioButton_Ln.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_PLn")) radioButton_PLn.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_SR")) radioButton_SR.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_WR")) radioButton_WR.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_Shop")) radioButton_Shop.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_St")) radioButton_St.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_Garden")) radioButton_Garden.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_SGarden")) radioButton_SGarden.Checked = true;
                */
                //new

                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_IRWc")) checkBox_IRWc.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_FWc")) checkBox_FWc.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_SK")) checkBox_SK.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_AV")) checkBox_AV.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_RDoor")) checkBox_RDoor.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_AC")) checkBox_AC.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Tel")) checkBox_Tel.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Balcony")) checkBox_Balcony.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_FirePlace")) checkBox_FirePlace.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Parking")) checkBox_Parking.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_StRoom")) checkBox_StRoom.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Cellar")) checkBox_Cellar.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Yard")) checkBox_Yard.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_BYard")) checkBox_BYard.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Patio")) checkBox_Patio.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_EmployeeSrv")) checkBox_EmployeeSrv.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Water")) checkBox_Water.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Electricity")) checkBox_Electricity.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Gaz")) checkBox_Gaz.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Cooler")) checkBox_Cooler.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_FanCoel")) checkBox_FanCoel.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Heat")) checkBox_Heat.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Chiler")) checkBox_Chiler.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Pakage")) checkBox_Pakage.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Sauna")) checkBox_Sauna.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Jacuzzi")) checkBox_Jacuzzi.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Pool")) checkBox_Pool.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Elevatoor")) checkBox_Elevatoor.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Property")) checkBox_Property.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_KeyMoney")) checkBox_KeyMoney.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_DocUse")) checkBox_DocUse.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_nonActive")) radioButton_nonActive.Checked = true;
            }
            catch { }

            comboBox_MnyUnit.Text = Global_Cls.Money_Unit;
            textBox_ChangeMoney.Text = Global_Cls.Money_Change.ToString();
            //Default value for HouseFile end



            //
            try
            {
                listBox_TypeHouse.Items.Clear();
                for (int i = listBox_TypeHouse.Items.Count; i < Global_Cls.TypeHouseAllCases.Count; i++)
                    listBox_TypeHouse.Items.Add(Global_Cls.TypeHouseAllCases[i].ToString());
            }
            catch { }

            try
            {
                listBox_HouseFor.Items.Clear();
                for (int i = listBox_HouseFor.Items.Count; i < Global_Cls.HouseFor.Count; i++)
                    listBox_HouseFor.Items.Add(Global_Cls.HouseFor[i].ToString());
            }
            catch { }
            try
            {
                listBox_ReqFor.Items.Clear();
                for (int i = listBox_ReqFor.Items.Count; i < Global_Cls.RequestFor.Count; i++)
                    listBox_ReqFor.Items.Add(Global_Cls.RequestFor[i].ToString());
            }
            catch { }
            //


            //Web Part Fill
            try
            {
                PartFillWebHouse(Global_Cls.SetWebHousePart[0], Global_Cls.SetWebHousePart[1], Global_Cls.SetWebHousePart[2],
                    Global_Cls.SetWebHousePart[3], Global_Cls.SetWebHousePart[4], Global_Cls.SetWebHousePart[5],
                    Global_Cls.SetWebHousePart[6], Global_Cls.SetWebHousePart[7]);
            }
            catch { }
            //


            //FileNoFlage
            comboBox_TypeFileNo.SelectedIndex = Convert.ToInt16(!Global_Cls.FileNoFlage);
            //



            
            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                treeView_Setting.Nodes["Node_SetOther"].Nodes["Node_AdverField"].Remove();
                treeView_Setting.Nodes["Node_SetSystem"].Nodes["Node_Sms"].Remove();
            }
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1") || Global_Cls.SoftwareCode == "Trial")
                treeView_Setting.Nodes["Node_SetOther"].Nodes["Node_SetAlarms"].Remove();

            //                if ("L1,L2,N1,N2".Contains(Global_Cls.SoftwareCode)) treeView_Setting.Nodes["Node_SetOther"].Nodes["Node_WebPart"].Remove();
            //codeing

        }

        private void InitializeComboBoxSMS()
        {
            //-------------------------------------
            //Initialize COM Port DropDown List
            //-------------------------------------
            cmbPort.Items.Add("Select Port");
            for (int i = 1; i <= 256; i++)
            {
                cmbPort.Items.Add("COM" + i.ToString());
            }
            cmbPort.SelectedIndex = 0;


            //--------------------------------------
            //Initialize BaudRate DropDown List
            //--------------------------------------
            cmbBaudRate.Items.Add("110");
            cmbBaudRate.Items.Add("300");
            cmbBaudRate.Items.Add("1200");
            cmbBaudRate.Items.Add("2400");
            cmbBaudRate.Items.Add("4800");
            cmbBaudRate.Items.Add("9600");
            cmbBaudRate.Items.Add("14400");
            cmbBaudRate.Items.Add("19200");
            cmbBaudRate.Items.Add("38400");
            cmbBaudRate.Items.Add("57600");
            cmbBaudRate.Items.Add("115200");
            cmbBaudRate.Items.Add("230400");
            cmbBaudRate.Items.Add("460800");
            cmbBaudRate.Items.Add("921600");
            //cmbBaudRate.SelectedIndex = cmbBaudRate.FindString(((int)objSMS.BaudRate).ToString());

            //--------------------------------------
            //Initialize DataBits DropDown List
            //--------------------------------------
            cmbDataBits.Items.Add("4");
            cmbDataBits.Items.Add("5");
            cmbDataBits.Items.Add("6");
            cmbDataBits.Items.Add("7");
            cmbDataBits.Items.Add("8");
            //cmbDataBits.SelectedIndex = cmbDataBits.FindString(((int)objSMS.DataBits).ToString());


            //--------------------------------------
            //Initialize Parity DropDown List
            //--------------------------------------
            cmbParity.Items.Add("None");
            cmbParity.Items.Add("Odd");
            cmbParity.Items.Add("Even");
            cmbParity.Items.Add("Mark");
            cmbParity.Items.Add("Space");
            //cmbParity.SelectedIndex = (int)objSMS.Parity;


            //--------------------------------------
            //Initialize StopBits DropDown List
            //--------------------------------------
            cmbStopBits.Items.Add("1");
            cmbStopBits.Items.Add("2");
            cmbStopBits.Items.Add("1.5");
            //cmbStopBits.SelectedIndex = (int)objSMS.StopBits - 1;


            //--------------------------------------
            //Initialize FlowControl DropDown List
            //--------------------------------------
            cmbFlowControl.Items.Add("None");
            cmbFlowControl.Items.Add("Hardware");
            cmbFlowControl.Items.Add("Xon/Xoff");
            //cmbFlowControl.SelectedIndex = (int)objSMS.FlowControl;


            cmbEncoding.Items.Add("Default Alphabet");
            cmbEncoding.Items.Add("ANSI (8-bit)");
            cmbEncoding.Items.Add("Unicode (16-bit)");
            //cmbEncoding.SelectedIndex = (int)objSMS.Encoding;

            //----------------------------------------
            //Initialize Long Message DropDown List
            //----------------------------------------
            cmbLongMsg.Items.Add("Truncate");
            cmbLongMsg.Items.Add("Simple Split");
            cmbLongMsg.Items.Add("Formatted Split");
            cmbLongMsg.Items.Add("Concatenate");
        }

        private void PartFill(string PartID)
        {
            if (PartID != "0")
            {
                comboBox_Country_Enter(this, null);
                comboBox_Country.SelectedValue = Convert.ToInt32(PartID.Substring(0, 1));
                comboBox_Country_Leave(this, null);

                comboBox_State_Enter(this, null);
                comboBox_State.SelectedValue = Convert.ToInt32(PartID.Substring(0, 3));
                comboBox_State_Leave(this, null);

                comboBox_City_Enter(this, null);
                comboBox_City.SelectedValue = Convert.ToInt32(PartID.Substring(0, 5));
                comboBox_City_Leave(this, null);

                comboBox_Part_Enter(this, null);
                comboBox_Part.SelectedValue = Convert.ToInt32(PartID);
            }
        }

        private void PartFillWebHouse(string PartID1,string PartID2,string PartID3, string PartID4, 
                                    string PartID5, string PartID6,string PartID7,string PartID8)
        {
            string PrtReq = "0";
            if (PartID1 != "0") PrtReq = PartID1;
            if (PartID2 != "0") PrtReq = PartID2;
            if (PartID3 != "0") PrtReq = PartID3;
            if (PartID4 != "0") PrtReq = PartID4;
            if (PartID5 != "0") PrtReq = PartID5;
            if (PartID6 != "0") PrtReq = PartID6;
            if (PartID7 != "0") PrtReq = PartID7;
            if (PartID8 != "0") PrtReq = PartID8;

            if (PrtReq != "0")
            {
                comboBox_HCountry_Enter(this, null);
                comboBox_HCountry.SelectedValue = Convert.ToInt32(PrtReq.Substring(0, 1));
                comboBox_HCountry_Leave(this, null);

                comboBox_HState_Enter(this, null);
                comboBox_HState.SelectedValue = Convert.ToInt32(PrtReq.Substring(0, 3));
                comboBox_HState_Leave(this, null);

                comboBox_HCity_Enter(this, null);
                comboBox_HCity.SelectedValue = Convert.ToInt32(PrtReq.Substring(0, 5));
                comboBox_HCity_Leave(this, null);

                comboBox_HPart1_Enter(this, null);
                comboBox_HPart1.SelectedValue = Convert.ToInt32(PartID1);
                comboBox_HPart2_Enter(this, null);
                comboBox_HPart2.SelectedValue = Convert.ToInt32(PartID2);
                comboBox_HPart3_Enter(this, null);
                comboBox_HPart3.SelectedValue = Convert.ToInt32(PartID3);
                comboBox_HPart4_Enter(this, null);
                comboBox_HPart4.SelectedValue = Convert.ToInt32(PartID4);
                comboBox_HPart5_Enter(this, null);
                comboBox_HPart5.SelectedValue = Convert.ToInt32(PartID5);
                comboBox_HPart6_Enter(this, null);
                comboBox_HPart6.SelectedValue = Convert.ToInt32(PartID6);
                comboBox_HPart7_Enter(this, null);
                comboBox_HPart7.SelectedValue = Convert.ToInt32(PartID7);
                comboBox_HPart8_Enter(this, null);
                comboBox_HPart8.SelectedValue = Convert.ToInt32(PartID8);
            }
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }
        #endregion


        
        #region OK

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            panel_Date_Leave(this, null);

            //sms start

            Global_Cls.SMSPort = cmbPort.Text;
            Global_Cls.SMSBaudRate = Convert.ToInt32(cmbBaudRate.Text);
            Global_Cls.SMSDataBits = Convert.ToInt32(cmbDataBits.Text);
            Global_Cls.SMSParity = cmbParity.SelectedIndex;
            Global_Cls.SMSStopBits = cmbStopBits.SelectedIndex + 1;
            Global_Cls.SMSFlowControl = cmbFlowControl.SelectedIndex;
            Global_Cls.SMSTimeOut = Convert.ToInt32(cmbTimeOut.Text);

            Global_Cls.SMSEncoding=cmbEncoding.SelectedIndex;
            Global_Cls.SMSLongMsg=cmbLongMsg.SelectedIndex;
            Global_Cls.SMSDeliveryReport=chkDeliveryReport.Checked;

            //Global_Cls.Comm_Port = Convert.ToInt32(cmbport.Text);
            //Global_Cls.Comm_BaudRate = Convert.ToInt32(cmbBaudRate.Text);
            //Global_Cls.Comm_TimeOut = Convert.ToInt32(cmbTimeOut.Text);
            //Global_Cls.Send_Unicode = chkunicode.Checked;
            //sms end

            //Agancy start
            if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName))
                FileSystem.DeleteFile(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName);
            if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.CityPic_Name))
                FileSystem.DeleteFile(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.CityPic_Name);

            Global_Cls.Agancy_Name = textBox_AgancyName.Text;
            Global_Cls.AgancyAdmin_Name = textBox_AdminAgName.Text;
            Global_Cls.Agancy_Tel = textBox_AgancyTel.Text;
            Global_Cls.Agancy_Mobile = textBox_AgancyMobile.Text;
            Global_Cls.Agancy_Address = textBox_AgencyAddress.Text;
            Global_Cls.Agancy_Email = textBox_AgEmail.Text;


            Global_Cls.Agancy_LogoName = "AgencyLogo" + AgencyLogoFilter;
            Global_Cls.CityPic_Name = "CityPic" + CityPicFilter;

            AgencyLogoFilter = Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName;
            CityPicFilter = Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.CityPic_Name;

            try
            {
                Bitmap Agencybmp = new Bitmap(pictureBox_AgencyLogo.Image);
                Agencybmp.Save(AgencyLogoFilter);
            }
            catch { }

            try
            {
                Bitmap CityPicbmp = new Bitmap(pictureBox_CityPic.Image);
                CityPicbmp.Save(CityPicFilter);
            }
            catch { }
            //Agancy end


            //BkpRst start
            Global_Cls.BkpAutoRoot = label_BkpAuto.Text;
            if (radioButton_BkpAuto.Checked) Global_Cls.BkpExitType = 2;
            else if (radioButton_BkpNonAuto.Checked) Global_Cls.BkpExitType = 1;
            else Global_Cls.BkpExitType = 0;
            Global_Cls.BkpRstPicsFilms = checkBox_BRPicFilm.Checked;
            Global_Cls.BkpRstDesignReport = checkBox_BRDesignRep.Checked;
            //BkpRst end


            //NonActive Alarm start
            Global_Cls.NonActive_Day = Convert.ToInt16(nUpDown_OnNonActive.Value);
            Global_Cls.NonActiveOn_Off = radioButton_OnNonActive.Checked;
            //NonActive Alarm end

            //Advertisment start
            Global_Cls.Adver_FieldName.Clear();
            //dgLH
            if (checkBox_PartName.Checked) Global_Cls.Adver_FieldName.Add("PartName_Fa");
            if (CheckBox_typehouse.Checked) Global_Cls.Adver_FieldName.Add("TypeHouse");
            if (CheckBox_housefor.Checked) Global_Cls.Adver_FieldName.Add("HouseFor");
            if (CheckBox_Submeter.Checked) Global_Cls.Adver_FieldName.Add("FH_Submeter");
            if (CheckBox_Fewestate.Checked) Global_Cls.Adver_FieldName.Add("Few_estate");
            if (CheckBox_estateNo.Checked) Global_Cls.Adver_FieldName.Add("FH_estateNo");
            if (checkBox_AllUnits.Checked) Global_Cls.Adver_FieldName.Add("Few_unitAll");
            if (checkBox_UnitNo.Checked) Global_Cls.Adver_FieldName.Add("FH_UnitNo");
            if (CheckBox_PriceHouseAll.Checked) Global_Cls.Adver_FieldName.Add("Price_HouseAllStr");
            if (CheckBox_PriceMR.Checked) Global_Cls.Adver_FieldName.Add("Price_MR");
            if (checkBox_FewBedR .Checked) Global_Cls.Adver_FieldName.Add("FH_BedRoomFew");
            if (checkBox_BldAge.Checked) Global_Cls.Adver_FieldName.Add("RH_Bldage");
            if (checkBox_UseType.Checked) Global_Cls.Adver_FieldName.Add("RH_UseType");

            Global_Cls.Adver_separator = comboBox_separator.Text;
            //Advertisment end


            //Default value for HouseFile Start
            Global_Cls.IsDefaultValue = checkBox_IsDefaltValue.Checked;

            Global_Cls.HouseFile_Print = checkBoxItem_Print.Checked;
            Global_Cls.HouseFile_CustomerList = checkBoxItem_ListCuHouse.Checked;
            Global_Cls.HouseFile_TelNtBook = checkBox_AddTelNotebook.Checked;
            Global_Cls.HouseFile_DataHolder = checkBox_HoldData.Checked;

            Global_Cls.DefaultValueHouseFile.Clear();
            try { Global_Cls.DefaultValueHouseFile.Insert(0, comboBox_Part.SelectedValue.ToString()); }
            catch { Global_Cls.DefaultValueHouseFile.Insert(0, "0"); }
            Global_Cls.DefaultValueHouseFile.Insert(1, nUpDown_KitchenFew.Value.ToString());

            Global_Cls.DefaultValueHouseFile.Insert(2, nUpDown_FBed.Value.ToString());

            Global_Cls.DefaultValueHouseFile.Insert(3, nUpDown_FRoom.Value.ToString());

            //catch { }
            Global_Cls.DefaultValueHouseFile.Insert(4, comboBox_BedRoom.Text);
            Global_Cls.DefaultValueHouseFile.Insert(5, comboBox_RcRoom.Text);
            Global_Cls.DefaultValueHouseFile.Insert(6, comboBox_BldLow.Text);
            Global_Cls.DefaultValueHouseFile.Insert(7, comboBox_MK.Text);
            Global_Cls.DefaultValueHouseFile.Insert(8, comboBox_CT.Text);
            Global_Cls.DefaultValueHouseFile.Insert(9, comboBox_DocType.Text);
            Global_Cls.DefaultValueHouseFile.Insert(10, comboBox_Priority.Text);
            Global_Cls.DefaultValueHouseFile.Insert(11, comboBox_Year1.Text + "/" + string.Format("{0:00}", Convert.ToInt16(comboBox_Month1.Text)) + "/" + string.Format("{0:00}", Convert.ToInt16(comboBox_day1.Text)));


            //new
            Global_Cls.DefaultValueHouseFile.Insert(12, comboBox_TypeHouse.Text);
            Global_Cls.DefaultValueHouseFile.Insert(13, comboBox_HouseFor.Text);
            /*for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
                if ((itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { Global_Cls.DefaultValueHouseFile.Insert(12, itemPanel_TypeHouse.Items[i].Text); break; }

            for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
                if ((itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { Global_Cls.DefaultValueHouseFile.Insert(13, itemPanel_HouseFor.Items[i].Text); break; }
            
            if (checkBox_Sale.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Sale");
            if (checkBox_Rent.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Rent");
            if (checkBox_Mortgage.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Mortgage");
            if (checkBox_PreSale.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_PreSale");
            if (checkBox_Prtpc.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Prtpc");
            if (radioButton_Apartmnt.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_Apartmnt");
            if (radioButton_Tent.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_Tent");
            if (radioButton_Villa.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_Villa");
            if (radioButton_Dila.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_Dila");
            if (radioButton_Ln.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_Ln");
            if (radioButton_PLn.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_PLn");
            if (radioButton_SR.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_SR");
            if (radioButton_WR.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_WR");
            if (radioButton_Shop.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_Shop");
            if (radioButton_St.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_St");
            if (radioButton_Garden.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_Garden");
            if (radioButton_SGarden.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_SGarden");
            */
            //new

            if (checkBox_IRWc.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_IRWc");
            if (checkBox_FWc.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_FWc");
            if (checkBox_SK.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_SK");
            if (checkBox_AV.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_AV");
            if (checkBox_RDoor.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_RDoor");
            if (checkBox_AC.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_AC");
            if (checkBox_Tel.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Tel");
            if (checkBox_Balcony.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Balcony");
            if (checkBox_FirePlace.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_FirePlace");
            if (checkBox_Parking.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Parking");
            if (checkBox_StRoom.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_StRoom");
            if (checkBox_Cellar.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Cellar");
            if (checkBox_Yard.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Yard");
            if (checkBox_BYard.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_BYard");
            if (checkBox_Patio.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Patio");
            if (checkBox_EmployeeSrv.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_EmployeeSrv");
            if (checkBox_Water.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Water");
            if (checkBox_Electricity.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Electricity");
            if (checkBox_Gaz.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Gaz");
            if (checkBox_Cooler.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Cooler");
            if (checkBox_FanCoel.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_FanCoel");
            if (checkBox_Heat.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Heat");
            if (checkBox_Chiler.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Chiler");
            if (checkBox_Pakage.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Pakage");
            if (checkBox_Sauna.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Sauna");
            if (checkBox_Jacuzzi.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Jacuzzi");
            if (checkBox_Pool.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Pool");
            if (checkBox_Elevatoor.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Elevatoor");
            if (checkBox_Property.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_Property");
            if (checkBox_KeyMoney.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_KeyMoney");
            if (checkBox_DocUse.Checked) Global_Cls.DefaultValueHouseFile.Add("checkBox_DocUse");

            if (radioButton_nonActive.Checked) Global_Cls.DefaultValueHouseFile.Add("radioButton_nonActive");

            Global_Cls.Money_Unit = comboBox_MnyUnit.Text;
            Global_Cls.Money_Change = (Int32)((textBox_ChangeMoney.Text == "") ? 0 : Int32.Parse(textBox_ChangeMoney.Text.Replace(",", "")));
                
            //Default value for HouseFile end

            //
            Global_Cls.TypeHouseAllCases.Clear();
            for (int i = 0; i < listBox_TypeHouse.Items.Count; i++)
                Global_Cls.TypeHouseAllCases.Insert(i, listBox_TypeHouse.Items[i].ToString());

            Global_Cls.HouseFor.Clear();
            for (int i = 0; i < listBox_HouseFor.Items.Count; i++)
                Global_Cls.HouseFor.Insert(i, listBox_HouseFor.Items[i].ToString());

            Global_Cls.RequestFor.Clear();
            for (int i = 0; i < listBox_ReqFor.Items.Count; i++)
                Global_Cls.RequestFor.Insert(i, listBox_ReqFor.Items[i].ToString());
            //


            //Web Part
            try
            {
                Global_Cls.SetWebHousePart.Clear();
                try { Global_Cls.SetWebHousePart.Insert(0, comboBox_HPart1.SelectedValue.ToString()); }
                catch { Global_Cls.SetWebHousePart.Insert(0, "0"); }
                try { Global_Cls.SetWebHousePart.Insert(1, comboBox_HPart2.SelectedValue.ToString()); }
                catch { Global_Cls.SetWebHousePart.Insert(1, "0"); }
                try { Global_Cls.SetWebHousePart.Insert(2, comboBox_HPart3.SelectedValue.ToString()); }
                catch { Global_Cls.SetWebHousePart.Insert(2, "0"); }
                try { Global_Cls.SetWebHousePart.Insert(3, comboBox_HPart4.SelectedValue.ToString()); }
                catch { Global_Cls.SetWebHousePart.Insert(3, "0"); }
                try { Global_Cls.SetWebHousePart.Insert(4, comboBox_HPart5.SelectedValue.ToString()); }
                catch { Global_Cls.SetWebHousePart.Insert(4, "0"); }
                try { Global_Cls.SetWebHousePart.Insert(5, comboBox_HPart6.SelectedValue.ToString()); }
                catch { Global_Cls.SetWebHousePart.Insert(5, "0"); }
                try { Global_Cls.SetWebHousePart.Insert(6, comboBox_HPart7.SelectedValue.ToString()); }
                catch { Global_Cls.SetWebHousePart.Insert(6, "0"); }
                try { Global_Cls.SetWebHousePart.Insert(7, comboBox_HPart8.SelectedValue.ToString()); }
                catch { Global_Cls.SetWebHousePart.Insert(7, "0"); }
            }
            catch { }
            //

            //FileNo Flage
            Global_Cls.FileNoFlage = !Convert.ToBoolean(comboBox_TypeFileNo.SelectedIndex);
            //

            Function_Cls.WriteToXmlFiles();

            CloseOK = true;
            this.Close();

        }

        #endregion



        #region Other
        PictureBox PB = null;
        private void button_AgencyLogo_Click(object sender, EventArgs e)
        {
            if (sender == button_AgencyLogo) PB = pictureBox_AgencyLogo;
            else PB = pictureBox_CityPic;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All image file|*.jpg;*.jpeg;*.png;*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PB.Load(ofd.FileName);
                string ofds = ofd.SafeFileName;
                ofds = ofds.Substring(ofds.IndexOf("."), ofds.Length - ofds.IndexOf("."));
                if (sender == button_AgencyLogo) AgencyLogoFilter = ofds;
                else CityPicFilter = ofds;
            }
        }

        private void button_BkpAuto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.SelectedPath = label_BkpAuto.Text;
            if (dir.ShowDialog() == DialogResult.OK)
            {
                label_BkpAuto.Text = dir.SelectedPath;
            }
        }

        private void button_RstChangePass_Click(object sender, EventArgs e)
        {
            Function_Cls.Restore_Func(true);
        }

        private void treeView_Setting_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "Node_FSetHouse") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_FsetHouse"];
            if (e.Node.Name == "Node_SetPosDef") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetPosDef"];
            if (e.Node.Name == "Node_SetUseHouse") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetUseHouse"];
            
            if (e.Node.Name == "Node_SetAgReg") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetAgReg"];
            if (e.Node.Name == "Node_SetAgPos") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetAgPos"];

            if (e.Node.Name == "Node_SetBkpRst") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetBkpRst"];
            
            if (e.Node.Name == "Node_SetAlarms") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetAlarms"];
            if (e.Node.Name == "Node_AdverField") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_AdverField"];
            if (e.Node.Name == "Node_Sms") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SMS"];
           // if (e.Node.Name == "Node_WebPart") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_WebPart"];
            if (e.Node.Name == "Node_SetUnits") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetUnits"];

        }

        private void panel_Date_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }
        #endregion



        #region Set Use House
        ListBox LB = null;
        private void button_UpTH_Click(object sender, EventArgs e)
        {
            if (sender == button_UpTH) LB = listBox_TypeHouse;
            if (sender == button_UpHF) LB = listBox_HouseFor;
            if (sender == button_UpRF) LB = listBox_ReqFor;

            if (LB.SelectedIndex != -1 && LB.SelectedIndex != 0)
            {
                string str = LB.Items[LB.SelectedIndex - 1].ToString();
                LB.Items[LB.SelectedIndex - 1] = LB.Items[LB.SelectedIndex];
                LB.Items[LB.SelectedIndex] = str;
                LB.SelectedIndex = LB.SelectedIndex - 1;
            }
        }

        private void button_DownTH_Click(object sender, EventArgs e)
        {
            if (sender == button_DownTH) LB = listBox_TypeHouse;
            if (sender == button_DownHF) LB = listBox_HouseFor;
            if (sender == button_DownRF) LB = listBox_ReqFor;

            if (LB.SelectedIndex != -1 && LB.SelectedIndex < LB.Items.Count - 1)
            {
                string str = LB.Items[LB.SelectedIndex + 1].ToString();
                LB.Items[LB.SelectedIndex + 1] = LB.Items[LB.SelectedIndex];
                LB.Items[LB.SelectedIndex] = str;
                LB.SelectedIndex = LB.SelectedIndex + 1;
            }
        }

        ComboBox CB = null;
        private void button_AddTH_Click(object sender, EventArgs e)
        {
            if (sender == button_AddTH) { LB = listBox_TypeHouse; CB = comboBox_AddTH; }
            if (sender == button_AddHF) { LB = listBox_HouseFor; CB = comboBox_AddHF; }
            if (sender == button_AddRF) { LB = listBox_ReqFor; CB = comboBox_AddRF; }

            if (CB.Text != "" && !LB.Items.Contains(CB.Text))
                LB.Items.Add(CB.Text);
        }

        private void button_DelTH_Click(object sender, EventArgs e)
        {
            if (sender == button_DelTH)
            {
                LB = listBox_TypeHouse;

                if (LB.SelectedIndex != -1)
                {
                    var p = (from prd in DMDC.TBL_HouseFiles
                             where prd.TypeHouse == LB.SelectedItem.ToString()
                             select prd).Count();
                    var r = (from prd in DMDC.TBL_HouseRequests
                             where prd.TypeHouseReq == LB.SelectedItem.ToString()
                             select prd).Count();

                    var s = (from prd in DSDC.TBL_SecondHouseFiles
                             where prd.TypeHouse == LB.SelectedItem.ToString()
                             select prd).Count();
                    if (s != 0 || p != 0 || r != 0)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "از این آیتم در سیستم استفاده شده است!");
                        return;
                    }
                }
            }
            if (sender == button_DelHF)
            {
                LB = listBox_HouseFor;
                if (LB.SelectedIndex != -1)
                {
                    var p = (from prd in DMDC.TBL_HouseFiles
                             where prd.HouseFor == LB.SelectedItem.ToString()
                             select prd).Count();

                    var s = (from prd in DSDC.TBL_SecondHouseFiles
                             where prd.HouseFor == LB.SelectedItem.ToString()
                             select prd).Count();
                    if (s != 0 || p != 0)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "از این آیتم در سیستم استفاده شده است!");
                        return;
                    }
                }
            }

            if (sender == button_DelRF)
            {
                LB = listBox_ReqFor;
                if (LB.SelectedIndex != -1)
                {
                    var r = (from prd in DMDC.TBL_HouseRequests
                             where prd.HouseReqFor == LB.SelectedItem.ToString()
                             select prd).Count();

                    if (r != 0)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "از این آیتم در سیستم استفاده شده است!");
                        return;
                    }
                }
            }


            if (LB.SelectedIndex != -1 && LB.SelectedIndex < LB.Items.Count)
                LB.Items.Remove(LB.SelectedItem);
        }
        #endregion



        #region  Select Part
        private int CntID, StID, CyID;
        private void comboBox_Country_Enter(object sender, EventArgs e)
        {
            if (comboBox_Country.DataSource == null)
            {
                var hh = from prd in DMDC.TBL_Countries
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
                var hh = from prd in DMDC.TBL_States
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
                var hh = from prd in DMDC.TBL_Cities
                         where prd.StateID == StID
                         select prd;
                comboBox_City.DataSource = hh;
            }
        }

        private void comboBox_City_Leave(object sender, EventArgs e)
        {
            CyID = Convert.ToInt32(comboBox_City.SelectedValue);
        }

        private void comboBox_Part_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Part.Tag.Equals(CyID))
            {
                comboBox_Part.Tag = CyID;
                var h1 = from prd in DMDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_Part.DataSource = h1;
            }
        }

        
        
        private int CntryID, SttID, CtyID;
        private void comboBox_Cntry_Enter(object sender, EventArgs e)
        {
            if (comboBox_Cntry.DataSource == null)
            {
                var hh = from prd in DMDC.TBL_Countries
                         select prd;
                comboBox_Cntry.DataSource = hh;
            }
        }

        private void comboBox_Cntry_Leave(object sender, EventArgs e)
        {
            CntryID = Convert.ToInt32(comboBox_Cntry.SelectedValue);
        }

        private void comboBox_Stt_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Stt.Tag.Equals(CntryID))
            {
                comboBox_Stt.Tag = CntryID;
                var hh = from prd in DMDC.TBL_States
                         where prd.CountryID == CntryID
                         select prd;
                comboBox_Stt.DataSource = hh;
            }
        }

        private void comboBox_Stt_Leave(object sender, EventArgs e)
        {
            SttID = Convert.ToInt32(comboBox_Stt.SelectedValue);
        }

        private void comboBox_Cty_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Cty.Tag.Equals(SttID))
            {
                comboBox_Cty.Tag = SttID;
                var hh = from prd in DMDC.TBL_Cities
                         where prd.StateID == SttID
                         select prd;
                comboBox_Cty.DataSource = hh;
            }
        }

        private void comboBox_Cty_Leave(object sender, EventArgs e)
        {
            CtyID = Convert.ToInt32(comboBox_Cty.SelectedValue);
        }

        private void comboBox_Prt_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Prt.Tag.Equals(CtyID))
            {
                comboBox_Prt.Tag = CtyID;
                var h1 = from prd in DMDC.TBL_Parts
                         where prd.CityID == CtyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_Prt.DataSource = h1;
            }
        }

        private void button_AddPrt_Click(object sender, EventArgs e)
        {
            if (textBox_NewPart.Text == "" || comboBox_Cty.Text == "") return;
            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            var tp1 = (from tpi in DCDC.TBL_Parts
                       where tpi.PartName_Fa == textBox_NewPart.Text && tpi.CityID == Convert.ToInt32(comboBox_Cty.SelectedValue)
                      select tpi).Count();
            if (tp1 != 0) { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نام منطقه وارد شده تکراری است"); return; }

            var tp = from tpi in DCDC.TBL_Parts
                     where tpi.CityID == Convert.ToInt32(comboBox_Cty.SelectedValue)
                     orderby tpi.PartID
                     select tpi.PartID;
            
            int partIdNew=0;

            if (tp.Count() == 0)
                partIdNew = Convert.ToInt32(Convert.ToInt32(comboBox_Cty.SelectedValue).ToString() + "100");
            else partIdNew = tp.Max() + 1;

            TBL_Part tprt = new TBL_Part
            {
                PartID = partIdNew,
                PartName_Fa = textBox_NewPart.Text,
                CityID = Convert.ToInt32(comboBox_Cty.SelectedValue)
            };
            DCDC.TBL_Parts.InsertOnSubmit(tprt);
            DCDC.SubmitChanges();
            comboBox_Prt.Tag = 0;
        }

        private void button_DelPrt_Click(object sender, EventArgs e)
        {
            if (comboBox_Prt.Text == "") return;

            var p = (from pr in DMDC.TBL_HouseFiles
                     where pr.Lord_Part.Value == Convert.ToInt32(comboBox_Prt.SelectedValue)
                     select pr).Count();
            var r = (from pr in DMDC.TBL_HouseRequests
                     where pr.PartRequest1.Value == Convert.ToInt32(comboBox_Prt.SelectedValue) ||
                     pr.PartRequest2.Value == Convert.ToInt32(comboBox_Prt.SelectedValue) ||
                     pr.PartRequest3.Value == Convert.ToInt32(comboBox_Prt.SelectedValue) ||
                     pr.PartRequest4.Value == Convert.ToInt32(comboBox_Prt.SelectedValue)
                     select pr).Count();
            var s = (from pr in DSDC.TBL_SecondHouseFiles
                     where pr.Lord_Part.Value == Convert.ToInt32(comboBox_Prt.SelectedValue)
                     select pr).Count();

            var pt = (from pr in DWDC.TBL_TmpHouseFiles
                     where pr.Lord_Part.Value == Convert.ToInt32(comboBox_Prt.SelectedValue)
                     select pr).Count();
            var rt = (from pr in DWDC.TBL_TmpHouseRequests
                     where pr.PartRequest1.Value == Convert.ToInt32(comboBox_Prt.SelectedValue) ||
                     pr.PartRequest2.Value == Convert.ToInt32(comboBox_Prt.SelectedValue) ||
                     pr.PartRequest3.Value == Convert.ToInt32(comboBox_Prt.SelectedValue) ||
                     pr.PartRequest4.Value == Convert.ToInt32(comboBox_Prt.SelectedValue)
                     select pr).Count();
            
            if (p != 0 || r != 0 || s != 0 || pt != 0 || rt != 0) 
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "از این منطفه در سیستم استفاده شده است!");
                return;
            }

            TBL_Part tprt = DMDC.TBL_Parts.First(i => i.PartID.Equals(Convert.ToInt32(comboBox_Prt.SelectedValue)));
            DMDC.TBL_Parts.DeleteOnSubmit(tprt);
            DMDC.SubmitChanges();
            comboBox_Prt.Tag = 0;
        }

        private void button_PartUpdate_Click(object sender, EventArgs e)
        {
            if (Global_Cls.Lock_Data == "Test")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در حالت تست امکان اتصال وجود ندارد!");
                return;
            }

            if (comboBox_Cty.Text != "" && Global_Cls.SetConnection() &&
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا مناطق شهر " + comboBox_Cty.Text + " به روز رسانی شوند؟"))
            {
                Function_Cls.UpdatePart(Convert.ToString(comboBox_Cty.SelectedValue));
            }
        }

        #endregion



        #region  Select Part Web
        private DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        private int WCntID, WStID, WCyID;
        private void comboBox_HCountry_Enter(object sender, EventArgs e)
        {
            if (comboBox_HCountry.DataSource == null)
            {
                var hh = from prd in DCDC.TBL_Countries
                         select prd;
                comboBox_HCountry.DataSource = hh;
            }
        }

        private void comboBox_HCountry_Leave(object sender, EventArgs e)
        {
            WCntID = Convert.ToInt32(comboBox_HCountry.SelectedValue);
        }

        private void comboBox_HState_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HState.Tag.Equals(WCntID))
            {
                comboBox_HState.Tag = WCntID;
                var hh = from prd in DCDC.TBL_States
                         where prd.CountryID == WCntID
                         select prd;
                comboBox_HState.DataSource = hh;
            }
        }

        private void comboBox_HState_Leave(object sender, EventArgs e)
        {
            WStID = Convert.ToInt32(comboBox_HState.SelectedValue);
        }

        private void comboBox_HCity_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HCity.Tag.Equals(WStID))
            {
                comboBox_HCity.Tag = WStID;
                var hh = from prd in DCDC.TBL_Cities
                         where prd.StateID == WStID
                         select prd;
                comboBox_HCity.DataSource = hh;
            }
        }

        private void comboBox_HCity_Leave(object sender, EventArgs e)
        {
            WCyID = Convert.ToInt32(comboBox_HCity.SelectedValue);
        }

        private void comboBox_HPart1_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart1.Tag.Equals(WCyID))
            {
                comboBox_HPart1.Tag = WCyID;
                var h1 = from prd in DCDC.TBL_Parts
                         where prd.CityID == WCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart1.DataSource = h1;
            }
        }

        private void comboBox_HPart2_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart2.Tag.Equals(WCyID))
            {
                comboBox_HPart2.Tag = WCyID;
                var h2 = from prd in DCDC.TBL_Parts
                         where prd.CityID == WCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart2.DataSource = h2;
            }
        }

        private void comboBox_HPart3_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart3.Tag.Equals(WCyID))
            {
                comboBox_HPart3.Tag = WCyID;
                var h3 = from prd in DCDC.TBL_Parts
                         where prd.CityID == WCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart3.DataSource = h3;
            }
        }

        private void comboBox_HPart4_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart4.Tag.Equals(WCyID))
            {
                comboBox_HPart4.Tag = WCyID;
                var h4 = from prd in DCDC.TBL_Parts
                         where prd.CityID == WCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart4.DataSource = h4;
            }
        }

        private void comboBox_HPart5_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart5.Tag.Equals(WCyID))
            {
                comboBox_HPart5.Tag = WCyID;
                var h5 = from prd in DCDC.TBL_Parts
                         where prd.CityID == WCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart5.DataSource = h5;
            }
        }

        private void comboBox_HPart6_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart6.Tag.Equals(WCyID))
            {
                comboBox_HPart6.Tag = WCyID;
                var h6 = from prd in DCDC.TBL_Parts
                         where prd.CityID == WCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart6.DataSource = h6;
            }
        }

        private void comboBox_HPart7_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart7.Tag.Equals(WCyID))
            {
                comboBox_HPart7.Tag = WCyID;
                var h7 = from prd in DCDC.TBL_Parts
                         where prd.CityID == WCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart7.DataSource = h7;
            }
        }

        private void comboBox_HPart8_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart8.Tag.Equals(WCyID))
            {
                comboBox_HPart8.Tag = WCyID;
                var h8 = from prd in DCDC.TBL_Parts
                         where prd.CityID == WCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart8.DataSource = h8;
            }
        }

        #endregion

        private void buttonX1_Click(object sender, EventArgs e)
        {

            var p = (from prd in DMDC.TBL_HouseFiles
                     select prd).Count();
            var r = (from prd in DMDC.TBL_HouseRequests
                     select prd).Count();
            var s = (from prd in DSDC.TBL_SecondHouseFiles
                     select prd).Count();
            var c = (from prd in DSDC.Tbl_HouseConclusions
                     select prd).Count();

            if (s != 0 || p != 0 || r != 0 || c != 0)
            {
                //                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "امکان تغییر واحد پول وجود ندارد!");
                //                      return;
                if (Global_Cls.MainForm.UserPermission != "admin")
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "فقط کاربر اصلی امکان تغییر را دارد!");
                    return;
                }
                else
                {
                    if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "درصورت تغییر، واحد پول رکوردهای قبلی براساس واحد پول جدید در نظر گرفته می شود! آیا ادامه می دهید؟"))
                        if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "درصورت تایید دیگر امکان تغییر وجود نخواهد داشت! "))
                          groupBox_MoneyUnit.Enabled = true;
                }
            }
            else
            {
                if (Global_Cls.MainForm.UserPermission != "admin")
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "فقط کاربر اصلی امکان تغییر را دارد!");
                    return;
                }
                groupBox_MoneyUnit.Enabled = true;
            }
        }

        private void comboBox_MnyUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_MnyU.Text = comboBox_MnyUnit.Text;
        }

        TextBox tx = new TextBox();
        private void textBox_Change_TextChanged(object sender, EventArgs e)
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

        private void textBox_Change_KeyPress(object sender, KeyPressEventArgs e)
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


    }
}
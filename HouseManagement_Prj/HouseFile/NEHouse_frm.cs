using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Collections.ObjectModel;
using System.Diagnostics;
using HouseManagement_Prj.Properties;
using System.Data.SqlClient;

namespace HouseManagement_Prj
{
    public partial class NEHouse_frm : Form
    {
        public NEHouse_frm()
        {
            InitializeComponent();
        }
        public int NewOrEditHouse, HsID;
        private int MaxHouseID, MaxFileNO;
        private bool CloseOK = false;

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DCSDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);


        #region Load Data
        public void SetData_NEHouse()
        {
            label_Mny1.Text = Global_Cls.Money_Unit;
            label_Mny2.Text = label_Mny1.Text;
            label_Mny3.Text = label_Mny1.Text;
            label_Mny4.Text = label_Mny1.Text;
            //new
            if (itemPanel_TypeHouse.Items.Count==0)
                for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
            {
                DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                Ch.Name = i.ToString();
                Ch.Text = Global_Cls.TypeHouseAllCases[i];
                Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
                Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
                if (i == 0) Ch.Checked = true;
                itemPanel_TypeHouse.Items.Add(Ch, i);
                itemPanel_TypeHouse.Refresh();
            }
            if (itemPanel_HouseFor.Items.Count == 0)
            for (int i = 0; i < Global_Cls.HouseForPrm.Count; i++)//new
            {
                DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                Ch.Name = i.ToString();
                Ch.Text = Global_Cls.HouseForPrm[i];//new
                Ch.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
                Ch.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Bottom;
                if (i == 0) Ch.Checked = true;
                itemPanel_HouseFor.Items.Add(Ch, i);
                itemPanel_HouseFor.Refresh();
            }
//new
            
            //Start Use Permission
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(checkBox_AddTelNotebook.Name)) checkBox_AddTelNotebook.Enabled = false;
                if (UPer.Contains(checkBoxItem_ListCuHouse.Name)) checkBoxItem_ListCuHouse.Enabled = false;
            }
            //End Use Permission

            try
            {
                var MaxID = (from prd in DCMD.TBL_HouseFiles
                             select prd.HouseID).Max();
                MaxHouseID = MaxID;
            }
            catch
            {
                MaxHouseID = 1;
            }

            try
            {
                var MaxFNO = (from prd in DCMD.TBL_HouseFiles
                              select Convert.ToInt32(prd.FileNO)).Max();
                MaxFileNO = MaxFNO + 1;
            }
            catch
            {
                MaxFileNO = 1;
            }


            if (NewOrEditHouse == 2)
            {
                buttonItem_OkNext.Visible = false;
                checkBox_HoldData.Visible = false;
                if (Global_Cls.IsDefaultValue)
                {
                    checkBoxItem_Print.Checked = Global_Cls.HouseFile_Print;
                    checkBoxItem_ListCuHouse.Checked = Global_Cls.HouseFile_CustomerList;
                    checkBox_AddTelNotebook.Checked = Global_Cls.HouseFile_TelNtBook;
                }

                try
                {
                    TBL_HouseFile tbhf = DCMD.TBL_HouseFiles.First(thfh => thfh.HouseID.Equals(HsID));

                    textBox_FN.Text = tbhf.FileNO;

                    //textBox_Date.Text = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.Modify_Date));
                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.Modify_Date));
                    comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_FName.Text = tbhf.Lord_Name;
                    textBox_LName.Text = tbhf.Lord_Family;
                    textBox_Address.Text = tbhf.Lord_Address;

                    PartFill(tbhf.Lord_Part.Value.ToString());

                    textBox_Email.Text = tbhf.Lord_Email;
                    textBox_Mobile.Text = tbhf.Lord_Mobile;
                    textBox_Tel.Text = tbhf.Lord_Telephone;
                    
                    //new
                    for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
                        if (tbhf.TypeHouse == itemPanel_TypeHouse.Items[i].Text)
                        { (itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked = true; break; }

                    for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
                        if (tbhf.HouseFor == itemPanel_HouseFor.Items[i].Text)
                        { (itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked = true; break; }

                    /*checkBox_Sale.Checked = tbhf.TR_Sale.Value;
                    checkBox_Rent.Checked = tbhf.TR_Rent.Value;
                    checkBox_Mortgage.Checked = tbhf.TR_Mortgage.Value;
                    checkBox_PreSale.Checked = tbhf.TR_PreSale.Value;
                    checkBox_Prtpc.Checked = tbhf.TR_Participation.Value;
                    radioButton_Apartmnt.Checked = tbhf.TH_Apartement.Value;
                    radioButton_Tent.Checked = tbhf.TH_Tenement.Value;
                    radioButton_Villa.Checked = tbhf.TH_Vila.Value;
                    radioButton_Dila.Checked = tbhf.TH_Dilapidated.Value;
                    radioButton_Ln.Checked = tbhf.TH_Land.Value;
                    radioButton_PLn.Checked = tbhf.TH_PartialLand.Value;
                    radioButton_SR.Checked = tbhf.TH_StoreRoom.Value;
                    radioButton_WR.Checked = tbhf.TH_WorkRoom.Value;
                    radioButton_Shop.Checked = tbhf.TH_Shop.Value;
                    radioButton_St.Checked = tbhf.TH_Suit.Value;
                    radioButton_Garden.Checked = tbhf.TH_Garden.Value;
                    radioButton_SGarden.Checked = tbhf.TH_SmallGarden.Value;*/
                    //new

                    radioButton_North.Checked = tbhf.P_Northern.Value;
                    radioButton_Southern.Checked = tbhf.P_Southern.Value;
                    radioButton_West.Checked = tbhf.P_Western.Value;
                    radioButton_East.Checked = tbhf.P_Eastern.Value;
                    textBox_Subbuild.Text = tbhf.FH_Submeter.ToString();
                    nUpDown_FewFloor.Value = tbhf.Few_estate.Value;
                    nUpDown_FUF.Value = tbhf.Few_estateunit.Value;
                    nUpDown_AFU.Value = tbhf.Few_unitAll.Value;
                    nUpDown_FBComplx.Value = tbhf.Few_ComplexBld.Value;
                    checkBox_Comlex.Checked = tbhf.Complex.Value;
                    nUpDown_WFloor.Value = tbhf.FH_estateNo.Value;
                    nUpDown_UnitNO.Value = tbhf.FH_UnitNo.Value;
                    textBox_HPrice.Text = Global_Cls.DigitSeparator(tbhf.Price_HouseMeter.ToString());
                    textBox_AHPrice.Text = Global_Cls.DigitSeparator(tbhf.Price_HouseAll.ToString());
                    textBox_MPrice.Text = Global_Cls.DigitSeparator(tbhf.Price_Mortgage.ToString());
                    textBox_RPrice.Text = Global_Cls.DigitSeparator(tbhf.Price_Rent.ToString());
                   
                    nUpDown_KitchenFew.Value = tbhf.FH_KitchenFew.Value;
                    nUpDown_FBed.Value = tbhf.FH_BedRoomFew.Value;
                    nUpDown_FRoom.Value = tbhf.FH_RcRoomFew.Value;
                    nUpDown_FWcIr.Value = tbhf.FH_WcFewIr.Value;
                    nUpDown_FWcFg.Value = tbhf.FH_WcFewFg.Value;
                    comboBox_BedRoom.Text = tbhf.FH_BedRoom;
                    comboBox_RcRoom.Text = tbhf.FH_RcRoom;
                    comboBox_BldLow.Text = tbhf.FH_BldLow;
                    comboBox_WallCover.Text = tbhf.FH_WallCover.ToString();
                    comboBox_MK.Text = tbhf.FH_KitchenModel;
                    comboBox_CT.Text = tbhf.FH_CupbrdType;
                    comboBox_FB.Text = tbhf.FH_Bldface;
                    checkBox_IRWc.Checked = tbhf.FH_WcIrani.Value;
                    checkBox_FWc.Checked = tbhf.FH_WcForeign.Value;
                    checkBox_SK.Checked = tbhf.FH_SmallKitchen.Value;
                    checkBox_AV.Checked = tbhf.FH_AifoonVideo.Value;
                    checkBox_RDoor.Checked = tbhf.FH_RemotingDoor.Value;
                    checkBox_AC.Checked = tbhf.FH_AerialCenter.Value;
                    comboBox_Decoration.Text = tbhf.FH_Decoration.ToString();
                    checkBox_Tel.Checked = tbhf.FH_Telephone.Value;
                    nUpDown_FTel.Value = tbhf.FH_TelFew.Value;
                    checkBox_Balcony.Checked = tbhf.FH_Balcony.Value;
                    textBox_BlcM.Text = tbhf.FH_BalconyMeter.ToString();
                    checkBox_FirePlace.Checked = tbhf.FH_FirePlace.Value;
                    nUpDown_FFireP.Value = tbhf.FH_FirePlaceFew.Value;
                    checkBox_Parking.Checked = tbhf.FH_Parking.Value;
                    nUpDown_FPark.Value = tbhf.FH_ParkingFew.Value;
                    checkBox_StRoom.Checked = tbhf.FH_StoreRoom.Value;
                    textBox_StRoomM.Text = tbhf.FH_StRoomMeter.ToString();
                    checkBox_Cellar.Checked = tbhf.FH_Cellar.Value;
                    textBox_CellarM.Text = tbhf.FH_CellarMeter.ToString();
                    checkBox_Yard.Checked = tbhf.FH_Yard.Value;
                    textBox_YardM.Text = tbhf.FH_YardMeter.ToString();
                    checkBox_BYard.Checked = tbhf.FH_BackYard.Value;
                    textBox_BYardM.Text = tbhf.FH_BackYardMeter.ToString();
                    checkBox_Patio.Checked = tbhf.FH_Patio.Value;
                    textBox_PatioM.Text = tbhf.FH_PatioMeter.ToString();
                    checkBox_EmployeeSrv.Checked = tbhf.FH_EmployeeSrv.Value;
                    checkBox_RubShooting.Checked = tbhf.FH_RubShooting.Value;
                    
                    checkBox_Water.Checked = tbhf.CH_Water.Value;
                    checkBox_Electricity.Checked = tbhf.CH_Electricity.Value;
                    checkBox_Gaz.Checked = tbhf.CH_Gaz.Value;
                    checkBox_Cooler.Checked = tbhf.CH_Cooler.Value;
                    checkBox_FanCoel.Checked = tbhf.CH_FanCoel.Value;
                    checkBox_Heat.Checked = tbhf.CH_Heat.Value;
                    checkBox_Chiler.Checked = tbhf.CH_Chiler.Value;
                    checkBox_Pakage.Checked = tbhf.CH_Pakage.Value;
                    checkBox_Sauna.Checked = tbhf.CH_Sauna.Value;
                    checkBox_Jacuzzi.Checked = tbhf.CH_Jacuzzi.Value;
                    checkBox_Pool.Checked = tbhf.CH_Pool.Value;
                    comboBox_PoolType.Text = tbhf.CH_PoolType.ToString();
                    checkBox_Elevatoor.Checked = tbhf.CH_Elevator.Value;
                    nUpDown_FElevatoor.Value = tbhf.CH_ElevatorFew.Value;
                    
                    textBox_LndArea.Text = tbhf.RH_LandArea.ToString();
                    textBox_SideWidth.Text = tbhf.RH_SideWidth.ToString();
                    textBox_Arena.Text = tbhf.RH_Arena.ToString();
                    textBox_UpScale.Text = tbhf.RH_Upscale.ToString();
                    textBox_Height.Text = tbhf.RH_Height.ToString();
                    textBox_Pressure.Text = tbhf.RH_Pressure.ToString();
                    textBox_Corrective.Text = tbhf.RH_Corrective.ToString();
                    textBox_Walled.Text = tbhf.RH_Walled.ToString();
                    nUpDown_BldAge.Value = tbhf.RH_Bldage.Value;
                    comboBox_UseType.Text = tbhf.RH_UseType;
                    checkBox_LicenceConfig.Checked = tbhf.RH_LicenceConfig.Value;
                    comboBox_LicenceType.Text = tbhf.RH_LicenceType;
                    checkBox_DocUse.Checked = tbhf.RH_DocUse.Value;
                    comboBox_DocType.Text = tbhf.RH_DocType;
                    checkBox_Property.Checked = tbhf.RH_Property.Value;
                    checkBox_KeyMoney.Checked = tbhf.RH_KeyMoney.Value;
                    checkBox_Discharge.Checked = tbhf.OH_Discharge.Value;
                    checkBox_RentUse.Checked = tbhf.OH_RentUse.Value;
                    checkBox_LordExist.Checked = tbhf.OH_LordExist.Value;

                    //textBox_DischargeDate.Text = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.OH_DischargeDate));
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.OH_DischargeDate));
                    comboBox_Year2.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_Month2.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day2.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_HolderName.Text = tbhf.OH_HolderName;
                    textBox_HolderTel.Text = tbhf.OH_HolderTel;
                    comboBox_VisitAllow.Text = tbhf.OH_VisitAllow;
                    textBox_MapDict.Text = tbhf.OH_MapDictation;
                    textBox_Specify.Text = tbhf.OH_Specify;
                    nUpDown_MaxPeople.Value = tbhf.OH_MaxPeople.Value;
                    textBox_InfoSource.Text = tbhf.InformationSource;
                    textBox_Desc.Text = tbhf.Description;
                    comboBox_Priority.Text = tbhf.FilePriority.ToString();
                    radioButton_Active.Checked = (tbhf.FileStatus == 0);
                    radioButton_nonActive.Checked = (tbhf.FileStatus == 1);

                    //textBox_NonActDate.Text = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.NonActive_Date));
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.NonActive_Date));
                    comboBox_yearNA.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_monthNA.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_dayNA.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                }
                catch //(Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در لود");
                }

                //pics & films
                LoadPics_Films(HsID);

            }
            else if (NewOrEditHouse == 1 && !checkBox_HoldData.Checked)
            {
                textBox_FN.Text = MaxFileNO.ToString();

                //textBox_Date.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                //textBox_NonActDate.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(365));
                DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(365));
                comboBox_yearNA.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_monthNA.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_dayNA.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                //textBox_DischargeDate.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_Year2.Text = comboBox_Year1.Text;
                comboBox_Month2.Text = comboBox_Month1.Text;
                comboBox_day2.Text = comboBox_day1.Text;

                comboBox_Priority.SelectedIndex = 0;
                if (Global_Cls.IsDefaultValue) SetDefault_NEHouseFileValue();

            }

        }


        private void SetDefault_NEHouseFileValue()
        {
            checkBoxItem_Print.Checked = Global_Cls.HouseFile_Print;
            checkBoxItem_ListCuHouse.Checked = Global_Cls.HouseFile_CustomerList;
            checkBox_AddTelNotebook.Checked = Global_Cls.HouseFile_TelNtBook;
            checkBox_HoldData.Checked = Global_Cls.HouseFile_DataHolder;

            try
            {
                PartFill(Global_Cls.DefaultValueHouseFile[0]);
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

                //textBox_NonActDate.Text = Global_Cls.DefaultValueHouseFile[11];
                string DateStr = Global_Cls.DefaultValueHouseFile[11];
                comboBox_yearNA.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_monthNA.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_dayNA.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


                //new
                for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
                    if (Global_Cls.DefaultValueHouseFile[12] == itemPanel_TypeHouse.Items[i].Text)
                    { (itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked = true; break; }

                for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
                    if (Global_Cls.DefaultValueHouseFile[13] == itemPanel_HouseFor.Items[i].Text)
                    { (itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked = true; break; }

                /*if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Sale")) checkBox_Sale.Checked = true;
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

                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_IRWc")) { checkBox_IRWc.Checked = true; nUpDown_FWcIr.Value = 1; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_FWc")) { checkBox_FWc.Checked = true; nUpDown_FWcFg.Value = 1; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_SK")) checkBox_SK.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_AV")) checkBox_AV.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_RDoor")) checkBox_RDoor.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_AC")) checkBox_AC.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Tel")) { checkBox_Tel.Checked = true; nUpDown_FTel.Value = 1; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Parking")) { checkBox_Parking.Checked = true; nUpDown_FPark.Value = 1; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_FirePlace")) { checkBox_FirePlace.Checked = true; nUpDown_FFireP.Value = 1; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Balcony")) { checkBox_Balcony.Checked = true; textBox_BlcM.Text = "1"; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_StRoom")) { checkBox_StRoom.Checked = true; textBox_StRoomM.Text = "1"; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Cellar")) { checkBox_Cellar.Checked = true; textBox_CellarM.Text = "1"; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Yard")) { checkBox_Yard.Checked = true; textBox_YardM.Text = "1"; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_BYard")) { checkBox_BYard.Checked = true; textBox_BYardM.Text = "1"; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Patio")) { checkBox_Patio.Checked = true; textBox_PatioM.Text = "1"; }
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
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Elevatoor")) { checkBox_Elevatoor.Checked = true; nUpDown_FElevatoor.Value = 1; }
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_Property")) checkBox_Property.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_KeyMoney")) checkBox_KeyMoney.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("checkBox_DocUse")) checkBox_DocUse.Checked = true;
                if (Global_Cls.DefaultValueHouseFile.Contains("radioButton_nonActive")) radioButton_nonActive.Checked = true;
            }
            catch { }

        }

        private void PartFill(string PartIDStr)
        {
            if (PartIDStr != "0")
            {
                comboBox_Country_Enter(this, null);
                comboBox_Country.SelectedValue = Convert.ToInt32(PartIDStr.Substring(0, 1));
                comboBox_Country_Leave(this, null);

                comboBox_State_Enter(this, null);
                comboBox_State.SelectedValue = Convert.ToInt32(PartIDStr.Substring(0, 3));
                comboBox_State_Leave(this, null);

                comboBox_City_Enter(this, null);
                comboBox_City.SelectedValue = Convert.ToInt32(PartIDStr.Substring(0, 5));
                comboBox_City_Leave(this, null);

                comboBox_Part_Enter(this, null);
                comboBox_Part.SelectedValue = Convert.ToInt32(PartIDStr);
            }
        }

        #endregion



        #region OK Data
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            //codeing
            if (Global_Cls.SoftwareCode == "Trial" && !Function_Cls.CheckTrialVersion(1)) return;
            //codeing

            if (OkFunction())
            {
                CloseOK = true;
                Close();
            }
                //Global_Cls.MainForm.DeleteTabFromTabControl(Global_Cls.MainForm.tabControl_Main.SelectedTab);
        }



        private void buttonItem_OkNext_Click(object sender, EventArgs e)
        {
            //codeing
            if (Global_Cls.SoftwareCode == "Trial" && !Function_Cls.CheckTrialVersion(1)) return;
            //codeing

            if (OkFunction())
            {
                if (!checkBox_HoldData.Checked)
                {
                    CloseOK = true;
                    Close(); 
                    Hide();
                    //                   Global_Cls.MainForm.DeleteTabFromTabControl(Global_Cls.MainForm.tabControl_Main.SelectedTab);
                    Global_Cls.MainForm.NewHouse_Function();
                }
                else
                    SetData_NEHouse();
            }
        }

        private bool OkFunction()
        {
            panel_Date_Leave(this, null);
            panel_DisDate_Leave(this, null);
            panel_NonActDate_Leave(this, null);
            
            //FileNoFlage
            if (Global_Cls.FileNoFlage)
                try { int i = Convert.ToInt32(textBox_FN.Text); }
                catch
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "شماره فایل عددی نمی باشد!");
                    textBox_FN.Focus();
                    return false;
                }
           
            if (textBox_LName.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام خانوادگی مالک را وارد نمایید"); textBox_LName.Focus(); return false; }
            if (textBox_Address.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "آدرس ملک را وارد نمایید"); textBox_Address.Focus(); return false; }
            if (textBox_Tel.Text == "" && textBox_Mobile.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "تلفن ثابت و یا موبایل مالک را وارد نمایید"); textBox_Mobile.Focus(); return false; }


            //اضافه به دفتر تلفن
            if (checkBox_AddTelNotebook.Checked)
            {
                try
                {
                    NETelMob_frm TMf = new NETelMob_frm();

                    TMf.textBox_Name.Text = textBox_FName.Text;
                    TMf.textBox_Family.Text = textBox_LName.Text;
                    TMf.textBox_Tel.Text = textBox_Tel.Text;
                    TMf.textBox_Mobile.Text = textBox_Mobile.Text;
                    TMf.textBox_Email.Text = textBox_Email.Text;
                    TMf.textBox_Address.Text = textBox_Address.Text;
                    TMf.textBox_Desc.Text = "";

                    TMf.UseFormInInsertOrEditMode(1);
                }
                catch { }

                //int A = Global_Cls.InsertPerTelMob(textBox_FName.Text, textBox_LName.Text, textBox_Tel.Text, textBox_Mobile.Text, textBox_Email.Text, textBox_Address.Text, "");
                //if (A != 0 && A != 2)
                //    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, true, "مشخصات این فرد در دفتر تلفن موجود می باشد! آیا ادامه می دهید؟"))
                //    { return false; }
            }

            //new
            string TypeHouseStr = "", HouseForStr = "";
            for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
                if ((itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { TypeHouseStr = itemPanel_TypeHouse.Items[i].Text; break; }

            for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
                if ((itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { HouseForStr = itemPanel_HouseFor.Items[i].Text; break; }
            //new

            DataClasses_MainDataContext DCD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (NewOrEditHouse == 1)
                try
                {
                    // Test Re FileNo
                    var FN = (from prd in DCMD.TBL_HouseFiles
                              where prd.FileNO == textBox_FN.Text
                              select prd).Count();
                    if (FN > 0)
                        if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "شماره فایل ورودی تکراری است! آیا ثبت شود؟"))
                        {
                            textBox_FN.Focus();
                            return false;
                        }


                    TBL_HouseFile THF = new TBL_HouseFile
                    {
                        FileNO = textBox_FN.Text,
                        Modify_Date = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text),
                        Lord_Name = textBox_FName.Text,
                        Lord_Family = textBox_LName.Text,
                        Lord_Address = textBox_Address.Text,
                        Lord_Part = Convert.ToInt32(comboBox_Part.SelectedValue),
                        Lord_PartName = comboBox_Part.Text,
                        Lord_CityName = comboBox_City.Text,
                        Lord_Email = textBox_Email.Text,
                        Lord_Mobile = textBox_Mobile.Text,
                        Lord_Telephone = textBox_Tel.Text,

                        //new
                        HouseFor = HouseForStr,
                        TypeHouse = TypeHouseStr,
                        /*TR_Sale = checkBox_Sale.Checked,
                        TR_Rent = checkBox_Rent.Checked,
                        TR_Mortgage = checkBox_Mortgage.Checked,
                        TR_PreSale = checkBox_PreSale.Checked,
                        TR_Participation = checkBox_Prtpc.Checked,
                        TH_Apartement = radioButton_Apartmnt.Checked,
                        TH_Tenement = radioButton_Tent.Checked,
                        TH_Vila = radioButton_Villa.Checked,
                        TH_Dilapidated = radioButton_Dila.Checked,
                        TH_Land = radioButton_Ln.Checked,
                        TH_PartialLand = radioButton_PLn.Checked,
                        TH_StoreRoom = radioButton_SR.Checked,
                        TH_WorkRoom = radioButton_WR.Checked,
                        TH_Shop = radioButton_Shop.Checked,
                        TH_Suit = radioButton_St.Checked,
                        TH_Garden = radioButton_Garden.Checked,
                        TH_SmallGarden = radioButton_SGarden.Checked,*/
                        //new

                        P_Northern = radioButton_North.Checked,
                        P_Southern = radioButton_Southern.Checked,
                        P_Western = radioButton_West.Checked,
                        P_Eastern = radioButton_East.Checked,

                        FH_Submeter = Convert.ToDouble((string)((textBox_Subbuild.Text == "") ? "0" : (textBox_Subbuild.Text))),
                        Few_estate = Convert.ToInt16(nUpDown_FewFloor.Value),
                        Few_estateunit = Convert.ToInt16(nUpDown_FUF.Value),
                        Few_unitAll = Convert.ToInt16(nUpDown_AFU.Value),
                        Complex = checkBox_Comlex.Checked,
                        Few_ComplexBld = Convert.ToInt16(nUpDown_FBComplx.Value),
                        FH_estateNo = Convert.ToInt16(nUpDown_WFloor.Value),
                        FH_UnitNo = Convert.ToInt32(nUpDown_UnitNO.Value),
                        Price_HouseMeter = Convert.ToInt64((string)((textBox_HPrice.Text == "") ? "0" : (textBox_HPrice.Text)).Replace(",", "")),
                        Price_HouseAll = Convert.ToInt64((string)((textBox_AHPrice.Text == "") ? "0" : (textBox_AHPrice.Text)).Replace(",", "")),
                        Price_Mortgage = Convert.ToInt64((string)((textBox_MPrice.Text == "") ? "0" : (textBox_MPrice.Text)).Replace(",", "")),
                        Price_Rent = Convert.ToInt64((string)((textBox_RPrice.Text == "") ? "0" : (textBox_RPrice.Text)).Replace(",", "")),

                        FH_KitchenFew = Convert.ToInt16(nUpDown_KitchenFew.Value),
                        FH_BedRoomFew = Convert.ToInt16(nUpDown_FBed.Value),
                        FH_RcRoomFew = Convert.ToInt16(nUpDown_FRoom.Value),
                        FH_WcFewIr = Convert.ToInt16(nUpDown_FWcIr.Value),
                        FH_WcFewFg = Convert.ToInt16(nUpDown_FWcFg.Value),
                        FH_BedRoom = comboBox_BedRoom.Text,
                        FH_RcRoom = comboBox_RcRoom.Text,
                        FH_BldLow = comboBox_BldLow.Text,
                        FH_WallCover = comboBox_WallCover.Text,
                        FH_KitchenModel = comboBox_MK.Text,
                        FH_CupbrdType = comboBox_CT.Text,
                        FH_Bldface = comboBox_FB.Text,
                        FH_WcIrani = checkBox_IRWc.Checked,
                        FH_WcForeign = checkBox_FWc.Checked,
                        FH_SmallKitchen = checkBox_SK.Checked,
                        FH_AifoonVideo = checkBox_AV.Checked,
                        FH_RemotingDoor = checkBox_RDoor.Checked,
                        FH_AerialCenter = checkBox_AC.Checked,
                        FH_Decoration = comboBox_Decoration.Text,
                        FH_Telephone = checkBox_Tel.Checked,
                        FH_TelFew = Convert.ToInt16(nUpDown_FTel.Value),
                        FH_Balcony = checkBox_Balcony.Checked,
                        FH_BalconyMeter = Convert.ToDouble((string)((textBox_BlcM.Text == "") ? "0" : (textBox_BlcM.Text))),
                        FH_FirePlace = checkBox_FirePlace.Checked,
                        FH_FirePlaceFew = Convert.ToInt16(nUpDown_FFireP.Value),
                        FH_Parking = checkBox_Parking.Checked,
                        FH_ParkingFew = Convert.ToInt16(nUpDown_FPark.Value),
                        FH_StoreRoom = checkBox_StRoom.Checked,
                        FH_StRoomMeter = Convert.ToDouble((string)((textBox_StRoomM.Text == "") ? "0" : (textBox_StRoomM.Text))),
                        FH_Cellar = checkBox_Cellar.Checked,
                        FH_CellarMeter = Convert.ToDouble((string)((textBox_CellarM.Text == "") ? "0" : (textBox_CellarM.Text))),
                        FH_Yard = checkBox_Yard.Checked,
                        FH_YardMeter = Convert.ToDouble((string)((textBox_YardM.Text == "") ? "0" : (textBox_YardM.Text))),
                        FH_BackYard = checkBox_BYard.Checked,
                        FH_BackYardMeter = Convert.ToDouble((string)((textBox_BYardM.Text == "") ? "0" : (textBox_BYardM.Text))),
                        FH_Patio = checkBox_Patio.Checked,
                        FH_PatioMeter = Convert.ToDouble((string)((textBox_PatioM.Text == "") ? "0" : (textBox_PatioM.Text))),
                        FH_EmployeeSrv = checkBox_EmployeeSrv.Checked,
                        FH_RubShooting = checkBox_RubShooting.Checked,

                        CH_Water = checkBox_Water.Checked,
                        CH_Electricity = checkBox_Electricity.Checked,
                        CH_Gaz = checkBox_Gaz.Checked,
                        CH_Cooler = checkBox_Cooler.Checked,
                        CH_FanCoel = checkBox_FanCoel.Checked,
                        CH_Heat = checkBox_Heat.Checked,
                        CH_Chiler = checkBox_Chiler.Checked,
                        CH_Pakage = checkBox_Pakage.Checked,
                        CH_Sauna = checkBox_Sauna.Checked,
                        CH_Jacuzzi = checkBox_Jacuzzi.Checked,
                        CH_Pool = checkBox_Pool.Checked,
                        CH_PoolType = comboBox_PoolType.Text,
                        CH_Elevator = checkBox_Elevatoor.Checked,
                        CH_ElevatorFew = Convert.ToInt16(nUpDown_FElevatoor.Value),
                        RH_LandArea = Convert.ToDouble(textBox_LndArea.Text),
                        RH_SideWidth = Convert.ToDouble(textBox_SideWidth.Text),
                        RH_Arena = Convert.ToDouble(textBox_Arena.Text),
                        RH_Upscale = Convert.ToDouble(textBox_UpScale.Text),
                        RH_Height = Convert.ToDouble(textBox_Height.Text),
                        RH_Pressure = Convert.ToDouble(textBox_Pressure.Text),
                        RH_Corrective = Convert.ToDouble(textBox_Corrective.Text),
                        RH_Walled = Convert.ToDouble(textBox_Walled.Text),
                        RH_Bldage = Convert.ToInt16(nUpDown_BldAge.Value),
                        RH_UseType = comboBox_UseType.Text,
                        RH_LicenceConfig = checkBox_LicenceConfig.Checked,
                        RH_LicenceType = comboBox_LicenceType.Text,
                        RH_Property = checkBox_Property.Checked,
                        RH_KeyMoney = checkBox_KeyMoney.Checked,
                        RH_DocUse = checkBox_DocUse.Checked,
                        RH_DocType = comboBox_DocType.Text,
                        OH_Discharge = checkBox_Discharge.Checked,
                        OH_RentUse = checkBox_RentUse.Checked,
                        OH_LordExist = checkBox_LordExist.Checked,
                        OH_DischargeDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_day2.Text),
                        OH_HolderName = textBox_HolderName.Text,
                        OH_HolderTel = textBox_HolderTel.Text,
                        OH_VisitAllow = comboBox_VisitAllow.Text,
                        OH_MapDictation = textBox_MapDict.Text,
                        OH_MaxPeople = Convert.ToInt16(nUpDown_MaxPeople.Value),
                        OH_Specify = textBox_Specify.Text,
                        InformationSource = textBox_InfoSource.Text,
                        Description = textBox_Desc.Text,
                        User_Code = Global_Cls.UserCode_Exist,
                        FilePriority = Convert.ToInt16(comboBox_Priority.Text),
                        FileStatus = Convert.ToInt16(radioButton_nonActive.Checked),
                        NonActive_Date = Global_Cls.ShamsiDateToMiladi(comboBox_yearNA.Text, comboBox_monthNA.Text, comboBox_dayNA.Text),

                    };
                    DCD.TBL_HouseFiles.InsertOnSubmit(THF);
                    DCD.SubmitChanges();
                    MaxHouseID++;

                    //pics & films
                    SavePics_Films(MaxHouseID);

                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                    else if (ex.Message.IndexOf("Duplicated Tbl_Second!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده در لیست بایگانی، حذفیات و یا قراردادها وجود دارد!");
                    else
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.ToString());

                    return false;
                }
            else
                if (NewOrEditHouse == 2)
                    try
                    {
                        TBL_HouseFile tbhf = DCD.TBL_HouseFiles.First(thfh => thfh.HouseID.Equals(HsID));

                        tbhf.FileNO = textBox_FN.Text;
                        tbhf.Modify_Date = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text);
                        tbhf.Lord_Name = textBox_FName.Text;
                        tbhf.Lord_Family = textBox_LName.Text;
                        tbhf.Lord_Address = textBox_Address.Text;
                        tbhf.Lord_Part = Convert.ToInt32(comboBox_Part.SelectedValue);
                        tbhf.Lord_Email = textBox_Email.Text;
                        tbhf.Lord_Mobile = textBox_Mobile.Text;
                        tbhf.Lord_Telephone = textBox_Tel.Text;

                        tbhf.TypeHouse = TypeHouseStr;
                        tbhf.HouseFor = HouseForStr;

                        /*tbhf.TR_Sale = checkBox_Sale.Checked;
                        tbhf.TR_Rent = checkBox_Rent.Checked;
                        tbhf.TR_Mortgage = checkBox_Mortgage.Checked;
                        tbhf.TR_PreSale = checkBox_PreSale.Checked;
                        tbhf.TR_Participation = checkBox_Prtpc.Checked;
                        tbhf.TH_Apartement = radioButton_Apartmnt.Checked;
                        tbhf.TH_Tenement = radioButton_Tent.Checked;
                        tbhf.TH_Vila = radioButton_Villa.Checked;
                        tbhf.TH_Dilapidated = radioButton_Dila.Checked;
                        tbhf.TH_Land = radioButton_Ln.Checked;
                        tbhf.TH_PartialLand = radioButton_PLn.Checked;
                        tbhf.TH_StoreRoom = radioButton_SR.Checked;
                        tbhf.TH_WorkRoom = radioButton_WR.Checked;
                        tbhf.TH_Shop = radioButton_Shop.Checked;
                        tbhf.TH_Suit = radioButton_St.Checked;
                        tbhf.TH_Garden = radioButton_Garden.Checked;
                        tbhf.TH_SmallGarden = radioButton_SGarden.Checked;
                         */
                        //new

                        tbhf.P_Northern = radioButton_North.Checked;
                        tbhf.P_Southern = radioButton_Southern.Checked;
                        tbhf.P_Western = radioButton_West.Checked;
                        tbhf.P_Eastern = radioButton_East.Checked;
                        tbhf.FH_Submeter = Convert.ToDouble((string)((textBox_Subbuild.Text == "") ? "0" : (textBox_Subbuild.Text)));
                        tbhf.Few_estate = Convert.ToInt16(nUpDown_FewFloor.Value);
                        tbhf.Few_estateunit = Convert.ToInt16(nUpDown_FUF.Value);
                        tbhf.Few_unitAll = Convert.ToInt16(nUpDown_AFU.Value);
                        tbhf.Complex = checkBox_Comlex.Checked;
                        tbhf.Few_ComplexBld = Convert.ToInt16(nUpDown_FBComplx.Value);
                        tbhf.FH_estateNo = Convert.ToInt16(nUpDown_WFloor.Value);
                        tbhf.FH_UnitNo = Convert.ToInt32(nUpDown_UnitNO.Value);
                        tbhf.Price_HouseMeter = Convert.ToInt64((string)((textBox_HPrice.Text == "") ? "0" : (textBox_HPrice.Text)).Replace(",", ""));
                        tbhf.Price_HouseAll = Convert.ToInt64((string)((textBox_AHPrice.Text == "") ? "0" : (textBox_AHPrice.Text)).Replace(",", ""));
                        tbhf.Price_Mortgage = Convert.ToInt64((string)((textBox_MPrice.Text == "") ? "0" : (textBox_MPrice.Text)).Replace(",", ""));
                        tbhf.Price_Rent = Convert.ToInt64((string)((textBox_RPrice.Text == "") ? "0" : (textBox_RPrice.Text)).Replace(",", ""));
                        
                        tbhf.FH_KitchenFew = Convert.ToInt16(nUpDown_KitchenFew.Value);
                        tbhf.FH_BedRoomFew = Convert.ToInt16(nUpDown_FBed.Value);
                        tbhf.FH_RcRoomFew = Convert.ToInt16(nUpDown_FRoom.Value);
                        tbhf.FH_WcFewIr = Convert.ToInt16(nUpDown_FWcIr.Value);
                        tbhf.FH_WcFewFg = Convert.ToInt16(nUpDown_FWcFg.Value);
                        tbhf.FH_BedRoom = comboBox_BedRoom.Text;
                        tbhf.FH_RcRoom = comboBox_RcRoom.Text;
                        tbhf.FH_BldLow = comboBox_BldLow.Text;
                        tbhf.FH_WallCover = comboBox_WallCover.Text;
                        tbhf.FH_KitchenModel = comboBox_MK.Text;
                        tbhf.FH_CupbrdType = comboBox_CT.Text;
                        tbhf.FH_Bldface = comboBox_FB.Text;
                        tbhf.FH_WcIrani = checkBox_IRWc.Checked;
                        tbhf.FH_WcForeign = checkBox_FWc.Checked;
                        tbhf.FH_SmallKitchen = checkBox_SK.Checked;
                        tbhf.FH_AifoonVideo = checkBox_AV.Checked;
                        tbhf.FH_RemotingDoor = checkBox_RDoor.Checked;
                        tbhf.FH_AerialCenter = checkBox_AC.Checked;
                        tbhf.FH_Decoration = comboBox_Decoration.Text;
                        tbhf.FH_Telephone = checkBox_Tel.Checked;
                        tbhf.FH_TelFew = Convert.ToInt16(nUpDown_FTel.Value);
                        tbhf.FH_Balcony = checkBox_Balcony.Checked;
                        tbhf.FH_BalconyMeter = Convert.ToDouble((string)((textBox_BlcM.Text == "") ? "0" : (textBox_BlcM.Text)));
                        tbhf.FH_FirePlace = checkBox_FirePlace.Checked;
                        tbhf.FH_FirePlaceFew = Convert.ToInt16(nUpDown_FFireP.Value);
                        tbhf.FH_Parking = checkBox_Parking.Checked;
                        tbhf.FH_ParkingFew = Convert.ToInt16(nUpDown_FPark.Value);
                        tbhf.FH_StoreRoom = checkBox_StRoom.Checked;
                        tbhf.FH_StRoomMeter = Convert.ToDouble((string)((textBox_StRoomM.Text == "") ? "0" : (textBox_StRoomM.Text)));
                        tbhf.FH_Cellar = checkBox_Cellar.Checked;
                        tbhf.FH_CellarMeter = Convert.ToDouble((string)((textBox_CellarM.Text == "") ? "0" : (textBox_CellarM.Text)));
                        tbhf.FH_Yard = checkBox_Yard.Checked;
                        tbhf.FH_YardMeter = Convert.ToDouble((string)((textBox_YardM.Text == "") ? "0" : (textBox_YardM.Text)));
                        tbhf.FH_BackYard = checkBox_BYard.Checked;
                        tbhf.FH_BackYardMeter = Convert.ToDouble((string)((textBox_BYardM.Text == "") ? "0" : (textBox_BYardM.Text)));
                        tbhf.FH_Patio = checkBox_Patio.Checked;
                        tbhf.FH_PatioMeter = Convert.ToDouble((string)((textBox_PatioM.Text == "") ? "0" : (textBox_PatioM.Text)));
                        tbhf.FH_EmployeeSrv = checkBox_EmployeeSrv.Checked;
                        tbhf.FH_RubShooting = checkBox_RubShooting.Checked;

                        tbhf.CH_Water = checkBox_Water.Checked;
                        tbhf.CH_Electricity = checkBox_Electricity.Checked;
                        tbhf.CH_Gaz = checkBox_Gaz.Checked;
                        tbhf.CH_Cooler = checkBox_Cooler.Checked;
                        tbhf.CH_FanCoel = checkBox_FanCoel.Checked;
                        tbhf.CH_Heat = checkBox_Heat.Checked;
                        tbhf.CH_Chiler = checkBox_Chiler.Checked;
                        tbhf.CH_Pakage = checkBox_Pakage.Checked;
                        tbhf.CH_Sauna = checkBox_Sauna.Checked;
                        tbhf.CH_Jacuzzi = checkBox_Jacuzzi.Checked;
                        tbhf.CH_Pool = checkBox_Pool.Checked;
                        tbhf.CH_PoolType = comboBox_PoolType.Text;
                        tbhf.CH_Elevator = checkBox_Elevatoor.Checked;
                        tbhf.CH_ElevatorFew = Convert.ToInt16(nUpDown_FElevatoor.Value);
                        tbhf.RH_LandArea = Convert.ToDouble(textBox_LndArea.Text);
                        tbhf.RH_SideWidth = Convert.ToDouble(textBox_SideWidth.Text);
                        tbhf.RH_Arena = Convert.ToDouble(textBox_Arena.Text);
                        tbhf.RH_Upscale = Convert.ToDouble(textBox_UpScale.Text);
                        tbhf.RH_Height = Convert.ToDouble(textBox_Height.Text);
                        tbhf.RH_Pressure = Convert.ToDouble(textBox_Pressure.Text);
                        tbhf.RH_Corrective = Convert.ToDouble(textBox_Corrective.Text);
                        tbhf.RH_Walled = Convert.ToDouble(textBox_Walled.Text);
                        tbhf.RH_Bldage = Convert.ToInt16(nUpDown_BldAge.Value);
                        tbhf.RH_UseType = comboBox_UseType.Text;
                        tbhf.RH_LicenceConfig = checkBox_LicenceConfig.Checked;
                        tbhf.RH_LicenceType = comboBox_LicenceType.Text;
                        tbhf.RH_Property = checkBox_Property.Checked;
                        tbhf.RH_KeyMoney = checkBox_KeyMoney.Checked;
                        tbhf.RH_DocUse = checkBox_DocUse.Checked;
                        tbhf.RH_DocType = comboBox_DocType.Text;
                        tbhf.OH_Discharge = checkBox_Discharge.Checked;
                        tbhf.OH_RentUse = checkBox_RentUse.Checked;
                        tbhf.OH_LordExist = checkBox_LordExist.Checked;
                        tbhf.OH_DischargeDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_day2.Text);
                        tbhf.OH_HolderName = textBox_HolderName.Text;
                        tbhf.OH_HolderTel = textBox_HolderTel.Text;
                        tbhf.OH_VisitAllow = comboBox_VisitAllow.Text;
                        tbhf.OH_MapDictation = textBox_MapDict.Text;
                        tbhf.OH_MaxPeople = Convert.ToInt16(nUpDown_MaxPeople.Value);
                        tbhf.OH_Specify = textBox_Specify.Text;
                        tbhf.InformationSource = textBox_InfoSource.Text;
                        tbhf.Description = textBox_Desc.Text;
                        tbhf.User_Code = Global_Cls.UserCode_Exist;
                        tbhf.FilePriority = Convert.ToInt16(comboBox_Priority.Text);
                        tbhf.FileStatus = Convert.ToInt16(radioButton_nonActive.Checked);
                        tbhf.NonActive_Date = Global_Cls.ShamsiDateToMiladi(comboBox_yearNA.Text, comboBox_monthNA.Text, comboBox_dayNA.Text);


                        DCD.SubmitChanges();

                        //pics & films
                        SavePics_Films(HsID);

                        //Conclusion Change FileNo
                        //بررسی شود ConclusionFileNoChange(HsID);

                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                        else if (ex.Message.IndexOf("Duplicated Tbl_Second!") > -1)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده در لیست بایگانی، حذفیات و یا قراردادها وجود دارد!");
                        else
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.ToString());

                        return false;
                    }


            if (checkBoxItem_Print.Checked & NewOrEditHouse == 2)
            {
                ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", false) + " Where HouseID = " + HsID,
                    "ملک", ReportClass_Cls.FindReportDesign_HouseType(TypeHouseStr));
            }

            if (checkBoxItem_Print.Checked & NewOrEditHouse == 1)
            {
                ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", false) + " Where HouseID = " + MaxHouseID,
                    "ملک", ReportClass_Cls.FindReportDesign_HouseType(TypeHouseStr));
            }

            if (radioButton_nonActive.Checked)
            {
                int ID = HsID;
                if (NewOrEditHouse == 1) ID = MaxHouseID;
                DCSDC.InsDelRecordHouseFile_Sp(ID, true, 1);
                DCSDC.SubmitChanges();
            }

            //customers
            if (checkBoxItem_ListCuHouse.Checked) SearchToListCustomers_AndShow();

            return true;
        }

        //customers
        private void SearchToListCustomers_AndShow()
        { 
                        //new
            string TypeHouseStr = "", HouseForStr = "";
            for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
                if ((itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { TypeHouseStr = itemPanel_TypeHouse.Items[i].Text; break; }

            for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
                if ((itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { HouseForStr = itemPanel_HouseFor.Items[i].Text;
                if (HouseForStr.Contains("فروش")) HouseForStr = HouseForStr.Replace("فروش", "خرید"); break; }

            string ListWhereSearch = "";

            ListWhereSearch += " And (HouseReqFor = N'" + HouseForStr + "')";
            ListWhereSearch += " And (TypeHouseReq = N'" + TypeHouseStr + "')";

            if (textBox_AHPrice.Text != "0" && textBox_AHPrice.Text != "") ListWhereSearch += " And (Bodget_Buy1 <= " + textBox_AHPrice.Text.Replace(",", "") + ") And (Bodget_Buy2 >= " + textBox_AHPrice.Text.Replace(",", "") + ")";
            if (textBox_MPrice.Text != "0" && textBox_MPrice.Text != "") ListWhereSearch += " And (Bodget_Mortgage1 <= " + textBox_MPrice.Text.Replace(",", "") + ") And (Bodget_Mortgage2 >= " + textBox_MPrice.Text.Replace(",", "") + ")";
            if (textBox_RPrice.Text != "0" && textBox_RPrice.Text != "") ListWhereSearch += " And (Bodget_Rent1 <= " + textBox_RPrice.Text.Replace(",", "") + ") And (Bodget_Rent2 >= " + textBox_RPrice.Text.Replace(",", "") + ")";

            if (textBox_Subbuild.Text != "0" && textBox_Subbuild.Text != "") ListWhereSearch += " And (Req_SubMeter1 <= " + textBox_Subbuild.Text + ") And (Req_SubMeter2 >= " + textBox_Subbuild.Text + ")";

            if (comboBox_Part.Text != "")
            {
                ListWhereSearch += " And (1<>1 ";
                ListWhereSearch += " Or PartRequest1 = " + comboBox_Part.SelectedValue.ToString();
                ListWhereSearch += " Or PartRequest2 = " + comboBox_Part.SelectedValue.ToString();
                ListWhereSearch += " Or PartRequest3 = " + comboBox_Part.SelectedValue.ToString();
                ListWhereSearch += " Or PartRequest4 = " + comboBox_Part.SelectedValue.ToString();

                ListWhereSearch += " ) ";
            }

            try
            {
                string StrConn = Global_Cls.ConnectionStr;

                SqlConnection SqConn = new SqlConnection(StrConn);
                SqConn.Open();

                SqlCommand SqCmd = new SqlCommand();
                SqCmd.Connection = SqConn;

                SqCmd.CommandText = " SELECT * "
                       + " FROM     dbo.TBL_HouseRequest Where (1=1)"
                       + ListWhereSearch;
                SqlDataReader da = SqCmd.ExecuteReader();
                da.Read();
                if (!da.HasRows) 
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "هیچ متقاضی یافت نشد");
                    SqConn.Close();
                    return;
                }
                SqConn.Close();
            }
            catch { }


            try
            {
                ListCustomer_UC Uc = new ListCustomer_UC();
                Uc.SearchOrNo = -1;
                Uc.ListWhereSearch = ListWhereSearch;
                
                Global_Cls.MainForm.AddTabToTabControl("ListCustomer" + DateTime.Now.ToLocalTime().ToString(), "لیست متقاضیان "+textBox_FN.Text, Uc);
            }
            catch { }

        }


        private void ConclusionFileNoChange(int HouseIDCnu)
        {
            DataClassesSecondDataContext DCSD = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);

            int f = DCSD.Tbl_HouseConclusions.Count(thfh => thfh.HouseId.Value == HouseIDCnu);
            while (f != 0)
            {
                Tbl_HouseConclusion tbhc = DCSD.Tbl_HouseConclusions.First(thfh => thfh.HouseId == HouseIDCnu && thfh.HF_FileNo != textBox_FN.Text);
                tbhc.HF_FileNo = textBox_FN.Text;

                DCSD.SubmitChanges();
                f--;
            }
        }

        #endregion



        #region UI Control Func
        TextBox tx = new TextBox();
        private void textBox_AHPrice_TextChanged(object sender, EventArgs e)
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

        private void textBox_HPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_Subbuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar == '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }

       /* MaskedTextBox mtb = new MaskedTextBox();
        private void textBox_Date_Leave(object sender, EventArgs e)
        {
            mtb = (MaskedTextBox)sender;
            if (mtb.Text == "" || mtb.Text == "0000/00/00") return;

            if (!Global_Cls.CheckShamsiDate(mtb.Text)) mtb.Focus();
        }*/

        private void panel_Date_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }

        private void panel_DisDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month2.Text) > 6 && Convert.ToInt16(comboBox_day2.Text) == 31) comboBox_day2.Text = "30";
            if (Convert.ToInt16(comboBox_Month2.Text) == 12 && (Convert.ToInt16(comboBox_day2.Text) == 31 || Convert.ToInt16(comboBox_day2.Text) == 30)) comboBox_day2.Text = "29";
        }

        private void panel_NonActDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_monthNA.Text) > 6 && Convert.ToInt16(comboBox_dayNA.Text) == 31) comboBox_dayNA.Text = "30";
            if (Convert.ToInt16(comboBox_monthNA.Text) == 12 && (Convert.ToInt16(comboBox_dayNA.Text) == 31 || Convert.ToInt16(comboBox_dayNA.Text) == 30)) comboBox_dayNA.Text = "29";
        }

        private void NEHouse_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl_NEHouse.SelectedTabIndex == tabControl_NEHouse.Tabs.Count - 1)
                    tabControl_NEHouse.SelectedTabIndex = 0;
                else
                    tabControl_NEHouse.SelectNextTab();
            }
        }

        private void NEHouse_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }   

        private void checkBoxItem_ListCuHouse_Click(object sender, EventArgs e)
        {
            label_StarHT.Visible = checkBoxItem_ListCuHouse.Checked;
            label_StarHF.Visible = checkBoxItem_ListCuHouse.Checked;
            label_StarPart.Visible = checkBoxItem_ListCuHouse.Checked;
            label_StarSB.Visible = checkBoxItem_ListCuHouse.Checked;
            label_ُStarFee.Visible = checkBoxItem_ListCuHouse.Checked;
            label_StarHT.BringToFront();
            label_StarPart.BringToFront();
            label_ُStarFee.BringToFront();
        }

        private void nUpDown_FTel_ValueChanged(object sender, EventArgs e)
        {
            if (sender == nUpDown_FTel) if (nUpDown_FTel.Value > 0) checkBox_Tel.Checked = true; else checkBox_Tel.Checked = false;
            if (sender == nUpDown_FPark) if (nUpDown_FPark.Value > 0) checkBox_Parking.Checked = true; else checkBox_Parking.Checked = false;
            if (sender == nUpDown_FWcIr) if (nUpDown_FWcIr.Value > 0) checkBox_IRWc.Checked = true; else checkBox_IRWc.Checked = false;
            if (sender == nUpDown_FWcFg) if (nUpDown_FWcFg.Value > 0) checkBox_FWc.Checked = true; else checkBox_FWc.Checked = false;
            if (sender == nUpDown_FFireP) if (nUpDown_FFireP.Value > 0) checkBox_FirePlace.Checked = true; else checkBox_FirePlace.Checked = false;
            if (sender == nUpDown_FElevatoor) if (nUpDown_FElevatoor.Value > 0) checkBox_Elevatoor.Checked = true; else checkBox_Elevatoor.Checked = false;
            if (sender == nUpDown_FBComplx) if (nUpDown_FBComplx.Value > 0) checkBox_Comlex.Checked = true; else checkBox_Comlex.Checked = false;
        }

        private void checkBox_Tel_Click(object sender, EventArgs e)
        {
            if (sender == checkBox_Tel) if (checkBox_Tel.Checked && nUpDown_FTel.Value == 0) nUpDown_FTel.Value = 1; else nUpDown_FTel.Value = 0;
            if (sender == checkBox_Parking) if (checkBox_Parking.Checked && nUpDown_FPark.Value == 0) nUpDown_FPark.Value = 1; else nUpDown_FPark.Value = 0;
            if (sender == checkBox_IRWc) if (checkBox_IRWc.Checked && nUpDown_FWcIr.Value == 0) nUpDown_FWcIr.Value = 1; else nUpDown_FWcIr.Value = 0;
            if (sender == checkBox_FWc) if (checkBox_FWc.Checked && nUpDown_FWcFg.Value == 0) nUpDown_FWcFg.Value = 1; else nUpDown_FWcFg.Value = 0;
            if (sender == checkBox_FirePlace) if (checkBox_FirePlace.Checked && nUpDown_FFireP.Value == 0) nUpDown_FFireP.Value = 1; else nUpDown_FFireP.Value = 0;
            if (sender == checkBox_Elevatoor) if (checkBox_Elevatoor.Checked && nUpDown_FElevatoor.Value == 0) nUpDown_FElevatoor.Value = 1; else nUpDown_FElevatoor.Value = 0;
            if (sender == checkBox_Comlex) if (checkBox_Comlex.Checked && nUpDown_FBComplx.Value == 0) nUpDown_FBComplx.Value = 1; else nUpDown_FBComplx.Value = 0;
        }

        private void checkBox_Balcony_Click(object sender, EventArgs e)
        {
            if (sender == checkBox_Balcony) if (checkBox_Balcony.Checked && textBox_BlcM.Text == "0") textBox_BlcM.Text = "1"; else textBox_BlcM.Text = "0";
            if (sender == checkBox_Cellar) if (checkBox_Cellar.Checked && textBox_CellarM.Text == "0") textBox_CellarM.Text = "1"; else textBox_CellarM.Text = "0";
            if (sender == checkBox_Yard) if (checkBox_Yard.Checked && textBox_YardM.Text == "0") textBox_YardM.Text = "1"; else textBox_YardM.Text = "0";
            if (sender == checkBox_StRoom) if (checkBox_StRoom.Checked && textBox_StRoomM.Text == "0") textBox_StRoomM.Text = "1"; else textBox_StRoomM.Text = "0";
            if (sender == checkBox_BYard) if (checkBox_BYard.Checked && textBox_BYardM.Text == "0") textBox_BYardM.Text = "1"; else textBox_BYardM.Text = "0";
            if (sender == checkBox_Patio) if (checkBox_Patio.Checked && textBox_PatioM.Text == "0") textBox_PatioM.Text = "1"; else textBox_PatioM.Text = "0";
        }

        private void textBox_BlcM_TextChanged(object sender, EventArgs e)
        {
            if (sender == textBox_BlcM) if (textBox_BlcM.Text != "0" && textBox_BlcM.Text != "") checkBox_Balcony.Checked = true; else checkBox_Balcony.Checked = false;
            if (sender == textBox_CellarM) if (textBox_CellarM.Text != "0" && textBox_CellarM.Text != "") checkBox_Cellar.Checked = true; else checkBox_Cellar.Checked = false;
            if (sender == textBox_YardM) if (textBox_YardM.Text != "0" && textBox_YardM.Text != "") checkBox_Yard.Checked = true; else checkBox_Yard.Checked = false;
            if (sender == textBox_StRoomM) if (textBox_StRoomM.Text != "0" && textBox_StRoomM.Text != "") checkBox_StRoom.Checked = true; else checkBox_StRoom.Checked = false;
            if (sender == textBox_BYardM) if (textBox_BYardM.Text != "0" && textBox_BYardM.Text != "") checkBox_BYard.Checked = true; else checkBox_BYard.Checked = false;
            if (sender == textBox_PatioM) if (textBox_PatioM.Text != "0" && textBox_PatioM.Text != "") checkBox_Patio.Checked = true; else checkBox_Patio.Checked = false;
        }


        #endregion



        #region Select Part
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

        private void comboBox_Part_Enter(object sender, EventArgs e)
        {
            if (!comboBox_Part.Tag.Equals(CyID))
            {
                comboBox_Part.Tag = CyID;
                var h1 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_Part.DataSource = h1;
            }
        }
        #endregion



        #region Pics & Films

        private int PicCounter = 0, MaxPicIDExist = 0;
        private int FilmCounter = 0, MaxFilmIDExist = 0;
        private PictureBox ImgPic = null;

        private void LoadPics_Films(int HouseID)
        {
            ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(Global_Cls.RootSaveLoad() + @"\PicsFilms\"));
            foreach (string PicFilmRoot in ROC)
            {
                //pics
                if (PicFilmRoot.Contains("PIC") && PicFilmRoot.Contains("ID" + HouseID.ToString()))
                {
                    string FileNameExist = PicFilmRoot.Substring(PicFilmRoot.IndexOf("\\PicsFilms\\") + 11);
                    string Maxstr = FileNameExist.Substring(3, FileNameExist.IndexOf("ID") - 3);
                    if (MaxPicIDExist < Convert.ToInt32(Maxstr)) MaxPicIDExist = Convert.ToInt32(Maxstr);

                    AddToListViewPic(FileNameExist, PicFilmRoot, PicCounter);
                    PicCounter++;
                }

                //films
                if (PicFilmRoot.Contains("FILM") && PicFilmRoot.Contains("ID" + HouseID.ToString()))
                {
                    string FileNameExist = PicFilmRoot.Substring(PicFilmRoot.IndexOf("\\PicsFilms\\") + 11);
                    string Maxstr = FileNameExist.Substring(4, FileNameExist.IndexOf("ID") - 4);
                    if (MaxFilmIDExist < Convert.ToInt32(Maxstr)) MaxFilmIDExist = Convert.ToInt32(Maxstr);

                    AddToListViewFilm(FileNameExist, PicFilmRoot, FilmCounter);
                    FilmCounter++;
                }

            }
        }


        private void SavePics_Films(int HouseID)
        {
            int i;

            ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(Global_Cls.RootSaveLoad() + @"\PicsFilms\"));

            foreach (string PicFilmRoot in ROC)
            {
                //pics
                if (PicFilmRoot.Contains("PIC") && PicFilmRoot.Contains("ID" + HouseID.ToString()))
                {
                    for (i = 0; i < listView_Pic.Items.Count; i++)
                    {
                        if (PicFilmRoot == listView_Pic.Items[i].Name) break;
                        else continue;
                    }
                    if (i == listView_Pic.Items.Count)
                        FileSystem.DeleteFile(PicFilmRoot);
                }

                //films
                if (PicFilmRoot.Contains("FILM") && PicFilmRoot.Contains("ID" + HouseID.ToString()))
                {
                    for (i = 0; i < listView_Film.Items.Count; i++)
                    {
                        if (PicFilmRoot == listView_Film.Items[i].Name) break;
                        else continue;
                    }
                    if (i == listView_Film.Items.Count)
                        FileSystem.DeleteFile(PicFilmRoot);
                }
            }


            //pics
            for (i = 0; i < listView_Pic.Items.Count; i++)
            {
                if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + @"\PicsFilms\" + listView_Pic.Items[i].Text)) continue;
                else
                {
                    MaxPicIDExist++;
                    string FileNameAdd = "PIC" + MaxPicIDExist.ToString() + "ID" + HouseID.ToString() + listView_Pic.Items[i].Text.Substring(listView_Pic.Items[i].Text.IndexOf("."));
                    FileSystem.CopyFile(listView_Pic.Items[i].Name, Global_Cls.RootSaveLoad() + @"\PicsFilms\" + FileNameAdd);
                }
            }


            //films
            for (i = 0; i < listView_Film.Items.Count; i++)
            {
                if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + @"\PicsFilms\" + listView_Film.Items[i].Text)) continue;
                else
                {
                    MaxFilmIDExist++;
                    string FileNameAdd = "FILM" + MaxFilmIDExist.ToString() + "ID" + HouseID.ToString() + listView_Film.Items[i].Text.Substring(listView_Film.Items[i].Text.IndexOf("."));
                    FileSystem.CopyFile(listView_Film.Items[i].Name, Global_Cls.RootSaveLoad() + @"\PicsFilms\" + FileNameAdd);
                }
            }

        }

        //pics

        private void AddToListViewPic(string PicFileName, string ItemName, int PicCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Load(ItemName);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(ItemName, PicFileName, PicCnt);
        }


        private void bubbleButton_PicNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All image file|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddToListViewPic(ofd.SafeFileName, ofd.FileName, PicCounter);

                PicCounter++;
            }
        }

        private void bubbleButton_PicDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0)
                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "تصویر مورد نظر حذف شود؟"))
                    listView_Pic.SelectedItems[0].Remove();
        }

        private void bubbleButton_PicView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0) Process.Start(listView_Pic.SelectedItems[0].Name);
        }

        private void bubbleButton_IconPic_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.View == View.LargeIcon)
                listView_Pic.View = View.Tile;
            else if (listView_Pic.View == View.Tile)
                listView_Pic.View = View.SmallIcon;
            else if (listView_Pic.View == View.SmallIcon)
                listView_Pic.View = View.List;
            else listView_Pic.View = View.LargeIcon;
        }

        private void listView_Pic_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_PicView_Click(this, null);
        }


        //films

        private void AddToListViewFilm(string FilmFileName, string ItemName, int FilmCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Load(Global_Cls.RootSaveLoad() + @"\PicsFilms\Templete.png");
            imageList_LargeFilm.Images.Add(ImgPic.Image);
            imageList_SmallFilm.Images.Add(ImgPic.Image);
            listView_Film.Items.Add(ItemName, FilmFileName, FilmCnt);
        }


        private void bubbleButton_FilmNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Video file|*.wmv;*.avi;*.mpeg;*.3gp;*.mp4;*.mp3;*.dat";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddToListViewFilm(ofd.SafeFileName, ofd.FileName, FilmCounter);

                FilmCounter++;
            }

        }

        private void bubbleButton_FilmDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.SelectedItems.Count != 0)
                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "فیلم مورد نظر حذف شود؟"))
                    listView_Film.SelectedItems[0].Remove();
        }

        private void bubbleButton_FilmView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                if (listView_Film.SelectedItems.Count != 0) Process.Start(listView_Film.SelectedItems[0].Name);
            }
            catch { }
        }

        private void bubbleButton_FilmIcon_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.View == View.LargeIcon)
                listView_Film.View = View.Tile;
            else if (listView_Film.View == View.Tile)
                listView_Film.View = View.SmallIcon;
            else if (listView_Film.View == View.SmallIcon)
                listView_Film.View = View.List;
            else listView_Film.View = View.LargeIcon;
        }

        private void listView_Film_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_FilmView_Click(this, null);
        }

        #endregion

        
        private void textBox_FN_Leave(object sender, EventArgs e)
        {
            //FileNoFlage
            if (Global_Cls.FileNoFlage)
                try { int i = Convert.ToInt32(textBox_FN.Text); }
                catch
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "شماره فایل عددی نمی باشد!");
                    textBox_FN.Focus();
                }
        }


    }
}

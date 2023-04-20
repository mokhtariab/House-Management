using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;

namespace HouseManagement_Prj
{
    public partial class ReportsAllModules_frm : Form
    {
        public ReportsAllModules_frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        

        #region Load & UI

        private void ReportsAllModules_frm_Load(object sender, EventArgs e)
        {
            buttonItem_Filing.Visible = tabItem_HouseFile.IsSelected;

            // permission
            SetPermission();

            // Fill TypeHouse And ...
            SetItemPanels_Report();

            // date component
            SetDateToModules();

            //
            var p = from prd in DCMD.TBL_Users select new { FLName = prd.FirstName + " " + prd.LastName, prd.UserCode };
            var R = from Rrd in DCMD.TBL_Users select new { FLName = Rrd.FirstName + " " + Rrd.LastName, Rrd.UserCode };
            var M = from Mrd in DCMD.TBL_Users select new { FLName = Mrd.FirstName + " " + Mrd.LastName, Mrd.UserCode };

            comboBox_HUserName.DataSource = p; comboBox_CUserName.DataSource = R; comboBox_CLUserName.DataSource = M;

            //
            label_Mny1.Text = Global_Cls.Money_Unit;
            label_Mny2.Text = label_Mny1.Text; label_Mny3.Text = label_Mny1.Text;
            label_Mny4.Text = label_Mny1.Text; label_Mny5.Text = label_Mny1.Text;
            label_Mny6.Text = label_Mny1.Text; label_Mny7.Text = label_Mny1.Text;
            label_Mny8.Text = label_Mny1.Text; label_Mny9.Text = label_Mny1.Text;
            label_Mny10.Text = label_Mny1.Text;

        }

        private void SetPermission()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains("buttonItem_FileRep")) tabControlPanel_HouseFile.Enabled = false;
                if (UPer.Contains("buttonItem_CustomRep")) tabControlPanel_Customers.Enabled = false;
                if (UPer.Contains("buttonItem_CncluRep")) tabControlPanel_Conclusions.Enabled = false;
            }
        }

        private void SetItemPanels_Report()
        {
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
        }

        private void tabItem_HouseFile_Click(object sender, EventArgs e)
        {
            buttonItem_Filing.Visible = tabItem_HouseFile.IsSelected;
            ribbonBar_Reports.Refresh();
        }

        private void ReportsAllModules_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }
        #endregion


        #region Set Date Module

        private void SetDateToModules()
        {
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBox_HYear1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString(); comboBox_HYear2.Text = comboBox_HYear1.Text; 
            comboBox_HMonth1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString(); comboBox_HMonth2.Text = comboBox_HMonth1.Text;
            comboBox_Hday1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString(); comboBox_Hday2.Text = comboBox_Hday1.Text;

            comboBox_NonAYr1.Text = comboBox_HYear1.Text; comboBox_NonAYr2.Text = comboBox_HYear1.Text;
            comboBox_NonAMnth1.Text = comboBox_HMonth1.Text; comboBox_NonAMnth2.Text = comboBox_HMonth1.Text;
            comboBox_NonADay1.Text = comboBox_Hday1.Text; comboBox_NonADay2.Text = comboBox_Hday1.Text;

            comboBox_CYear1.Text = comboBox_HYear1.Text; comboBox_CYear2.Text = comboBox_CYear1.Text;
            comboBox_CMonth1.Text = comboBox_HMonth1.Text; comboBox_CMonth2.Text = comboBox_CMonth1.Text;
            comboBox_Cday1.Text = comboBox_Hday1.Text; comboBox_Cday2.Text = comboBox_Cday1.Text;

            comboBox_CLYear1.Text = comboBox_CYear1.Text; comboBox_CLYear2.Text = comboBox_CLYear1.Text;
            comboBox_CLMonth1.Text = comboBox_CMonth1.Text; comboBox_CLMonth2.Text = comboBox_CLMonth1.Text;
            comboBox_CLday1.Text = comboBox_Cday1.Text; comboBox_CLday2.Text = comboBox_CLday1.Text;
        }
        
        private void panel_HDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_HMonth1.Text) > 6 && Convert.ToInt16(comboBox_Hday1.Text) == 31) comboBox_Hday1.Text = "30";
            if (Convert.ToInt16(comboBox_HMonth1.Text) == 12 && (Convert.ToInt16(comboBox_Hday1.Text) == 31 || Convert.ToInt16(comboBox_Hday1.Text) == 30)) comboBox_Hday1.Text = "29";
        }

        private void panel_HDate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_HMonth2.Text) > 6 && Convert.ToInt16(comboBox_Hday2.Text) == 31) comboBox_Hday2.Text = "30";
            if (Convert.ToInt16(comboBox_HMonth2.Text) == 12 && (Convert.ToInt16(comboBox_Hday2.Text) == 31 || Convert.ToInt16(comboBox_Hday2.Text) == 30)) comboBox_Hday2.Text = "29";
        }

        private void panel_NonADate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_NonAMnth1.Text) > 6 && Convert.ToInt16(comboBox_NonADay1.Text) == 31) comboBox_NonADay1.Text = "30";
            if (Convert.ToInt16(comboBox_NonAMnth1.Text) == 12 && (Convert.ToInt16(comboBox_NonADay1.Text) == 31 || Convert.ToInt16(comboBox_NonADay1.Text) == 30)) comboBox_NonADay1.Text = "29";
        }

        private void panel_NonADate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_NonAMnth2.Text) > 6 && Convert.ToInt16(comboBox_NonADay2.Text) == 31) comboBox_NonADay2.Text = "30";
            if (Convert.ToInt16(comboBox_NonAMnth2.Text) == 12 && (Convert.ToInt16(comboBox_NonADay2.Text) == 31 || Convert.ToInt16(comboBox_NonADay2.Text) == 30)) comboBox_NonADay2.Text = "29";
        }

        private void panel_CDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_CMonth1.Text) > 6 && Convert.ToInt16(comboBox_Cday1.Text) == 31) comboBox_Cday1.Text = "30";
            if (Convert.ToInt16(comboBox_CMonth1.Text) == 12 && (Convert.ToInt16(comboBox_Cday1.Text) == 31 || Convert.ToInt16(comboBox_Cday1.Text) == 30)) comboBox_Cday1.Text = "29";
        }

        private void panel_CDate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_CMonth2.Text) > 6 && Convert.ToInt16(comboBox_Cday2.Text) == 31) comboBox_Cday2.Text = "30";
            if (Convert.ToInt16(comboBox_CMonth2.Text) == 12 && (Convert.ToInt16(comboBox_Cday2.Text) == 31 || Convert.ToInt16(comboBox_Cday2.Text) == 30)) comboBox_Cday2.Text = "29";
        }

        private void panel_CLDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_CLMonth1.Text) > 6 && Convert.ToInt16(comboBox_CLday1.Text) == 31) comboBox_CLday1.Text = "30";
            if (Convert.ToInt16(comboBox_CLMonth1.Text) == 12 && (Convert.ToInt16(comboBox_CLday1.Text) == 31 || Convert.ToInt16(comboBox_CLday1.Text) == 30)) comboBox_CLday1.Text = "29";
        }

        private void panel_CLDate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_CLMonth2.Text) > 6 && Convert.ToInt16(comboBox_CLday2.Text) == 31) comboBox_CLday2.Text = "30";
            if (Convert.ToInt16(comboBox_CLMonth2.Text) == 12 && (Convert.ToInt16(comboBox_CLday2.Text) == 31 || Convert.ToInt16(comboBox_CLday2.Text) == 30)) comboBox_CLday2.Text = "29";
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
        
        private void textBox_AHPrice1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_AHPrice1_TextChanged(object sender, EventArgs e)
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


        #endregion


        #region OK & ShowReport

        int FileStatus = 0;
        private void buttonItem_Filing_Click(object sender, EventArgs e)
        {
            panel_HDate1_Leave(this, null);
            panel_HDate2_Leave(this, null);
            panel_NonADate1_Leave(this, null);
            panel_NonADate2_Leave(this, null);

            if (tabControl_Reports.SelectedTabIndex == 0)
            {
               
                string str = "";
                for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
                    if ((itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                    { str = itemPanel_TypeHouse.Items[i].Text; break; }

                FileStatus = 0; if (radioButton_nonActive.Checked) FileStatus = 1;
                if (radioButton_Mem.Checked) FileStatus = 2; if (radioButton_Del.Checked) FileStatus = 3;

                if (FileStatus == 0)
                    ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", false) + ShowReport(0),
                        "ملک", ReportClass_Cls.FindReportDesign_HouseType(str));
                else
                    ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "ملک", false) + ShowReport(0),
                        "ملک", ReportClass_Cls.FindReportDesign_HouseType(str));

            }
        }


        private void buttonItem_ListOK_Click(object sender, EventArgs e)
        {
            panel_CDate1_Leave(this, null);
            panel_CDate2_Leave(this, null);
            panel_CLDate1_Leave(this, null);
            panel_CLDate2_Leave(this, null);
            panel_HDate1_Leave(this, null);
            panel_HDate2_Leave(this, null);
            panel_NonADate1_Leave(this, null);
            panel_NonADate2_Leave(this, null);

            if (tabControl_Reports.SelectedTabIndex == 0)
            {
                FileStatus = 0; if (radioButton_nonActive.Checked) FileStatus = 1;
                if (radioButton_Mem.Checked) FileStatus = 2; if (radioButton_Del.Checked) FileStatus = 3;

                if (FileStatus == 0)
                    ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "فعال", false) + ShowReport(0),
                          "فعال", Global_Cls.ReportDesignAddress[7]);
                else if (FileStatus == 1)
                    ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "بایگانی", false) + ShowReport(0),
                          "بایگانی", Global_Cls.ReportDesignAddress[8]);
                else if (FileStatus == 2)
                    ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "قراردادشده", false) + ShowReport(0),
                          "قراردادشده", Global_Cls.ReportDesignAddress[9]);
                else if (FileStatus == 3)
                    ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "حذفی", false) + ShowReport(0),
                          "حذفی", Global_Cls.ReportDesignAddress[10]);
            }
            else if (tabControl_Reports.SelectedTabIndex == 1)
            {
                ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateRequestTbl_Report("متقاضیان", false) + ShowReport(1),
                    "متقاضیان", Global_Cls.ReportDesignAddress[11]);//Application.StartupPath + @"\Report\Customer\ListCustomer.frx");

            }
            else if (tabControl_Reports.SelectedTabIndex == 2)
            {
                ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateConclutionTbl_Report("قراردادها", false) + ShowReport(2),//" SELECT * FROM Tbl_HouseConclusion " 
                    "قراردادها", Global_Cls.ReportDesignAddress[12]);//Application.StartupPath + @"\Report\ListConclusion.frx");
            }

        }

        private string ShowReport(int TabIndx)
        {

            //new
            string TypeHouseStr = "", HouseForStr = "";
            for (int i = 0; i < itemPanel_TypeHouse.Items.Count; i++)
                if ((itemPanel_TypeHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { TypeHouseStr = itemPanel_TypeHouse.Items[i].Text; break; }

            for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
                if ((itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { HouseForStr = itemPanel_HouseFor.Items[i].Text; break; }

            string TypeHouseReqStr = "", HouseReqForStr = "";
            for (int i = 0; i < itemPanel_TypeReqHouse.Items.Count; i++)
                if ((itemPanel_TypeReqHouse.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { TypeHouseReqStr = itemPanel_TypeReqHouse.Items[i].Text; break; }

            for (int i = 0; i < itemPanel_ReqFor.Items.Count; i++)
                if ((itemPanel_ReqFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                { HouseReqForStr = itemPanel_ReqFor.Items[i].Text; break; }
            //new


            string ItemWhereReport = " Where (1=1) ";


            if (TabIndx == 0)
            {
                FileStatus = 0;  if (radioButton_nonActive.Checked) FileStatus = 1;
                if (radioButton_Mem.Checked) FileStatus = 2;  if (radioButton_Del.Checked) FileStatus = 3;
                ItemWhereReport += " And (FileStatus = " + FileStatus + ")";

                if (checkBox_FileNo.Checked) ItemWhereReport += " And (FileNO >= " + (string)((textBox_FileNo1.Text == "") ? "0" : (textBox_FileNo1.Text)) + ") And (FileNO <= " + (string)((textBox_FileNo2.Text == "") ? "0" : (textBox_FileNo2.Text)) + ")";
                if (checkBox_Date.Checked) ItemWhereReport += " And (Modify_Date >= '" + Global_Cls.ShamsiDateToMiladi(comboBox_HYear1.Text, comboBox_HMonth1.Text, comboBox_Hday1.Text).ToShortDateString() + "') And (Modify_Date <= '" + Global_Cls.ShamsiDateToMiladi(comboBox_HYear2.Text, comboBox_HMonth2.Text, comboBox_Hday2.Text).ToShortDateString() + "')";
                if (checkBox_LordName.Checked) ItemWhereReport += " And (Lord_Name like N'%" + textBox_LordName.Text + "%') ";
                if (checkBox_LordFamily.Checked) ItemWhereReport += " And (Lord_Family like N'%" + textBox_LordFamily.Text + "%') ";

                if (checkBox_HouseFor.Checked) ItemWhereReport += " And (HouseFor = N'" + HouseForStr + "')";
                if (checkBox_TypeHouse.Checked) ItemWhereReport += " And (TypeHouse = N'" + TypeHouseStr + "')";

                if (checkBox_AHPrice.Checked) ItemWhereReport += " And (Price_HouseAll >= " + (string)((textBox_AHPrice1.Text == "") ? "0" : (textBox_AHPrice1.Text)).Replace(",", "") + ") And (Price_HouseAll <= " + (string)((textBox_AHPrice2.Text == "") ? "0" : (textBox_AHPrice2.Text)).Replace(",", "") + ")";
                if (checkBox_MHPrice.Checked) ItemWhereReport += " And (Price_HouseMeter >= " + (string)((textBox_MHPrice1.Text == "") ? "0" : (textBox_MHPrice1.Text)).Replace(",", "") + ") And (Price_HouseMeter <= " + (string)((textBox_MHPrice2.Text == "") ? "0" : (textBox_MHPrice2.Text)).Replace(",", "") + ")";
                if (checkBox_MPrice.Checked) ItemWhereReport += " And (Price_Mortgage >= " + (string)((textBox_MPrice1.Text == "") ? "0" : (textBox_MPrice1.Text)).Replace(",", "") + ") And (Price_Mortgage <= " + (string)((textBox_MPrice2.Text == "") ? "0" : (textBox_MPrice2.Text)).Replace(",", "") + ")";
                if (checkBox_RPrice.Checked) ItemWhereReport += " And (Price_Rent >= " + (string)((textBox_RPrice1.Text == "") ? "0" : (textBox_RPrice1.Text)).Replace(",", "") + ") And (Price_Rent <= " + (string)((textBox_RPrice2.Text == "") ? "0" : (textBox_RPrice2.Text)).Replace(",", "") + ")";

                if (checkBox_Subbuild.Checked) ItemWhereReport += " And (FH_Submeter >= " + (string)((textBox_Subbuild1.Text == "") ? "0" : (textBox_Subbuild1.Text)) + ") And (FH_Submeter <= " + (string)((textBox_Subbuild2.Text == "") ? "0" : (textBox_Subbuild2.Text)) + ")";
                if (checkBox_FewFloor.Checked) ItemWhereReport += " And (Few_estate >= " + nUpDown_FewFloor1.Value.ToString() + ") And (Few_estate <= " + nUpDown_FewFloor2.Value.ToString() + ")";
                if (checkBox_FUF.Checked) ItemWhereReport += " And (Few_estateunit >= " + nUpDown_FUF1.Value.ToString() + ") And (Few_estateunit <= " + nUpDown_FUF2.Value.ToString() + ")";
                if (checkBox_FBed.Checked) ItemWhereReport += " And (FH_BedRoomFew >= " + nUpDown_FBed1.Value.ToString() + ") And (FH_BedRoomFew <= " + nUpDown_FBed2.Value.ToString() + ")";

                if (checkBox_MK.Checked) ItemWhereReport += " And (FH_KitchenModel = N'" + comboBox_MK.Text + "') ";
                if (checkBox_CT.Checked) ItemWhereReport += " And (FH_CupbrdType = N'" + comboBox_CT.Text + "') ";
                if (checkBox_BedRoom.Checked) ItemWhereReport += " And (FH_BedRoom = N'" + comboBox_BedRoom.Text + "') ";
                if (checkBox_RcRoom.Checked) ItemWhereReport += " And (FH_RcRoom = N'" + comboBox_RcRoom.Text + "') ";
                if (checkBox_BldLow.Checked) ItemWhereReport += " And (FH_BldLow = N'" + comboBox_BldLow.Text + "') ";
                if (checkBox_WallCover.Checked) ItemWhereReport += " And (FH_WallCover = N'" + comboBox_WallCover.Text + "') ";

                if (checkBox_FWc.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (FH_WcForeign = " + Convert.ToInt16(checkBox_FWc.Checked).ToString() + ")";
                if (checkBox_Parking.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (FH_Parking = " + Convert.ToInt16(checkBox_Parking.Checked).ToString() + ")";
                if (checkBox_StRoom.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (FH_StoreRoom = " + Convert.ToInt16(checkBox_StRoom.Checked).ToString() + ")";
                if (checkBox_Yard.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (FH_Yard = " + Convert.ToInt16(checkBox_Yard.Checked).ToString() + ")";
                if (checkBox_Cellar.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (FH_Cellar = " + Convert.ToInt16(checkBox_Cellar.Checked).ToString() + ")";
                if (checkBox_RDoor.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (FH_RemotingDoor = " + Convert.ToInt16(checkBox_RDoor.Checked).ToString() + ")";
                if (checkBox_Elevatoor.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (CH_Elevator = " + Convert.ToInt16(checkBox_Elevatoor.Checked).ToString() + ")";
                if (checkBox_AV.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (FH_AifoonVideo = " + Convert.ToInt16(checkBox_AV.Checked).ToString() + ")";
                if (checkBox_Cooler.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (CH_Cooler = " + Convert.ToInt16(checkBox_Cooler.Checked).ToString() + ")";
                if (checkBox_Heat.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (CH_Heat = " + Convert.ToInt16(checkBox_Heat.Checked).ToString() + ")";
                if (checkBox_Jacuzzi.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (CH_Jacuzzi = " + Convert.ToInt16(checkBox_Jacuzzi.Checked).ToString() + ")";
                if (checkBox_Pool.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (CH_pool = " + Convert.ToInt16(checkBox_Pool.Checked).ToString() + ")";

                if (checkBox_LndArea.Checked) ItemWhereReport += " And (RH_LandArea >= " + (string)((textBox_LndArea1.Text == "") ? "0" : (textBox_LndArea1.Text)) + ") And (RH_LandArea <= " + (string)((textBox_LndArea2.Text == "") ? "0" : (textBox_LndArea2.Text)) + ")";
                if (checkBox_BldAge.Checked) ItemWhereReport += " And (RH_Bldage >= " + nUpDown_BldAge1.Value.ToString() + ") And (RH_Bldage <= " + nUpDown_BldAge2.Value.ToString() + ")";

                if (checkBox_UseType.Checked) ItemWhereReport += " And (RH_UseType = N'" + comboBox_UseType.Text + "') ";
                if (checkBox_DocType.Checked) ItemWhereReport += " And (RH_DocType = N'" + comboBox_DocType.Text + "') ";

                if (checkBox_DocUse.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (RH_DocUse = " + Convert.ToInt16(checkBox_DocUse.Checked).ToString() + ")";
                if (checkBox_Property.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (RH_Property = " + Convert.ToInt16(checkBox_Property.Checked).ToString() + ")";
                if (checkBox_LordExist.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (OH_LordExist = " + Convert.ToInt16(checkBox_LordExist.Checked).ToString() + ")";
                if (checkBox_KeyMoney.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (RH_KeyMoney = " + Convert.ToInt16(checkBox_KeyMoney.Checked).ToString() + ")";
                if (checkBox_Discharge.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (OH_Discharge = " + Convert.ToInt16(checkBox_Discharge.Checked).ToString() + ")";
                if (checkBox_RentUse.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (OH_RentUse = " + Convert.ToInt16(checkBox_RentUse.Checked).ToString() + ")";

                if (checkBox_MaxPeople.Checked) ItemWhereReport += " And (OH_MaxPeople >= " + nUpDown_MaxPeople1.Value.ToString() + ") And (OH_MaxPeople <= " + nUpDown_MaxPeople2.Value.ToString() + ")";

                if (checkBox_HUserName.Checked) ItemWhereReport += " And (tbl_users.Usercode = " + comboBox_HUserName.SelectedValue.ToString() + ")";
                if (checkBox_NonActive.Checked && radioButton_nonActive.Checked) ItemWhereReport += " And (NonActive_Date >= '" + Global_Cls.ShamsiDateToMiladi(comboBox_NonAYr1.Text, comboBox_NonAMnth1.Text, comboBox_NonADay1.Text).ToShortDateString() + "') And (NonActive_Date <= '" + Global_Cls.ShamsiDateToMiladi(comboBox_NonAYr2.Text, comboBox_NonAMnth2.Text, comboBox_NonADay2.Text).ToShortDateString() + "')";

                if (checkBox_HPart.Checked)
                {
                    ItemWhereReport += " And (1<>1 ";
                    if (comboBox_HPart1.Text != "") ItemWhereReport += " Or Lord_Part = " + comboBox_HPart1.SelectedValue.ToString();
                    if (comboBox_HPart2.Text != "") ItemWhereReport += " Or Lord_Part = " + comboBox_HPart2.SelectedValue.ToString();
                    if (comboBox_HPart3.Text != "") ItemWhereReport += " Or Lord_Part = " + comboBox_HPart3.SelectedValue.ToString();
                    if (comboBox_HPart4.Text != "") ItemWhereReport += " Or Lord_Part = " + comboBox_HPart4.SelectedValue.ToString();
                    ItemWhereReport += " ) ";
                }

                string sorttxt = " Order By ";
                if (comboBox_HSort1.Text != "") { ItemWhereReport += sorttxt + FieldSortHouse(comboBox_HSort1.SelectedIndex); sorttxt = ","; }
                if (comboBox_HSort2.Text != "" && comboBox_HSort2.SelectedIndex != comboBox_HSort1.SelectedIndex) { ItemWhereReport += sorttxt + FieldSortHouse(comboBox_HSort2.SelectedIndex); sorttxt = ","; }
                if (comboBox_HSort3.Text != "" && comboBox_HSort3.SelectedIndex != comboBox_HSort1.SelectedIndex && comboBox_HSort3.SelectedIndex != comboBox_HSort2.SelectedIndex) ItemWhereReport += sorttxt + FieldSortHouse(comboBox_HSort3.SelectedIndex);
            }

            else if (TabIndx == 1)

            {
                if (checkBox_ReqNo.Checked) ItemWhereReport += " And (Convert(Int,Request_NO) >= " + nUpDown_ReqNo1.Value.ToString() + ") And (Convert(Int,Request_NO) <= " + nUpDown_ReqNo2.Value.ToString() + ")";
                if (checkBox_Reqdate.Checked) ItemWhereReport += " And (RequestDate >= '" + Global_Cls.ShamsiDateToMiladi(comboBox_CYear1.Text, comboBox_CMonth1.Text, comboBox_Cday1.Text).ToShortDateString() + "') And (RequestDate <= '" + Global_Cls.ShamsiDateToMiladi(comboBox_CYear2.Text, comboBox_CMonth2.Text, comboBox_Cday2.Text).ToShortDateString() + "')";
                if (checkBox_ApproachType.Checked) ItemWhereReport += " And (Approach_Type = " + Convert.ToInt16(radioButton_Facing.Checked).ToString() + ")";
                if (checkBox_CName.Checked) ItemWhereReport += " And (Customer_Name like N'%" + textBox_CName.Text + "%') ";
                if (checkBox_FName.Checked) ItemWhereReport += " And (Customer_Family like N'%" + textBox_FName.Text + "%') ";
                if (checkBox_ReqFor.Checked) ItemWhereReport += " And (HouseReqFor = N'" + HouseReqForStr + "')";
                if (checkBox_CTypeHouse.Checked) ItemWhereReport += " And (TypeHouseReq = N'" + TypeHouseReqStr + "')";
                if (checkBox_BodgetBuy.Checked) ItemWhereReport += " And (Bodget_Buy1 >= " + (string)((textBox_BodgetBuy1.Text == "") ? "0" : (textBox_BodgetBuy1.Text)).Replace(",", "") + ") And (Bodget_Buy2 <= " + (string)((textBox_BodgetBuy2.Text == "") ? "0" : (textBox_BodgetBuy2.Text)).Replace(",", "") + ")";
                if (checkBox_BodgetRent.Checked) ItemWhereReport += " And (Bodget_Rent1 >= " + (string)((textBox_BodgetRent1.Text == "") ? "0" : (textBox_BodgetRent1.Text)).Replace(",", "") + ") And (Bodget_Rent2 <= " + (string)((textBox_BodgetRent2.Text == "") ? "0" : (textBox_BodgetRent2.Text)).Replace(",", "") + ")";
                if (checkBox_BodgetMtg.Checked) ItemWhereReport += " And (Bodget_Mortgage1 >= " + (string)((textBox_BodgetMtg1.Text == "") ? "0" : (textBox_BodgetMtg1.Text)).Replace(",", "") + ") And (Bodget_Mortgage2 <= " + (string)((textBox_BodgetMtg2.Text == "") ? "0" : (textBox_BodgetMtg2.Text)).Replace(",", "") + ")";
                if (checkBox_CSubbuild.Checked) ItemWhereReport += " And (Req_SubMeter1 >= " + (string)((textBox_CSubBuild1.Text == "") ? "0" : (textBox_CSubBuild1.Text)) + ") And (Req_SubMeter2 <= " + (string)((textBox_CSubBuild2.Text == "") ? "0" : (textBox_CSubBuild2.Text)) + ")";
                if (checkBox_ReqUse.Checked) ItemWhereReport += " And (Request_Use = N'" + comboBox_ReqUse.Text + "')";

                if (checkBox_TGBuy.Checked) ItemWhereReport += " And (TypeGive_Buy = N'" + comboBox_TGBuy.Text + "') ";
                if (checkBox_CUseType.Checked) ItemWhereReport += " And (Type_Use = N'" + comboBox_CUseType.Text + "') ";
                if (checkBox_CDocType.Checked) ItemWhereReport += " And (Type_Document = N'" + comboBox_CDocType.Text + "') ";

                if (checkBox_DocExist.CheckState != CheckState.Indeterminate) ItemWhereReport += " And (Document_Exist = " + Convert.ToInt16(checkBox_DocExist.Checked).ToString() + ")";
                if (checkBox_CMaxPeople.Checked) ItemWhereReport += " And (FewPerson_Rent >= " + nUpDown_CMaxPeople1.Value.ToString() + ") And (FewPerson_Rent <= " + nUpDown_CMaxPeople2.Value.ToString() + ")";

                if (checkBox_CUserName.Checked) ItemWhereReport += " And (tbl_users.Usercode = " + comboBox_CUserName.SelectedValue.ToString() + ")";
                
                if (checkBox_CPartName.Checked)
                {
                    ItemWhereReport += " And (1<>1 ";
                    if (comboBox_CPart1.Text != "") ItemWhereReport += " Or PartRequest1 = " + comboBox_CPart1.SelectedValue.ToString() + " Or PartRequest2 = " + comboBox_CPart1.SelectedValue.ToString() + " Or PartRequest3 = " + comboBox_CPart1.SelectedValue.ToString() + " Or PartRequest4 = " + comboBox_CPart1.SelectedValue.ToString();
                    if (comboBox_CPart2.Text != "") ItemWhereReport += " Or PartRequest1 = " + comboBox_CPart2.SelectedValue.ToString() + " Or PartRequest2 = " + comboBox_CPart2.SelectedValue.ToString() + " Or PartRequest3 = " + comboBox_CPart2.SelectedValue.ToString() + " Or PartRequest4 = " + comboBox_CPart2.SelectedValue.ToString();
                    if (comboBox_CPart3.Text != "") ItemWhereReport += " Or PartRequest1 = " + comboBox_CPart3.SelectedValue.ToString() + " Or PartRequest2 = " + comboBox_CPart3.SelectedValue.ToString() + " Or PartRequest3 = " + comboBox_CPart3.SelectedValue.ToString() + " Or PartRequest4 = " + comboBox_CPart3.SelectedValue.ToString();
                    if (comboBox_CPart4.Text != "") ItemWhereReport += " Or PartRequest1 = " + comboBox_CPart4.SelectedValue.ToString() + " Or PartRequest2 = " + comboBox_CPart4.SelectedValue.ToString() + " Or PartRequest3 = " + comboBox_CPart4.SelectedValue.ToString() + " Or PartRequest4 = " + comboBox_CPart4.SelectedValue.ToString();
                    ItemWhereReport += " ) ";
                }

                string sorttxt = " Order By ";
                if (comboBox_CSort1.Text != "") { ItemWhereReport += sorttxt + FieldSortCustomer(comboBox_CSort1.SelectedIndex); sorttxt = ","; }
                if (comboBox_CSort2.Text != "" && comboBox_CSort2.SelectedIndex != comboBox_CSort1.SelectedIndex) { ItemWhereReport += sorttxt + FieldSortCustomer(comboBox_CSort2.SelectedIndex); sorttxt = ","; }
                if (comboBox_CSort3.Text != "" && comboBox_CSort3.SelectedIndex != comboBox_CSort1.SelectedIndex && comboBox_CSort3.SelectedIndex != comboBox_CSort2.SelectedIndex) ItemWhereReport += sorttxt + FieldSortCustomer(comboBox_CSort3.SelectedIndex);

            }
            else if (TabIndx == 2)
            {
                if (checkBox_CncluFNo.Checked) ItemWhereReport += " And (Hc_No >= " + (string)((textBox_CncluFNo1.Text == "") ? "0" : (textBox_CncluFNo1.Text)) + ")And(Hc_No <= " + (string)((textBox_CncluFNo2.Text == "") ? "0" : (textBox_CncluFNo2.Text)) + ")";
                if (checkBox_CDate.Checked) ItemWhereReport += " And (Hc_Date >= '" + Global_Cls.ShamsiDateToMiladi(comboBox_CLYear1.Text, comboBox_CLMonth1.Text, comboBox_CLday1.Text).ToShortDateString() + "') And (Hc_Date <= '" + Global_Cls.ShamsiDateToMiladi(comboBox_CLYear2.Text, comboBox_CLMonth2.Text, comboBox_CLday2.Text).ToShortDateString() + "')";
                if (checkBox_Type.Checked) ItemWhereReport += " And (Hc_Type = N'" + comboBox_Type.Text + "')";

                if (checkBox_LordN.Checked) ItemWhereReport += " And (Hc_LName Like N'%" + textBox_LordN.Text + "%')";
                if (checkBox_LordF.Checked) ItemWhereReport += " And (Hc_LFamily Like N'%" + textBox_LordF.Text + "%')";
                if (checkBox_CustomerN.Checked) ItemWhereReport += " And (Hc_CName Like N'%" + textBox_CustomerN.Text + "%')";
                if (checkBox_CustomerF.Checked) ItemWhereReport += " And (Hc_CFamily Like N'%" + textBox_CustomerF.Text + "%')";

                if (checkBox_CostPrice.Checked) ItemWhereReport += " And (Hc_CostPrice >= " + (string)((textBox_CostPrice1.Text == "") ? "0" : (textBox_CostPrice1.Text)).Replace(",", "") + ")And(Hc_CostPrice <= " + (string)((textBox_CostPrice2.Text == "") ? "0" : (textBox_CostPrice2.Text)).Replace(",", "") + ")";
                if (checkBox_CostMtg.Checked) ItemWhereReport += " And (Hc_CostMtg >= " + (string)((textBox_CostMtg1.Text == "") ? "0" : (textBox_CostMtg1.Text)).Replace(",", "") + ")And(Hc_CostMtg <= " + (string)((textBox_CostMtg2.Text == "") ? "0" : (textBox_CostMtg2.Text)).Replace(",", "") + ")";
                if (checkBox_CostRent.Checked) ItemWhereReport += " And (Hc_CostRent >= " + (string)((textBox_CostRent1.Text == "") ? "0" : (textBox_CostRent1.Text)).Replace(",", "") + ")And(Hc_CostRent <= " + (string)((textBox_CostRent2.Text == "") ? "0" : (textBox_CostRent2.Text)).Replace(",", "") + ")";

                if (checkBox_RentMonth.Checked) ItemWhereReport += " And (Hc_RentMonth >= " + nUpDown_RentMonth1.Value.ToString() + ")And(Hc_RentMonth <= " + nUpDown_RentMonth2.Value.ToString() + ")";
                if (checkBox_CLUserName.Checked) ItemWhereReport += " And (tbl_users.Usercode = " + comboBox_CLUserName.SelectedValue.ToString() + ")";

                string sorttxt = " Order By ";
                if (comboBox_ClSort1.Text != "") { ItemWhereReport += sorttxt + FieldSortConclusion(comboBox_ClSort1.SelectedIndex); sorttxt = ","; }
                if (comboBox_ClSort2.Text != "" && comboBox_ClSort2.SelectedIndex != comboBox_ClSort1.SelectedIndex) { ItemWhereReport += sorttxt + FieldSortConclusion(comboBox_ClSort2.SelectedIndex); sorttxt = ","; }
                if (comboBox_ClSort3.Text != "" && comboBox_ClSort3.SelectedIndex != comboBox_ClSort1.SelectedIndex && comboBox_ClSort3.SelectedIndex != comboBox_ClSort2.SelectedIndex) ItemWhereReport += sorttxt + FieldSortConclusion(comboBox_ClSort3.SelectedIndex);
            }

            return ItemWhereReport;
        }

        private string FieldSortHouse(int ItemIndex)
        {
            //fileno visible
            if (ItemIndex == 1) if (!Global_Cls.FileNoFlage) return "FileNo"; else return "CAST(FileNo AS Int)";
            if (ItemIndex == 2) return "Modify_Date";
            if (ItemIndex == 3) return "HouseFor"; if (ItemIndex == 4) return "TypeHouse";
            if (ItemIndex == 5) return "Price_HouseAll"; if (ItemIndex == 6) return "FH_Submeter";
            if (ItemIndex == 7) return "FH_BedRoomFew"; if (ItemIndex == 8) return "RH_Bldage";
            if (ItemIndex == 7) return "RH_LandArea";
            return "HouseID";
        }

        private string FieldSortCustomer(int ItemIndex)
        {
            if (ItemIndex == 1) return "Request_NO"; if (ItemIndex == 2) return "RequestDate";
            if (ItemIndex == 3) return "HouseReqFor"; if (ItemIndex == 4) return "TypeHouseReq";
            return "RequestID";
        }

        private string FieldSortConclusion(int ItemIndex)
        {
            if (ItemIndex == 1) return "Hc_No"; if (ItemIndex == 2) return "Hc_Date";
            if (ItemIndex == 3) return "Hc_Type"; if (ItemIndex == 4) return "Hc_CostPrice";
            return "ConclusionID";
        }

        #endregion


        #region  Select Part
        private int CntID, StID, CyID;
        private void comboBox_Country_Enter(object sender, EventArgs e)
        {
            if (comboBox_CCountry.DataSource == null)
            {
                var hh = from prd in DCMD.TBL_Countries
                         select prd;
                comboBox_CCountry.DataSource = hh;
            }
        }

        private void comboBox_Country_Leave(object sender, EventArgs e)
        {
            CntID = Convert.ToInt32(comboBox_CCountry.SelectedValue);
        }

        private void comboBox_State_Enter(object sender, EventArgs e)
        {
            if (!comboBox_CState.Tag.Equals(CntID))
            {
                comboBox_CState.Tag = CntID;
                var hh = from prd in DCMD.TBL_States
                         where prd.CountryID == CntID
                         select prd;
                comboBox_CState.DataSource = hh;
            }
        }

        private void comboBox_State_Leave(object sender, EventArgs e)
        {
            StID = Convert.ToInt32(comboBox_CState.SelectedValue);
        }

        private void comboBox_City_Enter(object sender, EventArgs e)
        {
            if (!comboBox_CCity.Tag.Equals(StID))
            {
                comboBox_CCity.Tag = StID;
                var hh = from prd in DCMD.TBL_Cities
                         where prd.StateID == StID
                         select prd;
                comboBox_CCity.DataSource = hh;
            }
        }

        private void comboBox_City_Leave(object sender, EventArgs e)
        {
            CyID = Convert.ToInt32(comboBox_CCity.SelectedValue);
        }

        private void comboBox_Part1_Enter(object sender, EventArgs e)
        {
            if (!comboBox_CPart1.Tag.Equals(CyID))
            {
                comboBox_CPart1.Tag = CyID;
                var h1 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_CPart1.DataSource = h1;
            }
        }

        private void comboBox_Part2_Enter(object sender, EventArgs e)
        {
            if (!comboBox_CPart2.Tag.Equals(CyID))
            {
                comboBox_CPart2.Tag = CyID;
                var h2 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_CPart2.DataSource = h2;
            }
        }

        private void comboBox_Part3_Enter(object sender, EventArgs e)
        {
            if (!comboBox_CPart3.Tag.Equals(CyID))
            {
                comboBox_CPart3.Tag = CyID;
                var h3 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_CPart3.DataSource = h3;
            }
        }

        private void comboBox_Part4_Enter(object sender, EventArgs e)
        {
            if (!comboBox_CPart4.Tag.Equals(CyID))
            {
                comboBox_CPart4.Tag = CyID;
                var h4 = from prd in DCMD.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_CPart4.DataSource = h4;
            }
        }

        private int HCntID, HStID, HCyID;
        private void comboBox_HCountry_Enter(object sender, EventArgs e)
        {
            if (comboBox_HCountry.DataSource == null)
            {
                var hh = from prd in DCMD.TBL_Countries
                         select prd;
                comboBox_HCountry.DataSource = hh;
            }
        }

        private void comboBox_HCountry_Leave(object sender, EventArgs e)
        {
            HCntID = Convert.ToInt32(comboBox_HCountry.SelectedValue);
        }

        private void comboBox_HState_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HState.Tag.Equals(HCntID))
            {
                comboBox_HState.Tag = HCntID;
                var hh = from prd in DCMD.TBL_States
                         where prd.CountryID == HCntID
                         select prd;
                comboBox_HState.DataSource = hh;
            }
        }

        private void comboBox_HState_Leave(object sender, EventArgs e)
        {
            HStID = Convert.ToInt32(comboBox_HState.SelectedValue);
        }

        private void comboBox_HCity_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HCity.Tag.Equals(HStID))
            {
                comboBox_HCity.Tag = HStID;
                var hh = from prd in DCMD.TBL_Cities
                         where prd.StateID == HStID
                         select prd;
                comboBox_HCity.DataSource = hh;
            }
        }

        private void comboBox_HCity_Leave(object sender, EventArgs e)
        {
            HCyID = Convert.ToInt32(comboBox_HCity.SelectedValue);
        }

        private void comboBox_HPart1_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart1.Tag.Equals(HCyID))
            {
                comboBox_HPart1.Tag = HCyID;
                var h1 = from prd in DCMD.TBL_Parts
                         where prd.CityID == HCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart1.DataSource = h1;
            }
        }

        private void comboBox_HPart2_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart2.Tag.Equals(HCyID))
            {
                comboBox_HPart2.Tag = HCyID;
                var h2 = from prd in DCMD.TBL_Parts
                         where prd.CityID == HCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart2.DataSource = h2;
            }
        }

        private void comboBox_HPart3_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart3.Tag.Equals(HCyID))
            {
                comboBox_HPart3.Tag = HCyID;
                var h3 = from prd in DCMD.TBL_Parts
                         where prd.CityID == HCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart3.DataSource = h3;
            }
        }

        private void comboBox_HPart4_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart4.Tag.Equals(HCyID))
            {
                comboBox_HPart4.Tag = HCyID;
                var h4 = from prd in DCMD.TBL_Parts
                         where prd.CityID == HCyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart4.DataSource = h4;
            }
        }

        #endregion

        private void groupPanel_RepCustomer_Click(object sender, EventArgs e)
        {


        }


    }
}

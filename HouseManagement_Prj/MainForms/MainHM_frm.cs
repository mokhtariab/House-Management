﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;
using HouseManagement_Prj.Properties;
using Microsoft.VisualBasic.FileIO;
using System.Collections.ObjectModel;
using System.Globalization;

namespace HouseManagement_Prj
{
    public partial class MainHM_frm : Form
    {

        public MainHM_frm()
        {
            InitializeComponent();
        }

        
        #region All Events in Forms
        

        public string UserPermission, UserPrmHouseFor;
        private void MainHM_frm_Shown(object sender, EventArgs e)
        {
            //main color
            if (Global_Cls.ColorDisplay == 0) { checkBoxItem_Black.Checked = true; checkBoxItem_Black_Click(this, null); }
            else if (Global_Cls.ColorDisplay == 1) { checkBoxItem_Silver.Checked = true; checkBoxItem_Silver_Click(this, null); }
            else if (Global_Cls.ColorDisplay == 2) { checkBoxItem_Blue.Checked = true; checkBoxItem_Blue_Click(this, null); }
            //

            //HouseManagement_Prj.Properties.Settings.Default.Initialize( , Properties.Resources.ResourceManager.ResourceSetType.FullName = "\\Settings.settings";
            if (UserPermission != "" && UserPermission != "admin")
            {
                foreach (Control c in this.Controls["ribbonControl_Main"].Controls)
                {
                    if (c.Name != "")
                        foreach (Control c1 in this.Controls["ribbonControl_Main"].Controls[c.Name].Controls)
                        {
                            if (c1.Name != "")
                            {
                                string sp = UserPermission;
                                string st = "";
                                while (sp != "")
                                {
                                    st = sp.Substring(0, sp.IndexOf(","));
                                    sp = sp.Substring(sp.IndexOf(",") + 1, sp.Length - (sp.IndexOf(",") + 1));
                                    BaseItem item = (c1 as RibbonBar).GetItem(st);
                                    try
                                    {
                                        item.Enabled = false;
                                    }
                                    catch { }
                                }
                            }
                        }
                }
            }


            Function_Cls.ReadSettingFromDB();

            if (Global_Cls.NonActiveOn_Off)
            {
                DataClassesSecondDataContext DCSDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
                var SUN = from prd in DCSDC.ListSecondHouse_Vws
                          where (prd.FileStatus == 1) && (prd.NonActive_Date.Value <= DateTime.Now.AddDays(Global_Cls.NonActive_Day))
                          select prd;
                if (SUN.Count() > 0 && Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا لیست فایلهای سررسید شده تا "+Global_Cls.NonActive_Day.ToString()+" روز جلوتر نمایش داده شود؟"))
                    Global_Cls.AddTab_ListFileStatus(" لیست فایلهای سررسید شده ", 1, true);
            }
            tabNameStr = "tabControlPanel_StartPnl,";


            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItem_Advertisement.Enabled = false;
                buttonItemSMS.Enabled = false;
                buttonItem_SendSMS.Enabled = false;
                buttonItem_ReciveSMS.Enabled = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1") || Global_Cls.SoftwareCode == "Trial")
            {
                ribbonBar_FileCRecive.Enabled = false;
                ribbonBar_HFileRecived.Enabled = false;
                buttonItem_ChartPos.Enabled = false;
                buttonItem_SendEmail.Enabled = false;
                buttonItem_DesignRep.Enabled = false;
            }
            if (Global_Cls.SoftwareCode == "Trial")
            {
                buttonItem_ieSearch.Enabled = false;
                buttonItem_SearchHouse.Enabled = false;
            }

            /*if (Global_Cls.SoftwareCode != "L4" && Global_Cls.SoftwareCode != "N4")
            {
                ribbonBar_FileCRecive.Enabled = !"L1,L2,L3,N1,N2,N3".Contains(Global_Cls.SoftwareCode);
                ribbonBar_HFileRecived.Enabled = !"L1,L2,N1,N2".Contains(Global_Cls.SoftwareCode);
                ribbonBar_SMSAdver.Enabled = !"L1,N1".Contains(Global_Cls.SoftwareCode);
            }*/
            //codeing
        }



        private void MainHM_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Function_Cls.ExitForce)
                if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از برنامه خارج می شوید؟"))
                {
                    e.Cancel = true;
                    return;
                }

            try
            {
                for (int i = 0; i < tabControl_Main.Tabs.Count; i++)
                    tabControl_Main.Tabs.RemoveAt(i);
            }
            catch { }


            //setting
            if (Global_Cls.BkpExitType == 2)
            {
                string RootStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                RootStr = RootStr.Replace("/", "");
                RootStr = Global_Cls.BkpAutoRoot + "\\" + RootStr + " " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + ".bak";
                Function_Cls.SetBackUpDBAll(RootStr);
            }
            if (Global_Cls.BkpExitType == 1) Func_CallTheBackUp();

            //main color
            if (checkBoxItem_Black.Checked) Global_Cls.ColorDisplay = 0;
            else if (checkBoxItem_Silver.Checked) Global_Cls.ColorDisplay = 1;
            else if (checkBoxItem_Blue.Checked) Global_Cls.ColorDisplay = 2;
            //

            Function_Cls.WriteSettingToDB();
            Function_Cls.WriteToXmlFiles();

            timer_Main.Enabled = false;
        }


        private void MainHM_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        public bool CloseAllOK = false;
        private void notifyToolStrip_ItemExit_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOK = true;
                Close();
            }
            catch { }
        }

        private void MainHM_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl_Main.SelectedTabIndex == tabControl_Main.Tabs.Count - 1)
                    tabControl_Main.SelectedTabIndex = 0;
                else
                    tabControl_Main.SelectNextTab();
            }
        }

        #endregion



        #region Add Tabs to TabControl Functions & Add UserControl to Tabs

        //private int Cnt;
        public string tabNameStr;

        public void AddTabToTabControl(string tabName, string tabCaption, UserControl UC)
        {
            if (tabNameStr != null && tabNameStr.Contains(tabName + "Pnl,"))
            {
                tabControl_Main.SelectedPanel = (TabControlPanel)tabControl_Main.Controls[tabName + "Pnl"];
                UC.Dispose();
                return;
            }

            DevComponents.DotNetBar.TabItem NewTabItem = new DevComponents.DotNetBar.TabItem(this.components);
            DevComponents.DotNetBar.TabControlPanel NewTabControlPanel = new DevComponents.DotNetBar.TabControlPanel();

            NewTabControlPanel.Controls.Add(UC);
            UC.Dock = DockStyle.Fill;
            NewTabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            NewTabControlPanel.Location = new System.Drawing.Point(0, 0);
            NewTabControlPanel.Padding = new System.Windows.Forms.Padding(1);
            NewTabControlPanel.Size = new System.Drawing.Size(778, 289);
            NewTabControlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            NewTabControlPanel.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark;
            NewTabControlPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                 | DevComponents.DotNetBar.eBorderSide.Top)));
            NewTabControlPanel.Style.GradientAngle = -90;
            NewTabControlPanel.TabIndex = 1;

            NewTabControlPanel.TabItem = NewTabItem;
            NewTabItem.AttachedControl = NewTabControlPanel;

            
            //
            tabNameStr += tabName + "Pnl,";

            NewTabControlPanel.Name = tabName + "Pnl";
            NewTabControlPanel.Text = tabCaption;

            try
            {
                NewTabItem.Name = tabName + "Itm";
            }
            catch
            {
            }
            NewTabItem.Text = tabCaption;

            tabControl_Main.Controls.Add(NewTabControlPanel);
            tabControl_Main.Tabs.Add(NewTabItem);
            tabControl_Main.Refresh();

            tabControl_Main.SelectedPanel = NewTabControlPanel;


            /*Cnt = 1;
            string tabstr = tabName + "Pnl";

            if (tabNameStr != null && tabNameStr.Contains(tabstr))
            {
                Cnt = tabNameStr.IndexOf(tabstr) + tabstr.Length;
                string newtabstr = tabNameStr.Substring(Cnt, tabNameStr.Length - Cnt);
                Cnt = Convert.ToInt32(tabNameStr.Substring(Cnt, newtabstr.IndexOf(","))) + 1;
            }
            else
                tabNameStr += tabName + "Pnl" + Cnt + ",";

            NewTabControlPanel.Name = tabName + "Pnl" + Cnt;
            NewTabControlPanel.Text = tabCaption + Cnt;

            NewTabItem.Name = tabName + "Itm" + Cnt;
            NewTabItem.Text = tabCaption + Cnt;

            tabNameStr = tabNameStr.Replace(tabName + "Pnl" + (Cnt - 1), tabName + "Pnl" + Cnt);

            tabControl_Main.Controls.Add(NewTabControlPanel);
            tabControl_Main.Tabs.Add(NewTabItem);
            tabControl_Main.Refresh();

            tabControl_Main.SelectedPanel = NewTabControlPanel;*/
        }

        public void DeleteTabFromTabControl(DevComponents.DotNetBar.TabItem TabItemName)
        {
            tabControl_Main.Tabs.Remove(TabItemName);
            tabControl_Main.Controls.Remove(TabItemName.AttachedControl);
        }


        private void tabControl_Main_ControlRemoved(object sender, ControlEventArgs e)
        {
            tabNameStr = tabNameStr.Replace(tabControl_Main.SelectedPanel.Name + ",", "");
            tabControl_Main.Tabs.Capacity--;
        }
        
        private void buttonItem_Users_Click(object sender, EventArgs e)
        {
            ListUser_UC Uc = new ListUser_UC();
            AddTabToTabControl("User", " کاربران ", Uc);
        }

        private void buttonItem_SearchHouse_Click(object sender, EventArgs e)
        {
            SearchHouse_UC Uc = new SearchHouse_UC();
            AddTabToTabControl("SearchHouse", " جستجوی پیشرفته ملک ", Uc);
        }

        private void buttonItem_NewHouse_Click(object sender, EventArgs e)
        {
            NewHouse_Function();
        }

        public void NewHouse_Function()
        {
            NEHouse_frm Uc = new NEHouse_frm();
            Uc.NewOrEditHouse = 1;
            Uc.SetData_NEHouse();
            Uc.ShowDialog();
            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }

        }

        private void buttonItem_EditHouse_Click(object sender, EventArgs e)
        {
            if (Global_Cls.HouseIDChangeEdit != -100)
                EditHouse_Function(Global_Cls.HouseIDChangeEdit);
        }

        public void EditHouse_Function(int HouseIdforEdit)
        {
            NEHouse_frm Uc = new NEHouse_frm();
            Uc.NewOrEditHouse = 2;
            Uc.HsID = HouseIdforEdit;
            Uc.SetData_NEHouse();
            Uc.ShowDialog();
            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
        }

        private void buttonItem_ListHouse_Click(object sender, EventArgs e)
        {
            Function_Cls.CheckKeyFile(); 

            ListHouse_UC Uc = new ListHouse_UC();
            AddTabToTabControl("ListHouse", " لیست املاک ", Uc);
        }

        private void buttonItem_HFRecive_Click(object sender, EventArgs e)
        {
            HouseReqRcv_frm hrf = new HouseReqRcv_frm();
            hrf.InterfaceMode = 1;
            hrf.ShowDialog();
        }

        private void buttonItem_ListHRecived_Click(object sender, EventArgs e)
        {
            ListHouseRcv_UC Uc = new ListHouseRcv_UC();
            AddTabToTabControl("ListHouseRcv", " لیست دریافت املاک ", Uc);
        }




        private void buttonItem_NewCustom_Click(object sender, EventArgs e)
        {
            NewCustomer_Function();
        }

        public void NewCustomer_Function()
        {
            //NECustomer_UC Uc = new NECustomer_UC();
            NECustomer_frm Uc = new NECustomer_frm();
            Uc.NewOrEditCustomer = 1;
            Uc.SetDefault_NECustomer();
            Uc.ShowDialog();
            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
            //AddTabToTabControl("NewCustomer", " متقاضی جدید ", Uc);
        }

        private void buttonItem_EditCustom_Click(object sender, EventArgs e)
        {
            if (Global_Cls.RequestIDChangeEdit != -100)
                EditCustomer_Function(Global_Cls.RequestIDChangeEdit);
        }

        public void EditCustomer_Function(int CustomerIdforEdit)
        {
            //NECustomer_UC Uc = new NECustomer_UC();
            NECustomer_frm Uc = new NECustomer_frm();
            Uc.NewOrEditCustomer = 2;
            Uc.CtID = CustomerIdforEdit;
            Uc.SetDefault_NECustomer();
            Uc.ShowDialog();
            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
//            AddTabToTabControl("EditCustomer", " ویرایش تقاضا ", Uc);
        }

        private void buttonItem_ListCustomer_Click(object sender, EventArgs e)
        {
            ListCustomer_UC Uc = new ListCustomer_UC();
            AddTabToTabControl("ListCustomer", " لیست متقاضیان ", Uc);
        }

        private void buttonItem_CFRecive_Click(object sender, EventArgs e)
        {
            HouseReqRcv_frm hrf = new HouseReqRcv_frm();
            hrf.InterfaceMode = 2;
            hrf.ShowDialog();
        }

        private void buttonItem_ListCRecive_Click(object sender, EventArgs e)
        {
            ListReqRcv_UC Uc = new ListReqRcv_UC();
            AddTabToTabControl("ListReqRcv_UC", " لیست دریافت متقاضیان ", Uc);
        }



        private void buttonItem_PerTelMob_Click(object sender, EventArgs e)
        {
            ListTelMob_UC Uc = new ListTelMob_UC();
            AddTabToTabControl("ListTelMob", " دفتر تلفن ", Uc);
        }

        private void buttonItem_ListFileCnlu_Click(object sender, EventArgs e)
        {
            Global_Cls.AddTab_ListFileStatus(" لیست فایل های قولنامه شده ", 2, false);
        }

        private void buttonItem_DelList_Click(object sender, EventArgs e)
        {
            Global_Cls.AddTab_ListFileStatus(" لیست فایلهای حذف شده ", 3, false);
        }

        private void buttonItem_NonActiveList_Click(object sender, EventArgs e)
        {
            Global_Cls.AddTab_ListFileStatus(" لیست فایلهای بایگانی شده ", 1, false);
        }

        public void buttonItem_ListConclusion_Click(object sender, EventArgs e)
        {
            ListConclusion_UC Uc = new ListConclusion_UC();
            AddTabToTabControl("ListConclusion", " لیست قراردادها ", Uc);
        }

        #endregion



        #region Backup Or Restore Functions
        private void buttonItem_Bkp_Click(object sender, EventArgs e)
        {
            Func_CallTheBackUp();
        }

        private void Func_CallTheBackUp()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files(*.bak)|*.bak";
            if (dlg.ShowDialog() == DialogResult.OK)
                Function_Cls.SetBackUpDBAll(dlg.FileName);
        }
       
        private void buttonItem_Rst_Click(object sender, EventArgs e)
        {
            Func_CallTheRestore();
        }

        private void Func_CallTheRestore()
        {
            if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا نسبت به عمل بازیابی مطمئنید؟"))
                Function_Cls.Restore_Func(false);
        }
        #endregion



        #region All Settings
        private void checkBoxItem_Black_Click(object sender, EventArgs e)
        {
            ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
        }

        private void checkBoxItem_Silver_Click(object sender, EventArgs e)
        {
            ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
        }

        private void checkBoxItem_Blue_Click(object sender, EventArgs e)
        {
            ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue;
        }

        private static void SettingForm_Open(int tabindex)
        {
            Setting_frm Sf = new Setting_frm();
            //Sf.tabControl_Setting.SelectedTabIndex = tabindex;
            if(tabindex!=4) Sf.treeView_Setting.SelectedNode = Sf.treeView_Setting.Nodes[tabindex].Nodes[0];
            else Sf.treeView_Setting.SelectedNode = Sf.treeView_Setting.Nodes[tabindex];
            Sf.ShowDialog();
        }

        private void ribbonBar_MainSet_DialogLauncherMouseDown(object sender, MouseEventArgs e)
        {
            SettingForm_Open(0);
        }

        private void buttonItem_FirstSet_Click(object sender, EventArgs e)
        {
            SettingForm_Open(0);
        }

        private void buttonItem_AgencySet_Click(object sender, EventArgs e)
        {
            SettingForm_Open(1);
        }

        private void buttonItem_BkpRstSet_Click(object sender, EventArgs e)
        {
            SettingForm_Open(4);
        }

        private void buttonItem_OtherSet_Click(object sender, EventArgs e)
        {
            SettingForm_Open(3);
        }

        private void buttonItem_SetSystem_Click(object sender, EventArgs e)
        {
            SettingForm_Open(2);
        }


        #endregion



        #region Tools

        private void buttonItem_SendSMS_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(true, "", "");
        }

        private void buttonItem_Advertisement_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(false, "", "");
        }

        private void buttonItem_Calc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void buttonItem_Notepad_Click(object sender, EventArgs e)
        {
            Process.Start("NotePad");
        }

        private void buttonItem_ieSearch_Click(object sender, EventArgs e)
        {
            Function_Cls.SearchInternet(1);
        }

        private void buttonItem_ChartPos_Click(object sender, EventArgs e)
        {
            Function_Cls.SearchInternet(2);
        }

        private void buttonItem_ReciveSMS_Click(object sender, EventArgs e)
        {
            ReciveSMS_frm rsf = new ReciveSMS_frm();
            rsf.ShowDialog();
        }

        private void buttonItem_SendEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("");
        }


        #endregion



        #region Reports

        private void ReportFormViewer(int TbIndex)
        {
            ReportsAllModules_frm RAM = new ReportsAllModules_frm();
            RAM.tabControl_Reports.SelectedTabIndex = TbIndex;
            RAM.ShowDialog();
        }

        private void buttonItem_FileRep_Click(object sender, EventArgs e)
        {
            ReportFormViewer(0);
            
            //ReportHouseFile_UC Uc = new ReportHouseFile_UC();
            //AddTabToTabControl("ReportHouseFile", " گزارش ملک ", Uc);
        }

        private void buttonItem_CustomRep_Click(object sender, EventArgs e)
        {
            ReportFormViewer(1);
//            ReportCustomer_UC Uc = new ReportCustomer_UC();
  //          AddTabToTabControl("ReportCustomer", " گزارش متقاضی ", Uc);
        }

        private void buttonItem_CncluRep_Click(object sender, EventArgs e)
        {
            ReportFormViewer(2);

//            ReportConclusionMng_UC Uc = new ReportConclusionMng_UC();
  //          AddTabToTabControl("ReportConclusionMng", " گزارش قراردادها ", Uc);
        }

        private void buttonItem_DesignRep_Click(object sender, EventArgs e)
        {
            ReportsDesign_frm Uc = new ReportsDesign_frm();
            Uc.ShowDialog();
        }
        #endregion



        #region Date Time UserName
        Int16 CounterColor = 0;
        private void timer_Main_Tick(object sender, EventArgs e)
        {
            //if (CounterColor == 100) CounterColor = 0;
            //label_main.ForeColor = Convert.ChangeType(CounterColor++, System.Drawing.Color);// Color.Khaki;// CounterColor++;
            label_main.Text = taghvim() + "           ساعت: " +
                DateTime.Now.TimeOfDay.Hours.ToString() + ":" +
                DateTime.Now.TimeOfDay.Minutes.ToString() + ":" +
                DateTime.Now.TimeOfDay.Seconds.ToString() + "         کاربر: " +
                Global_Cls.UserName_Exist.ToString();
            label_main.Left = bar_MainView.Width/2 - 250;
        }

        private string taghvim()
        {
            string TghvmStr = "";

            string[] fasl = new string[12];
            fasl[0] = "فروردین";
            fasl[1] = "اردیبهشت";
            fasl[2] = "خرداد";
            fasl[3] = "تیر";
            fasl[4] = "مرداد";
            fasl[5] = "شهریور";
            fasl[6] = "مهر";
            fasl[7] = "آبان";
            fasl[8] = "آذر";
            fasl[9] = "دی";
            fasl[10] = "بهمن";
            fasl[11] = "اسفند";
            string[] rooz = new string[7];
            rooz[0] = "شنبه"; rooz[1] = "یکشنبه"; rooz[2] = "دوشنبه"; rooz[3] = "سه شنبه"; rooz[4] = "چهارشنبه"; rooz[5] = "پنج شنبه"; rooz[6] = "جمعه";

            PersianCalendar farsi = new PersianCalendar();
            int a;
            DayOfWeek dd;

            dd = farsi.GetDayOfWeek(DateTime.Now);
            switch (dd.ToString())
            {
                case "Saturday":
                    TghvmStr = rooz[0].ToString();
                    break;
                case "Sunday":
                    TghvmStr = rooz[1].ToString();
                    break;
                case "Monday":
                    TghvmStr = rooz[2].ToString();
                    break;
                case "Tuesday":
                    TghvmStr = rooz[3].ToString();
                    break;
                case "Wednesday":
                    TghvmStr = rooz[4].ToString();
                    break;
                case "Thursday":
                    TghvmStr = rooz[5].ToString();
                    break;
                case "Friday":
                    TghvmStr = rooz[6].ToString();
                    break;
            }
            string str;
            a = farsi.GetDayOfMonth(DateTime.Now);
            TghvmStr += " " + Convert.ToString(a);
            str = Convert.ToString(a);
            a = farsi.GetMonth(DateTime.Now);
            TghvmStr += " " + fasl[a - 1];
            str += "/" + Convert.ToString(a);
            a = farsi.GetYear(DateTime.Now);
            TghvmStr += " " + Convert.ToString(a);
            str += "/" + Convert.ToString(a);

            return TghvmStr;
        }
        #endregion

       
        
        private void buttonItem_Help_Click(object sender, EventArgs e)
        {
            Process.Start("SaraHelp.chm");
        }

    }
}

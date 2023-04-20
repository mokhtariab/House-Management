namespace HouseManagement_Prj
{
    partial class Setting_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_frm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("تنظیم واحدها");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("موارد ثبت اولیه املاک");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("تنظیمات مناطق");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("تنظیمات اولیه", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("موارد ثبتی");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("تنظیم موقعیت و تصویر");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("تنظیمات آژانس", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("تنظیم نوع املاک");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("SMS");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("تنظیمات سیستمی", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("تنظیم آلارم ها");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("فیلدهای آگهی");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("دیگر تنظیمات", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("پشتیبانی و بازیابی");
            this.ribbonBar_Setting = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.treeView_Setting = new System.Windows.Forms.TreeView();
            this.imageList_Setting = new System.Windows.Forms.ImageList(this.components);
            this.tabControl_Setting = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel_SetAlarms = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nUpDown_OnNonActive = new System.Windows.Forms.NumericUpDown();
            this.radioButton_OffNonActive = new System.Windows.Forms.RadioButton();
            this.radioButton_OnNonActive = new System.Windows.Forms.RadioButton();
            this.tabItem_SetAlarms = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetBkpRst = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_Set = new System.Windows.Forms.GroupBox();
            this.checkBox_BRDesignRep = new System.Windows.Forms.CheckBox();
            this.checkBox_BRPicFilm = new System.Windows.Forms.CheckBox();
            this.groupBox_Rst = new System.Windows.Forms.GroupBox();
            this.button_RstChangePass = new DevComponents.DotNetBar.ButtonX();
            this.groupBox_Bkp = new System.Windows.Forms.GroupBox();
            this.label_BkpAuto = new System.Windows.Forms.Label();
            this.button_BkpAuto = new DevComponents.DotNetBar.ButtonX();
            this.radioButton_BkpNo = new System.Windows.Forms.RadioButton();
            this.radioButton_BkpAuto = new System.Windows.Forms.RadioButton();
            this.radioButton_BkpNonAuto = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabItem_SetBkpRst = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetAgPos = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_Pic = new System.Windows.Forms.GroupBox();
            this.button_CityPic = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox_CityPic = new System.Windows.Forms.PictureBox();
            this.tabItem_SetAgPos = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetAgReg = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_Reg = new System.Windows.Forms.GroupBox();
            this.textBox_AgEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_AdminAgName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_AgencyAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.button_AgencyLogo = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox_AgencyLogo = new System.Windows.Forms.PictureBox();
            this.textBox_AgancyMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_AgancyTel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_AgancyName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_AgancyMobile = new System.Windows.Forms.Label();
            this.label_AgancyTel = new System.Windows.Forms.Label();
            this.label_AgancyName = new System.Windows.Forms.Label();
            this.tabItem_SetAgReg = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetUseHouse = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel_ReqFor = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox_AddRF = new System.Windows.Forms.ComboBox();
            this.button_AddRF = new DevComponents.DotNetBar.ButtonX();
            this.button_DelRF = new DevComponents.DotNetBar.ButtonX();
            this.button_UpRF = new System.Windows.Forms.Button();
            this.button_DownRF = new System.Windows.Forms.Button();
            this.listBox_ReqFor = new System.Windows.Forms.ListBox();
            this.groupPanel_TypeHouse = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox_AddTH = new System.Windows.Forms.ComboBox();
            this.button_AddTH = new DevComponents.DotNetBar.ButtonX();
            this.button_DelTH = new DevComponents.DotNetBar.ButtonX();
            this.button_UpTH = new System.Windows.Forms.Button();
            this.button_DownTH = new System.Windows.Forms.Button();
            this.listBox_TypeHouse = new System.Windows.Forms.ListBox();
            this.groupPanel_HouseFor = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox_AddHF = new System.Windows.Forms.ComboBox();
            this.button_AddHF = new DevComponents.DotNetBar.ButtonX();
            this.button_DelHF = new DevComponents.DotNetBar.ButtonX();
            this.button_UpHF = new System.Windows.Forms.Button();
            this.button_DownHF = new System.Windows.Forms.Button();
            this.listBox_HouseFor = new System.Windows.Forms.ListBox();
            this.tabItem_SetUseHouse = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetPosDef = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_PartSet = new System.Windows.Forms.GroupBox();
            this.button_PartUpdate = new DevComponents.DotNetBar.ButtonX();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button_DelPrt = new DevComponents.DotNetBar.ButtonX();
            this.textBox_NewPart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new System.Windows.Forms.Label();
            this.button_AddPrt = new DevComponents.DotNetBar.ButtonX();
            this.comboBox_Stt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_Prt = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_Cntry = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label_Prt = new System.Windows.Forms.Label();
            this.comboBox_Cty = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label_Cty = new System.Windows.Forms.Label();
            this.label_Cntry = new System.Windows.Forms.Label();
            this.label_Stt = new System.Windows.Forms.Label();
            this.tabItem_SetPosDef = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_FsetHouse = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel_Instalation = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkBox_Water = new System.Windows.Forms.CheckBox();
            this.checkBox_Electricity = new System.Windows.Forms.CheckBox();
            this.checkBox_Gaz = new System.Windows.Forms.CheckBox();
            this.checkBox_Cooler = new System.Windows.Forms.CheckBox();
            this.checkBox_FanCoel = new System.Windows.Forms.CheckBox();
            this.checkBox_Heat = new System.Windows.Forms.CheckBox();
            this.checkBox_Chiler = new System.Windows.Forms.CheckBox();
            this.checkBox_Pakage = new System.Windows.Forms.CheckBox();
            this.checkBox_Sauna = new System.Windows.Forms.CheckBox();
            this.checkBox_Jacuzzi = new System.Windows.Forms.CheckBox();
            this.checkBox_Pool = new System.Windows.Forms.CheckBox();
            this.groupPanel_RegH = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label_UseType = new System.Windows.Forms.Label();
            this.comboBox_UseType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem25 = new DevComponents.Editors.ComboItem();
            this.comboItem26 = new DevComponents.Editors.ComboItem();
            this.comboItem28 = new DevComponents.Editors.ComboItem();
            this.comboItem29 = new DevComponents.Editors.ComboItem();
            this.comboItem30 = new DevComponents.Editors.ComboItem();
            this.label_LicenceType = new System.Windows.Forms.Label();
            this.checkBox_KeyMoney = new System.Windows.Forms.CheckBox();
            this.checkBox_DocUse = new System.Windows.Forms.CheckBox();
            this.comboBox_LicenceType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.checkBox_Property = new System.Windows.Forms.CheckBox();
            this.comboBox_DocType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem32 = new DevComponents.Editors.ComboItem();
            this.comboItem33 = new DevComponents.Editors.ComboItem();
            this.comboItem34 = new DevComponents.Editors.ComboItem();
            this.comboItem35 = new DevComponents.Editors.ComboItem();
            this.comboItem36 = new DevComponents.Editors.ComboItem();
            this.comboItem37 = new DevComponents.Editors.ComboItem();
            this.comboItem38 = new DevComponents.Editors.ComboItem();
            this.comboItem39 = new DevComponents.Editors.ComboItem();
            this.comboItem40 = new DevComponents.Editors.ComboItem();
            this.comboItem41 = new DevComponents.Editors.ComboItem();
            this.label_DocType = new System.Windows.Forms.Label();
            this.groupPanel_Part = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox_Part = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_City = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label_City = new System.Windows.Forms.Label();
            this.label_Part = new System.Windows.Forms.Label();
            this.comboBox_State = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_Country = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label_Country = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.groupPanel_StatusH = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox_BldLow = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem24 = new DevComponents.Editors.ComboItem();
            this.comboItem27 = new DevComponents.Editors.ComboItem();
            this.comboBox_RcRoom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.comboItem12 = new DevComponents.Editors.ComboItem();
            this.comboItem23 = new DevComponents.Editors.ComboItem();
            this.checkBox_Patio = new System.Windows.Forms.CheckBox();
            this.comboBox_CT = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem7 = new DevComponents.Editors.ComboItem();
            this.checkBox_BYard = new System.Windows.Forms.CheckBox();
            this.label_CT = new System.Windows.Forms.Label();
            this.comboBox_MK = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem16 = new DevComponents.Editors.ComboItem();
            this.comboItem17 = new DevComponents.Editors.ComboItem();
            this.comboItem18 = new DevComponents.Editors.ComboItem();
            this.comboBox_BedRoom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem20 = new DevComponents.Editors.ComboItem();
            this.comboItem19 = new DevComponents.Editors.ComboItem();
            this.comboItem22 = new DevComponents.Editors.ComboItem();
            this.comboItem21 = new DevComponents.Editors.ComboItem();
            this.checkBox_Yard = new System.Windows.Forms.CheckBox();
            this.label_MK = new System.Windows.Forms.Label();
            this.label_KitchenFew = new System.Windows.Forms.Label();
            this.checkBox_Cellar = new System.Windows.Forms.CheckBox();
            this.label_BldLow = new System.Windows.Forms.Label();
            this.nUpDown_KitchenFew = new System.Windows.Forms.NumericUpDown();
            this.label_FBed = new System.Windows.Forms.Label();
            this.checkBox_StRoom = new System.Windows.Forms.CheckBox();
            this.label_RCRoom = new System.Windows.Forms.Label();
            this.nUpDown_FRoom = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Balcony = new System.Windows.Forms.CheckBox();
            this.label_FRoom = new System.Windows.Forms.Label();
            this.checkBox_FirePlace = new System.Windows.Forms.CheckBox();
            this.label_Bedroom = new System.Windows.Forms.Label();
            this.nUpDown_FBed = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Parking = new System.Windows.Forms.CheckBox();
            this.checkBox_FWc = new System.Windows.Forms.CheckBox();
            this.checkBox_Tel = new System.Windows.Forms.CheckBox();
            this.checkBox_IRWc = new System.Windows.Forms.CheckBox();
            this.groupPanel_facility = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkBox_EmployeeSrv = new System.Windows.Forms.CheckBox();
            this.checkBox_AV = new System.Windows.Forms.CheckBox();
            this.checkBox_RubShooting = new System.Windows.Forms.CheckBox();
            this.checkBox_SK = new System.Windows.Forms.CheckBox();
            this.checkBox_RDoor = new System.Windows.Forms.CheckBox();
            this.checkBox_AC = new System.Windows.Forms.CheckBox();
            this.checkBox_Elevatoor = new System.Windows.Forms.CheckBox();
            this.groupPanel_StsFile = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel_Date = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Year1 = new System.Windows.Forms.ComboBox();
            this.comboBox_day1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Month1 = new System.Windows.Forms.ComboBox();
            this.label_NonActDate = new System.Windows.Forms.Label();
            this.radioButton_Active = new System.Windows.Forms.RadioButton();
            this.radioButton_nonActive = new System.Windows.Forms.RadioButton();
            this.label_Priority = new System.Windows.Forms.Label();
            this.comboBox_Priority = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem8 = new DevComponents.Editors.ComboItem();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem13 = new DevComponents.Editors.ComboItem();
            this.groupPanel_House = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox_HouseFor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_TypeHouse = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.groupPanel_Ctrl = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.checkBox_HoldData = new System.Windows.Forms.CheckBox();
            this.checkBoxItem_Print = new System.Windows.Forms.CheckBox();
            this.checkBoxItem_ListCuHouse = new System.Windows.Forms.CheckBox();
            this.checkBox_AddTelNotebook = new System.Windows.Forms.CheckBox();
            this.checkBox_IsDefaltValue = new System.Windows.Forms.CheckBox();
            this.tabItem_FsetHouse = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_AdverField = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_Advertisment = new System.Windows.Forms.GroupBox();
            this.checkBox_UnitNo = new System.Windows.Forms.CheckBox();
            this.checkBox_FewBedR = new System.Windows.Forms.CheckBox();
            this.checkBox_UseType = new System.Windows.Forms.CheckBox();
            this.checkBox_BldAge = new System.Windows.Forms.CheckBox();
            this.checkBox_PartName = new System.Windows.Forms.CheckBox();
            this.checkBox_AllUnits = new System.Windows.Forms.CheckBox();
            this.comboBox_separator = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.label_Separator = new System.Windows.Forms.Label();
            this.CheckBox_PriceMR = new System.Windows.Forms.CheckBox();
            this.CheckBox_PriceHouseAll = new System.Windows.Forms.CheckBox();
            this.CheckBox_estateNo = new System.Windows.Forms.CheckBox();
            this.CheckBox_Fewestate = new System.Windows.Forms.CheckBox();
            this.CheckBox_Submeter = new System.Windows.Forms.CheckBox();
            this.CheckBox_housefor = new System.Windows.Forms.CheckBox();
            this.CheckBox_typehouse = new System.Windows.Forms.CheckBox();
            this.tabItem_AdverField = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_Sms = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel_SMS = new System.Windows.Forms.GroupBox();
            this.chkDeliveryReport = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLongMsg = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbFlowControl = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.chkunicode = new System.Windows.Forms.CheckBox();
            this.cmbTimeOut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabItem_Sms = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_WebPart = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBox_HPart8 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_HPart7 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_HPart5 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_HPart6 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_HPart4 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_HPart3 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox_HPart1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox_HCity = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBox_HState = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox_HCountry = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox_HPart2 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tabItem_WebPart = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetUnits = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_MoneyUnit = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBox_ChangeMoney = new System.Windows.Forms.TextBox();
            this.comboBox_MnyUnit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem14 = new DevComponents.Editors.ComboItem();
            this.comboItem15 = new DevComponents.Editors.ComboItem();
            this.comboItem31 = new DevComponents.Editors.ComboItem();
            this.label31 = new System.Windows.Forms.Label();
            this.label_MnyUnit = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label_MnyU = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_TypeFileNo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem_Int = new DevComponents.Editors.ComboItem();
            this.comboItem_String = new DevComponents.Editors.ComboItem();
            this.button_Active = new DevComponents.DotNetBar.ButtonX();
            this.tabItem_SetUnits = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Setting)).BeginInit();
            this.tabControl_Setting.SuspendLayout();
            this.tabControlPanel_SetAlarms.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_OnNonActive)).BeginInit();
            this.tabControlPanel_SetBkpRst.SuspendLayout();
            this.groupBox_Set.SuspendLayout();
            this.groupBox_Rst.SuspendLayout();
            this.groupBox_Bkp.SuspendLayout();
            this.tabControlPanel_SetAgPos.SuspendLayout();
            this.groupBox_Pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CityPic)).BeginInit();
            this.tabControlPanel_SetAgReg.SuspendLayout();
            this.groupBox_Reg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AgencyLogo)).BeginInit();
            this.tabControlPanel_SetUseHouse.SuspendLayout();
            this.groupPanel_ReqFor.SuspendLayout();
            this.groupPanel_TypeHouse.SuspendLayout();
            this.groupPanel_HouseFor.SuspendLayout();
            this.tabControlPanel_SetPosDef.SuspendLayout();
            this.groupBox_PartSet.SuspendLayout();
            this.tabControlPanel_FsetHouse.SuspendLayout();
            this.groupPanel_Instalation.SuspendLayout();
            this.groupPanel_RegH.SuspendLayout();
            this.groupPanel_Part.SuspendLayout();
            this.groupPanel_StatusH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_KitchenFew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_FRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_FBed)).BeginInit();
            this.groupPanel_facility.SuspendLayout();
            this.groupPanel_StsFile.SuspendLayout();
            this.panel_Date.SuspendLayout();
            this.groupPanel_House.SuspendLayout();
            this.groupPanel_Ctrl.SuspendLayout();
            this.tabControlPanel_AdverField.SuspendLayout();
            this.groupBox_Advertisment.SuspendLayout();
            this.tabControlPanel_Sms.SuspendLayout();
            this.groupPanel_SMS.SuspendLayout();
            this.tabControlPanel_WebPart.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.tabControlPanel_SetUnits.SuspendLayout();
            this.groupBox_MoneyUnit.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBar_Setting
            // 
            this.ribbonBar_Setting.AutoOverflowEnabled = true;
            this.ribbonBar_Setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonBar_Setting.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar_Setting.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_OK,
            this.buttonItem_Cancel});
            this.ribbonBar_Setting.Location = new System.Drawing.Point(0, 493);
            this.ribbonBar_Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Setting.Name = "ribbonBar_Setting";
            this.ribbonBar_Setting.Size = new System.Drawing.Size(843, 59);
            this.ribbonBar_Setting.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.ribbonBar_Setting.TabIndex = 2;
            this.ribbonBar_Setting.TitleVisible = false;
            // 
            // buttonItem_OK
            // 
            this.buttonItem_OK.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_OK.FixedSize = new System.Drawing.Size(80, 58);
            this.buttonItem_OK.HotFontBold = true;
            this.buttonItem_OK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_OK.Image")));
            this.buttonItem_OK.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_OK.ImagePaddingHorizontal = 20;
            this.buttonItem_OK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_OK.Name = "buttonItem_OK";
            this.buttonItem_OK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem_OK.SubItemsExpandWidth = 20;
            this.buttonItem_OK.Text = "تایید";
            this.buttonItem_OK.Tooltip = "F2";
            this.buttonItem_OK.Click += new System.EventHandler(this.buttonItem_OK_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(80, 58);
            this.buttonItem_Cancel.HotFontBold = true;
            this.buttonItem_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Cancel.Image")));
            this.buttonItem_Cancel.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_Cancel.ImagePaddingHorizontal = 20;
            this.buttonItem_Cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Cancel.Name = "buttonItem_Cancel";
            this.buttonItem_Cancel.SubItemsExpandWidth = 14;
            this.buttonItem_Cancel.Text = "انصراف";
            this.buttonItem_Cancel.Tooltip = "Esc";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // treeView_Setting
            // 
            this.treeView_Setting.BackColor = System.Drawing.Color.White;
            this.treeView_Setting.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView_Setting.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView_Setting.ForeColor = System.Drawing.Color.Black;
            this.treeView_Setting.Indent = 25;
            this.treeView_Setting.ItemHeight = 40;
            this.treeView_Setting.LineColor = System.Drawing.Color.MediumVioletRed;
            this.treeView_Setting.Location = new System.Drawing.Point(629, 0);
            this.treeView_Setting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView_Setting.Name = "treeView_Setting";
            treeNode1.Name = "Node_SetUnits";
            treeNode1.StateImageKey = "Utilities.png";
            treeNode1.Text = "تنظیم واحدها";
            treeNode2.Name = "Node_FSetHouse";
            treeNode2.StateImageKey = "Startup Wizard.png";
            treeNode2.Text = "موارد ثبت اولیه املاک";
            treeNode3.Name = "Node_SetPosDef";
            treeNode3.StateImageKey = "go_kde.png";
            treeNode3.Text = "تنظیمات مناطق";
            treeNode4.Name = "Node_FSet";
            treeNode4.StateImageKey = "advancedsettings.png";
            treeNode4.Text = "تنظیمات اولیه";
            treeNode5.Name = "Node_SetAgReg";
            treeNode5.StateImageKey = "artscontrol.png";
            treeNode5.Text = "موارد ثبتی";
            treeNode6.Name = "Node_SetAgPos";
            treeNode6.StateImageKey = "blender.png";
            treeNode6.Text = "تنظیم موقعیت و تصویر";
            treeNode7.Name = "Node_SetAgency";
            treeNode7.StateImageKey = "home.png";
            treeNode7.Text = "تنظیمات آژانس";
            treeNode8.Name = "Node_SetUseHouse";
            treeNode8.StateImageKey = "kfm_home.png";
            treeNode8.Text = "تنظیم نوع املاک";
            treeNode9.Name = "Node_Sms";
            treeNode9.StateImageKey = "sms.png";
            treeNode9.Text = "SMS";
            treeNode10.Name = "Node_SetSystem";
            treeNode10.StateImageKey = "systemsettings.png";
            treeNode10.Text = "تنظیمات سیستمی";
            treeNode11.Name = "Node_SetAlarms";
            treeNode11.StateImageKey = "bell.png";
            treeNode11.Text = "تنظیم آلارم ها";
            treeNode12.Name = "Node_AdverField";
            treeNode12.StateImageKey = "knode.png";
            treeNode12.Text = "فیلدهای آگهی";
            treeNode13.Name = "Node_SetOther";
            treeNode13.StateImageKey = "announcements.png";
            treeNode13.Text = "دیگر تنظیمات";
            treeNode14.Name = "Node_SetBkpRst";
            treeNode14.StateImageKey = "kcmdf.png";
            treeNode14.Text = "پشتیبانی و بازیابی";
            this.treeView_Setting.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode10,
            treeNode13,
            treeNode14});
            this.treeView_Setting.RightToLeftLayout = true;
            this.treeView_Setting.Size = new System.Drawing.Size(214, 493);
            this.treeView_Setting.StateImageList = this.imageList_Setting;
            this.treeView_Setting.TabIndex = 4;
            this.treeView_Setting.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Setting_NodeMouseClick);
            // 
            // imageList_Setting
            // 
            this.imageList_Setting.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Setting.ImageStream")));
            this.imageList_Setting.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Setting.Images.SetKeyName(0, "home.png");
            this.imageList_Setting.Images.SetKeyName(1, "advancedsettings.png");
            this.imageList_Setting.Images.SetKeyName(2, "announcements.png");
            this.imageList_Setting.Images.SetKeyName(3, "artscontrol.png");
            this.imageList_Setting.Images.SetKeyName(4, "go_kde.png");
            this.imageList_Setting.Images.SetKeyName(5, "sms.png");
            this.imageList_Setting.Images.SetKeyName(6, "kfm_home.png");
            this.imageList_Setting.Images.SetKeyName(7, "Startup Wizard.png");
            this.imageList_Setting.Images.SetKeyName(8, "bell.png");
            this.imageList_Setting.Images.SetKeyName(9, "kcmdf.png");
            this.imageList_Setting.Images.SetKeyName(10, "knode.png");
            this.imageList_Setting.Images.SetKeyName(11, "blender.png");
            this.imageList_Setting.Images.SetKeyName(12, "navigator.png");
            this.imageList_Setting.Images.SetKeyName(13, "systemsettings.png");
            this.imageList_Setting.Images.SetKeyName(14, "Utilities.png");
            // 
            // tabControl_Setting
            // 
            this.tabControl_Setting.CanReorderTabs = true;
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_FsetHouse);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetAlarms);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetBkpRst);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetAgPos);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetAgReg);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetUseHouse);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetPosDef);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_AdverField);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_Sms);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_WebPart);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetUnits);
            this.tabControl_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Setting.FixedTabSize = new System.Drawing.Size(1, 1);
            this.tabControl_Setting.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Setting.Name = "tabControl_Setting";
            this.tabControl_Setting.SelectedTabFont = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold);
            this.tabControl_Setting.SelectedTabIndex = 0;
            this.tabControl_Setting.Size = new System.Drawing.Size(629, 493);
            this.tabControl_Setting.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl_Setting.TabIndex = 5;
            this.tabControl_Setting.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.tabControl_Setting.Tabs.Add(this.tabItem_FsetHouse);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetPosDef);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetUseHouse);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetAgReg);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetAgPos);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetBkpRst);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetAlarms);
            this.tabControl_Setting.Tabs.Add(this.tabItem_AdverField);
            this.tabControl_Setting.Tabs.Add(this.tabItem_Sms);
            this.tabControl_Setting.Tabs.Add(this.tabItem_WebPart);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetUnits);
            // 
            // tabControlPanel_SetAlarms
            // 
            this.tabControlPanel_SetAlarms.AutoScroll = true;
            this.tabControlPanel_SetAlarms.AutoScrollMinSize = new System.Drawing.Size(554, 400);
            this.tabControlPanel_SetAlarms.Controls.Add(this.groupBox2);
            this.tabControlPanel_SetAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetAlarms.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetAlarms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetAlarms.Name = "tabControlPanel_SetAlarms";
            this.tabControlPanel_SetAlarms.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetAlarms.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_SetAlarms.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_SetAlarms.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_SetAlarms.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetAlarms.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_SetAlarms.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetAlarms.Style.GradientAngle = 90;
            this.tabControlPanel_SetAlarms.TabIndex = 7;
            this.tabControlPanel_SetAlarms.TabItem = this.tabItem_SetAlarms;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.nUpDown_OnNonActive);
            this.groupBox2.Controls.Add(this.radioButton_OffNonActive);
            this.groupBox2.Controls.Add(this.radioButton_OnNonActive);
            this.groupBox2.Location = new System.Drawing.Point(44, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(520, 236);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تنظیم آلارم ها";
            // 
            // nUpDown_OnNonActive
            // 
            this.nUpDown_OnNonActive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nUpDown_OnNonActive.ForeColor = System.Drawing.Color.Black;
            this.nUpDown_OnNonActive.Location = new System.Drawing.Point(370, 119);
            this.nUpDown_OnNonActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDown_OnNonActive.Name = "nUpDown_OnNonActive";
            this.nUpDown_OnNonActive.Size = new System.Drawing.Size(59, 22);
            this.nUpDown_OnNonActive.TabIndex = 7;
            this.nUpDown_OnNonActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDown_OnNonActive.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUpDown_OnNonActive.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // radioButton_OffNonActive
            // 
            this.radioButton_OffNonActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OffNonActive.AutoSize = true;
            this.radioButton_OffNonActive.Checked = true;
            this.radioButton_OffNonActive.Location = new System.Drawing.Point(431, 82);
            this.radioButton_OffNonActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_OffNonActive.Name = "radioButton_OffNonActive";
            this.radioButton_OffNonActive.Size = new System.Drawing.Size(63, 18);
            this.radioButton_OffNonActive.TabIndex = 6;
            this.radioButton_OffNonActive.TabStop = true;
            this.radioButton_OffNonActive.Text = "خاموش";
            this.radioButton_OffNonActive.UseVisualStyleBackColor = true;
            // 
            // radioButton_OnNonActive
            // 
            this.radioButton_OnNonActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OnNonActive.AutoSize = true;
            this.radioButton_OnNonActive.Location = new System.Drawing.Point(141, 119);
            this.radioButton_OnNonActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_OnNonActive.Name = "radioButton_OnNonActive";
            this.radioButton_OnNonActive.Size = new System.Drawing.Size(354, 18);
            this.radioButton_OnNonActive.TabIndex = 5;
            this.radioButton_OnNonActive.Text = "از                            روز قبل فایلهای بایگانی شده، فعال شوند.";
            this.radioButton_OnNonActive.UseVisualStyleBackColor = true;
            // 
            // tabItem_SetAlarms
            // 
            this.tabItem_SetAlarms.AttachedControl = this.tabControlPanel_SetAlarms;
            this.tabItem_SetAlarms.Name = "tabItem_SetAlarms";
            this.tabItem_SetAlarms.Text = "tabItem_SetAlarms";
            // 
            // tabControlPanel_SetBkpRst
            // 
            this.tabControlPanel_SetBkpRst.AutoScroll = true;
            this.tabControlPanel_SetBkpRst.AutoScrollMinSize = new System.Drawing.Size(600, 450);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.groupBox_Set);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.groupBox_Rst);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.groupBox_Bkp);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.panel4);
            this.tabControlPanel_SetBkpRst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetBkpRst.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetBkpRst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetBkpRst.Name = "tabControlPanel_SetBkpRst";
            this.tabControlPanel_SetBkpRst.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetBkpRst.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_SetBkpRst.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_SetBkpRst.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_SetBkpRst.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetBkpRst.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_SetBkpRst.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetBkpRst.Style.GradientAngle = 90;
            this.tabControlPanel_SetBkpRst.TabIndex = 6;
            this.tabControlPanel_SetBkpRst.TabItem = this.tabItem_SetBkpRst;
            // 
            // groupBox_Set
            // 
            this.groupBox_Set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Set.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Set.Controls.Add(this.checkBox_BRDesignRep);
            this.groupBox_Set.Controls.Add(this.checkBox_BRPicFilm);
            this.groupBox_Set.Location = new System.Drawing.Point(21, 189);
            this.groupBox_Set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Set.Name = "groupBox_Set";
            this.groupBox_Set.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Set.Size = new System.Drawing.Size(586, 54);
            this.groupBox_Set.TabIndex = 16;
            this.groupBox_Set.TabStop = false;
            this.groupBox_Set.Text = "تنظیمات";
            // 
            // checkBox_BRDesignRep
            // 
            this.checkBox_BRDesignRep.AutoSize = true;
            this.checkBox_BRDesignRep.Location = new System.Drawing.Point(44, 26);
            this.checkBox_BRDesignRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_BRDesignRep.Name = "checkBox_BRDesignRep";
            this.checkBox_BRDesignRep.Size = new System.Drawing.Size(218, 18);
            this.checkBox_BRDesignRep.TabIndex = 1;
            this.checkBox_BRDesignRep.Text = "پشتیبانی و بازیابی با طراحی گزارشات";
            this.checkBox_BRDesignRep.UseVisualStyleBackColor = true;
            // 
            // checkBox_BRPicFilm
            // 
            this.checkBox_BRPicFilm.AutoSize = true;
            this.checkBox_BRPicFilm.Location = new System.Drawing.Point(326, 26);
            this.checkBox_BRPicFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_BRPicFilm.Name = "checkBox_BRPicFilm";
            this.checkBox_BRPicFilm.Size = new System.Drawing.Size(207, 18);
            this.checkBox_BRPicFilm.TabIndex = 0;
            this.checkBox_BRPicFilm.Text = "پشتیبانی و بازیابی با تصاویر و فیلمها";
            this.checkBox_BRPicFilm.UseVisualStyleBackColor = true;
            // 
            // groupBox_Rst
            // 
            this.groupBox_Rst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Rst.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Rst.Controls.Add(this.button_RstChangePass);
            this.groupBox_Rst.Location = new System.Drawing.Point(22, 274);
            this.groupBox_Rst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Rst.Name = "groupBox_Rst";
            this.groupBox_Rst.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Rst.Size = new System.Drawing.Size(585, 177);
            this.groupBox_Rst.TabIndex = 15;
            this.groupBox_Rst.TabStop = false;
            this.groupBox_Rst.Text = "بازیابی";
            // 
            // button_RstChangePass
            // 
            this.button_RstChangePass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_RstChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_RstChangePass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_RstChangePass.Location = new System.Drawing.Point(175, 71);
            this.button_RstChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_RstChangePass.Name = "button_RstChangePass";
            this.button_RstChangePass.Size = new System.Drawing.Size(235, 40);
            this.button_RstChangePass.TabIndex = 0;
            this.button_RstChangePass.Text = "تغییر رمز بازیابی";
            this.button_RstChangePass.Click += new System.EventHandler(this.button_RstChangePass_Click);
            // 
            // groupBox_Bkp
            // 
            this.groupBox_Bkp.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Bkp.Controls.Add(this.label_BkpAuto);
            this.groupBox_Bkp.Controls.Add(this.button_BkpAuto);
            this.groupBox_Bkp.Controls.Add(this.radioButton_BkpNo);
            this.groupBox_Bkp.Controls.Add(this.radioButton_BkpAuto);
            this.groupBox_Bkp.Controls.Add(this.radioButton_BkpNonAuto);
            this.groupBox_Bkp.Location = new System.Drawing.Point(21, 39);
            this.groupBox_Bkp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Bkp.Name = "groupBox_Bkp";
            this.groupBox_Bkp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Bkp.Size = new System.Drawing.Size(590, 143);
            this.groupBox_Bkp.TabIndex = 14;
            this.groupBox_Bkp.TabStop = false;
            this.groupBox_Bkp.Text = "پشتیبانی";
            // 
            // label_BkpAuto
            // 
            this.label_BkpAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_BkpAuto.Location = new System.Drawing.Point(5, 13);
            this.label_BkpAuto.Name = "label_BkpAuto";
            this.label_BkpAuto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_BkpAuto.Size = new System.Drawing.Size(252, 60);
            this.label_BkpAuto.TabIndex = 6;
            this.label_BkpAuto.Text = "D:\\BackUpData";
            this.label_BkpAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_BkpAuto
            // 
            this.button_BkpAuto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_BkpAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_BkpAuto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_BkpAuto.Location = new System.Drawing.Point(263, 32);
            this.button_BkpAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_BkpAuto.Name = "button_BkpAuto";
            this.button_BkpAuto.Size = new System.Drawing.Size(29, 21);
            this.button_BkpAuto.TabIndex = 5;
            this.button_BkpAuto.Text = "...";
            this.button_BkpAuto.Click += new System.EventHandler(this.button_BkpAuto_Click);
            // 
            // radioButton_BkpNo
            // 
            this.radioButton_BkpNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpNo.AutoSize = true;
            this.radioButton_BkpNo.Location = new System.Drawing.Point(506, 112);
            this.radioButton_BkpNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpNo.Name = "radioButton_BkpNo";
            this.radioButton_BkpNo.Size = new System.Drawing.Size(68, 18);
            this.radioButton_BkpNo.TabIndex = 4;
            this.radioButton_BkpNo.Text = "هیچکدام";
            this.radioButton_BkpNo.UseVisualStyleBackColor = true;
            // 
            // radioButton_BkpAuto
            // 
            this.radioButton_BkpAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpAuto.AutoSize = true;
            this.radioButton_BkpAuto.Checked = true;
            this.radioButton_BkpAuto.Location = new System.Drawing.Point(329, 33);
            this.radioButton_BkpAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpAuto.Name = "radioButton_BkpAuto";
            this.radioButton_BkpAuto.Size = new System.Drawing.Size(245, 18);
            this.radioButton_BkpAuto.TabIndex = 3;
            this.radioButton_BkpAuto.TabStop = true;
            this.radioButton_BkpAuto.Text = "به صورت اتوماتیک گرفته شود            مسیر";
            this.radioButton_BkpAuto.UseVisualStyleBackColor = true;
            // 
            // radioButton_BkpNonAuto
            // 
            this.radioButton_BkpNonAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpNonAuto.AutoSize = true;
            this.radioButton_BkpNonAuto.Location = new System.Drawing.Point(386, 72);
            this.radioButton_BkpNonAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpNonAuto.Name = "radioButton_BkpNonAuto";
            this.radioButton_BkpNonAuto.Size = new System.Drawing.Size(188, 18);
            this.radioButton_BkpNonAuto.TabIndex = 2;
            this.radioButton_BkpNonAuto.Text = "در هنگام خروج مسیر سوال شود";
            this.radioButton_BkpNonAuto.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(28, 260);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(570, 4);
            this.panel4.TabIndex = 13;
            // 
            // tabItem_SetBkpRst
            // 
            this.tabItem_SetBkpRst.AttachedControl = this.tabControlPanel_SetBkpRst;
            this.tabItem_SetBkpRst.Name = "tabItem_SetBkpRst";
            this.tabItem_SetBkpRst.Text = "tabItem_SetBkpRst";
            // 
            // tabControlPanel_SetAgPos
            // 
            this.tabControlPanel_SetAgPos.AutoScroll = true;
            this.tabControlPanel_SetAgPos.AutoScrollMinSize = new System.Drawing.Size(480, 350);
            this.tabControlPanel_SetAgPos.Controls.Add(this.groupBox_Pic);
            this.tabControlPanel_SetAgPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetAgPos.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetAgPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetAgPos.Name = "tabControlPanel_SetAgPos";
            this.tabControlPanel_SetAgPos.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetAgPos.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_SetAgPos.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_SetAgPos.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_SetAgPos.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetAgPos.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_SetAgPos.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetAgPos.Style.GradientAngle = 90;
            this.tabControlPanel_SetAgPos.TabIndex = 5;
            this.tabControlPanel_SetAgPos.TabItem = this.tabItem_SetAgPos;
            // 
            // groupBox_Pic
            // 
            this.groupBox_Pic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Pic.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Pic.Controls.Add(this.button_CityPic);
            this.groupBox_Pic.Controls.Add(this.pictureBox_CityPic);
            this.groupBox_Pic.Location = new System.Drawing.Point(12, 32);
            this.groupBox_Pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Pic.Name = "groupBox_Pic";
            this.groupBox_Pic.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Pic.Size = new System.Drawing.Size(598, 431);
            this.groupBox_Pic.TabIndex = 13;
            this.groupBox_Pic.TabStop = false;
            this.groupBox_Pic.Text = "تصویر منطقه";
            // 
            // button_CityPic
            // 
            this.button_CityPic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_CityPic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_CityPic.Location = new System.Drawing.Point(79, 23);
            this.button_CityPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_CityPic.Name = "button_CityPic";
            this.button_CityPic.Size = new System.Drawing.Size(448, 26);
            this.button_CityPic.TabIndex = 9;
            this.button_CityPic.Text = "عکس شهر در صورت وجود";
            this.button_CityPic.Click += new System.EventHandler(this.button_AgencyLogo_Click);
            // 
            // pictureBox_CityPic
            // 
            this.pictureBox_CityPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_CityPic.Location = new System.Drawing.Point(18, 65);
            this.pictureBox_CityPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_CityPic.Name = "pictureBox_CityPic";
            this.pictureBox_CityPic.Size = new System.Drawing.Size(570, 349);
            this.pictureBox_CityPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CityPic.TabIndex = 8;
            this.pictureBox_CityPic.TabStop = false;
            // 
            // tabItem_SetAgPos
            // 
            this.tabItem_SetAgPos.AttachedControl = this.tabControlPanel_SetAgPos;
            this.tabItem_SetAgPos.Name = "tabItem_SetAgPos";
            this.tabItem_SetAgPos.Text = "tabItem_SetAgPos";
            // 
            // tabControlPanel_SetAgReg
            // 
            this.tabControlPanel_SetAgReg.AutoScroll = true;
            this.tabControlPanel_SetAgReg.AutoScrollMinSize = new System.Drawing.Size(600, 450);
            this.tabControlPanel_SetAgReg.Controls.Add(this.groupBox_Reg);
            this.tabControlPanel_SetAgReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetAgReg.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetAgReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetAgReg.Name = "tabControlPanel_SetAgReg";
            this.tabControlPanel_SetAgReg.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetAgReg.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_SetAgReg.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_SetAgReg.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_SetAgReg.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetAgReg.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_SetAgReg.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetAgReg.Style.GradientAngle = 90;
            this.tabControlPanel_SetAgReg.TabIndex = 4;
            this.tabControlPanel_SetAgReg.TabItem = this.tabItem_SetAgReg;
            // 
            // groupBox_Reg
            // 
            this.groupBox_Reg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_Reg.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Reg.Controls.Add(this.textBox_AgEmail);
            this.groupBox_Reg.Controls.Add(this.label26);
            this.groupBox_Reg.Controls.Add(this.textBox_AdminAgName);
            this.groupBox_Reg.Controls.Add(this.label24);
            this.groupBox_Reg.Controls.Add(this.textBox_AgencyAddress);
            this.groupBox_Reg.Controls.Add(this.label2);
            this.groupBox_Reg.Controls.Add(this.button_AgencyLogo);
            this.groupBox_Reg.Controls.Add(this.pictureBox_AgencyLogo);
            this.groupBox_Reg.Controls.Add(this.textBox_AgancyMobile);
            this.groupBox_Reg.Controls.Add(this.textBox_AgancyTel);
            this.groupBox_Reg.Controls.Add(this.textBox_AgancyName);
            this.groupBox_Reg.Controls.Add(this.label_AgancyMobile);
            this.groupBox_Reg.Controls.Add(this.label_AgancyTel);
            this.groupBox_Reg.Controls.Add(this.label_AgancyName);
            this.groupBox_Reg.Location = new System.Drawing.Point(15, 27);
            this.groupBox_Reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Reg.Name = "groupBox_Reg";
            this.groupBox_Reg.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Reg.Size = new System.Drawing.Size(598, 435);
            this.groupBox_Reg.TabIndex = 0;
            this.groupBox_Reg.TabStop = false;
            this.groupBox_Reg.Text = "موارد ثبتی";
            // 
            // textBox_AgEmail
            // 
            this.textBox_AgEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_AgEmail.Border.Class = "TextBoxBorder";
            this.textBox_AgEmail.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AgEmail.ForeColor = System.Drawing.Color.Black;
            this.textBox_AgEmail.Location = new System.Drawing.Point(73, 393);
            this.textBox_AgEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AgEmail.MaxLength = 0;
            this.textBox_AgEmail.Name = "textBox_AgEmail";
            this.textBox_AgEmail.Size = new System.Drawing.Size(358, 22);
            this.textBox_AgEmail.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(480, 396);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 14);
            this.label26.TabIndex = 13;
            this.label26.Text = "Email:";
            // 
            // textBox_AdminAgName
            // 
            this.textBox_AdminAgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_AdminAgName.Border.Class = "TextBoxBorder";
            this.textBox_AdminAgName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AdminAgName.ForeColor = System.Drawing.Color.Black;
            this.textBox_AdminAgName.Location = new System.Drawing.Point(129, 63);
            this.textBox_AdminAgName.MaxLength = 50;
            this.textBox_AdminAgName.Name = "textBox_AdminAgName";
            this.textBox_AdminAgName.Size = new System.Drawing.Size(268, 22);
            this.textBox_AdminAgName.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(410, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 14);
            this.label24.TabIndex = 11;
            this.label24.Text = "نام مدیریت:";
            // 
            // textBox_AgencyAddress
            // 
            this.textBox_AgencyAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_AgencyAddress.Border.Class = "TextBoxBorder";
            this.textBox_AgencyAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AgencyAddress.ForeColor = System.Drawing.Color.Black;
            this.textBox_AgencyAddress.Location = new System.Drawing.Point(18, 326);
            this.textBox_AgencyAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AgencyAddress.MaxLength = 0;
            this.textBox_AgencyAddress.Multiline = true;
            this.textBox_AgencyAddress.Name = "textBox_AgencyAddress";
            this.textBox_AgencyAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_AgencyAddress.Size = new System.Drawing.Size(563, 49);
            this.textBox_AgencyAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "آدرس دفتر:";
            // 
            // button_AgencyLogo
            // 
            this.button_AgencyLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_AgencyLogo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_AgencyLogo.Location = new System.Drawing.Point(354, 114);
            this.button_AgencyLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AgencyLogo.Name = "button_AgencyLogo";
            this.button_AgencyLogo.Size = new System.Drawing.Size(74, 89);
            this.button_AgencyLogo.TabIndex = 1;
            this.button_AgencyLogo.Text = "آرم یا لوگوی ثبت شده آژانس";
            this.button_AgencyLogo.Click += new System.EventHandler(this.button_AgencyLogo_Click);
            // 
            // pictureBox_AgencyLogo
            // 
            this.pictureBox_AgencyLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_AgencyLogo.Location = new System.Drawing.Point(172, 106);
            this.pictureBox_AgencyLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_AgencyLogo.Name = "pictureBox_AgencyLogo";
            this.pictureBox_AgencyLogo.Size = new System.Drawing.Size(176, 108);
            this.pictureBox_AgencyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_AgencyLogo.TabIndex = 7;
            this.pictureBox_AgencyLogo.TabStop = false;
            // 
            // textBox_AgancyMobile
            // 
            this.textBox_AgancyMobile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_AgancyMobile.Border.Class = "TextBoxBorder";
            this.textBox_AgancyMobile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AgancyMobile.ForeColor = System.Drawing.Color.Black;
            this.textBox_AgancyMobile.Location = new System.Drawing.Point(18, 246);
            this.textBox_AgancyMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AgancyMobile.MaxLength = 0;
            this.textBox_AgancyMobile.Multiline = true;
            this.textBox_AgancyMobile.Name = "textBox_AgancyMobile";
            this.textBox_AgancyMobile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_AgancyMobile.Size = new System.Drawing.Size(262, 49);
            this.textBox_AgancyMobile.TabIndex = 3;
            // 
            // textBox_AgancyTel
            // 
            this.textBox_AgancyTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_AgancyTel.Border.Class = "TextBoxBorder";
            this.textBox_AgancyTel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AgancyTel.ForeColor = System.Drawing.Color.Black;
            this.textBox_AgancyTel.Location = new System.Drawing.Point(318, 246);
            this.textBox_AgancyTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AgancyTel.MaxLength = 0;
            this.textBox_AgancyTel.Multiline = true;
            this.textBox_AgancyTel.Name = "textBox_AgancyTel";
            this.textBox_AgancyTel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_AgancyTel.Size = new System.Drawing.Size(262, 49);
            this.textBox_AgancyTel.TabIndex = 2;
            // 
            // textBox_AgancyName
            // 
            this.textBox_AgancyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_AgancyName.Border.Class = "TextBoxBorder";
            this.textBox_AgancyName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AgancyName.ForeColor = System.Drawing.Color.Black;
            this.textBox_AgancyName.Location = new System.Drawing.Point(129, 31);
            this.textBox_AgancyName.MaxLength = 50;
            this.textBox_AgancyName.Name = "textBox_AgancyName";
            this.textBox_AgancyName.Size = new System.Drawing.Size(268, 22);
            this.textBox_AgancyName.TabIndex = 0;
            // 
            // label_AgancyMobile
            // 
            this.label_AgancyMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AgancyMobile.AutoSize = true;
            this.label_AgancyMobile.Location = new System.Drawing.Point(212, 227);
            this.label_AgancyMobile.Name = "label_AgancyMobile";
            this.label_AgancyMobile.Size = new System.Drawing.Size(57, 14);
            this.label_AgancyMobile.TabIndex = 3;
            this.label_AgancyMobile.Text = "موبایل ها:";
            // 
            // label_AgancyTel
            // 
            this.label_AgancyTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AgancyTel.AutoSize = true;
            this.label_AgancyTel.Location = new System.Drawing.Point(519, 227);
            this.label_AgancyTel.Name = "label_AgancyTel";
            this.label_AgancyTel.Size = new System.Drawing.Size(49, 14);
            this.label_AgancyTel.TabIndex = 2;
            this.label_AgancyTel.Text = "تلفن ها:";
            // 
            // label_AgancyName
            // 
            this.label_AgancyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AgancyName.AutoSize = true;
            this.label_AgancyName.Location = new System.Drawing.Point(410, 37);
            this.label_AgancyName.Name = "label_AgancyName";
            this.label_AgancyName.Size = new System.Drawing.Size(25, 14);
            this.label_AgancyName.TabIndex = 1;
            this.label_AgancyName.Text = "نام:";
            // 
            // tabItem_SetAgReg
            // 
            this.tabItem_SetAgReg.AttachedControl = this.tabControlPanel_SetAgReg;
            this.tabItem_SetAgReg.Name = "tabItem_SetAgReg";
            this.tabItem_SetAgReg.Text = "tabItem_SetAgReg";
            // 
            // tabControlPanel_SetUseHouse
            // 
            this.tabControlPanel_SetUseHouse.AutoScroll = true;
            this.tabControlPanel_SetUseHouse.AutoScrollMinSize = new System.Drawing.Size(570, 470);
            this.tabControlPanel_SetUseHouse.Controls.Add(this.groupPanel_ReqFor);
            this.tabControlPanel_SetUseHouse.Controls.Add(this.groupPanel_TypeHouse);
            this.tabControlPanel_SetUseHouse.Controls.Add(this.groupPanel_HouseFor);
            this.tabControlPanel_SetUseHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetUseHouse.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetUseHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetUseHouse.Name = "tabControlPanel_SetUseHouse";
            this.tabControlPanel_SetUseHouse.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetUseHouse.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_SetUseHouse.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_SetUseHouse.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_SetUseHouse.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetUseHouse.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_SetUseHouse.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetUseHouse.Style.GradientAngle = 90;
            this.tabControlPanel_SetUseHouse.TabIndex = 3;
            this.tabControlPanel_SetUseHouse.TabItem = this.tabItem_SetUseHouse;
            // 
            // groupPanel_ReqFor
            // 
            this.groupPanel_ReqFor.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_ReqFor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_ReqFor.Controls.Add(this.comboBox_AddRF);
            this.groupPanel_ReqFor.Controls.Add(this.button_AddRF);
            this.groupPanel_ReqFor.Controls.Add(this.button_DelRF);
            this.groupPanel_ReqFor.Controls.Add(this.button_UpRF);
            this.groupPanel_ReqFor.Controls.Add(this.button_DownRF);
            this.groupPanel_ReqFor.Controls.Add(this.listBox_ReqFor);
            this.groupPanel_ReqFor.Location = new System.Drawing.Point(14, 24);
            this.groupPanel_ReqFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_ReqFor.Name = "groupPanel_ReqFor";
            this.groupPanel_ReqFor.Size = new System.Drawing.Size(192, 447);
            // 
            // 
            // 
            this.groupPanel_ReqFor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_ReqFor.Style.BackColorGradientAngle = 90;
            this.groupPanel_ReqFor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_ReqFor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_ReqFor.Style.BorderBottomWidth = 1;
            this.groupPanel_ReqFor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_ReqFor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_ReqFor.Style.BorderLeftWidth = 1;
            this.groupPanel_ReqFor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_ReqFor.Style.BorderRightWidth = 1;
            this.groupPanel_ReqFor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_ReqFor.Style.BorderTopWidth = 1;
            this.groupPanel_ReqFor.Style.CornerDiameter = 4;
            this.groupPanel_ReqFor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_ReqFor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_ReqFor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_ReqFor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_ReqFor.TabIndex = 26;
            this.groupPanel_ReqFor.Text = "درخواست جهت";
            // 
            // comboBox_AddRF
            // 
            this.comboBox_AddRF.ForeColor = System.Drawing.Color.Black;
            this.comboBox_AddRF.FormattingEnabled = true;
            this.comboBox_AddRF.IntegralHeight = false;
            this.comboBox_AddRF.Items.AddRange(new object[] {
            "خرید",
            "رهن و اجاره",
            "رهن",
            "اجاره",
            "پیش خرید",
            "مشارکت",
            "معاوضه"});
            this.comboBox_AddRF.Location = new System.Drawing.Point(41, 294);
            this.comboBox_AddRF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_AddRF.Name = "comboBox_AddRF";
            this.comboBox_AddRF.Size = new System.Drawing.Size(114, 22);
            this.comboBox_AddRF.TabIndex = 29;
            // 
            // button_AddRF
            // 
            this.button_AddRF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_AddRF.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_AddRF.Image = ((System.Drawing.Image)(resources.GetObject("button_AddRF.Image")));
            this.button_AddRF.Location = new System.Drawing.Point(52, 324);
            this.button_AddRF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AddRF.Name = "button_AddRF";
            this.button_AddRF.Size = new System.Drawing.Size(90, 19);
            this.button_AddRF.TabIndex = 28;
            this.button_AddRF.Text = "اضافه";
            this.button_AddRF.Click += new System.EventHandler(this.button_AddTH_Click);
            // 
            // button_DelRF
            // 
            this.button_DelRF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_DelRF.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_DelRF.Image = ((System.Drawing.Image)(resources.GetObject("button_DelRF.Image")));
            this.button_DelRF.Location = new System.Drawing.Point(52, 376);
            this.button_DelRF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DelRF.Name = "button_DelRF";
            this.button_DelRF.Size = new System.Drawing.Size(90, 19);
            this.button_DelRF.TabIndex = 27;
            this.button_DelRF.Text = "حذف";
            this.button_DelRF.Click += new System.EventHandler(this.button_DelTH_Click);
            // 
            // button_UpRF
            // 
            this.button_UpRF.Image = ((System.Drawing.Image)(resources.GetObject("button_UpRF.Image")));
            this.button_UpRF.Location = new System.Drawing.Point(15, 89);
            this.button_UpRF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_UpRF.Name = "button_UpRF";
            this.button_UpRF.Size = new System.Drawing.Size(21, 30);
            this.button_UpRF.TabIndex = 26;
            this.button_UpRF.UseVisualStyleBackColor = true;
            this.button_UpRF.Click += new System.EventHandler(this.button_UpTH_Click);
            // 
            // button_DownRF
            // 
            this.button_DownRF.Image = ((System.Drawing.Image)(resources.GetObject("button_DownRF.Image")));
            this.button_DownRF.Location = new System.Drawing.Point(15, 124);
            this.button_DownRF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DownRF.Name = "button_DownRF";
            this.button_DownRF.Size = new System.Drawing.Size(21, 30);
            this.button_DownRF.TabIndex = 25;
            this.button_DownRF.UseVisualStyleBackColor = true;
            this.button_DownRF.Click += new System.EventHandler(this.button_DownTH_Click);
            // 
            // listBox_ReqFor
            // 
            this.listBox_ReqFor.FormattingEnabled = true;
            this.listBox_ReqFor.ItemHeight = 14;
            this.listBox_ReqFor.Items.AddRange(new object[] {
            "خرید",
            "رهن و اجاره",
            "رهن",
            "اجاره",
            "پیش خرید",
            "مشارکت",
            "معاوضه"});
            this.listBox_ReqFor.Location = new System.Drawing.Point(41, 17);
            this.listBox_ReqFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_ReqFor.Name = "listBox_ReqFor";
            this.listBox_ReqFor.Size = new System.Drawing.Size(114, 256);
            this.listBox_ReqFor.TabIndex = 20;
            // 
            // groupPanel_TypeHouse
            // 
            this.groupPanel_TypeHouse.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_TypeHouse.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_TypeHouse.Controls.Add(this.comboBox_AddTH);
            this.groupPanel_TypeHouse.Controls.Add(this.button_AddTH);
            this.groupPanel_TypeHouse.Controls.Add(this.button_DelTH);
            this.groupPanel_TypeHouse.Controls.Add(this.button_UpTH);
            this.groupPanel_TypeHouse.Controls.Add(this.button_DownTH);
            this.groupPanel_TypeHouse.Controls.Add(this.listBox_TypeHouse);
            this.groupPanel_TypeHouse.Location = new System.Drawing.Point(424, 24);
            this.groupPanel_TypeHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_TypeHouse.Name = "groupPanel_TypeHouse";
            this.groupPanel_TypeHouse.Size = new System.Drawing.Size(192, 447);
            // 
            // 
            // 
            this.groupPanel_TypeHouse.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_TypeHouse.Style.BackColorGradientAngle = 90;
            this.groupPanel_TypeHouse.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_TypeHouse.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_TypeHouse.Style.BorderBottomWidth = 1;
            this.groupPanel_TypeHouse.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_TypeHouse.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_TypeHouse.Style.BorderLeftWidth = 1;
            this.groupPanel_TypeHouse.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_TypeHouse.Style.BorderRightWidth = 1;
            this.groupPanel_TypeHouse.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_TypeHouse.Style.BorderTopWidth = 1;
            this.groupPanel_TypeHouse.Style.CornerDiameter = 4;
            this.groupPanel_TypeHouse.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_TypeHouse.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_TypeHouse.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_TypeHouse.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_TypeHouse.TabIndex = 25;
            this.groupPanel_TypeHouse.Text = "تعیین نوع ملک";
            // 
            // comboBox_AddTH
            // 
            this.comboBox_AddTH.ForeColor = System.Drawing.Color.Black;
            this.comboBox_AddTH.FormattingEnabled = true;
            this.comboBox_AddTH.IntegralHeight = false;
            this.comboBox_AddTH.Items.AddRange(new object[] {
            "آپارتمان",
            "اتاق اداری",
            "سوئیت",
            "خانه",
            "کلنگی",
            "مستغلات",
            "ویلا",
            "دفترکار",
            "مغازه",
            "کانکس",
            "زیرپله",
            "زمین",
            "زمین نیمه کاره",
            "انبار",
            "باغ",
            "باغچه",
            "کارخانه",
            "کارگاه",
            "سوله",
            "سالن",
            "گاوداری",
            "مرغداری"});
            this.comboBox_AddTH.Location = new System.Drawing.Point(41, 294);
            this.comboBox_AddTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_AddTH.Name = "comboBox_AddTH";
            this.comboBox_AddTH.Size = new System.Drawing.Size(114, 22);
            this.comboBox_AddTH.TabIndex = 24;
            // 
            // button_AddTH
            // 
            this.button_AddTH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_AddTH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_AddTH.Image = ((System.Drawing.Image)(resources.GetObject("button_AddTH.Image")));
            this.button_AddTH.Location = new System.Drawing.Point(55, 324);
            this.button_AddTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AddTH.Name = "button_AddTH";
            this.button_AddTH.Size = new System.Drawing.Size(90, 19);
            this.button_AddTH.TabIndex = 22;
            this.button_AddTH.Text = "اضافه";
            this.button_AddTH.Click += new System.EventHandler(this.button_AddTH_Click);
            // 
            // button_DelTH
            // 
            this.button_DelTH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_DelTH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_DelTH.Image = ((System.Drawing.Image)(resources.GetObject("button_DelTH.Image")));
            this.button_DelTH.Location = new System.Drawing.Point(55, 376);
            this.button_DelTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DelTH.Name = "button_DelTH";
            this.button_DelTH.Size = new System.Drawing.Size(90, 19);
            this.button_DelTH.TabIndex = 21;
            this.button_DelTH.Text = "حذف";
            this.button_DelTH.Click += new System.EventHandler(this.button_DelTH_Click);
            // 
            // button_UpTH
            // 
            this.button_UpTH.Image = ((System.Drawing.Image)(resources.GetObject("button_UpTH.Image")));
            this.button_UpTH.Location = new System.Drawing.Point(16, 89);
            this.button_UpTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_UpTH.Name = "button_UpTH";
            this.button_UpTH.Size = new System.Drawing.Size(21, 30);
            this.button_UpTH.TabIndex = 20;
            this.button_UpTH.UseVisualStyleBackColor = true;
            this.button_UpTH.Click += new System.EventHandler(this.button_UpTH_Click);
            // 
            // button_DownTH
            // 
            this.button_DownTH.Image = ((System.Drawing.Image)(resources.GetObject("button_DownTH.Image")));
            this.button_DownTH.Location = new System.Drawing.Point(16, 124);
            this.button_DownTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DownTH.Name = "button_DownTH";
            this.button_DownTH.Size = new System.Drawing.Size(21, 30);
            this.button_DownTH.TabIndex = 19;
            this.button_DownTH.UseVisualStyleBackColor = true;
            this.button_DownTH.Click += new System.EventHandler(this.button_DownTH_Click);
            // 
            // listBox_TypeHouse
            // 
            this.listBox_TypeHouse.ForeColor = System.Drawing.Color.Black;
            this.listBox_TypeHouse.FormattingEnabled = true;
            this.listBox_TypeHouse.IntegralHeight = false;
            this.listBox_TypeHouse.ItemHeight = 14;
            this.listBox_TypeHouse.Items.AddRange(new object[] {
            "آپارتمان",
            "اتاق اداری",
            "سوئیت",
            "خانه",
            "کلنگی",
            "مستغلات",
            "ویلا",
            "دفترکار",
            "مغازه",
            "کانکس",
            "زیرپله",
            "زمین",
            "زمین نیمه کاره",
            "انبار",
            "باغ",
            "باغچه",
            "کارخانه",
            "کارگاه",
            "سوله",
            "سالن",
            "گاوداری",
            "مرغداری"});
            this.listBox_TypeHouse.Location = new System.Drawing.Point(41, 17);
            this.listBox_TypeHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_TypeHouse.Name = "listBox_TypeHouse";
            this.listBox_TypeHouse.Size = new System.Drawing.Size(114, 256);
            this.listBox_TypeHouse.TabIndex = 18;
            // 
            // groupPanel_HouseFor
            // 
            this.groupPanel_HouseFor.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_HouseFor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_HouseFor.Controls.Add(this.comboBox_AddHF);
            this.groupPanel_HouseFor.Controls.Add(this.button_AddHF);
            this.groupPanel_HouseFor.Controls.Add(this.button_DelHF);
            this.groupPanel_HouseFor.Controls.Add(this.button_UpHF);
            this.groupPanel_HouseFor.Controls.Add(this.button_DownHF);
            this.groupPanel_HouseFor.Controls.Add(this.listBox_HouseFor);
            this.groupPanel_HouseFor.Location = new System.Drawing.Point(219, 24);
            this.groupPanel_HouseFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_HouseFor.Name = "groupPanel_HouseFor";
            this.groupPanel_HouseFor.Size = new System.Drawing.Size(192, 447);
            // 
            // 
            // 
            this.groupPanel_HouseFor.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_HouseFor.Style.BackColorGradientAngle = 90;
            this.groupPanel_HouseFor.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_HouseFor.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HouseFor.Style.BorderBottomWidth = 1;
            this.groupPanel_HouseFor.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_HouseFor.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HouseFor.Style.BorderLeftWidth = 1;
            this.groupPanel_HouseFor.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HouseFor.Style.BorderRightWidth = 1;
            this.groupPanel_HouseFor.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HouseFor.Style.BorderTopWidth = 1;
            this.groupPanel_HouseFor.Style.CornerDiameter = 4;
            this.groupPanel_HouseFor.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_HouseFor.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_HouseFor.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_HouseFor.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_HouseFor.TabIndex = 0;
            this.groupPanel_HouseFor.Text = "ملک جهت";
            // 
            // comboBox_AddHF
            // 
            this.comboBox_AddHF.ForeColor = System.Drawing.Color.Black;
            this.comboBox_AddHF.FormattingEnabled = true;
            this.comboBox_AddHF.IntegralHeight = false;
            this.comboBox_AddHF.Items.AddRange(new object[] {
            "فروش",
            "رهن و اجاره",
            "رهن",
            "اجاره",
            "پیش فروش",
            "مشارکت",
            "معاوضه"});
            this.comboBox_AddHF.Location = new System.Drawing.Point(42, 294);
            this.comboBox_AddHF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_AddHF.Name = "comboBox_AddHF";
            this.comboBox_AddHF.Size = new System.Drawing.Size(114, 22);
            this.comboBox_AddHF.TabIndex = 29;
            // 
            // button_AddHF
            // 
            this.button_AddHF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_AddHF.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_AddHF.Image = ((System.Drawing.Image)(resources.GetObject("button_AddHF.Image")));
            this.button_AddHF.Location = new System.Drawing.Point(55, 324);
            this.button_AddHF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AddHF.Name = "button_AddHF";
            this.button_AddHF.Size = new System.Drawing.Size(90, 19);
            this.button_AddHF.TabIndex = 28;
            this.button_AddHF.Text = "اضافه";
            this.button_AddHF.Click += new System.EventHandler(this.button_AddTH_Click);
            // 
            // button_DelHF
            // 
            this.button_DelHF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_DelHF.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_DelHF.Image = ((System.Drawing.Image)(resources.GetObject("button_DelHF.Image")));
            this.button_DelHF.Location = new System.Drawing.Point(55, 376);
            this.button_DelHF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DelHF.Name = "button_DelHF";
            this.button_DelHF.Size = new System.Drawing.Size(90, 19);
            this.button_DelHF.TabIndex = 27;
            this.button_DelHF.Text = "حذف";
            this.button_DelHF.Click += new System.EventHandler(this.button_DelTH_Click);
            // 
            // button_UpHF
            // 
            this.button_UpHF.Image = ((System.Drawing.Image)(resources.GetObject("button_UpHF.Image")));
            this.button_UpHF.Location = new System.Drawing.Point(17, 89);
            this.button_UpHF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_UpHF.Name = "button_UpHF";
            this.button_UpHF.Size = new System.Drawing.Size(21, 30);
            this.button_UpHF.TabIndex = 26;
            this.button_UpHF.UseVisualStyleBackColor = true;
            this.button_UpHF.Click += new System.EventHandler(this.button_UpTH_Click);
            // 
            // button_DownHF
            // 
            this.button_DownHF.Image = ((System.Drawing.Image)(resources.GetObject("button_DownHF.Image")));
            this.button_DownHF.Location = new System.Drawing.Point(17, 124);
            this.button_DownHF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DownHF.Name = "button_DownHF";
            this.button_DownHF.Size = new System.Drawing.Size(21, 30);
            this.button_DownHF.TabIndex = 25;
            this.button_DownHF.UseVisualStyleBackColor = true;
            this.button_DownHF.Click += new System.EventHandler(this.button_DownTH_Click);
            // 
            // listBox_HouseFor
            // 
            this.listBox_HouseFor.FormattingEnabled = true;
            this.listBox_HouseFor.ItemHeight = 14;
            this.listBox_HouseFor.Items.AddRange(new object[] {
            "فروش",
            "رهن و اجاره",
            "رهن",
            "اجاره",
            "پیش فروش",
            "مشارکت",
            "معاوضه"});
            this.listBox_HouseFor.Location = new System.Drawing.Point(42, 17);
            this.listBox_HouseFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_HouseFor.Name = "listBox_HouseFor";
            this.listBox_HouseFor.Size = new System.Drawing.Size(114, 256);
            this.listBox_HouseFor.TabIndex = 19;
            // 
            // tabItem_SetUseHouse
            // 
            this.tabItem_SetUseHouse.AttachedControl = this.tabControlPanel_SetUseHouse;
            this.tabItem_SetUseHouse.Name = "tabItem_SetUseHouse";
            this.tabItem_SetUseHouse.Text = "tabItem_SetUseHouse";
            // 
            // tabControlPanel_SetPosDef
            // 
            this.tabControlPanel_SetPosDef.AutoScroll = true;
            this.tabControlPanel_SetPosDef.AutoScrollMinSize = new System.Drawing.Size(580, 480);
            this.tabControlPanel_SetPosDef.Controls.Add(this.groupBox_PartSet);
            this.tabControlPanel_SetPosDef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetPosDef.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetPosDef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetPosDef.Name = "tabControlPanel_SetPosDef";
            this.tabControlPanel_SetPosDef.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetPosDef.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_SetPosDef.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_SetPosDef.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_SetPosDef.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetPosDef.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_SetPosDef.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetPosDef.Style.GradientAngle = 90;
            this.tabControlPanel_SetPosDef.TabIndex = 2;
            this.tabControlPanel_SetPosDef.TabItem = this.tabItem_SetPosDef;
            // 
            // groupBox_PartSet
            // 
            this.groupBox_PartSet.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_PartSet.Controls.Add(this.button_PartUpdate);
            this.groupBox_PartSet.Controls.Add(this.label16);
            this.groupBox_PartSet.Controls.Add(this.label15);
            this.groupBox_PartSet.Controls.Add(this.button_DelPrt);
            this.groupBox_PartSet.Controls.Add(this.textBox_NewPart);
            this.groupBox_PartSet.Controls.Add(this.label9);
            this.groupBox_PartSet.Controls.Add(this.button_AddPrt);
            this.groupBox_PartSet.Controls.Add(this.comboBox_Stt);
            this.groupBox_PartSet.Controls.Add(this.comboBox_Prt);
            this.groupBox_PartSet.Controls.Add(this.comboBox_Cntry);
            this.groupBox_PartSet.Controls.Add(this.label_Prt);
            this.groupBox_PartSet.Controls.Add(this.comboBox_Cty);
            this.groupBox_PartSet.Controls.Add(this.label_Cty);
            this.groupBox_PartSet.Controls.Add(this.label_Cntry);
            this.groupBox_PartSet.Controls.Add(this.label_Stt);
            this.groupBox_PartSet.Location = new System.Drawing.Point(27, 23);
            this.groupBox_PartSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_PartSet.Name = "groupBox_PartSet";
            this.groupBox_PartSet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_PartSet.Size = new System.Drawing.Size(577, 416);
            this.groupBox_PartSet.TabIndex = 13;
            this.groupBox_PartSet.TabStop = false;
            this.groupBox_PartSet.Text = "حذف و اضافه منطقه و به روز رسانی";
            // 
            // button_PartUpdate
            // 
            this.button_PartUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_PartUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_PartUpdate.Image = ((System.Drawing.Image)(resources.GetObject("button_PartUpdate.Image")));
            this.button_PartUpdate.Location = new System.Drawing.Point(109, 354);
            this.button_PartUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_PartUpdate.Name = "button_PartUpdate";
            this.button_PartUpdate.Size = new System.Drawing.Size(358, 46);
            this.button_PartUpdate.TabIndex = 54;
            this.button_PartUpdate.Text = "به روز رسانی مناطق";
            this.button_PartUpdate.Click += new System.EventHandler(this.button_PartUpdate_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGreen;
            this.label16.Location = new System.Drawing.Point(63, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(450, 19);
            this.label16.TabIndex = 53;
            this.label16.Text = "توجه داشته باشید به روزرسانی براساس بانک کشوری مناطق شهری می باشد.";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(35, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(507, 19);
            this.label15.TabIndex = 52;
            this.label15.Text = "«به روز رسانی منطقه ها بر اساس کشور و استان و شهر مشخص شده»";
            // 
            // button_DelPrt
            // 
            this.button_DelPrt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_DelPrt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_DelPrt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DelPrt.Image = ((System.Drawing.Image)(resources.GetObject("button_DelPrt.Image")));
            this.button_DelPrt.Location = new System.Drawing.Point(341, 184);
            this.button_DelPrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DelPrt.Name = "button_DelPrt";
            this.button_DelPrt.Size = new System.Drawing.Size(193, 46);
            this.button_DelPrt.TabIndex = 51;
            this.button_DelPrt.Text = "حذف منطقه";
            this.button_DelPrt.Click += new System.EventHandler(this.button_DelPrt_Click);
            // 
            // textBox_NewPart
            // 
            this.textBox_NewPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_NewPart.Border.Class = "TextBoxBorder";
            this.textBox_NewPart.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPart.ForeColor = System.Drawing.Color.Black;
            this.textBox_NewPart.Location = new System.Drawing.Point(23, 184);
            this.textBox_NewPart.MaxLength = 50;
            this.textBox_NewPart.Name = "textBox_NewPart";
            this.textBox_NewPart.Size = new System.Drawing.Size(268, 22);
            this.textBox_NewPart.TabIndex = 50;
            this.textBox_NewPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(35, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 35);
            this.label9.TabIndex = 49;
            this.label9.Text = "نام منطقه جدید بر اساس کشور و استان و شهر مشخص شده:";
            // 
            // button_AddPrt
            // 
            this.button_AddPrt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_AddPrt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_AddPrt.Image = ((System.Drawing.Image)(resources.GetObject("button_AddPrt.Image")));
            this.button_AddPrt.Location = new System.Drawing.Point(68, 215);
            this.button_AddPrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_AddPrt.Name = "button_AddPrt";
            this.button_AddPrt.Size = new System.Drawing.Size(160, 46);
            this.button_AddPrt.TabIndex = 48;
            this.button_AddPrt.Text = "اضافه کردن منطقه";
            this.button_AddPrt.Click += new System.EventHandler(this.button_AddPrt_Click);
            // 
            // comboBox_Stt
            // 
            this.comboBox_Stt.DisplayMember = "StateName_Fa";
            this.comboBox_Stt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Stt.DropDownHeight = 100;
            this.comboBox_Stt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Stt.DropDownWidth = 150;
            this.comboBox_Stt.FocusHighlightEnabled = true;
            this.comboBox_Stt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Stt.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Stt.FormattingEnabled = true;
            this.comboBox_Stt.IntegralHeight = false;
            this.comboBox_Stt.ItemHeight = 20;
            this.comboBox_Stt.Location = new System.Drawing.Point(207, 58);
            this.comboBox_Stt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Stt.MaxDropDownItems = 15;
            this.comboBox_Stt.Name = "comboBox_Stt";
            this.comboBox_Stt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Stt.Size = new System.Drawing.Size(162, 26);
            this.comboBox_Stt.TabIndex = 1;
            this.comboBox_Stt.Tag = "0";
            this.comboBox_Stt.ValueMember = "StateID";
            this.comboBox_Stt.Enter += new System.EventHandler(this.comboBox_Stt_Enter);
            this.comboBox_Stt.Leave += new System.EventHandler(this.comboBox_Stt_Leave);
            // 
            // comboBox_Prt
            // 
            this.comboBox_Prt.DisplayMember = "PartName_Fa";
            this.comboBox_Prt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Prt.DropDownHeight = 100;
            this.comboBox_Prt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Prt.DropDownWidth = 150;
            this.comboBox_Prt.FocusHighlightEnabled = true;
            this.comboBox_Prt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Prt.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Prt.FormattingEnabled = true;
            this.comboBox_Prt.IntegralHeight = false;
            this.comboBox_Prt.ItemHeight = 20;
            this.comboBox_Prt.Location = new System.Drawing.Point(117, 103);
            this.comboBox_Prt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Prt.Name = "comboBox_Prt";
            this.comboBox_Prt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Prt.Size = new System.Drawing.Size(252, 26);
            this.comboBox_Prt.TabIndex = 3;
            this.comboBox_Prt.Tag = "0";
            this.comboBox_Prt.ValueMember = "PartID";
            this.comboBox_Prt.Enter += new System.EventHandler(this.comboBox_Prt_Enter);
            // 
            // comboBox_Cntry
            // 
            this.comboBox_Cntry.DisplayMember = "CountryName_Fa";
            this.comboBox_Cntry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Cntry.DropDownHeight = 100;
            this.comboBox_Cntry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cntry.DropDownWidth = 150;
            this.comboBox_Cntry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Cntry.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Cntry.FormattingEnabled = true;
            this.comboBox_Cntry.IntegralHeight = false;
            this.comboBox_Cntry.ItemHeight = 20;
            this.comboBox_Cntry.Location = new System.Drawing.Point(397, 58);
            this.comboBox_Cntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Cntry.MaxDropDownItems = 15;
            this.comboBox_Cntry.Name = "comboBox_Cntry";
            this.comboBox_Cntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Cntry.Size = new System.Drawing.Size(162, 26);
            this.comboBox_Cntry.TabIndex = 0;
            this.comboBox_Cntry.Tag = "0";
            this.comboBox_Cntry.ValueMember = "CountryID";
            this.comboBox_Cntry.Enter += new System.EventHandler(this.comboBox_Cntry_Enter);
            this.comboBox_Cntry.Leave += new System.EventHandler(this.comboBox_Cntry_Leave);
            // 
            // label_Prt
            // 
            this.label_Prt.AutoSize = true;
            this.label_Prt.BackColor = System.Drawing.Color.Transparent;
            this.label_Prt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Prt.ForeColor = System.Drawing.Color.Black;
            this.label_Prt.Location = new System.Drawing.Point(385, 109);
            this.label_Prt.Name = "label_Prt";
            this.label_Prt.Size = new System.Drawing.Size(42, 14);
            this.label_Prt.TabIndex = 47;
            this.label_Prt.Text = "منطقه:";
            // 
            // comboBox_Cty
            // 
            this.comboBox_Cty.DisplayMember = "CityName_Fa";
            this.comboBox_Cty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Cty.DropDownHeight = 100;
            this.comboBox_Cty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cty.DropDownWidth = 150;
            this.comboBox_Cty.FocusHighlightEnabled = true;
            this.comboBox_Cty.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Cty.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Cty.FormattingEnabled = true;
            this.comboBox_Cty.IntegralHeight = false;
            this.comboBox_Cty.ItemHeight = 20;
            this.comboBox_Cty.Location = new System.Drawing.Point(18, 58);
            this.comboBox_Cty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Cty.MaxDropDownItems = 15;
            this.comboBox_Cty.Name = "comboBox_Cty";
            this.comboBox_Cty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Cty.Size = new System.Drawing.Size(162, 26);
            this.comboBox_Cty.TabIndex = 2;
            this.comboBox_Cty.Tag = "0";
            this.comboBox_Cty.ValueMember = "CityID";
            this.comboBox_Cty.Enter += new System.EventHandler(this.comboBox_Cty_Enter);
            this.comboBox_Cty.Leave += new System.EventHandler(this.comboBox_Cty_Leave);
            // 
            // label_Cty
            // 
            this.label_Cty.AutoSize = true;
            this.label_Cty.BackColor = System.Drawing.Color.Transparent;
            this.label_Cty.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cty.ForeColor = System.Drawing.Color.Black;
            this.label_Cty.Location = new System.Drawing.Point(117, 35);
            this.label_Cty.Name = "label_Cty";
            this.label_Cty.Size = new System.Drawing.Size(53, 14);
            this.label_Cty.TabIndex = 46;
            this.label_Cty.Text = "نام شهر:";
            // 
            // label_Cntry
            // 
            this.label_Cntry.AutoSize = true;
            this.label_Cntry.BackColor = System.Drawing.Color.Transparent;
            this.label_Cntry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cntry.ForeColor = System.Drawing.Color.Black;
            this.label_Cntry.Location = new System.Drawing.Point(491, 35);
            this.label_Cntry.Name = "label_Cntry";
            this.label_Cntry.Size = new System.Drawing.Size(57, 14);
            this.label_Cntry.TabIndex = 41;
            this.label_Cntry.Text = "نام کشور:";
            // 
            // label_Stt
            // 
            this.label_Stt.AutoSize = true;
            this.label_Stt.BackColor = System.Drawing.Color.Transparent;
            this.label_Stt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Stt.ForeColor = System.Drawing.Color.Black;
            this.label_Stt.Location = new System.Drawing.Point(297, 35);
            this.label_Stt.Name = "label_Stt";
            this.label_Stt.Size = new System.Drawing.Size(60, 14);
            this.label_Stt.TabIndex = 45;
            this.label_Stt.Text = "نام استان:";
            // 
            // tabItem_SetPosDef
            // 
            this.tabItem_SetPosDef.AttachedControl = this.tabControlPanel_SetPosDef;
            this.tabItem_SetPosDef.Name = "tabItem_SetPosDef";
            this.tabItem_SetPosDef.Text = "tabItem_SetPosDef";
            // 
            // tabControlPanel_FsetHouse
            // 
            this.tabControlPanel_FsetHouse.AutoScroll = true;
            this.tabControlPanel_FsetHouse.AutoScrollMinSize = new System.Drawing.Size(550, 450);
            this.tabControlPanel_FsetHouse.Controls.Add(this.groupPanel_Instalation);
            this.tabControlPanel_FsetHouse.Controls.Add(this.groupPanel_RegH);
            this.tabControlPanel_FsetHouse.Controls.Add(this.groupPanel_Part);
            this.tabControlPanel_FsetHouse.Controls.Add(this.groupPanel_StatusH);
            this.tabControlPanel_FsetHouse.Controls.Add(this.groupPanel_facility);
            this.tabControlPanel_FsetHouse.Controls.Add(this.groupPanel_StsFile);
            this.tabControlPanel_FsetHouse.Controls.Add(this.groupPanel_House);
            this.tabControlPanel_FsetHouse.Controls.Add(this.groupPanel_Ctrl);
            this.tabControlPanel_FsetHouse.Controls.Add(this.checkBox_IsDefaltValue);
            this.tabControlPanel_FsetHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_FsetHouse.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_FsetHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_FsetHouse.Name = "tabControlPanel_FsetHouse";
            this.tabControlPanel_FsetHouse.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_FsetHouse.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_FsetHouse.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_FsetHouse.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_FsetHouse.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_FsetHouse.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_FsetHouse.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_FsetHouse.Style.GradientAngle = 90;
            this.tabControlPanel_FsetHouse.TabIndex = 1;
            this.tabControlPanel_FsetHouse.TabItem = this.tabItem_FsetHouse;
            // 
            // groupPanel_Instalation
            // 
            this.groupPanel_Instalation.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Instalation.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Water);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Electricity);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Gaz);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Cooler);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_FanCoel);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Heat);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Chiler);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Pakage);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Sauna);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Jacuzzi);
            this.groupPanel_Instalation.Controls.Add(this.checkBox_Pool);
            this.groupPanel_Instalation.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_Instalation.Location = new System.Drawing.Point(5, 263);
            this.groupPanel_Instalation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Instalation.Name = "groupPanel_Instalation";
            this.groupPanel_Instalation.Size = new System.Drawing.Size(306, 100);
            // 
            // 
            // 
            this.groupPanel_Instalation.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Instalation.Style.BackColorGradientAngle = 90;
            this.groupPanel_Instalation.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Instalation.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Instalation.Style.BorderBottomWidth = 1;
            this.groupPanel_Instalation.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Instalation.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Instalation.Style.BorderLeftWidth = 1;
            this.groupPanel_Instalation.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Instalation.Style.BorderRightWidth = 1;
            this.groupPanel_Instalation.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Instalation.Style.BorderTopWidth = 1;
            this.groupPanel_Instalation.Style.CornerDiameter = 4;
            this.groupPanel_Instalation.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Instalation.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Instalation.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Instalation.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_Instalation.TabIndex = 7;
            this.groupPanel_Instalation.Text = "تاسیسات";
            // 
            // checkBox_Water
            // 
            this.checkBox_Water.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Water.AutoSize = true;
            this.checkBox_Water.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Water.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Water.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Water.Location = new System.Drawing.Point(276, 6);
            this.checkBox_Water.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Water.Name = "checkBox_Water";
            this.checkBox_Water.Size = new System.Drawing.Size(24, 32);
            this.checkBox_Water.TabIndex = 0;
            this.checkBox_Water.Text = "آب";
            this.checkBox_Water.UseVisualStyleBackColor = false;
            // 
            // checkBox_Electricity
            // 
            this.checkBox_Electricity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Electricity.AutoSize = true;
            this.checkBox_Electricity.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Electricity.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Electricity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Electricity.Location = new System.Drawing.Point(231, 6);
            this.checkBox_Electricity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Electricity.Name = "checkBox_Electricity";
            this.checkBox_Electricity.Size = new System.Drawing.Size(29, 32);
            this.checkBox_Electricity.TabIndex = 1;
            this.checkBox_Electricity.Text = "برق";
            this.checkBox_Electricity.UseVisualStyleBackColor = false;
            // 
            // checkBox_Gaz
            // 
            this.checkBox_Gaz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Gaz.AutoSize = true;
            this.checkBox_Gaz.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Gaz.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Gaz.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Gaz.Location = new System.Drawing.Point(187, 6);
            this.checkBox_Gaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Gaz.Name = "checkBox_Gaz";
            this.checkBox_Gaz.Size = new System.Drawing.Size(25, 32);
            this.checkBox_Gaz.TabIndex = 2;
            this.checkBox_Gaz.Text = "گاز";
            this.checkBox_Gaz.UseVisualStyleBackColor = false;
            // 
            // checkBox_Cooler
            // 
            this.checkBox_Cooler.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Cooler.AutoSize = true;
            this.checkBox_Cooler.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Cooler.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Cooler.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Cooler.Location = new System.Drawing.Point(141, 6);
            this.checkBox_Cooler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Cooler.Name = "checkBox_Cooler";
            this.checkBox_Cooler.Size = new System.Drawing.Size(30, 32);
            this.checkBox_Cooler.TabIndex = 3;
            this.checkBox_Cooler.Text = "کولر";
            this.checkBox_Cooler.UseVisualStyleBackColor = false;
            // 
            // checkBox_FanCoel
            // 
            this.checkBox_FanCoel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_FanCoel.AutoSize = true;
            this.checkBox_FanCoel.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_FanCoel.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_FanCoel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_FanCoel.Location = new System.Drawing.Point(69, 6);
            this.checkBox_FanCoel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_FanCoel.Name = "checkBox_FanCoel";
            this.checkBox_FanCoel.Size = new System.Drawing.Size(52, 32);
            this.checkBox_FanCoel.TabIndex = 4;
            this.checkBox_FanCoel.Text = "فن کوئل";
            this.checkBox_FanCoel.UseVisualStyleBackColor = false;
            // 
            // checkBox_Heat
            // 
            this.checkBox_Heat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Heat.AutoSize = true;
            this.checkBox_Heat.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Heat.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Heat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Heat.Location = new System.Drawing.Point(7, 6);
            this.checkBox_Heat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Heat.Name = "checkBox_Heat";
            this.checkBox_Heat.Size = new System.Drawing.Size(41, 32);
            this.checkBox_Heat.TabIndex = 5;
            this.checkBox_Heat.Text = "شوفاژ";
            this.checkBox_Heat.UseVisualStyleBackColor = false;
            // 
            // checkBox_Chiler
            // 
            this.checkBox_Chiler.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Chiler.AutoSize = true;
            this.checkBox_Chiler.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Chiler.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Chiler.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Chiler.Location = new System.Drawing.Point(268, 43);
            this.checkBox_Chiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Chiler.Name = "checkBox_Chiler";
            this.checkBox_Chiler.Size = new System.Drawing.Size(32, 32);
            this.checkBox_Chiler.TabIndex = 6;
            this.checkBox_Chiler.Text = "چیلر";
            this.checkBox_Chiler.UseVisualStyleBackColor = false;
            // 
            // checkBox_Pakage
            // 
            this.checkBox_Pakage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Pakage.AutoSize = true;
            this.checkBox_Pakage.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Pakage.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Pakage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Pakage.Location = new System.Drawing.Point(223, 43);
            this.checkBox_Pakage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Pakage.Name = "checkBox_Pakage";
            this.checkBox_Pakage.Size = new System.Drawing.Size(32, 32);
            this.checkBox_Pakage.TabIndex = 7;
            this.checkBox_Pakage.Text = "پکیج";
            this.checkBox_Pakage.UseVisualStyleBackColor = false;
            // 
            // checkBox_Sauna
            // 
            this.checkBox_Sauna.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Sauna.AutoSize = true;
            this.checkBox_Sauna.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Sauna.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Sauna.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Sauna.Location = new System.Drawing.Point(176, 43);
            this.checkBox_Sauna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Sauna.Name = "checkBox_Sauna";
            this.checkBox_Sauna.Size = new System.Drawing.Size(35, 32);
            this.checkBox_Sauna.TabIndex = 8;
            this.checkBox_Sauna.Text = "سونا";
            this.checkBox_Sauna.UseVisualStyleBackColor = false;
            // 
            // checkBox_Jacuzzi
            // 
            this.checkBox_Jacuzzi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Jacuzzi.AutoSize = true;
            this.checkBox_Jacuzzi.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Jacuzzi.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Jacuzzi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Jacuzzi.Location = new System.Drawing.Point(121, 43);
            this.checkBox_Jacuzzi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Jacuzzi.Name = "checkBox_Jacuzzi";
            this.checkBox_Jacuzzi.Size = new System.Drawing.Size(44, 32);
            this.checkBox_Jacuzzi.TabIndex = 9;
            this.checkBox_Jacuzzi.Text = "جکوزی";
            this.checkBox_Jacuzzi.UseVisualStyleBackColor = false;
            // 
            // checkBox_Pool
            // 
            this.checkBox_Pool.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Pool.AutoSize = true;
            this.checkBox_Pool.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Pool.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Pool.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Pool.Location = new System.Drawing.Point(62, 43);
            this.checkBox_Pool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Pool.Name = "checkBox_Pool";
            this.checkBox_Pool.Size = new System.Drawing.Size(43, 32);
            this.checkBox_Pool.TabIndex = 10;
            this.checkBox_Pool.Text = "استخر";
            this.checkBox_Pool.UseVisualStyleBackColor = false;
            // 
            // groupPanel_RegH
            // 
            this.groupPanel_RegH.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_RegH.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_RegH.Controls.Add(this.label_UseType);
            this.groupPanel_RegH.Controls.Add(this.comboBox_UseType);
            this.groupPanel_RegH.Controls.Add(this.label_LicenceType);
            this.groupPanel_RegH.Controls.Add(this.checkBox_KeyMoney);
            this.groupPanel_RegH.Controls.Add(this.checkBox_DocUse);
            this.groupPanel_RegH.Controls.Add(this.comboBox_LicenceType);
            this.groupPanel_RegH.Controls.Add(this.checkBox_Property);
            this.groupPanel_RegH.Controls.Add(this.comboBox_DocType);
            this.groupPanel_RegH.Controls.Add(this.label_DocType);
            this.groupPanel_RegH.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_RegH.Location = new System.Drawing.Point(5, 366);
            this.groupPanel_RegH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_RegH.Name = "groupPanel_RegH";
            this.groupPanel_RegH.Size = new System.Drawing.Size(306, 117);
            // 
            // 
            // 
            this.groupPanel_RegH.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_RegH.Style.BackColorGradientAngle = 90;
            this.groupPanel_RegH.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_RegH.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_RegH.Style.BorderBottomWidth = 1;
            this.groupPanel_RegH.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_RegH.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_RegH.Style.BorderLeftWidth = 1;
            this.groupPanel_RegH.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_RegH.Style.BorderRightWidth = 1;
            this.groupPanel_RegH.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_RegH.Style.BorderTopWidth = 1;
            this.groupPanel_RegH.Style.CornerDiameter = 4;
            this.groupPanel_RegH.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_RegH.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_RegH.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_RegH.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_RegH.TabIndex = 8;
            this.groupPanel_RegH.Text = "موارد ثبتی ملک";
            // 
            // label_UseType
            // 
            this.label_UseType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_UseType.AutoSize = true;
            this.label_UseType.BackColor = System.Drawing.Color.Transparent;
            this.label_UseType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UseType.ForeColor = System.Drawing.Color.Black;
            this.label_UseType.Location = new System.Drawing.Point(119, 40);
            this.label_UseType.Name = "label_UseType";
            this.label_UseType.Size = new System.Drawing.Size(58, 14);
            this.label_UseType.TabIndex = 111;
            this.label_UseType.Text = "نوع کاربری";
            // 
            // comboBox_UseType
            // 
            this.comboBox_UseType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_UseType.DisplayMember = "Text";
            this.comboBox_UseType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_UseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UseType.DropDownWidth = 120;
            this.comboBox_UseType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_UseType.ForeColor = System.Drawing.Color.Black;
            this.comboBox_UseType.IntegralHeight = false;
            this.comboBox_UseType.ItemHeight = 16;
            this.comboBox_UseType.Items.AddRange(new object[] {
            this.comboItem25,
            this.comboItem26,
            this.comboItem28,
            this.comboItem29,
            this.comboItem30});
            this.comboBox_UseType.Location = new System.Drawing.Point(4, 37);
            this.comboBox_UseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_UseType.MaxDropDownItems = 20;
            this.comboBox_UseType.MaxLength = 50;
            this.comboBox_UseType.Name = "comboBox_UseType";
            this.comboBox_UseType.Size = new System.Drawing.Size(114, 22);
            this.comboBox_UseType.TabIndex = 4;
            // 
            // comboItem25
            // 
            this.comboItem25.Text = "مسکونی";
            this.comboItem25.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem25.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem26
            // 
            this.comboItem26.Text = "موقعیت اداری";
            this.comboItem26.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem26.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem28
            // 
            this.comboItem28.Text = "سند اداری";
            this.comboItem28.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem28.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem29
            // 
            this.comboItem29.Text = "سند تجاری";
            this.comboItem29.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem29.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem30
            // 
            this.comboItem30.Text = "سایر";
            this.comboItem30.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem30.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label_LicenceType
            // 
            this.label_LicenceType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_LicenceType.AutoSize = true;
            this.label_LicenceType.BackColor = System.Drawing.Color.Transparent;
            this.label_LicenceType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LicenceType.ForeColor = System.Drawing.Color.Black;
            this.label_LicenceType.Location = new System.Drawing.Point(133, 68);
            this.label_LicenceType.Name = "label_LicenceType";
            this.label_LicenceType.Size = new System.Drawing.Size(46, 14);
            this.label_LicenceType.TabIndex = 113;
            this.label_LicenceType.Text = "نوع جواز";
            // 
            // checkBox_KeyMoney
            // 
            this.checkBox_KeyMoney.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_KeyMoney.AutoSize = true;
            this.checkBox_KeyMoney.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_KeyMoney.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_KeyMoney.ForeColor = System.Drawing.Color.Black;
            this.checkBox_KeyMoney.Location = new System.Drawing.Point(219, 65);
            this.checkBox_KeyMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_KeyMoney.Name = "checkBox_KeyMoney";
            this.checkBox_KeyMoney.Size = new System.Drawing.Size(70, 18);
            this.checkBox_KeyMoney.TabIndex = 2;
            this.checkBox_KeyMoney.Text = "سرقفلی";
            this.checkBox_KeyMoney.UseVisualStyleBackColor = false;
            // 
            // checkBox_DocUse
            // 
            this.checkBox_DocUse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_DocUse.AutoSize = true;
            this.checkBox_DocUse.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_DocUse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_DocUse.ForeColor = System.Drawing.Color.Black;
            this.checkBox_DocUse.Location = new System.Drawing.Point(217, 9);
            this.checkBox_DocUse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_DocUse.Name = "checkBox_DocUse";
            this.checkBox_DocUse.Size = new System.Drawing.Size(72, 18);
            this.checkBox_DocUse.TabIndex = 0;
            this.checkBox_DocUse.Text = "سند دارد";
            this.checkBox_DocUse.UseVisualStyleBackColor = false;
            // 
            // comboBox_LicenceType
            // 
            this.comboBox_LicenceType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_LicenceType.DisplayMember = "Text";
            this.comboBox_LicenceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_LicenceType.DropDownWidth = 120;
            this.comboBox_LicenceType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LicenceType.ForeColor = System.Drawing.Color.Black;
            this.comboBox_LicenceType.IntegralHeight = false;
            this.comboBox_LicenceType.ItemHeight = 16;
            this.comboBox_LicenceType.Location = new System.Drawing.Point(4, 65);
            this.comboBox_LicenceType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_LicenceType.MaxDropDownItems = 20;
            this.comboBox_LicenceType.MaxLength = 50;
            this.comboBox_LicenceType.Name = "comboBox_LicenceType";
            this.comboBox_LicenceType.Size = new System.Drawing.Size(114, 22);
            this.comboBox_LicenceType.TabIndex = 5;
            // 
            // checkBox_Property
            // 
            this.checkBox_Property.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Property.AutoSize = true;
            this.checkBox_Property.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Property.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Property.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Property.Location = new System.Drawing.Point(229, 37);
            this.checkBox_Property.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Property.Name = "checkBox_Property";
            this.checkBox_Property.Size = new System.Drawing.Size(60, 18);
            this.checkBox_Property.TabIndex = 1;
            this.checkBox_Property.Text = "مالکیت";
            this.checkBox_Property.UseVisualStyleBackColor = false;
            // 
            // comboBox_DocType
            // 
            this.comboBox_DocType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_DocType.DisplayMember = "Text";
            this.comboBox_DocType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_DocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DocType.DropDownWidth = 120;
            this.comboBox_DocType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_DocType.ForeColor = System.Drawing.Color.Black;
            this.comboBox_DocType.IntegralHeight = false;
            this.comboBox_DocType.ItemHeight = 16;
            this.comboBox_DocType.Items.AddRange(new object[] {
            this.comboItem32,
            this.comboItem33,
            this.comboItem34,
            this.comboItem35,
            this.comboItem36,
            this.comboItem37,
            this.comboItem38,
            this.comboItem39,
            this.comboItem40,
            this.comboItem41});
            this.comboBox_DocType.Location = new System.Drawing.Point(4, 9);
            this.comboBox_DocType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_DocType.MaxDropDownItems = 20;
            this.comboBox_DocType.MaxLength = 50;
            this.comboBox_DocType.Name = "comboBox_DocType";
            this.comboBox_DocType.Size = new System.Drawing.Size(114, 22);
            this.comboBox_DocType.TabIndex = 3;
            // 
            // comboItem32
            // 
            this.comboItem32.Text = "شخصی";
            this.comboItem32.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem32.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem33
            // 
            this.comboItem33.Text = "تعاونی";
            this.comboItem33.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem33.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem34
            // 
            this.comboItem34.Text = "زمین شهری";
            this.comboItem34.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem34.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem35
            // 
            this.comboItem35.Text = "حاکم شرعی";
            this.comboItem35.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem35.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem36
            // 
            this.comboItem36.Text = "اوقافی";
            this.comboItem36.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem36.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem37
            // 
            this.comboItem37.Text = "بنیادی";
            this.comboItem37.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem37.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem38
            // 
            this.comboItem38.Text = "معوض ";
            this.comboItem38.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem38.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem39
            // 
            this.comboItem39.Text = "سهم مالک";
            this.comboItem39.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem39.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem40
            // 
            this.comboItem40.Text = "مصادره ای";
            this.comboItem40.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem40.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem41
            // 
            this.comboItem41.Text = "سایر";
            this.comboItem41.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem41.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label_DocType
            // 
            this.label_DocType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_DocType.AutoSize = true;
            this.label_DocType.BackColor = System.Drawing.Color.Transparent;
            this.label_DocType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DocType.ForeColor = System.Drawing.Color.Black;
            this.label_DocType.Location = new System.Drawing.Point(130, 12);
            this.label_DocType.Name = "label_DocType";
            this.label_DocType.Size = new System.Drawing.Size(49, 14);
            this.label_DocType.TabIndex = 117;
            this.label_DocType.Text = "نوع سند";
            // 
            // groupPanel_Part
            // 
            this.groupPanel_Part.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Part.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Part.Controls.Add(this.comboBox_Part);
            this.groupPanel_Part.Controls.Add(this.comboBox_City);
            this.groupPanel_Part.Controls.Add(this.label_City);
            this.groupPanel_Part.Controls.Add(this.label_Part);
            this.groupPanel_Part.Controls.Add(this.comboBox_State);
            this.groupPanel_Part.Controls.Add(this.comboBox_Country);
            this.groupPanel_Part.Controls.Add(this.label_Country);
            this.groupPanel_Part.Controls.Add(this.label_State);
            this.groupPanel_Part.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_Part.Location = new System.Drawing.Point(5, 75);
            this.groupPanel_Part.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Part.Name = "groupPanel_Part";
            this.groupPanel_Part.Size = new System.Drawing.Size(306, 86);
            // 
            // 
            // 
            this.groupPanel_Part.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Part.Style.BackColorGradientAngle = 90;
            this.groupPanel_Part.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Part.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Part.Style.BorderBottomWidth = 1;
            this.groupPanel_Part.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Part.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Part.Style.BorderLeftWidth = 1;
            this.groupPanel_Part.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Part.Style.BorderRightWidth = 1;
            this.groupPanel_Part.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Part.Style.BorderTopWidth = 1;
            this.groupPanel_Part.Style.CornerDiameter = 4;
            this.groupPanel_Part.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Part.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Part.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Part.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_Part.TabIndex = 3;
            this.groupPanel_Part.Text = "منطقه";
            // 
            // comboBox_Part
            // 
            this.comboBox_Part.DisplayMember = "PartName_Fa";
            this.comboBox_Part.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Part.DropDownHeight = 100;
            this.comboBox_Part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Part.DropDownWidth = 200;
            this.comboBox_Part.FocusHighlightEnabled = true;
            this.comboBox_Part.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Part.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Part.IntegralHeight = false;
            this.comboBox_Part.ItemHeight = 20;
            this.comboBox_Part.Location = new System.Drawing.Point(27, 40);
            this.comboBox_Part.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Part.Name = "comboBox_Part";
            this.comboBox_Part.PreventEnterBeep = true;
            this.comboBox_Part.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Part.Size = new System.Drawing.Size(157, 26);
            this.comboBox_Part.TabIndex = 3;
            this.comboBox_Part.Tag = "0";
            this.comboBox_Part.ValueMember = "PartID";
            this.comboBox_Part.Enter += new System.EventHandler(this.comboBox_Part_Enter);
            // 
            // comboBox_City
            // 
            this.comboBox_City.DisplayMember = "CityName_Fa";
            this.comboBox_City.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_City.DropDownHeight = 100;
            this.comboBox_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_City.DropDownWidth = 150;
            this.comboBox_City.FocusHighlightEnabled = true;
            this.comboBox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_City.ForeColor = System.Drawing.Color.Black;
            this.comboBox_City.IntegralHeight = false;
            this.comboBox_City.ItemHeight = 20;
            this.comboBox_City.Location = new System.Drawing.Point(6, 14);
            this.comboBox_City.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.PreventEnterBeep = true;
            this.comboBox_City.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_City.Size = new System.Drawing.Size(92, 26);
            this.comboBox_City.TabIndex = 2;
            this.comboBox_City.Tag = "0";
            this.comboBox_City.ValueMember = "CityID";
            this.comboBox_City.Enter += new System.EventHandler(this.comboBox_City_Enter);
            this.comboBox_City.Leave += new System.EventHandler(this.comboBox_City_Leave);
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.BackColor = System.Drawing.Color.Transparent;
            this.label_City.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_City.ForeColor = System.Drawing.Color.Black;
            this.label_City.Location = new System.Drawing.Point(58, -4);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(31, 14);
            this.label_City.TabIndex = 52;
            this.label_City.Text = "شهر";
            // 
            // label_Part
            // 
            this.label_Part.AutoSize = true;
            this.label_Part.BackColor = System.Drawing.Color.Transparent;
            this.label_Part.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Part.ForeColor = System.Drawing.Color.Black;
            this.label_Part.Location = new System.Drawing.Point(185, 42);
            this.label_Part.Name = "label_Part";
            this.label_Part.Size = new System.Drawing.Size(60, 14);
            this.label_Part.TabIndex = 53;
            this.label_Part.Text = "نام منطقه:";
            // 
            // comboBox_State
            // 
            this.comboBox_State.DisplayMember = "StateName_Fa";
            this.comboBox_State.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_State.DropDownHeight = 100;
            this.comboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_State.DropDownWidth = 150;
            this.comboBox_State.FocusHighlightEnabled = true;
            this.comboBox_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_State.ForeColor = System.Drawing.Color.Black;
            this.comboBox_State.IntegralHeight = false;
            this.comboBox_State.ItemHeight = 20;
            this.comboBox_State.Location = new System.Drawing.Point(105, 14);
            this.comboBox_State.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_State.Name = "comboBox_State";
            this.comboBox_State.PreventEnterBeep = true;
            this.comboBox_State.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_State.Size = new System.Drawing.Size(92, 26);
            this.comboBox_State.TabIndex = 1;
            this.comboBox_State.Tag = "0";
            this.comboBox_State.ValueMember = "StateID";
            this.comboBox_State.Enter += new System.EventHandler(this.comboBox_State_Enter);
            this.comboBox_State.Leave += new System.EventHandler(this.comboBox_State_Leave);
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.DisplayMember = "CountryName_Fa";
            this.comboBox_Country.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Country.DropDownHeight = 100;
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.DropDownWidth = 150;
            this.comboBox_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Country.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Country.IntegralHeight = false;
            this.comboBox_Country.ItemHeight = 20;
            this.comboBox_Country.Location = new System.Drawing.Point(204, 14);
            this.comboBox_Country.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.PreventEnterBeep = true;
            this.comboBox_Country.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Country.Size = new System.Drawing.Size(92, 26);
            this.comboBox_Country.TabIndex = 0;
            this.comboBox_Country.Tag = "0";
            this.comboBox_Country.ValueMember = "CountryID";
            this.comboBox_Country.Enter += new System.EventHandler(this.comboBox_Country_Enter);
            this.comboBox_Country.Leave += new System.EventHandler(this.comboBox_Country_Leave);
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.BackColor = System.Drawing.Color.Transparent;
            this.label_Country.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Country.ForeColor = System.Drawing.Color.Black;
            this.label_Country.Location = new System.Drawing.Point(251, -4);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(35, 14);
            this.label_Country.TabIndex = 48;
            this.label_Country.Text = "کشور";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.BackColor = System.Drawing.Color.Transparent;
            this.label_State.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_State.ForeColor = System.Drawing.Color.Black;
            this.label_State.Location = new System.Drawing.Point(148, -4);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(38, 14);
            this.label_State.TabIndex = 49;
            this.label_State.Text = "استان";
            // 
            // groupPanel_StatusH
            // 
            this.groupPanel_StatusH.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_StatusH.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_StatusH.Controls.Add(this.comboBox_BldLow);
            this.groupPanel_StatusH.Controls.Add(this.comboBox_RcRoom);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_Patio);
            this.groupPanel_StatusH.Controls.Add(this.comboBox_CT);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_BYard);
            this.groupPanel_StatusH.Controls.Add(this.label_CT);
            this.groupPanel_StatusH.Controls.Add(this.comboBox_MK);
            this.groupPanel_StatusH.Controls.Add(this.comboBox_BedRoom);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_Yard);
            this.groupPanel_StatusH.Controls.Add(this.label_MK);
            this.groupPanel_StatusH.Controls.Add(this.label_KitchenFew);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_Cellar);
            this.groupPanel_StatusH.Controls.Add(this.label_BldLow);
            this.groupPanel_StatusH.Controls.Add(this.nUpDown_KitchenFew);
            this.groupPanel_StatusH.Controls.Add(this.label_FBed);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_StRoom);
            this.groupPanel_StatusH.Controls.Add(this.label_RCRoom);
            this.groupPanel_StatusH.Controls.Add(this.nUpDown_FRoom);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_Balcony);
            this.groupPanel_StatusH.Controls.Add(this.label_FRoom);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_FirePlace);
            this.groupPanel_StatusH.Controls.Add(this.label_Bedroom);
            this.groupPanel_StatusH.Controls.Add(this.nUpDown_FBed);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_Parking);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_FWc);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_Tel);
            this.groupPanel_StatusH.Controls.Add(this.checkBox_IRWc);
            this.groupPanel_StatusH.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_StatusH.IsShadowEnabled = true;
            this.groupPanel_StatusH.Location = new System.Drawing.Point(316, 236);
            this.groupPanel_StatusH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_StatusH.Name = "groupPanel_StatusH";
            this.groupPanel_StatusH.Size = new System.Drawing.Size(309, 249);
            // 
            // 
            // 
            this.groupPanel_StatusH.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_StatusH.Style.BackColorGradientAngle = 90;
            this.groupPanel_StatusH.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_StatusH.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_StatusH.Style.BorderBottomWidth = 1;
            this.groupPanel_StatusH.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_StatusH.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_StatusH.Style.BorderLeftWidth = 1;
            this.groupPanel_StatusH.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_StatusH.Style.BorderRightWidth = 1;
            this.groupPanel_StatusH.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_StatusH.Style.BorderTopWidth = 1;
            this.groupPanel_StatusH.Style.CornerDiameter = 4;
            this.groupPanel_StatusH.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_StatusH.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_StatusH.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_StatusH.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_StatusH.TabIndex = 5;
            this.groupPanel_StatusH.Text = "وضعیت ملک";
            // 
            // comboBox_BldLow
            // 
            this.comboBox_BldLow.DisplayMember = "Text";
            this.comboBox_BldLow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_BldLow.DropDownWidth = 100;
            this.comboBox_BldLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BldLow.IntegralHeight = false;
            this.comboBox_BldLow.ItemHeight = 15;
            this.comboBox_BldLow.Items.AddRange(new object[] {
            this.comboItem24,
            this.comboItem27});
            this.comboBox_BldLow.Location = new System.Drawing.Point(84, 108);
            this.comboBox_BldLow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_BldLow.MaxDropDownItems = 20;
            this.comboBox_BldLow.MaxLength = 50;
            this.comboBox_BldLow.Name = "comboBox_BldLow";
            this.comboBox_BldLow.Size = new System.Drawing.Size(97, 21);
            this.comboBox_BldLow.TabIndex = 7;
            // 
            // comboItem24
            // 
            this.comboItem24.Text = "سنگ";
            this.comboItem24.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem24.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem27
            // 
            this.comboItem27.Text = "موزاییک";
            this.comboItem27.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem27.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboBox_RcRoom
            // 
            this.comboBox_RcRoom.DisplayMember = "Text";
            this.comboBox_RcRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_RcRoom.DropDownWidth = 100;
            this.comboBox_RcRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_RcRoom.ForeColor = System.Drawing.Color.Black;
            this.comboBox_RcRoom.IntegralHeight = false;
            this.comboBox_RcRoom.ItemHeight = 15;
            this.comboBox_RcRoom.Items.AddRange(new object[] {
            this.comboItem10,
            this.comboItem11,
            this.comboItem12,
            this.comboItem23});
            this.comboBox_RcRoom.Location = new System.Drawing.Point(197, 108);
            this.comboBox_RcRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_RcRoom.MaxDropDownItems = 20;
            this.comboBox_RcRoom.MaxLength = 50;
            this.comboBox_RcRoom.Name = "comboBox_RcRoom";
            this.comboBox_RcRoom.Size = new System.Drawing.Size(97, 21);
            this.comboBox_RcRoom.TabIndex = 6;
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "سنگ";
            this.comboItem10.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem10.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "سرامیک";
            this.comboItem11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem11.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem12
            // 
            this.comboItem12.Text = "پارکت";
            this.comboItem12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem12.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem23
            // 
            this.comboItem23.Text = "موزاییک";
            this.comboItem23.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem23.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // checkBox_Patio
            // 
            this.checkBox_Patio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Patio.AutoSize = true;
            this.checkBox_Patio.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Patio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Patio.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Patio.Location = new System.Drawing.Point(89, 207);
            this.checkBox_Patio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Patio.Name = "checkBox_Patio";
            this.checkBox_Patio.Size = new System.Drawing.Size(52, 17);
            this.checkBox_Patio.TabIndex = 18;
            this.checkBox_Patio.Text = "پاسیو";
            this.checkBox_Patio.UseVisualStyleBackColor = false;
            // 
            // comboBox_CT
            // 
            this.comboBox_CT.DisplayMember = "Text";
            this.comboBox_CT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_CT.DropDownWidth = 100;
            this.comboBox_CT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_CT.ForeColor = System.Drawing.Color.Black;
            this.comboBox_CT.IntegralHeight = false;
            this.comboBox_CT.ItemHeight = 15;
            this.comboBox_CT.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6,
            this.comboItem7});
            this.comboBox_CT.Location = new System.Drawing.Point(10, 19);
            this.comboBox_CT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_CT.MaxDropDownItems = 20;
            this.comboBox_CT.MaxLength = 50;
            this.comboBox_CT.Name = "comboBox_CT";
            this.comboBox_CT.Size = new System.Drawing.Size(97, 21);
            this.comboBox_CT.TabIndex = 2;
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "چوبی";
            this.comboItem5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem5.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "MDF";
            this.comboItem6.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem6.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem7
            // 
            this.comboItem7.Text = "فلزی";
            this.comboItem7.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem7.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // checkBox_BYard
            // 
            this.checkBox_BYard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_BYard.AutoSize = true;
            this.checkBox_BYard.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_BYard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_BYard.ForeColor = System.Drawing.Color.Black;
            this.checkBox_BYard.Location = new System.Drawing.Point(147, 208);
            this.checkBox_BYard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_BYard.Name = "checkBox_BYard";
            this.checkBox_BYard.Size = new System.Drawing.Size(75, 17);
            this.checkBox_BYard.TabIndex = 17;
            this.checkBox_BYard.Text = "حیاط خلوت";
            this.checkBox_BYard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_BYard.UseVisualStyleBackColor = false;
            // 
            // label_CT
            // 
            this.label_CT.AutoSize = true;
            this.label_CT.BackColor = System.Drawing.Color.Transparent;
            this.label_CT.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CT.ForeColor = System.Drawing.Color.Black;
            this.label_CT.Location = new System.Drawing.Point(48, 3);
            this.label_CT.Name = "label_CT";
            this.label_CT.Size = new System.Drawing.Size(54, 13);
            this.label_CT.TabIndex = 51;
            this.label_CT.Text = "نوع کابینت";
            // 
            // comboBox_MK
            // 
            this.comboBox_MK.DisplayMember = "Text";
            this.comboBox_MK.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_MK.DropDownWidth = 100;
            this.comboBox_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MK.ForeColor = System.Drawing.Color.Black;
            this.comboBox_MK.IntegralHeight = false;
            this.comboBox_MK.ItemHeight = 15;
            this.comboBox_MK.Items.AddRange(new object[] {
            this.comboItem16,
            this.comboItem17,
            this.comboItem18});
            this.comboBox_MK.Location = new System.Drawing.Point(116, 19);
            this.comboBox_MK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_MK.MaxDropDownItems = 20;
            this.comboBox_MK.MaxLength = 50;
            this.comboBox_MK.Name = "comboBox_MK";
            this.comboBox_MK.Size = new System.Drawing.Size(97, 21);
            this.comboBox_MK.TabIndex = 1;
            // 
            // comboItem16
            // 
            this.comboItem16.Text = "اوپن";
            this.comboItem16.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem16.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem17
            // 
            this.comboItem17.Text = "نیمه اوپن";
            this.comboItem17.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem17.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem18
            // 
            this.comboItem18.Text = "بسته";
            this.comboItem18.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem18.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboBox_BedRoom
            // 
            this.comboBox_BedRoom.DisplayMember = "Text";
            this.comboBox_BedRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_BedRoom.DropDownWidth = 100;
            this.comboBox_BedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BedRoom.ForeColor = System.Drawing.Color.Black;
            this.comboBox_BedRoom.IntegralHeight = false;
            this.comboBox_BedRoom.ItemHeight = 15;
            this.comboBox_BedRoom.Items.AddRange(new object[] {
            this.comboItem20,
            this.comboItem19,
            this.comboItem22,
            this.comboItem21});
            this.comboBox_BedRoom.Location = new System.Drawing.Point(116, 63);
            this.comboBox_BedRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_BedRoom.MaxDropDownItems = 20;
            this.comboBox_BedRoom.MaxLength = 50;
            this.comboBox_BedRoom.Name = "comboBox_BedRoom";
            this.comboBox_BedRoom.Size = new System.Drawing.Size(97, 21);
            this.comboBox_BedRoom.TabIndex = 4;
            // 
            // comboItem20
            // 
            this.comboItem20.Text = "سنگ";
            this.comboItem20.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem20.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem19
            // 
            this.comboItem19.Text = "سرامیک";
            this.comboItem19.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem19.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem22
            // 
            this.comboItem22.Text = "پارکت";
            this.comboItem22.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem22.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem21
            // 
            this.comboItem21.Text = "موزاییک";
            this.comboItem21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem21.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // checkBox_Yard
            // 
            this.checkBox_Yard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Yard.AutoSize = true;
            this.checkBox_Yard.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Yard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Yard.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Yard.Location = new System.Drawing.Point(244, 207);
            this.checkBox_Yard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Yard.Name = "checkBox_Yard";
            this.checkBox_Yard.Size = new System.Drawing.Size(47, 17);
            this.checkBox_Yard.TabIndex = 16;
            this.checkBox_Yard.Text = "حیاط";
            this.checkBox_Yard.UseVisualStyleBackColor = false;
            // 
            // label_MK
            // 
            this.label_MK.AutoSize = true;
            this.label_MK.BackColor = System.Drawing.Color.Transparent;
            this.label_MK.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MK.ForeColor = System.Drawing.Color.Black;
            this.label_MK.Location = new System.Drawing.Point(139, 3);
            this.label_MK.Name = "label_MK";
            this.label_MK.Size = new System.Drawing.Size(71, 13);
            this.label_MK.TabIndex = 53;
            this.label_MK.Text = "مدل آشپزخانه";
            // 
            // label_KitchenFew
            // 
            this.label_KitchenFew.AutoSize = true;
            this.label_KitchenFew.BackColor = System.Drawing.Color.Transparent;
            this.label_KitchenFew.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KitchenFew.ForeColor = System.Drawing.Color.Black;
            this.label_KitchenFew.Location = new System.Drawing.Point(219, 2);
            this.label_KitchenFew.Name = "label_KitchenFew";
            this.label_KitchenFew.Size = new System.Drawing.Size(75, 13);
            this.label_KitchenFew.TabIndex = 150;
            this.label_KitchenFew.Text = "تعداد آشپزخانه";
            // 
            // checkBox_Cellar
            // 
            this.checkBox_Cellar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Cellar.AutoSize = true;
            this.checkBox_Cellar.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Cellar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Cellar.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Cellar.Location = new System.Drawing.Point(20, 175);
            this.checkBox_Cellar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Cellar.Name = "checkBox_Cellar";
            this.checkBox_Cellar.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Cellar.TabIndex = 15;
            this.checkBox_Cellar.Text = "زیرزمین";
            this.checkBox_Cellar.UseVisualStyleBackColor = false;
            // 
            // label_BldLow
            // 
            this.label_BldLow.AutoSize = true;
            this.label_BldLow.BackColor = System.Drawing.Color.Transparent;
            this.label_BldLow.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BldLow.ForeColor = System.Drawing.Color.Black;
            this.label_BldLow.Location = new System.Drawing.Point(84, 92);
            this.label_BldLow.Name = "label_BldLow";
            this.label_BldLow.Size = new System.Drawing.Size(91, 13);
            this.label_BldLow.TabIndex = 47;
            this.label_BldLow.Text = "کف پوش ساختمان";
            // 
            // nUpDown_KitchenFew
            // 
            this.nUpDown_KitchenFew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown_KitchenFew.ForeColor = System.Drawing.Color.Black;
            this.nUpDown_KitchenFew.Location = new System.Drawing.Point(220, 19);
            this.nUpDown_KitchenFew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDown_KitchenFew.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDown_KitchenFew.Name = "nUpDown_KitchenFew";
            this.nUpDown_KitchenFew.Size = new System.Drawing.Size(73, 21);
            this.nUpDown_KitchenFew.TabIndex = 0;
            this.nUpDown_KitchenFew.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label_FBed
            // 
            this.label_FBed.AutoSize = true;
            this.label_FBed.BackColor = System.Drawing.Color.Transparent;
            this.label_FBed.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FBed.ForeColor = System.Drawing.Color.Black;
            this.label_FBed.Location = new System.Drawing.Point(233, 46);
            this.label_FBed.Name = "label_FBed";
            this.label_FBed.Size = new System.Drawing.Size(62, 14);
            this.label_FBed.TabIndex = 38;
            this.label_FBed.Text = "تعداد خواب";
            // 
            // checkBox_StRoom
            // 
            this.checkBox_StRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_StRoom.AutoSize = true;
            this.checkBox_StRoom.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_StRoom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_StRoom.ForeColor = System.Drawing.Color.Black;
            this.checkBox_StRoom.Location = new System.Drawing.Point(94, 175);
            this.checkBox_StRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_StRoom.Name = "checkBox_StRoom";
            this.checkBox_StRoom.Size = new System.Drawing.Size(53, 17);
            this.checkBox_StRoom.TabIndex = 14;
            this.checkBox_StRoom.Text = "انباری";
            this.checkBox_StRoom.UseVisualStyleBackColor = false;
            // 
            // label_RCRoom
            // 
            this.label_RCRoom.AutoSize = true;
            this.label_RCRoom.BackColor = System.Drawing.Color.Transparent;
            this.label_RCRoom.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RCRoom.ForeColor = System.Drawing.Color.Black;
            this.label_RCRoom.Location = new System.Drawing.Point(226, 91);
            this.label_RCRoom.Name = "label_RCRoom";
            this.label_RCRoom.Size = new System.Drawing.Size(64, 14);
            this.label_RCRoom.TabIndex = 45;
            this.label_RCRoom.Text = "کفِ پذیرایی";
            // 
            // nUpDown_FRoom
            // 
            this.nUpDown_FRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown_FRoom.ForeColor = System.Drawing.Color.Black;
            this.nUpDown_FRoom.Location = new System.Drawing.Point(20, 63);
            this.nUpDown_FRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDown_FRoom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDown_FRoom.Name = "nUpDown_FRoom";
            this.nUpDown_FRoom.Size = new System.Drawing.Size(73, 21);
            this.nUpDown_FRoom.TabIndex = 5;
            this.nUpDown_FRoom.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // checkBox_Balcony
            // 
            this.checkBox_Balcony.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Balcony.AutoSize = true;
            this.checkBox_Balcony.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Balcony.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Balcony.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Balcony.Location = new System.Drawing.Point(172, 175);
            this.checkBox_Balcony.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Balcony.Name = "checkBox_Balcony";
            this.checkBox_Balcony.Size = new System.Drawing.Size(49, 17);
            this.checkBox_Balcony.TabIndex = 13;
            this.checkBox_Balcony.Text = "بالکن";
            this.checkBox_Balcony.UseVisualStyleBackColor = false;
            // 
            // label_FRoom
            // 
            this.label_FRoom.AutoSize = true;
            this.label_FRoom.BackColor = System.Drawing.Color.Transparent;
            this.label_FRoom.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FRoom.ForeColor = System.Drawing.Color.Black;
            this.label_FRoom.Location = new System.Drawing.Point(20, 46);
            this.label_FRoom.Name = "label_FRoom";
            this.label_FRoom.Size = new System.Drawing.Size(72, 14);
            this.label_FRoom.TabIndex = 40;
            this.label_FRoom.Text = "تعداد پذیرایی";
            // 
            // checkBox_FirePlace
            // 
            this.checkBox_FirePlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_FirePlace.AutoSize = true;
            this.checkBox_FirePlace.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_FirePlace.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_FirePlace.ForeColor = System.Drawing.Color.Black;
            this.checkBox_FirePlace.Location = new System.Drawing.Point(229, 175);
            this.checkBox_FirePlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_FirePlace.Name = "checkBox_FirePlace";
            this.checkBox_FirePlace.Size = new System.Drawing.Size(62, 17);
            this.checkBox_FirePlace.TabIndex = 12;
            this.checkBox_FirePlace.Text = "شومینه";
            this.checkBox_FirePlace.UseVisualStyleBackColor = false;
            // 
            // label_Bedroom
            // 
            this.label_Bedroom.AutoSize = true;
            this.label_Bedroom.BackColor = System.Drawing.Color.Transparent;
            this.label_Bedroom.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bedroom.ForeColor = System.Drawing.Color.Black;
            this.label_Bedroom.Location = new System.Drawing.Point(159, 46);
            this.label_Bedroom.Name = "label_Bedroom";
            this.label_Bedroom.Size = new System.Drawing.Size(54, 14);
            this.label_Bedroom.TabIndex = 43;
            this.label_Bedroom.Text = "کفِ خواب";
            // 
            // nUpDown_FBed
            // 
            this.nUpDown_FBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDown_FBed.ForeColor = System.Drawing.Color.Black;
            this.nUpDown_FBed.Location = new System.Drawing.Point(220, 63);
            this.nUpDown_FBed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDown_FBed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDown_FBed.Name = "nUpDown_FBed";
            this.nUpDown_FBed.Size = new System.Drawing.Size(73, 21);
            this.nUpDown_FBed.TabIndex = 3;
            this.nUpDown_FBed.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // checkBox_Parking
            // 
            this.checkBox_Parking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Parking.AutoSize = true;
            this.checkBox_Parking.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Parking.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Parking.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Parking.Location = new System.Drawing.Point(20, 142);
            this.checkBox_Parking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Parking.Name = "checkBox_Parking";
            this.checkBox_Parking.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Parking.TabIndex = 11;
            this.checkBox_Parking.Text = "پارکینگ";
            this.checkBox_Parking.UseVisualStyleBackColor = false;
            // 
            // checkBox_FWc
            // 
            this.checkBox_FWc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_FWc.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_FWc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_FWc.ForeColor = System.Drawing.Color.Black;
            this.checkBox_FWc.Location = new System.Drawing.Point(79, 138);
            this.checkBox_FWc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_FWc.Name = "checkBox_FWc";
            this.checkBox_FWc.Size = new System.Drawing.Size(69, 30);
            this.checkBox_FWc.TabIndex = 10;
            this.checkBox_FWc.Text = "سرویس فرنگی";
            this.checkBox_FWc.UseVisualStyleBackColor = false;
            // 
            // checkBox_Tel
            // 
            this.checkBox_Tel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Tel.AutoSize = true;
            this.checkBox_Tel.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Tel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Tel.ForeColor = System.Drawing.Color.Black;
            this.checkBox_Tel.Location = new System.Drawing.Point(244, 142);
            this.checkBox_Tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Tel.Name = "checkBox_Tel";
            this.checkBox_Tel.Size = new System.Drawing.Size(47, 17);
            this.checkBox_Tel.TabIndex = 8;
            this.checkBox_Tel.Text = "تلفن";
            this.checkBox_Tel.UseVisualStyleBackColor = false;
            // 
            // checkBox_IRWc
            // 
            this.checkBox_IRWc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_IRWc.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_IRWc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_IRWc.ForeColor = System.Drawing.Color.Black;
            this.checkBox_IRWc.Location = new System.Drawing.Point(155, 138);
            this.checkBox_IRWc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_IRWc.Name = "checkBox_IRWc";
            this.checkBox_IRWc.Size = new System.Drawing.Size(66, 30);
            this.checkBox_IRWc.TabIndex = 9;
            this.checkBox_IRWc.Text = "سرویس ایرانی";
            this.checkBox_IRWc.UseVisualStyleBackColor = false;
            // 
            // groupPanel_facility
            // 
            this.groupPanel_facility.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_facility.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_facility.Controls.Add(this.checkBox_EmployeeSrv);
            this.groupPanel_facility.Controls.Add(this.checkBox_AV);
            this.groupPanel_facility.Controls.Add(this.checkBox_RubShooting);
            this.groupPanel_facility.Controls.Add(this.checkBox_SK);
            this.groupPanel_facility.Controls.Add(this.checkBox_RDoor);
            this.groupPanel_facility.Controls.Add(this.checkBox_AC);
            this.groupPanel_facility.Controls.Add(this.checkBox_Elevatoor);
            this.groupPanel_facility.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_facility.Location = new System.Drawing.Point(5, 166);
            this.groupPanel_facility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_facility.Name = "groupPanel_facility";
            this.groupPanel_facility.Size = new System.Drawing.Size(306, 93);
            // 
            // 
            // 
            this.groupPanel_facility.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_facility.Style.BackColorGradientAngle = 90;
            this.groupPanel_facility.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_facility.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_facility.Style.BorderBottomWidth = 1;
            this.groupPanel_facility.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_facility.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_facility.Style.BorderLeftWidth = 1;
            this.groupPanel_facility.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_facility.Style.BorderRightWidth = 1;
            this.groupPanel_facility.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_facility.Style.BorderTopWidth = 1;
            this.groupPanel_facility.Style.CornerDiameter = 4;
            this.groupPanel_facility.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_facility.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_facility.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_facility.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_facility.TabIndex = 6;
            this.groupPanel_facility.Text = "امکانات";
            // 
            // checkBox_EmployeeSrv
            // 
            this.checkBox_EmployeeSrv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_EmployeeSrv.AutoSize = true;
            this.checkBox_EmployeeSrv.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_EmployeeSrv.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_EmployeeSrv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_EmployeeSrv.Location = new System.Drawing.Point(144, 40);
            this.checkBox_EmployeeSrv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_EmployeeSrv.Name = "checkBox_EmployeeSrv";
            this.checkBox_EmployeeSrv.Size = new System.Drawing.Size(94, 31);
            this.checkBox_EmployeeSrv.TabIndex = 5;
            this.checkBox_EmployeeSrv.Text = "سرویس مستخدم";
            this.checkBox_EmployeeSrv.UseVisualStyleBackColor = false;
            // 
            // checkBox_AV
            // 
            this.checkBox_AV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_AV.AutoSize = true;
            this.checkBox_AV.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AV.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_AV.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AV.Location = new System.Drawing.Point(226, 3);
            this.checkBox_AV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_AV.Name = "checkBox_AV";
            this.checkBox_AV.Size = new System.Drawing.Size(73, 31);
            this.checkBox_AV.TabIndex = 0;
            this.checkBox_AV.Text = "آیفون تصویری";
            this.checkBox_AV.UseVisualStyleBackColor = false;
            // 
            // checkBox_RubShooting
            // 
            this.checkBox_RubShooting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_RubShooting.AutoSize = true;
            this.checkBox_RubShooting.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_RubShooting.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_RubShooting.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RubShooting.Location = new System.Drawing.Point(7, 3);
            this.checkBox_RubShooting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_RubShooting.Name = "checkBox_RubShooting";
            this.checkBox_RubShooting.Size = new System.Drawing.Size(71, 31);
            this.checkBox_RubShooting.TabIndex = 3;
            this.checkBox_RubShooting.Text = "شوتینگ زباله";
            this.checkBox_RubShooting.UseVisualStyleBackColor = false;
            // 
            // checkBox_SK
            // 
            this.checkBox_SK.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_SK.AutoSize = true;
            this.checkBox_SK.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_SK.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_SK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SK.Location = new System.Drawing.Point(240, 40);
            this.checkBox_SK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_SK.Name = "checkBox_SK";
            this.checkBox_SK.Size = new System.Drawing.Size(49, 31);
            this.checkBox_SK.TabIndex = 4;
            this.checkBox_SK.Text = "آبدارخانه";
            this.checkBox_SK.UseVisualStyleBackColor = false;
            // 
            // checkBox_RDoor
            // 
            this.checkBox_RDoor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_RDoor.AutoSize = true;
            this.checkBox_RDoor.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_RDoor.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_RDoor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RDoor.Location = new System.Drawing.Point(157, 3);
            this.checkBox_RDoor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_RDoor.Name = "checkBox_RDoor";
            this.checkBox_RDoor.Size = new System.Drawing.Size(60, 31);
            this.checkBox_RDoor.TabIndex = 1;
            this.checkBox_RDoor.Text = "درب ریموت";
            this.checkBox_RDoor.UseVisualStyleBackColor = false;
            // 
            // checkBox_AC
            // 
            this.checkBox_AC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_AC.AutoSize = true;
            this.checkBox_AC.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AC.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_AC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AC.Location = new System.Drawing.Point(85, 3);
            this.checkBox_AC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_AC.Name = "checkBox_AC";
            this.checkBox_AC.Size = new System.Drawing.Size(63, 31);
            this.checkBox_AC.TabIndex = 2;
            this.checkBox_AC.Text = "آنتن مرکزی";
            this.checkBox_AC.UseVisualStyleBackColor = false;
            // 
            // checkBox_Elevatoor
            // 
            this.checkBox_Elevatoor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_Elevatoor.AutoSize = true;
            this.checkBox_Elevatoor.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Elevatoor.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox_Elevatoor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Elevatoor.Location = new System.Drawing.Point(90, 40);
            this.checkBox_Elevatoor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_Elevatoor.Name = "checkBox_Elevatoor";
            this.checkBox_Elevatoor.Size = new System.Drawing.Size(52, 31);
            this.checkBox_Elevatoor.TabIndex = 6;
            this.checkBox_Elevatoor.Text = "آسانسور";
            this.checkBox_Elevatoor.UseVisualStyleBackColor = false;
            // 
            // groupPanel_StsFile
            // 
            this.groupPanel_StsFile.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_StsFile.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_StsFile.Controls.Add(this.panel_Date);
            this.groupPanel_StsFile.Controls.Add(this.label_NonActDate);
            this.groupPanel_StsFile.Controls.Add(this.radioButton_Active);
            this.groupPanel_StsFile.Controls.Add(this.radioButton_nonActive);
            this.groupPanel_StsFile.Controls.Add(this.label_Priority);
            this.groupPanel_StsFile.Controls.Add(this.comboBox_Priority);
            this.groupPanel_StsFile.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_StsFile.Location = new System.Drawing.Point(316, 75);
            this.groupPanel_StsFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_StsFile.MinimumSize = new System.Drawing.Size(262, 52);
            this.groupPanel_StsFile.Name = "groupPanel_StsFile";
            this.groupPanel_StsFile.Size = new System.Drawing.Size(309, 86);
            // 
            // 
            // 
            this.groupPanel_StsFile.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_StsFile.Style.BackColorGradientAngle = 90;
            this.groupPanel_StsFile.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_StsFile.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_StsFile.Style.BorderBottomWidth = 1;
            this.groupPanel_StsFile.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_StsFile.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_StsFile.Style.BorderLeftWidth = 1;
            this.groupPanel_StsFile.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_StsFile.Style.BorderRightWidth = 1;
            this.groupPanel_StsFile.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_StsFile.Style.BorderTopWidth = 1;
            this.groupPanel_StsFile.Style.CornerDiameter = 4;
            this.groupPanel_StsFile.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_StsFile.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_StsFile.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_StsFile.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_StsFile.TabIndex = 2;
            this.groupPanel_StsFile.Text = "وضعیت فایل";
            // 
            // panel_Date
            // 
            this.panel_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Date.Controls.Add(this.label7);
            this.panel_Date.Controls.Add(this.label8);
            this.panel_Date.Controls.Add(this.comboBox_Year1);
            this.panel_Date.Controls.Add(this.comboBox_day1);
            this.panel_Date.Controls.Add(this.comboBox_Month1);
            this.panel_Date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Date.Location = new System.Drawing.Point(101, 35);
            this.panel_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Date.Name = "panel_Date";
            this.panel_Date.Size = new System.Drawing.Size(147, 26);
            this.panel_Date.TabIndex = 2;
            this.panel_Date.Leave += new System.EventHandler(this.panel_Date_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(96, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "/";
            // 
            // comboBox_Year1
            // 
            this.comboBox_Year1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Year1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Year1.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Year1.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Year1.IntegralHeight = false;
            this.comboBox_Year1.Items.AddRange(new object[] {
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1412",
            "1413",
            "1414",
            "1415",
            "1416",
            "1417",
            "1418",
            "1419",
            "1420"});
            this.comboBox_Year1.Location = new System.Drawing.Point(3, 2);
            this.comboBox_Year1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Year1.Name = "comboBox_Year1";
            this.comboBox_Year1.Size = new System.Drawing.Size(53, 21);
            this.comboBox_Year1.TabIndex = 2;
            // 
            // comboBox_day1
            // 
            this.comboBox_day1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_day1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_day1.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_day1.ForeColor = System.Drawing.Color.Black;
            this.comboBox_day1.IntegralHeight = false;
            this.comboBox_day1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_day1.Location = new System.Drawing.Point(108, 2);
            this.comboBox_day1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_day1.Name = "comboBox_day1";
            this.comboBox_day1.Size = new System.Drawing.Size(35, 21);
            this.comboBox_day1.TabIndex = 0;
            // 
            // comboBox_Month1
            // 
            this.comboBox_Month1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Month1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Month1.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Month1.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Month1.IntegralHeight = false;
            this.comboBox_Month1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_Month1.Location = new System.Drawing.Point(62, 2);
            this.comboBox_Month1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Month1.Name = "comboBox_Month1";
            this.comboBox_Month1.Size = new System.Drawing.Size(36, 21);
            this.comboBox_Month1.TabIndex = 1;
            // 
            // label_NonActDate
            // 
            this.label_NonActDate.AutoSize = true;
            this.label_NonActDate.BackColor = System.Drawing.Color.Transparent;
            this.label_NonActDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NonActDate.ForeColor = System.Drawing.Color.Black;
            this.label_NonActDate.Location = new System.Drawing.Point(247, 40);
            this.label_NonActDate.Name = "label_NonActDate";
            this.label_NonActDate.Size = new System.Drawing.Size(44, 14);
            this.label_NonActDate.TabIndex = 88;
            this.label_NonActDate.Text = "تا تاریخ:";
            // 
            // radioButton_Active
            // 
            this.radioButton_Active.AutoSize = true;
            this.radioButton_Active.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Active.Checked = true;
            this.radioButton_Active.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Active.ForeColor = System.Drawing.Color.Black;
            this.radioButton_Active.Location = new System.Drawing.Point(249, 5);
            this.radioButton_Active.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_Active.Name = "radioButton_Active";
            this.radioButton_Active.Size = new System.Drawing.Size(48, 18);
            this.radioButton_Active.TabIndex = 0;
            this.radioButton_Active.TabStop = true;
            this.radioButton_Active.Text = "فعال";
            this.radioButton_Active.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton_Active.UseVisualStyleBackColor = false;
            // 
            // radioButton_nonActive
            // 
            this.radioButton_nonActive.AutoSize = true;
            this.radioButton_nonActive.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_nonActive.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_nonActive.ForeColor = System.Drawing.Color.Black;
            this.radioButton_nonActive.Location = new System.Drawing.Point(159, 5);
            this.radioButton_nonActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_nonActive.Name = "radioButton_nonActive";
            this.radioButton_nonActive.Size = new System.Drawing.Size(60, 18);
            this.radioButton_nonActive.TabIndex = 1;
            this.radioButton_nonActive.Text = "بایگانی";
            this.radioButton_nonActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton_nonActive.UseVisualStyleBackColor = false;
            // 
            // label_Priority
            // 
            this.label_Priority.AutoSize = true;
            this.label_Priority.BackColor = System.Drawing.Color.Transparent;
            this.label_Priority.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Priority.ForeColor = System.Drawing.Color.Black;
            this.label_Priority.Location = new System.Drawing.Point(35, 7);
            this.label_Priority.Name = "label_Priority";
            this.label_Priority.Size = new System.Drawing.Size(37, 14);
            this.label_Priority.TabIndex = 92;
            this.label_Priority.Text = "اولویت";
            // 
            // comboBox_Priority
            // 
            this.comboBox_Priority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Priority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Priority.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Priority.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Priority.ItemHeight = 16;
            this.comboBox_Priority.Items.AddRange(new object[] {
            this.comboItem8,
            this.comboItem9,
            this.comboItem13});
            this.comboBox_Priority.Location = new System.Drawing.Point(10, 30);
            this.comboBox_Priority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Priority.Name = "comboBox_Priority";
            this.comboBox_Priority.Size = new System.Drawing.Size(66, 22);
            this.comboBox_Priority.TabIndex = 3;
            // 
            // comboItem8
            // 
            this.comboItem8.Text = "1";
            this.comboItem8.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem8.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "2";
            this.comboItem9.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem9.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem13
            // 
            this.comboItem13.Text = "3";
            this.comboItem13.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem13.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupPanel_House
            // 
            this.groupPanel_House.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_House.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_House.Controls.Add(this.comboBox_HouseFor);
            this.groupPanel_House.Controls.Add(this.label3);
            this.groupPanel_House.Controls.Add(this.comboBox_TypeHouse);
            this.groupPanel_House.Controls.Add(this.label6);
            this.groupPanel_House.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold);
            this.groupPanel_House.Location = new System.Drawing.Point(316, 166);
            this.groupPanel_House.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_House.Name = "groupPanel_House";
            this.groupPanel_House.Size = new System.Drawing.Size(309, 67);
            // 
            // 
            // 
            this.groupPanel_House.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_House.Style.BackColorGradientAngle = 90;
            this.groupPanel_House.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_House.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_House.Style.BorderBottomWidth = 1;
            this.groupPanel_House.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_House.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_House.Style.BorderLeftWidth = 1;
            this.groupPanel_House.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_House.Style.BorderRightWidth = 1;
            this.groupPanel_House.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_House.Style.BorderTopWidth = 1;
            this.groupPanel_House.Style.CornerDiameter = 4;
            this.groupPanel_House.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_House.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_House.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_House.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_House.TabIndex = 4;
            this.groupPanel_House.Text = "ملک";
            // 
            // comboBox_HouseFor
            // 
            this.comboBox_HouseFor.DisplayMember = "Text";
            this.comboBox_HouseFor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HouseFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HouseFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HouseFor.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HouseFor.IntegralHeight = false;
            this.comboBox_HouseFor.ItemHeight = 15;
            this.comboBox_HouseFor.Location = new System.Drawing.Point(17, 21);
            this.comboBox_HouseFor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HouseFor.Name = "comboBox_HouseFor";
            this.comboBox_HouseFor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HouseFor.Size = new System.Drawing.Size(119, 21);
            this.comboBox_HouseFor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 291;
            this.label3.Text = "ملک جهت";
            // 
            // comboBox_TypeHouse
            // 
            this.comboBox_TypeHouse.DisplayMember = "Text";
            this.comboBox_TypeHouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_TypeHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TypeHouse.ForeColor = System.Drawing.Color.Black;
            this.comboBox_TypeHouse.IntegralHeight = false;
            this.comboBox_TypeHouse.ItemHeight = 15;
            this.comboBox_TypeHouse.Location = new System.Drawing.Point(168, 21);
            this.comboBox_TypeHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_TypeHouse.Name = "comboBox_TypeHouse";
            this.comboBox_TypeHouse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_TypeHouse.Size = new System.Drawing.Size(119, 21);
            this.comboBox_TypeHouse.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(222, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 290;
            this.label6.Text = "نوع ملک";
            // 
            // groupPanel_Ctrl
            // 
            this.groupPanel_Ctrl.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Ctrl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Ctrl.Controls.Add(this.checkBox_HoldData);
            this.groupPanel_Ctrl.Controls.Add(this.checkBoxItem_Print);
            this.groupPanel_Ctrl.Controls.Add(this.checkBoxItem_ListCuHouse);
            this.groupPanel_Ctrl.Controls.Add(this.checkBox_AddTelNotebook);
            this.groupPanel_Ctrl.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold);
            this.groupPanel_Ctrl.Location = new System.Drawing.Point(5, 3);
            this.groupPanel_Ctrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Ctrl.Name = "groupPanel_Ctrl";
            this.groupPanel_Ctrl.Size = new System.Drawing.Size(377, 69);
            // 
            // 
            // 
            this.groupPanel_Ctrl.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Ctrl.Style.BackColorGradientAngle = 90;
            this.groupPanel_Ctrl.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Ctrl.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Ctrl.Style.BorderBottomWidth = 1;
            this.groupPanel_Ctrl.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Ctrl.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Ctrl.Style.BorderLeftWidth = 1;
            this.groupPanel_Ctrl.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Ctrl.Style.BorderRightWidth = 1;
            this.groupPanel_Ctrl.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Ctrl.Style.BorderTopWidth = 1;
            this.groupPanel_Ctrl.Style.CornerDiameter = 4;
            this.groupPanel_Ctrl.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Ctrl.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Ctrl.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Ctrl.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_Ctrl.TabIndex = 1;
            this.groupPanel_Ctrl.Text = "موارد کنترلی";
            // 
            // checkBox_HoldData
            // 
            this.checkBox_HoldData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_HoldData.AutoSize = true;
            this.checkBox_HoldData.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_HoldData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_HoldData.Location = new System.Drawing.Point(29, 25);
            this.checkBox_HoldData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_HoldData.Name = "checkBox_HoldData";
            this.checkBox_HoldData.Size = new System.Drawing.Size(111, 18);
            this.checkBox_HoldData.TabIndex = 3;
            this.checkBox_HoldData.Text = "نگهداری اطلاعات";
            this.checkBox_HoldData.UseVisualStyleBackColor = false;
            // 
            // checkBoxItem_Print
            // 
            this.checkBoxItem_Print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxItem_Print.AutoSize = true;
            this.checkBoxItem_Print.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxItem_Print.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItem_Print.Location = new System.Drawing.Point(227, 5);
            this.checkBoxItem_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxItem_Print.Name = "checkBoxItem_Print";
            this.checkBoxItem_Print.Size = new System.Drawing.Size(133, 18);
            this.checkBoxItem_Print.TabIndex = 0;
            this.checkBoxItem_Print.Text = "فایل چاپ شـــــــــــود";
            this.checkBoxItem_Print.UseVisualStyleBackColor = false;
            // 
            // checkBoxItem_ListCuHouse
            // 
            this.checkBoxItem_ListCuHouse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxItem_ListCuHouse.AutoSize = true;
            this.checkBoxItem_ListCuHouse.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxItem_ListCuHouse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItem_ListCuHouse.Location = new System.Drawing.Point(191, 25);
            this.checkBoxItem_ListCuHouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxItem_ListCuHouse.Name = "checkBoxItem_ListCuHouse";
            this.checkBoxItem_ListCuHouse.Size = new System.Drawing.Size(169, 18);
            this.checkBoxItem_ListCuHouse.TabIndex = 1;
            this.checkBoxItem_ListCuHouse.Text = "نمایش لیست متقاضیان ملک";
            this.checkBoxItem_ListCuHouse.UseVisualStyleBackColor = false;
            // 
            // checkBox_AddTelNotebook
            // 
            this.checkBox_AddTelNotebook.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_AddTelNotebook.AutoSize = true;
            this.checkBox_AddTelNotebook.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AddTelNotebook.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AddTelNotebook.Location = new System.Drawing.Point(22, 5);
            this.checkBox_AddTelNotebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_AddTelNotebook.Name = "checkBox_AddTelNotebook";
            this.checkBox_AddTelNotebook.Size = new System.Drawing.Size(118, 18);
            this.checkBox_AddTelNotebook.TabIndex = 2;
            this.checkBox_AddTelNotebook.Text = "اضافه به دفتر تلفن";
            this.checkBox_AddTelNotebook.UseVisualStyleBackColor = false;
            // 
            // checkBox_IsDefaltValue
            // 
            this.checkBox_IsDefaltValue.AutoSize = true;
            this.checkBox_IsDefaltValue.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_IsDefaltValue.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_IsDefaltValue.Location = new System.Drawing.Point(424, 25);
            this.checkBox_IsDefaltValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_IsDefaltValue.Name = "checkBox_IsDefaltValue";
            this.checkBox_IsDefaltValue.Size = new System.Drawing.Size(170, 22);
            this.checkBox_IsDefaltValue.TabIndex = 0;
            this.checkBox_IsDefaltValue.Text = "مقادیر اولیه فعال باشند";
            this.checkBox_IsDefaltValue.UseVisualStyleBackColor = false;
            // 
            // tabItem_FsetHouse
            // 
            this.tabItem_FsetHouse.AttachedControl = this.tabControlPanel_FsetHouse;
            this.tabItem_FsetHouse.Name = "tabItem_FsetHouse";
            this.tabItem_FsetHouse.Text = "tabItem_FsetHouse";
            // 
            // tabControlPanel_AdverField
            // 
            this.tabControlPanel_AdverField.AutoScroll = true;
            this.tabControlPanel_AdverField.AutoScrollMinSize = new System.Drawing.Size(570, 400);
            this.tabControlPanel_AdverField.Controls.Add(this.groupBox_Advertisment);
            this.tabControlPanel_AdverField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_AdverField.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_AdverField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_AdverField.Name = "tabControlPanel_AdverField";
            this.tabControlPanel_AdverField.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_AdverField.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_AdverField.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_AdverField.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_AdverField.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_AdverField.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_AdverField.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_AdverField.Style.GradientAngle = 90;
            this.tabControlPanel_AdverField.TabIndex = 8;
            this.tabControlPanel_AdverField.TabItem = this.tabItem_AdverField;
            // 
            // groupBox_Advertisment
            // 
            this.groupBox_Advertisment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Advertisment.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Advertisment.Controls.Add(this.checkBox_UnitNo);
            this.groupBox_Advertisment.Controls.Add(this.checkBox_FewBedR);
            this.groupBox_Advertisment.Controls.Add(this.checkBox_UseType);
            this.groupBox_Advertisment.Controls.Add(this.checkBox_BldAge);
            this.groupBox_Advertisment.Controls.Add(this.checkBox_PartName);
            this.groupBox_Advertisment.Controls.Add(this.checkBox_AllUnits);
            this.groupBox_Advertisment.Controls.Add(this.comboBox_separator);
            this.groupBox_Advertisment.Controls.Add(this.label_Separator);
            this.groupBox_Advertisment.Controls.Add(this.CheckBox_PriceMR);
            this.groupBox_Advertisment.Controls.Add(this.CheckBox_PriceHouseAll);
            this.groupBox_Advertisment.Controls.Add(this.CheckBox_estateNo);
            this.groupBox_Advertisment.Controls.Add(this.CheckBox_Fewestate);
            this.groupBox_Advertisment.Controls.Add(this.CheckBox_Submeter);
            this.groupBox_Advertisment.Controls.Add(this.CheckBox_housefor);
            this.groupBox_Advertisment.Controls.Add(this.CheckBox_typehouse);
            this.groupBox_Advertisment.Location = new System.Drawing.Point(44, 44);
            this.groupBox_Advertisment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Advertisment.Name = "groupBox_Advertisment";
            this.groupBox_Advertisment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Advertisment.Size = new System.Drawing.Size(499, 405);
            this.groupBox_Advertisment.TabIndex = 9;
            this.groupBox_Advertisment.TabStop = false;
            this.groupBox_Advertisment.Text = "تنظیم فیلدهای آگهی";
            // 
            // checkBox_UnitNo
            // 
            this.checkBox_UnitNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_UnitNo.AutoSize = true;
            this.checkBox_UnitNo.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_UnitNo.Location = new System.Drawing.Point(49, 94);
            this.checkBox_UnitNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_UnitNo.Name = "checkBox_UnitNo";
            this.checkBox_UnitNo.Size = new System.Drawing.Size(86, 18);
            this.checkBox_UnitNo.TabIndex = 55;
            this.checkBox_UnitNo.Text = "شماره واحد";
            this.checkBox_UnitNo.UseVisualStyleBackColor = false;
            // 
            // checkBox_FewBedR
            // 
            this.checkBox_FewBedR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_FewBedR.AutoSize = true;
            this.checkBox_FewBedR.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_FewBedR.Location = new System.Drawing.Point(215, 147);
            this.checkBox_FewBedR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_FewBedR.Name = "checkBox_FewBedR";
            this.checkBox_FewBedR.Size = new System.Drawing.Size(81, 18);
            this.checkBox_FewBedR.TabIndex = 54;
            this.checkBox_FewBedR.Text = "تعداد خواب";
            this.checkBox_FewBedR.UseVisualStyleBackColor = false;
            // 
            // checkBox_UseType
            // 
            this.checkBox_UseType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_UseType.AutoSize = true;
            this.checkBox_UseType.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_UseType.Location = new System.Drawing.Point(58, 252);
            this.checkBox_UseType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_UseType.Name = "checkBox_UseType";
            this.checkBox_UseType.Size = new System.Drawing.Size(77, 18);
            this.checkBox_UseType.TabIndex = 53;
            this.checkBox_UseType.Text = "نوع کاربری";
            this.checkBox_UseType.UseVisualStyleBackColor = false;
            // 
            // checkBox_BldAge
            // 
            this.checkBox_BldAge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox_BldAge.AutoSize = true;
            this.checkBox_BldAge.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_BldAge.Location = new System.Drawing.Point(207, 252);
            this.checkBox_BldAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_BldAge.Name = "checkBox_BldAge";
            this.checkBox_BldAge.Size = new System.Drawing.Size(89, 18);
            this.checkBox_BldAge.TabIndex = 52;
            this.checkBox_BldAge.Text = "سال ساخت";
            this.checkBox_BldAge.UseVisualStyleBackColor = false;
            // 
            // checkBox_PartName
            // 
            this.checkBox_PartName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_PartName.AutoSize = true;
            this.checkBox_PartName.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_PartName.Location = new System.Drawing.Point(400, 252);
            this.checkBox_PartName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_PartName.Name = "checkBox_PartName";
            this.checkBox_PartName.Size = new System.Drawing.Size(75, 18);
            this.checkBox_PartName.TabIndex = 51;
            this.checkBox_PartName.Text = "نام منطقه";
            this.checkBox_PartName.UseVisualStyleBackColor = false;
            // 
            // checkBox_AllUnits
            // 
            this.checkBox_AllUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_AllUnits.AutoSize = true;
            this.checkBox_AllUnits.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AllUnits.Location = new System.Drawing.Point(365, 147);
            this.checkBox_AllUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_AllUnits.Name = "checkBox_AllUnits";
            this.checkBox_AllUnits.Size = new System.Drawing.Size(109, 18);
            this.checkBox_AllUnits.TabIndex = 50;
            this.checkBox_AllUnits.Text = "تعداد کل واحدها";
            this.checkBox_AllUnits.UseVisualStyleBackColor = false;
            // 
            // comboBox_separator
            // 
            this.comboBox_separator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_separator.DropDownHeight = 100;
            this.comboBox_separator.DropDownWidth = 200;
            this.comboBox_separator.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_separator.ForeColor = System.Drawing.Color.Black;
            this.comboBox_separator.IntegralHeight = false;
            this.comboBox_separator.ItemHeight = 20;
            this.comboBox_separator.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.comboBox_separator.Location = new System.Drawing.Point(209, 331);
            this.comboBox_separator.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_separator.Name = "comboBox_separator";
            this.comboBox_separator.Size = new System.Drawing.Size(85, 26);
            this.comboBox_separator.TabIndex = 48;
            this.comboBox_separator.Text = "،";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "،";
            this.comboItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "-";
            this.comboItem2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "  ";
            this.comboItem3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "؛";
            this.comboItem4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem4.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label_Separator
            // 
            this.label_Separator.AutoSize = true;
            this.label_Separator.BackColor = System.Drawing.Color.Transparent;
            this.label_Separator.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Separator.ForeColor = System.Drawing.Color.Black;
            this.label_Separator.Location = new System.Drawing.Point(310, 335);
            this.label_Separator.Name = "label_Separator";
            this.label_Separator.Size = new System.Drawing.Size(65, 17);
            this.label_Separator.TabIndex = 49;
            this.label_Separator.Text = "جداکننده:";
            // 
            // CheckBox_PriceMR
            // 
            this.CheckBox_PriceMR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBox_PriceMR.AutoSize = true;
            this.CheckBox_PriceMR.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_PriceMR.Location = new System.Drawing.Point(180, 199);
            this.CheckBox_PriceMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_PriceMR.Name = "CheckBox_PriceMR";
            this.CheckBox_PriceMR.Size = new System.Drawing.Size(116, 18);
            this.CheckBox_PriceMR.TabIndex = 23;
            this.CheckBox_PriceMR.Text = "قیمت رهن و اجاره";
            this.CheckBox_PriceMR.UseVisualStyleBackColor = false;
            // 
            // CheckBox_PriceHouseAll
            // 
            this.CheckBox_PriceHouseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox_PriceHouseAll.AutoSize = true;
            this.CheckBox_PriceHouseAll.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_PriceHouseAll.Location = new System.Drawing.Point(376, 199);
            this.CheckBox_PriceHouseAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_PriceHouseAll.Name = "CheckBox_PriceHouseAll";
            this.CheckBox_PriceHouseAll.Size = new System.Drawing.Size(98, 18);
            this.CheckBox_PriceHouseAll.TabIndex = 22;
            this.CheckBox_PriceHouseAll.Text = "قیمت کل ملک";
            this.CheckBox_PriceHouseAll.UseVisualStyleBackColor = false;
            // 
            // CheckBox_estateNo
            // 
            this.CheckBox_estateNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBox_estateNo.AutoSize = true;
            this.CheckBox_estateNo.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_estateNo.Location = new System.Drawing.Point(205, 94);
            this.CheckBox_estateNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_estateNo.Name = "CheckBox_estateNo";
            this.CheckBox_estateNo.Size = new System.Drawing.Size(91, 18);
            this.CheckBox_estateNo.TabIndex = 21;
            this.CheckBox_estateNo.Text = "طبقه (چندم)";
            this.CheckBox_estateNo.UseVisualStyleBackColor = false;
            // 
            // CheckBox_Fewestate
            // 
            this.CheckBox_Fewestate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox_Fewestate.AutoSize = true;
            this.CheckBox_Fewestate.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_Fewestate.Location = new System.Drawing.Point(378, 94);
            this.CheckBox_Fewestate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_Fewestate.Name = "CheckBox_Fewestate";
            this.CheckBox_Fewestate.Size = new System.Drawing.Size(96, 18);
            this.CheckBox_Fewestate.TabIndex = 20;
            this.CheckBox_Fewestate.Text = "تعداد طبقه ها";
            this.CheckBox_Fewestate.UseVisualStyleBackColor = false;
            // 
            // CheckBox_Submeter
            // 
            this.CheckBox_Submeter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBox_Submeter.AutoSize = true;
            this.CheckBox_Submeter.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_Submeter.Location = new System.Drawing.Point(86, 41);
            this.CheckBox_Submeter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_Submeter.Name = "CheckBox_Submeter";
            this.CheckBox_Submeter.Size = new System.Drawing.Size(49, 18);
            this.CheckBox_Submeter.TabIndex = 19;
            this.CheckBox_Submeter.Text = "زیربنا";
            this.CheckBox_Submeter.UseVisualStyleBackColor = false;
            // 
            // CheckBox_housefor
            // 
            this.CheckBox_housefor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckBox_housefor.AutoSize = true;
            this.CheckBox_housefor.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_housefor.Location = new System.Drawing.Point(217, 41);
            this.CheckBox_housefor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_housefor.Name = "CheckBox_housefor";
            this.CheckBox_housefor.Size = new System.Drawing.Size(78, 18);
            this.CheckBox_housefor.TabIndex = 18;
            this.CheckBox_housefor.Text = "ملک جهت";
            this.CheckBox_housefor.UseVisualStyleBackColor = false;
            // 
            // CheckBox_typehouse
            // 
            this.CheckBox_typehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox_typehouse.AutoSize = true;
            this.CheckBox_typehouse.BackColor = System.Drawing.Color.Transparent;
            this.CheckBox_typehouse.Location = new System.Drawing.Point(408, 41);
            this.CheckBox_typehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckBox_typehouse.Name = "CheckBox_typehouse";
            this.CheckBox_typehouse.Size = new System.Drawing.Size(67, 18);
            this.CheckBox_typehouse.TabIndex = 17;
            this.CheckBox_typehouse.Text = "نوع ملک";
            this.CheckBox_typehouse.UseVisualStyleBackColor = false;
            // 
            // tabItem_AdverField
            // 
            this.tabItem_AdverField.AttachedControl = this.tabControlPanel_AdverField;
            this.tabItem_AdverField.Name = "tabItem_AdverField";
            this.tabItem_AdverField.Text = "tabItem_AdverField";
            // 
            // tabControlPanel_Sms
            // 
            this.tabControlPanel_Sms.AutoScroll = true;
            this.tabControlPanel_Sms.AutoScrollMinSize = new System.Drawing.Size(600, 400);
            this.tabControlPanel_Sms.Controls.Add(this.groupPanel_SMS);
            this.tabControlPanel_Sms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_Sms.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_Sms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_Sms.Name = "tabControlPanel_Sms";
            this.tabControlPanel_Sms.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_Sms.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_Sms.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_Sms.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_Sms.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_Sms.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_Sms.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_Sms.Style.GradientAngle = 90;
            this.tabControlPanel_Sms.TabIndex = 9;
            this.tabControlPanel_Sms.TabItem = this.tabItem_Sms;
            // 
            // groupPanel_SMS
            // 
            this.groupPanel_SMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel_SMS.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel_SMS.Controls.Add(this.chkDeliveryReport);
            this.groupPanel_SMS.Controls.Add(this.label4);
            this.groupPanel_SMS.Controls.Add(this.cmbLongMsg);
            this.groupPanel_SMS.Controls.Add(this.label36);
            this.groupPanel_SMS.Controls.Add(this.cmbEncoding);
            this.groupPanel_SMS.Controls.Add(this.label28);
            this.groupPanel_SMS.Controls.Add(this.label30);
            this.groupPanel_SMS.Controls.Add(this.label32);
            this.groupPanel_SMS.Controls.Add(this.label33);
            this.groupPanel_SMS.Controls.Add(this.label34);
            this.groupPanel_SMS.Controls.Add(this.label35);
            this.groupPanel_SMS.Controls.Add(this.cmbFlowControl);
            this.groupPanel_SMS.Controls.Add(this.cmbStopBits);
            this.groupPanel_SMS.Controls.Add(this.cmbParity);
            this.groupPanel_SMS.Controls.Add(this.cmbDataBits);
            this.groupPanel_SMS.Controls.Add(this.cmbBaudRate);
            this.groupPanel_SMS.Controls.Add(this.cmbPort);
            this.groupPanel_SMS.Controls.Add(this.chkunicode);
            this.groupPanel_SMS.Controls.Add(this.cmbTimeOut);
            this.groupPanel_SMS.Controls.Add(this.label1);
            this.groupPanel_SMS.Location = new System.Drawing.Point(34, 38);
            this.groupPanel_SMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_SMS.Name = "groupPanel_SMS";
            this.groupPanel_SMS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_SMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupPanel_SMS.Size = new System.Drawing.Size(562, 413);
            this.groupPanel_SMS.TabIndex = 2;
            this.groupPanel_SMS.TabStop = false;
            this.groupPanel_SMS.Text = "SMS";
            // 
            // chkDeliveryReport
            // 
            this.chkDeliveryReport.AutoSize = true;
            this.chkDeliveryReport.Location = new System.Drawing.Point(375, 247);
            this.chkDeliveryReport.Name = "chkDeliveryReport";
            this.chkDeliveryReport.Size = new System.Drawing.Size(159, 18);
            this.chkDeliveryReport.TabIndex = 33;
            this.chkDeliveryReport.Text = "Message Delivery Report";
            this.chkDeliveryReport.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "Long Messages:";
            // 
            // cmbLongMsg
            // 
            this.cmbLongMsg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbLongMsg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLongMsg.FormattingEnabled = true;
            this.cmbLongMsg.Location = new System.Drawing.Point(384, 209);
            this.cmbLongMsg.Name = "cmbLongMsg";
            this.cmbLongMsg.Size = new System.Drawing.Size(145, 22);
            this.cmbLongMsg.TabIndex = 31;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(318, 132);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 14);
            this.label36.TabIndex = 30;
            this.label36.Text = "Encoding:";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(384, 127);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(145, 22);
            this.cmbEncoding.TabIndex = 29;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(46, 281);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 14);
            this.label28.TabIndex = 28;
            this.label28.Text = "Flow Control:";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(66, 242);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 14);
            this.label30.TabIndex = 27;
            this.label30.Text = "Stop Bits:";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(84, 203);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 14);
            this.label32.TabIndex = 26;
            this.label32.Text = "Parity:";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(65, 164);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 14);
            this.label33.TabIndex = 25;
            this.label33.Text = "Data Bits:";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(56, 125);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 14);
            this.label34.TabIndex = 24;
            this.label34.Text = "Baud Rate:";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(89, 95);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 14);
            this.label35.TabIndex = 23;
            this.label35.Text = "Port:";
            // 
            // cmbFlowControl
            // 
            this.cmbFlowControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlowControl.FormattingEnabled = true;
            this.cmbFlowControl.Location = new System.Drawing.Point(129, 282);
            this.cmbFlowControl.Name = "cmbFlowControl";
            this.cmbFlowControl.Size = new System.Drawing.Size(121, 22);
            this.cmbFlowControl.TabIndex = 22;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(129, 243);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 22);
            this.cmbStopBits.TabIndex = 21;
            // 
            // cmbParity
            // 
            this.cmbParity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(129, 204);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 22);
            this.cmbParity.TabIndex = 20;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(129, 165);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 22);
            this.cmbDataBits.TabIndex = 19;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(129, 126);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 22);
            this.cmbBaudRate.TabIndex = 18;
            // 
            // cmbPort
            // 
            this.cmbPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(129, 87);
            this.cmbPort.MaxDropDownItems = 16;
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 22);
            this.cmbPort.TabIndex = 17;
            // 
            // chkunicode
            // 
            this.chkunicode.AutoSize = true;
            this.chkunicode.BackColor = System.Drawing.Color.Transparent;
            this.chkunicode.Checked = true;
            this.chkunicode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkunicode.Location = new System.Drawing.Point(350, 380);
            this.chkunicode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkunicode.Name = "chkunicode";
            this.chkunicode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkunicode.Size = new System.Drawing.Size(156, 18);
            this.chkunicode.TabIndex = 16;
            this.chkunicode.Text = "Send as Unicode(UCS2)";
            this.chkunicode.UseVisualStyleBackColor = false;
            this.chkunicode.Visible = false;
            // 
            // cmbTimeOut
            // 
            this.cmbTimeOut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbTimeOut.AutoCompleteCustomSource.AddRange(new string[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.cmbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeOut.FormattingEnabled = true;
            this.cmbTimeOut.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.cmbTimeOut.Location = new System.Drawing.Point(384, 171);
            this.cmbTimeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTimeOut.Name = "cmbTimeOut";
            this.cmbTimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTimeOut.Size = new System.Drawing.Size(145, 22);
            this.cmbTimeOut.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(316, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Time Out:";
            // 
            // tabItem_Sms
            // 
            this.tabItem_Sms.AttachedControl = this.tabControlPanel_Sms;
            this.tabItem_Sms.Name = "tabItem_Sms";
            this.tabItem_Sms.Text = "tabItem_Sms";
            // 
            // tabControlPanel_WebPart
            // 
            this.tabControlPanel_WebPart.AutoScroll = true;
            this.tabControlPanel_WebPart.AutoScrollMinSize = new System.Drawing.Size(500, 400);
            this.tabControlPanel_WebPart.Controls.Add(this.groupPanel1);
            this.tabControlPanel_WebPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_WebPart.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_WebPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_WebPart.Name = "tabControlPanel_WebPart";
            this.tabControlPanel_WebPart.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_WebPart.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_WebPart.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_WebPart.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_WebPart.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_WebPart.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_WebPart.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_WebPart.Style.GradientAngle = 90;
            this.tabControlPanel_WebPart.TabIndex = 10;
            this.tabControlPanel_WebPart.TabItem = this.tabItem_WebPart;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.comboBox_HPart8);
            this.groupPanel1.Controls.Add(this.comboBox_HPart7);
            this.groupPanel1.Controls.Add(this.label10);
            this.groupPanel1.Controls.Add(this.comboBox_HPart5);
            this.groupPanel1.Controls.Add(this.label11);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.label13);
            this.groupPanel1.Controls.Add(this.comboBox_HPart6);
            this.groupPanel1.Controls.Add(this.comboBox_HPart4);
            this.groupPanel1.Controls.Add(this.comboBox_HPart3);
            this.groupPanel1.Controls.Add(this.label22);
            this.groupPanel1.Controls.Add(this.comboBox_HPart1);
            this.groupPanel1.Controls.Add(this.label25);
            this.groupPanel1.Controls.Add(this.comboBox_HCity);
            this.groupPanel1.Controls.Add(this.comboBox_HState);
            this.groupPanel1.Controls.Add(this.label23);
            this.groupPanel1.Controls.Add(this.comboBox_HCountry);
            this.groupPanel1.Controls.Add(this.label21);
            this.groupPanel1.Controls.Add(this.label17);
            this.groupPanel1.Controls.Add(this.label20);
            this.groupPanel1.Controls.Add(this.label18);
            this.groupPanel1.Controls.Add(this.label19);
            this.groupPanel1.Controls.Add(this.comboBox_HPart2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(1, 1);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel1.MinimumSize = new System.Drawing.Size(446, 100);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(627, 478);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 16;
            this.groupPanel1.Text = "منطقه";
            // 
            // comboBox_HPart8
            // 
            this.comboBox_HPart8.DisplayMember = "PartName_Fa";
            this.comboBox_HPart8.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HPart8.DropDownHeight = 100;
            this.comboBox_HPart8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HPart8.DropDownWidth = 150;
            this.comboBox_HPart8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HPart8.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HPart8.IntegralHeight = false;
            this.comboBox_HPart8.ItemHeight = 16;
            this.comboBox_HPart8.Location = new System.Drawing.Point(159, 300);
            this.comboBox_HPart8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HPart8.Name = "comboBox_HPart8";
            this.comboBox_HPart8.PreventEnterBeep = true;
            this.comboBox_HPart8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HPart8.Size = new System.Drawing.Size(136, 22);
            this.comboBox_HPart8.TabIndex = 162;
            this.comboBox_HPart8.Tag = "0";
            this.comboBox_HPart8.ValueMember = "PartID";
            this.comboBox_HPart8.Enter += new System.EventHandler(this.comboBox_HPart8_Enter);
            // 
            // comboBox_HPart7
            // 
            this.comboBox_HPart7.DisplayMember = "PartName_Fa";
            this.comboBox_HPart7.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HPart7.DropDownHeight = 100;
            this.comboBox_HPart7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HPart7.DropDownWidth = 150;
            this.comboBox_HPart7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HPart7.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HPart7.IntegralHeight = false;
            this.comboBox_HPart7.ItemHeight = 16;
            this.comboBox_HPart7.Location = new System.Drawing.Point(311, 300);
            this.comboBox_HPart7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HPart7.Name = "comboBox_HPart7";
            this.comboBox_HPart7.PreventEnterBeep = true;
            this.comboBox_HPart7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HPart7.Size = new System.Drawing.Size(136, 22);
            this.comboBox_HPart7.TabIndex = 161;
            this.comboBox_HPart7.Tag = "0";
            this.comboBox_HPart7.ValueMember = "PartID";
            this.comboBox_HPart7.Enter += new System.EventHandler(this.comboBox_HPart7_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(222, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 14);
            this.label10.TabIndex = 165;
            this.label10.Text = "8";
            // 
            // comboBox_HPart5
            // 
            this.comboBox_HPart5.DisplayMember = "PartName_Fa";
            this.comboBox_HPart5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HPart5.DropDownHeight = 100;
            this.comboBox_HPart5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HPart5.DropDownWidth = 150;
            this.comboBox_HPart5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HPart5.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HPart5.IntegralHeight = false;
            this.comboBox_HPart5.ItemHeight = 16;
            this.comboBox_HPart5.Location = new System.Drawing.Point(311, 240);
            this.comboBox_HPart5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HPart5.Name = "comboBox_HPart5";
            this.comboBox_HPart5.PreventEnterBeep = true;
            this.comboBox_HPart5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HPart5.Size = new System.Drawing.Size(136, 22);
            this.comboBox_HPart5.TabIndex = 159;
            this.comboBox_HPart5.Tag = "0";
            this.comboBox_HPart5.ValueMember = "PartID";
            this.comboBox_HPart5.Enter += new System.EventHandler(this.comboBox_HPart5_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(222, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 14);
            this.label11.TabIndex = 163;
            this.label11.Text = "6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(364, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 14);
            this.label12.TabIndex = 164;
            this.label12.Text = "7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(364, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 14);
            this.label13.TabIndex = 166;
            this.label13.Text = "5";
            // 
            // comboBox_HPart6
            // 
            this.comboBox_HPart6.DisplayMember = "PartName_Fa";
            this.comboBox_HPart6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HPart6.DropDownHeight = 100;
            this.comboBox_HPart6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HPart6.DropDownWidth = 150;
            this.comboBox_HPart6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HPart6.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HPart6.IntegralHeight = false;
            this.comboBox_HPart6.ItemHeight = 16;
            this.comboBox_HPart6.Location = new System.Drawing.Point(159, 240);
            this.comboBox_HPart6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HPart6.Name = "comboBox_HPart6";
            this.comboBox_HPart6.PreventEnterBeep = true;
            this.comboBox_HPart6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HPart6.Size = new System.Drawing.Size(136, 22);
            this.comboBox_HPart6.TabIndex = 160;
            this.comboBox_HPart6.Tag = "0";
            this.comboBox_HPart6.ValueMember = "PartID";
            this.comboBox_HPart6.Enter += new System.EventHandler(this.comboBox_HPart6_Enter);
            // 
            // comboBox_HPart4
            // 
            this.comboBox_HPart4.DisplayMember = "PartName_Fa";
            this.comboBox_HPart4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HPart4.DropDownHeight = 100;
            this.comboBox_HPart4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HPart4.DropDownWidth = 150;
            this.comboBox_HPart4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HPart4.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HPart4.IntegralHeight = false;
            this.comboBox_HPart4.ItemHeight = 16;
            this.comboBox_HPart4.Location = new System.Drawing.Point(159, 180);
            this.comboBox_HPart4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HPart4.Name = "comboBox_HPart4";
            this.comboBox_HPart4.PreventEnterBeep = true;
            this.comboBox_HPart4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HPart4.Size = new System.Drawing.Size(136, 22);
            this.comboBox_HPart4.TabIndex = 7;
            this.comboBox_HPart4.Tag = "0";
            this.comboBox_HPart4.ValueMember = "PartID";
            this.comboBox_HPart4.Enter += new System.EventHandler(this.comboBox_HPart4_Enter);
            // 
            // comboBox_HPart3
            // 
            this.comboBox_HPart3.DisplayMember = "PartName_Fa";
            this.comboBox_HPart3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HPart3.DropDownHeight = 100;
            this.comboBox_HPart3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HPart3.DropDownWidth = 150;
            this.comboBox_HPart3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HPart3.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HPart3.IntegralHeight = false;
            this.comboBox_HPart3.ItemHeight = 16;
            this.comboBox_HPart3.Location = new System.Drawing.Point(311, 180);
            this.comboBox_HPart3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HPart3.Name = "comboBox_HPart3";
            this.comboBox_HPart3.PreventEnterBeep = true;
            this.comboBox_HPart3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HPart3.Size = new System.Drawing.Size(136, 22);
            this.comboBox_HPart3.TabIndex = 6;
            this.comboBox_HPart3.Tag = "0";
            this.comboBox_HPart3.ValueMember = "PartID";
            this.comboBox_HPart3.Enter += new System.EventHandler(this.comboBox_HPart3_Enter);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(222, 164);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 14);
            this.label22.TabIndex = 133;
            this.label22.Text = "4";
            // 
            // comboBox_HPart1
            // 
            this.comboBox_HPart1.DisplayMember = "PartName_Fa";
            this.comboBox_HPart1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HPart1.DropDownHeight = 100;
            this.comboBox_HPart1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HPart1.DropDownWidth = 150;
            this.comboBox_HPart1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HPart1.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HPart1.IntegralHeight = false;
            this.comboBox_HPart1.ItemHeight = 16;
            this.comboBox_HPart1.Location = new System.Drawing.Point(311, 119);
            this.comboBox_HPart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HPart1.Name = "comboBox_HPart1";
            this.comboBox_HPart1.PreventEnterBeep = true;
            this.comboBox_HPart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HPart1.Size = new System.Drawing.Size(136, 22);
            this.comboBox_HPart1.TabIndex = 4;
            this.comboBox_HPart1.Tag = "0";
            this.comboBox_HPart1.ValueMember = "PartID";
            this.comboBox_HPart1.Enter += new System.EventHandler(this.comboBox_HPart1_Enter);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(222, 104);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(14, 14);
            this.label25.TabIndex = 129;
            this.label25.Text = "2";
            // 
            // comboBox_HCity
            // 
            this.comboBox_HCity.DisplayMember = "CityName_Fa";
            this.comboBox_HCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HCity.DropDownHeight = 100;
            this.comboBox_HCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HCity.DropDownWidth = 150;
            this.comboBox_HCity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HCity.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HCity.IntegralHeight = false;
            this.comboBox_HCity.ItemHeight = 16;
            this.comboBox_HCity.Location = new System.Drawing.Point(147, 30);
            this.comboBox_HCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HCity.Name = "comboBox_HCity";
            this.comboBox_HCity.PreventEnterBeep = true;
            this.comboBox_HCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HCity.Size = new System.Drawing.Size(106, 22);
            this.comboBox_HCity.TabIndex = 3;
            this.comboBox_HCity.Tag = "0";
            this.comboBox_HCity.ValueMember = "CityID";
            this.comboBox_HCity.Enter += new System.EventHandler(this.comboBox_HCity_Enter);
            this.comboBox_HCity.Leave += new System.EventHandler(this.comboBox_HCity_Leave);
            // 
            // comboBox_HState
            // 
            this.comboBox_HState.DisplayMember = "StateName_Fa";
            this.comboBox_HState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HState.DropDownHeight = 100;
            this.comboBox_HState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HState.DropDownWidth = 150;
            this.comboBox_HState.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HState.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HState.IntegralHeight = false;
            this.comboBox_HState.ItemHeight = 16;
            this.comboBox_HState.Location = new System.Drawing.Point(259, 30);
            this.comboBox_HState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HState.Name = "comboBox_HState";
            this.comboBox_HState.PreventEnterBeep = true;
            this.comboBox_HState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HState.Size = new System.Drawing.Size(106, 22);
            this.comboBox_HState.TabIndex = 2;
            this.comboBox_HState.Tag = "0";
            this.comboBox_HState.ValueMember = "StateID";
            this.comboBox_HState.Enter += new System.EventHandler(this.comboBox_HState_Enter);
            this.comboBox_HState.Leave += new System.EventHandler(this.comboBox_HState_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(364, 164);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 14);
            this.label23.TabIndex = 131;
            this.label23.Text = "3";
            // 
            // comboBox_HCountry
            // 
            this.comboBox_HCountry.DisplayMember = "CountryName_Fa";
            this.comboBox_HCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HCountry.DropDownHeight = 100;
            this.comboBox_HCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HCountry.DropDownWidth = 150;
            this.comboBox_HCountry.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HCountry.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HCountry.IntegralHeight = false;
            this.comboBox_HCountry.ItemHeight = 16;
            this.comboBox_HCountry.Location = new System.Drawing.Point(371, 30);
            this.comboBox_HCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HCountry.Name = "comboBox_HCountry";
            this.comboBox_HCountry.PreventEnterBeep = true;
            this.comboBox_HCountry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HCountry.Size = new System.Drawing.Size(106, 22);
            this.comboBox_HCountry.TabIndex = 1;
            this.comboBox_HCountry.Tag = "0";
            this.comboBox_HCountry.ValueMember = "CountryID";
            this.comboBox_HCountry.Enter += new System.EventHandler(this.comboBox_HCountry_Enter);
            this.comboBox_HCountry.Leave += new System.EventHandler(this.comboBox_HCountry_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(364, 104);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 14);
            this.label21.TabIndex = 145;
            this.label21.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(503, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 14);
            this.label17.TabIndex = 158;
            this.label17.Text = "نام:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(183, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 14);
            this.label20.TabIndex = 144;
            this.label20.Text = "شهر";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(400, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 14);
            this.label18.TabIndex = 139;
            this.label18.Text = "کشور";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(287, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 14);
            this.label19.TabIndex = 143;
            this.label19.Text = "استان";
            // 
            // comboBox_HPart2
            // 
            this.comboBox_HPart2.DisplayMember = "PartName_Fa";
            this.comboBox_HPart2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_HPart2.DropDownHeight = 100;
            this.comboBox_HPart2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HPart2.DropDownWidth = 150;
            this.comboBox_HPart2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_HPart2.ForeColor = System.Drawing.Color.Black;
            this.comboBox_HPart2.IntegralHeight = false;
            this.comboBox_HPart2.ItemHeight = 16;
            this.comboBox_HPart2.Location = new System.Drawing.Point(159, 119);
            this.comboBox_HPart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_HPart2.Name = "comboBox_HPart2";
            this.comboBox_HPart2.PreventEnterBeep = true;
            this.comboBox_HPart2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_HPart2.Size = new System.Drawing.Size(136, 22);
            this.comboBox_HPart2.TabIndex = 5;
            this.comboBox_HPart2.Tag = "0";
            this.comboBox_HPart2.ValueMember = "PartID";
            this.comboBox_HPart2.Enter += new System.EventHandler(this.comboBox_HPart2_Enter);
            // 
            // tabItem_WebPart
            // 
            this.tabItem_WebPart.AttachedControl = this.tabControlPanel_WebPart;
            this.tabItem_WebPart.Name = "tabItem_WebPart";
            this.tabItem_WebPart.Text = "tabItem_WebPart";
            // 
            // tabControlPanel_SetUnits
            // 
            this.tabControlPanel_SetUnits.AutoScroll = true;
            this.tabControlPanel_SetUnits.AutoScrollMinSize = new System.Drawing.Size(550, 400);
            this.tabControlPanel_SetUnits.Controls.Add(this.groupBox_MoneyUnit);
            this.tabControlPanel_SetUnits.Controls.Add(this.groupPanel2);
            this.tabControlPanel_SetUnits.Controls.Add(this.button_Active);
            this.tabControlPanel_SetUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetUnits.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetUnits.Name = "tabControlPanel_SetUnits";
            this.tabControlPanel_SetUnits.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetUnits.Size = new System.Drawing.Size(629, 489);
            this.tabControlPanel_SetUnits.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tabControlPanel_SetUnits.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tabControlPanel_SetUnits.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetUnits.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabControlPanel_SetUnits.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetUnits.Style.GradientAngle = 90;
            this.tabControlPanel_SetUnits.TabIndex = 11;
            this.tabControlPanel_SetUnits.TabItem = this.tabItem_SetUnits;
            // 
            // groupBox_MoneyUnit
            // 
            this.groupBox_MoneyUnit.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupBox_MoneyUnit.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupBox_MoneyUnit.Controls.Add(this.textBox_ChangeMoney);
            this.groupBox_MoneyUnit.Controls.Add(this.comboBox_MnyUnit);
            this.groupBox_MoneyUnit.Controls.Add(this.label31);
            this.groupBox_MoneyUnit.Controls.Add(this.label_MnyUnit);
            this.groupBox_MoneyUnit.Controls.Add(this.label29);
            this.groupBox_MoneyUnit.Controls.Add(this.label27);
            this.groupBox_MoneyUnit.Controls.Add(this.label_MnyU);
            this.groupBox_MoneyUnit.Enabled = false;
            this.groupBox_MoneyUnit.Location = new System.Drawing.Point(28, 177);
            this.groupBox_MoneyUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_MoneyUnit.Name = "groupBox_MoneyUnit";
            this.groupBox_MoneyUnit.Size = new System.Drawing.Size(494, 236);
            // 
            // 
            // 
            this.groupBox_MoneyUnit.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupBox_MoneyUnit.Style.BackColorGradientAngle = 90;
            this.groupBox_MoneyUnit.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupBox_MoneyUnit.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox_MoneyUnit.Style.BorderBottomWidth = 1;
            this.groupBox_MoneyUnit.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupBox_MoneyUnit.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox_MoneyUnit.Style.BorderLeftWidth = 1;
            this.groupBox_MoneyUnit.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox_MoneyUnit.Style.BorderRightWidth = 1;
            this.groupBox_MoneyUnit.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox_MoneyUnit.Style.BorderTopWidth = 1;
            this.groupBox_MoneyUnit.Style.CornerDiameter = 4;
            this.groupBox_MoneyUnit.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupBox_MoneyUnit.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupBox_MoneyUnit.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupBox_MoneyUnit.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupBox_MoneyUnit.TabIndex = 104;
            this.groupBox_MoneyUnit.Text = "واحد پول";
            // 
            // textBox_ChangeMoney
            // 
            this.textBox_ChangeMoney.Location = new System.Drawing.Point(216, 93);
            this.textBox_ChangeMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ChangeMoney.Name = "textBox_ChangeMoney";
            this.textBox_ChangeMoney.Size = new System.Drawing.Size(65, 22);
            this.textBox_ChangeMoney.TabIndex = 104;
            this.textBox_ChangeMoney.Text = "1";
            this.textBox_ChangeMoney.TextChanged += new System.EventHandler(this.textBox_Change_TextChanged);
            this.textBox_ChangeMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Change_KeyPress);
            // 
            // comboBox_MnyUnit
            // 
            this.comboBox_MnyUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_MnyUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_MnyUnit.ForeColor = System.Drawing.Color.Black;
            this.comboBox_MnyUnit.ItemHeight = 16;
            this.comboBox_MnyUnit.Items.AddRange(new object[] {
            this.comboItem14,
            this.comboItem15,
            this.comboItem31});
            this.comboBox_MnyUnit.Location = new System.Drawing.Point(194, 26);
            this.comboBox_MnyUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_MnyUnit.Name = "comboBox_MnyUnit";
            this.comboBox_MnyUnit.Size = new System.Drawing.Size(132, 22);
            this.comboBox_MnyUnit.TabIndex = 97;
            this.comboBox_MnyUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_MnyUnit_SelectedIndexChanged);
            // 
            // comboItem14
            // 
            this.comboItem14.Text = "ریال";
            this.comboItem14.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem14.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem15
            // 
            this.comboItem15.Text = "تومان";
            this.comboItem15.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem15.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem31
            // 
            this.comboItem31.Text = "دلار";
            this.comboItem31.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem31.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label31.ForeColor = System.Drawing.Color.Maroon;
            this.label31.Location = new System.Drawing.Point(173, 92);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(37, 18);
            this.label31.TabIndex = 103;
            this.label31.Text = "ریال";
            // 
            // label_MnyUnit
            // 
            this.label_MnyUnit.AutoSize = true;
            this.label_MnyUnit.BackColor = System.Drawing.Color.Transparent;
            this.label_MnyUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MnyUnit.ForeColor = System.Drawing.Color.Black;
            this.label_MnyUnit.Location = new System.Drawing.Point(337, 29);
            this.label_MnyUnit.Name = "label_MnyUnit";
            this.label_MnyUnit.Size = new System.Drawing.Size(54, 14);
            this.label_MnyUnit.TabIndex = 98;
            this.label_MnyUnit.Text = "واحد پول:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(287, 94);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 17);
            this.label29.TabIndex = 101;
            this.label29.Text = "=";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(378, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 17);
            this.label27.TabIndex = 99;
            this.label27.Text = "یک";
            // 
            // label_MnyU
            // 
            this.label_MnyU.AutoSize = true;
            this.label_MnyU.BackColor = System.Drawing.Color.Transparent;
            this.label_MnyU.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_MnyU.ForeColor = System.Drawing.Color.Maroon;
            this.label_MnyU.Location = new System.Drawing.Point(332, 93);
            this.label_MnyU.Name = "label_MnyU";
            this.label_MnyU.Size = new System.Drawing.Size(29, 18);
            this.label_MnyU.TabIndex = 100;
            this.label_MnyU.Text = "یک";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.label14);
            this.groupPanel2.Controls.Add(this.comboBox_TypeFileNo);
            this.groupPanel2.Location = new System.Drawing.Point(28, 34);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(563, 93);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 103;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(362, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 14);
            this.label14.TabIndex = 102;
            this.label14.Text = "نوع شماره فایل:";
            // 
            // comboBox_TypeFileNo
            // 
            this.comboBox_TypeFileNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_TypeFileNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TypeFileNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TypeFileNo.ForeColor = System.Drawing.Color.Black;
            this.comboBox_TypeFileNo.ItemHeight = 16;
            this.comboBox_TypeFileNo.Items.AddRange(new object[] {
            this.comboItem_Int,
            this.comboItem_String});
            this.comboBox_TypeFileNo.Location = new System.Drawing.Point(210, 25);
            this.comboBox_TypeFileNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_TypeFileNo.Name = "comboBox_TypeFileNo";
            this.comboBox_TypeFileNo.Size = new System.Drawing.Size(141, 22);
            this.comboBox_TypeFileNo.TabIndex = 101;
            // 
            // comboItem_Int
            // 
            this.comboItem_Int.Text = "عددی";
            this.comboItem_Int.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem_Int.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // comboItem_String
            // 
            this.comboItem_String.Text = "متنی";
            this.comboItem_String.TextAlignment = System.Drawing.StringAlignment.Center;
            this.comboItem_String.TextLineAlignment = System.Drawing.StringAlignment.Center;
            // 
            // button_Active
            // 
            this.button_Active.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Active.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Active.Location = new System.Drawing.Point(543, 189);
            this.button_Active.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Active.Name = "button_Active";
            this.button_Active.Size = new System.Drawing.Size(47, 77);
            this.button_Active.TabIndex = 99;
            this.button_Active.Text = "فعال شود";
            this.button_Active.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // tabItem_SetUnits
            // 
            this.tabItem_SetUnits.AttachedControl = this.tabControlPanel_SetUnits;
            this.tabItem_SetUnits.Name = "tabItem_SetUnits";
            this.tabItem_SetUnits.Text = "tabItem_SetUnits";
            // 
            // Setting_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 552);
            this.Controls.Add(this.tabControl_Setting);
            this.Controls.Add(this.treeView_Setting);
            this.Controls.Add(this.ribbonBar_Setting);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Setting_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_frm_FormClosing);
            this.Load += new System.EventHandler(this.Setting_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Setting)).EndInit();
            this.tabControl_Setting.ResumeLayout(false);
            this.tabControlPanel_SetAlarms.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_OnNonActive)).EndInit();
            this.tabControlPanel_SetBkpRst.ResumeLayout(false);
            this.groupBox_Set.ResumeLayout(false);
            this.groupBox_Set.PerformLayout();
            this.groupBox_Rst.ResumeLayout(false);
            this.groupBox_Bkp.ResumeLayout(false);
            this.groupBox_Bkp.PerformLayout();
            this.tabControlPanel_SetAgPos.ResumeLayout(false);
            this.groupBox_Pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CityPic)).EndInit();
            this.tabControlPanel_SetAgReg.ResumeLayout(false);
            this.groupBox_Reg.ResumeLayout(false);
            this.groupBox_Reg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AgencyLogo)).EndInit();
            this.tabControlPanel_SetUseHouse.ResumeLayout(false);
            this.groupPanel_ReqFor.ResumeLayout(false);
            this.groupPanel_TypeHouse.ResumeLayout(false);
            this.groupPanel_HouseFor.ResumeLayout(false);
            this.tabControlPanel_SetPosDef.ResumeLayout(false);
            this.groupBox_PartSet.ResumeLayout(false);
            this.groupBox_PartSet.PerformLayout();
            this.tabControlPanel_FsetHouse.ResumeLayout(false);
            this.tabControlPanel_FsetHouse.PerformLayout();
            this.groupPanel_Instalation.ResumeLayout(false);
            this.groupPanel_Instalation.PerformLayout();
            this.groupPanel_RegH.ResumeLayout(false);
            this.groupPanel_RegH.PerformLayout();
            this.groupPanel_Part.ResumeLayout(false);
            this.groupPanel_Part.PerformLayout();
            this.groupPanel_StatusH.ResumeLayout(false);
            this.groupPanel_StatusH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_KitchenFew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_FRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_FBed)).EndInit();
            this.groupPanel_facility.ResumeLayout(false);
            this.groupPanel_facility.PerformLayout();
            this.groupPanel_StsFile.ResumeLayout(false);
            this.groupPanel_StsFile.PerformLayout();
            this.panel_Date.ResumeLayout(false);
            this.panel_Date.PerformLayout();
            this.groupPanel_House.ResumeLayout(false);
            this.groupPanel_House.PerformLayout();
            this.groupPanel_Ctrl.ResumeLayout(false);
            this.groupPanel_Ctrl.PerformLayout();
            this.tabControlPanel_AdverField.ResumeLayout(false);
            this.groupBox_Advertisment.ResumeLayout(false);
            this.groupBox_Advertisment.PerformLayout();
            this.tabControlPanel_Sms.ResumeLayout(false);
            this.groupPanel_SMS.ResumeLayout(false);
            this.groupPanel_SMS.PerformLayout();
            this.tabControlPanel_WebPart.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.tabControlPanel_SetUnits.ResumeLayout(false);
            this.groupBox_MoneyUnit.ResumeLayout(false);
            this.groupBox_MoneyUnit.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Setting;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private System.Windows.Forms.ImageList imageList_Setting;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_FsetHouse;
        private DevComponents.DotNetBar.TabItem tabItem_FsetHouse;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_StsFile;
        private System.Windows.Forms.Label label_NonActDate;
        private System.Windows.Forms.RadioButton radioButton_Active;
        private System.Windows.Forms.RadioButton radioButton_nonActive;
        private System.Windows.Forms.Label label_Priority;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Priority;
        private DevComponents.Editors.ComboItem comboItem8;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem13;
        private System.Windows.Forms.CheckBox checkBox_IsDefaltValue;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Part;
        private System.Windows.Forms.CheckBox checkBoxItem_Print;
        private System.Windows.Forms.CheckBox checkBoxItem_ListCuHouse;
        private System.Windows.Forms.CheckBox checkBox_AddTelNotebook;
        private System.Windows.Forms.CheckBox checkBox_HoldData;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_RegH;
        private System.Windows.Forms.Label label_UseType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_UseType;
        private DevComponents.Editors.ComboItem comboItem25;
        private DevComponents.Editors.ComboItem comboItem26;
        private DevComponents.Editors.ComboItem comboItem28;
        private DevComponents.Editors.ComboItem comboItem29;
        private DevComponents.Editors.ComboItem comboItem30;
        private System.Windows.Forms.Label label_LicenceType;
        private System.Windows.Forms.CheckBox checkBox_KeyMoney;
        private System.Windows.Forms.CheckBox checkBox_DocUse;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_LicenceType;
        private System.Windows.Forms.CheckBox checkBox_Property;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_DocType;
        private DevComponents.Editors.ComboItem comboItem32;
        private DevComponents.Editors.ComboItem comboItem33;
        private DevComponents.Editors.ComboItem comboItem34;
        private DevComponents.Editors.ComboItem comboItem35;
        private DevComponents.Editors.ComboItem comboItem36;
        private DevComponents.Editors.ComboItem comboItem37;
        private DevComponents.Editors.ComboItem comboItem38;
        private DevComponents.Editors.ComboItem comboItem39;
        private DevComponents.Editors.ComboItem comboItem40;
        private DevComponents.Editors.ComboItem comboItem41;
        private System.Windows.Forms.Label label_DocType;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_StatusH;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_BldLow;
        private DevComponents.Editors.ComboItem comboItem24;
        private DevComponents.Editors.ComboItem comboItem27;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_RcRoom;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.Editors.ComboItem comboItem12;
        private DevComponents.Editors.ComboItem comboItem23;
        private System.Windows.Forms.CheckBox checkBox_Patio;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_CT;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.Editors.ComboItem comboItem7;
        private System.Windows.Forms.CheckBox checkBox_BYard;
        private System.Windows.Forms.Label label_CT;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_MK;
        private DevComponents.Editors.ComboItem comboItem16;
        private DevComponents.Editors.ComboItem comboItem17;
        private DevComponents.Editors.ComboItem comboItem18;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_BedRoom;
        private DevComponents.Editors.ComboItem comboItem20;
        private DevComponents.Editors.ComboItem comboItem19;
        private DevComponents.Editors.ComboItem comboItem22;
        private DevComponents.Editors.ComboItem comboItem21;
        private System.Windows.Forms.CheckBox checkBox_Yard;
        private System.Windows.Forms.Label label_MK;
        private System.Windows.Forms.Label label_KitchenFew;
        private System.Windows.Forms.CheckBox checkBox_Cellar;
        private System.Windows.Forms.Label label_BldLow;
        private System.Windows.Forms.NumericUpDown nUpDown_KitchenFew;
        private System.Windows.Forms.Label label_FBed;
        private System.Windows.Forms.CheckBox checkBox_StRoom;
        private System.Windows.Forms.Label label_RCRoom;
        private System.Windows.Forms.NumericUpDown nUpDown_FRoom;
        private System.Windows.Forms.CheckBox checkBox_Balcony;
        private System.Windows.Forms.Label label_FRoom;
        private System.Windows.Forms.CheckBox checkBox_FirePlace;
        private System.Windows.Forms.Label label_Bedroom;
        private System.Windows.Forms.NumericUpDown nUpDown_FBed;
        private System.Windows.Forms.CheckBox checkBox_Parking;
        private System.Windows.Forms.CheckBox checkBox_FWc;
        private System.Windows.Forms.CheckBox checkBox_Tel;
        private System.Windows.Forms.CheckBox checkBox_IRWc;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Instalation;
        private System.Windows.Forms.CheckBox checkBox_Water;
        private System.Windows.Forms.CheckBox checkBox_Electricity;
        private System.Windows.Forms.CheckBox checkBox_Gaz;
        private System.Windows.Forms.CheckBox checkBox_Cooler;
        private System.Windows.Forms.CheckBox checkBox_FanCoel;
        private System.Windows.Forms.CheckBox checkBox_Heat;
        private System.Windows.Forms.CheckBox checkBox_Chiler;
        private System.Windows.Forms.CheckBox checkBox_Pakage;
        private System.Windows.Forms.CheckBox checkBox_Sauna;
        private System.Windows.Forms.CheckBox checkBox_Jacuzzi;
        private System.Windows.Forms.CheckBox checkBox_Pool;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetPosDef;
        private DevComponents.DotNetBar.TabItem tabItem_SetPosDef;
        private System.Windows.Forms.GroupBox groupBox_PartSet;
        private DevComponents.DotNetBar.ButtonX button_AddPrt;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Stt;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Prt;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Cntry;
        private System.Windows.Forms.Label label_Prt;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Cty;
        private System.Windows.Forms.Label label_Cty;
        private System.Windows.Forms.Label label_Cntry;
        private System.Windows.Forms.Label label_Stt;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetUseHouse;
        private DevComponents.DotNetBar.TabItem tabItem_SetUseHouse;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetAgReg;
        private DevComponents.DotNetBar.TabItem tabItem_SetAgReg;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetAgPos;
        private DevComponents.DotNetBar.TabItem tabItem_SetAgPos;
        private System.Windows.Forms.GroupBox groupBox_Reg;
        private DevComponents.DotNetBar.ButtonX button_AgencyLogo;
        private System.Windows.Forms.PictureBox pictureBox_AgencyLogo;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AgancyMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AgancyTel;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AgancyName;
        private System.Windows.Forms.Label label_AgancyMobile;
        private System.Windows.Forms.Label label_AgancyTel;
        private System.Windows.Forms.Label label_AgancyName;
        private System.Windows.Forms.GroupBox groupBox_Pic;
        private DevComponents.DotNetBar.ButtonX button_CityPic;
        private System.Windows.Forms.PictureBox pictureBox_CityPic;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetBkpRst;
        private DevComponents.DotNetBar.TabItem tabItem_SetBkpRst;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetAlarms;
        private DevComponents.DotNetBar.TabItem tabItem_SetAlarms;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_Sms;
        private DevComponents.DotNetBar.TabItem tabItem_Sms;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_AdverField;
        private DevComponents.DotNetBar.TabItem tabItem_AdverField;
        private System.Windows.Forms.GroupBox groupBox_Advertisment;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_separator;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private System.Windows.Forms.Label label_Separator;
        private System.Windows.Forms.CheckBox CheckBox_PriceMR;
        private System.Windows.Forms.CheckBox CheckBox_PriceHouseAll;
        private System.Windows.Forms.CheckBox CheckBox_estateNo;
        private System.Windows.Forms.CheckBox CheckBox_Fewestate;
        private System.Windows.Forms.CheckBox CheckBox_Submeter;
        private System.Windows.Forms.CheckBox CheckBox_housefor;
        private System.Windows.Forms.CheckBox CheckBox_typehouse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nUpDown_OnNonActive;
        private System.Windows.Forms.RadioButton radioButton_OffNonActive;
        private System.Windows.Forms.RadioButton radioButton_OnNonActive;
        private System.Windows.Forms.CheckBox chkunicode;
        private System.Windows.Forms.ComboBox cmbTimeOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_Rst;
        private DevComponents.DotNetBar.ButtonX button_RstChangePass;
        private System.Windows.Forms.GroupBox groupBox_Bkp;
        private System.Windows.Forms.Label label_BkpAuto;
        private DevComponents.DotNetBar.ButtonX button_BkpAuto;
        private System.Windows.Forms.RadioButton radioButton_BkpNo;
        private System.Windows.Forms.RadioButton radioButton_BkpAuto;
        private System.Windows.Forms.RadioButton radioButton_BkpNonAuto;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TreeView treeView_Setting;
        private DevComponents.DotNetBar.TabControl tabControl_Setting;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_HouseFor;
        private System.Windows.Forms.ListBox listBox_TypeHouse;
        private System.Windows.Forms.ListBox listBox_HouseFor;
        private System.Windows.Forms.ListBox listBox_ReqFor;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_State;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Country;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.Label label_State;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_Part;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_City;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_Part;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AgencyAddress;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Ctrl;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_House;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HouseFor;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_TypeHouse;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_facility;
        private System.Windows.Forms.CheckBox checkBox_EmployeeSrv;
        private System.Windows.Forms.CheckBox checkBox_AV;
        private System.Windows.Forms.CheckBox checkBox_RubShooting;
        private System.Windows.Forms.CheckBox checkBox_SK;
        private System.Windows.Forms.CheckBox checkBox_RDoor;
        private System.Windows.Forms.CheckBox checkBox_AC;
        private System.Windows.Forms.CheckBox checkBox_Elevatoor;
        private System.Windows.Forms.Panel panel_Date;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Year1;
        private System.Windows.Forms.ComboBox comboBox_day1;
        private System.Windows.Forms.ComboBox comboBox_Month1;
        private System.Windows.Forms.GroupBox groupPanel_SMS;
        private System.Windows.Forms.Button button_DownTH;
        private System.Windows.Forms.Button button_UpTH;
        private DevComponents.DotNetBar.ButtonX button_DelTH;
        private DevComponents.DotNetBar.ButtonX button_AddTH;
        private System.Windows.Forms.ComboBox comboBox_AddTH;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_TypeHouse;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_ReqFor;
        private System.Windows.Forms.ComboBox comboBox_AddRF;
        private DevComponents.DotNetBar.ButtonX button_AddRF;
        private DevComponents.DotNetBar.ButtonX button_DelRF;
        private System.Windows.Forms.Button button_UpRF;
        private System.Windows.Forms.Button button_DownRF;
        private System.Windows.Forms.ComboBox comboBox_AddHF;
        private DevComponents.DotNetBar.ButtonX button_AddHF;
        private DevComponents.DotNetBar.ButtonX button_DelHF;
        private System.Windows.Forms.Button button_UpHF;
        private System.Windows.Forms.Button button_DownHF;
        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_NewPart;
        private DevComponents.DotNetBar.ButtonX button_DelPrt;
        private System.Windows.Forms.CheckBox checkBox_AllUnits;
        private System.Windows.Forms.CheckBox checkBox_FewBedR;
        private System.Windows.Forms.CheckBox checkBox_UseType;
        private System.Windows.Forms.CheckBox checkBox_BldAge;
        private System.Windows.Forms.CheckBox checkBox_PartName;
        private System.Windows.Forms.CheckBox checkBox_UnitNo;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_WebPart;
        private DevComponents.DotNetBar.TabItem tabItem_WebPart;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HPart8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HPart7;
        private System.Windows.Forms.Label label10;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HPart5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HPart6;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HPart4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HPart3;
        private System.Windows.Forms.Label label22;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HPart1;
        private System.Windows.Forms.Label label25;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HCity;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HState;
        private System.Windows.Forms.Label label23;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HCountry;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_HPart2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevComponents.DotNetBar.ButtonX button_PartUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AdminAgName;
        private System.Windows.Forms.Label label24;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AgEmail;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetUnits;
        private DevComponents.DotNetBar.TabItem tabItem_SetUnits;
        private System.Windows.Forms.Label label_MnyUnit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_MnyUnit;
        private DevComponents.Editors.ComboItem comboItem14;
        private DevComponents.Editors.ComboItem comboItem15;
        private DevComponents.Editors.ComboItem comboItem31;
        private DevComponents.DotNetBar.ButtonX button_Active;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label_MnyU;
        private System.Windows.Forms.TextBox textBox_ChangeMoney;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Label label14;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_TypeFileNo;
        private DevComponents.Editors.ComboItem comboItem_Int;
        private DevComponents.Editors.ComboItem comboItem_String;
        private DevComponents.DotNetBar.Controls.GroupPanel groupBox_MoneyUnit;
        private System.Windows.Forms.GroupBox groupBox_Set;
        private System.Windows.Forms.CheckBox checkBox_BRPicFilm;
        private System.Windows.Forms.CheckBox checkBox_BRDesignRep;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cmbFlowControl;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLongMsg;
        private System.Windows.Forms.CheckBox chkDeliveryReport;
    }
}
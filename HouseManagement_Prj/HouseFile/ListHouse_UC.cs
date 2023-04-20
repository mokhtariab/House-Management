using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace HouseManagement_Prj
{
    public partial class ListHouse_UC: UserControl
    {
        public ListHouse_UC()
        {
            InitializeComponent();
        }

        private DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        DataClassesSecondDataContext DCSDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        public int SearchOrNo = 0;
        public string ListWhereSearch = "";
        private bool LoadStatus = false;//ContexMenu
        private string FileNoFieldStr = "FileNo";
        int dgRowCnt = 0;


        #region Load & UI
        private void ListHouse_UC_Load(object sender, EventArgs e)
        {
            //fileno visible
            dataGridView_ListHouse.Columns["FileNO"].Visible = !Global_Cls.FileNoFlage;
            dataGridView_ListHouse.Columns["FileNOInt"].Visible = Global_Cls.FileNoFlage;

            if (Global_Cls.FileNoFlage) FileNoFieldStr = "FileNOInt";
            
            //new
            comboBox_TypeHouse.Items.Add("");
            comboBox_HouseFor.Items.Add("");
            for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
                comboBox_TypeHouse.Items.Add(Global_Cls.TypeHouseAllCases[i]);
            for (int i = 0; i < Global_Cls.HouseForPrm.Count; i++)//new
                comboBox_HouseFor.Items.Add(Global_Cls.HouseForPrm[i]);//new
            //new
            
            string UPer=Global_Cls.MainForm.UserPermission;
            if ( UPer!= "" && UPer != "admin")
            {
                if (UPer.Contains(button_Transmutation.Name)) button_Transmutation.Enabled = false;
                if (UPer.Contains(buttonItem_Del.Name)) buttonItem_Del.Enabled = false;
                if (UPer.Contains(buttonItem_ForMemorundom.Name)) buttonItem_ForMemorundom.Enabled = false;
                if (UPer.Contains(buttonItem_NonActive.Name)) buttonItem_NonActive.Enabled = false;
                if (UPer.Contains(button_SendFile.Name)) button_SendFile.Enabled = false;
                if (UPer.Contains(buttonItemHouseSMS.Name)) buttonItemHouseSMS.Enabled = false;
                if (UPer.Contains(buttonItemHouseEmail.Name)) buttonItemHouseEmail.Enabled = false;
                if (UPer.Contains(button_SendList.Name)) button_SendList.Enabled = false;
                if (UPer.Contains(buttonItemAllHouseSMS.Name)) buttonItemAllHouseSMS.Enabled = false;
                if (UPer.Contains(buttonItemAllHouseEmail.Name)) buttonItemAllHouseEmail.Enabled = false;
                if (UPer.Contains(button_AdvertisementFile.Name)) button_AdvertisementFile.Enabled = false;
                if (UPer.Contains(button_SendToSite.Name)) button_SendToSite.Enabled = false;
            }


            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItemHouseSMS.Enabled = false;
                buttonItemAllHouseSMS.Enabled = false;
                button_AdvertisementFile.Enabled = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1") || Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemHouseEmail.Enabled = false;
                buttonItemAllHouseEmail.Enabled = false;
                button_ChartPos.Enabled = false;
                button_SendToSite.Enabled = false;
            }
            //codeing

            dgRowCnt = dataGridView_ListHouse.RowCount;
            ShowListHouse(dgRowCnt - 1);

            
            //ContexMenu
            for (int i = 0; i < dataGridView_ListHouse.ColumnCount; i++)
                if (dataGridView_ListHouse.Columns[i].Visible)
                {
                    ToolStripMenuItem TSI = new ToolStripMenuItem();
                    TSI.Alignment = ToolStripItemAlignment.Right;
                    TSI.CheckOnClick = true;
                    TSI.Name = dataGridView_ListHouse.Columns[i].Name;
                    TSI.Text = dataGridView_ListHouse.Columns[i].HeaderText;
                    TSI.Checked = true;

                    if (Global_Cls.AllSelectField_House.Count != 0)
                        try
                        {
                            if (!Global_Cls.AllSelectField_House.Contains(TSI.Name))
                            {
                                TSI.Checked = false;
                                dataGridView_ListHouse.Columns[i].Visible = false;
                            }
                        }
                        catch { }
                    contextMenuStrip_LHouse.Items.Add(TSI);
                }
            LoadStatus = true;
            //ContexMenu

        }

        private void contextMenuStrip_LHouse_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                dataGridView_ListHouse.Columns[e.ClickedItem.Name].Visible = (e.ClickedItem as ToolStripMenuItem).CheckState == CheckState.Unchecked;
            }
            catch { }
        }

        private void dataGridView_ListHouse_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_ListHouse.RowCount != 0)
            {
                HouseViewer_frm HVf = new HouseViewer_frm();
                HVf.LoadDataAndShow(ListWhereSearch, dataGridView_ListHouse.CurrentRow.Index.ToString(),0);
            }
        }

        private void ListHouse_UC_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                int RowCnt = dataGridView_ListHouse.RowCount;
                int RFocus = 0;
                if (RowCnt != 0) RFocus = dataGridView_ListHouse.CurrentRow.Index;
                ShowListHouse(RFocus);
                if (RowCnt != dataGridView_ListHouse.RowCount)
                {
                    dataGridView_ListHouse.CurrentCell = dataGridView_ListHouse.Rows[dataGridView_ListHouse.RowCount - 1].Cells[dataGridView_ListHouse.CurrentCell.ColumnIndex];
                    dgRowCnt = dataGridView_ListHouse.RowCount;
                }
            }
            catch { }

            if (LoadStatus)
            {
                Global_Cls.AllSelectField_House.Clear();
                for (int i = 0; i < contextMenuStrip_LHouse.Items.Count; i++)
                    if ((contextMenuStrip_LHouse.Items[i] as ToolStripMenuItem).Checked)
                        Global_Cls.AllSelectField_House.Add((contextMenuStrip_LHouse.Items[i] as ToolStripMenuItem).Name);
            }

        }

        private void ListHouse_UC_Leave(object sender, EventArgs e)
        {
            Global_Cls.HouseIDChangeEdit = -100;
        }

        private void dataGridView_ListHouse_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                if (dataGridView_ListHouse.CurrentRow.Cells["HouseID"].Value != null)
                    Global_Cls.HouseIDChangeEdit = Convert.ToInt32(dataGridView_ListHouse.CurrentRow.Cells["HouseID"].Value);
            }
            catch { }
        }

        #endregion



        #region Show List
        private void ShowListHouse(int RowFocus)
        {
            if (SearchOrNo==1)
            {
                var SUS = from prd in DCMDC.ListHouse_Vws
                          select prd;

                ListWhereSearch = "";

                if (comboBox_TypeHouse.Text != "")
                {
                    SUS = SUS.Where(m => m.TypeHouse == comboBox_TypeHouse.Text);
                    ListWhereSearch += " And (TypeHouse = N'" + comboBox_TypeHouse.Text + "')";
                }

                if (comboBox_HouseFor.Text != "")
                {
                    SUS = SUS.Where(m => m.HouseFor == comboBox_HouseFor.Text);
                    ListWhereSearch += " And (HouseFor = N'" + comboBox_HouseFor.Text + "')";
                }             //New
                else if (Global_Cls.MainForm.UserPrmHouseFor != "admin")
                {
                    SUS = SUS.Where(m => System.Data.Linq.SqlClient.SqlMethods.Like(Global_Cls.MainForm.UserPrmHouseFor, "%" + m.HouseFor + "%"));
                    ListWhereSearch += " And (patindex('%'+HouseFor+'%',N'" + Global_Cls.MainForm.UserPrmHouseFor + "')>0 )";
                }
                //New

                
                if (nUpDown_Estate.Value != 0)
                {
                    SUS = SUS.Where(m => m.Few_estate <= nUpDown_Estate.Value);
                    ListWhereSearch += " And (Few_estate <= " + nUpDown_Estate.Value.ToString() + ")";
                }

                if (nUpDown_Units.Value != 0)
                {
                    SUS = SUS.Where(m => m.Few_unitAll <= nUpDown_Units.Value);
                    ListWhereSearch += " And (Few_unitAll <= " + nUpDown_Units.Value.ToString() + ")";
                }

                if (nUpDown_BldAge.Value != 0)
                {
                    SUS = SUS.Where(m => m.RH_Bldage <= nUpDown_BldAge.Value);
                    ListWhereSearch += " And (RH_Bldage <= " + nUpDown_BldAge.Value.ToString() + ")";
                }

                if (nUpDown_FBedRoom.Value != 0)
                {
                    SUS = SUS.Where(m => m.FH_BedRoomFew <= nUpDown_FBedRoom.Value);
                    ListWhereSearch += " And (FH_BedRoomFew <= " + nUpDown_FBedRoom.Value.ToString() + ")";
                }

                if (checkBox_Parking.CheckState != CheckState.Indeterminate)
                {
                    SUS = SUS.Where(m => m.FH_Parking == checkBox_Parking.Checked);
                    ListWhereSearch += " And (FH_Parking = " + Convert.ToInt16(checkBox_Parking.Checked).ToString() + ")";
                }

                if (checkBox_StRoom.CheckState != CheckState.Indeterminate)
                {
                    SUS = SUS.Where(m => m.FH_StoreRoom == checkBox_StRoom.Checked);
                    ListWhereSearch += " And (FH_StoreRoom = " + Convert.ToInt16(checkBox_StRoom.Checked).ToString() + ")";
                }

                if (checkBox_AV.CheckState != CheckState.Indeterminate)
                {
                    SUS = SUS.Where(m => m.FH_AifoonVideo == checkBox_AV.Checked);
                    ListWhereSearch += " And (FH_AifoonVideo = " + Convert.ToInt16(checkBox_AV.Checked).ToString() + ")";
                }

                if (checkBox_Cooler.CheckState != CheckState.Indeterminate)
                {
                    SUS = SUS.Where(m => m.CH_Cooler == checkBox_AV.Checked);
                    ListWhereSearch += " And (CH_Cooler = " + Convert.ToInt16(checkBox_Cooler.Checked).ToString() + ")";
                }

                if (checkBox_Elevatoor.CheckState != CheckState.Indeterminate)
                {
                    SUS = SUS.Where(m => m.CH_Elevator == checkBox_Elevatoor.Checked);
                    ListWhereSearch += " And (CH_Elevator = " + Convert.ToInt16(checkBox_Elevatoor.Checked).ToString() + ")";
                }

                if (checkBox_Heat.CheckState != CheckState.Indeterminate)
                {
                    SUS = SUS.Where(m => m.CH_Heat == checkBox_Heat.Checked);
                    ListWhereSearch += " And (CH_Heat = " + Convert.ToInt16(checkBox_Heat.Checked).ToString() + ")";
                }

                if (checkBox_DocUse.CheckState != CheckState.Indeterminate)
                {
                    SUS = SUS.Where(m => m.RH_DocUse == checkBox_DocUse.Checked);
                    ListWhereSearch += " And (RH_DocUse = " + Convert.ToInt16(checkBox_DocUse.Checked).ToString() + ")";
                }

                if (checkBox_LordExist.CheckState != CheckState.Indeterminate)
                {
                    SUS = SUS.Where(m => m.OH_LordExist == checkBox_LordExist.Checked);
                    ListWhereSearch += " And (OH_LordExist = " + Convert.ToInt16(checkBox_LordExist.Checked).ToString() + ")";
                }
                
                if (comboBox_UseType.Text != "")
                {
                    SUS = SUS.Where(m => m.RH_UseType == comboBox_UseType.Text);
                    ListWhereSearch += " And (RH_UseType = N'" + comboBox_UseType.Text + "')";
                }

                if (checkBox_Subbuild.Checked)
                {
                    SUS = SUS.Where(m => m.FH_Submeter >= (double)((textBox_SubBuild1.Text == "") ? 0 : (double.Parse(textBox_SubBuild1.Text))) && m.FH_Submeter <= (double)((textBox_SubBuild2.Text == "") ? 0 : (double.Parse(textBox_SubBuild2.Text))));
                    ListWhereSearch += " And (FH_Submeter >= " + (string)((textBox_SubBuild1.Text == "") ? "0" : (textBox_SubBuild1.Text)) + ") And (FH_Submeter <= " + (string)((textBox_SubBuild2.Text == "") ? "0" : (textBox_SubBuild2.Text)) + ")";
                }

                Int64 Cost1 = 0, Cost2 = 0;
                try { Cost1 = Convert.ToInt64(textBox_AHPrice1.Text.Replace(",", "")); }
                catch { }
                try { Cost2 = Convert.ToInt64(textBox_AHPrice2.Text.Replace(",", "")); }
                catch { }

                if (Cost1 != 0 || Cost2 != 0)
                {
                    if (radioButton_AllPrice.Checked)
                    {
                        SUS = SUS.Where(m => m.Price_HouseAll >= Cost1 && m.Price_HouseAll <= Cost2);
                        ListWhereSearch += " And (Price_HouseAll >= " + Cost1.ToString() + ")And(Price_HouseAll <= " + Cost2.ToString() + ")";
                    }
                    else if (radioButton_Mtg.Checked)
                    {
                        SUS = SUS.Where(m => m.Price_Mortgage >= Cost1 && m.Price_Mortgage <= Cost2);
                        ListWhereSearch += " And (Price_Mortgage >= " + Cost1.ToString() + ")And(Price_Mortgage <= " + Cost2.ToString() + ")";
                    }
                    else if (radioButton_Rent.Checked)
                    {
                        SUS = SUS.Where(m => m.Price_Rent >= Cost1 && m.Price_Rent <= Cost2);
                        ListWhereSearch += " And (Price_Rent >= " + Cost1.ToString() + ")And(Price_Rent <= " + Cost2.ToString() + ")";
                    }
                }


                dataGridView_ListHouse.DataSource = SUS;
            }
            else if (SearchOrNo ==0)
            {
                ListWhereSearch = "";
                
                var SUN = from prd in DCMDC.ListHouse_Vws
                          select prd;

                //New
                if (Global_Cls.MainForm.UserPrmHouseFor != "admin")
                {
                    SUN = SUN.Where(m => System.Data.Linq.SqlClient.SqlMethods.Like(Global_Cls.MainForm.UserPrmHouseFor, "%"+m.HouseFor+"%"));
                    ListWhereSearch += " And (patindex('%'+HouseFor+'%',N'" + Global_Cls.MainForm.UserPrmHouseFor + "')>0 )";
                }
                //New

                dataGridView_ListHouse.DataSource = SUN;
            }
            else if (SearchOrNo == -1)
            {
                try
                {
                    string StrConn = Global_Cls.ConnectionStr;

                    SqlConnection SqConn = new SqlConnection(StrConn);
                    SqConn.Open();

                    SqlCommand SqCmd = new SqlCommand();
                    SqCmd.Connection = SqConn;

                    SqCmd.CommandText = "SELECT  TOP (100) PERCENT dbo.TBL_HouseFile.HouseID, dbo.TBL_HouseFile.FileNO, CAST(dbo.TBL_HouseFile.FileNO AS int) AS FileNOInt, dbo.MiladiToShamsi(dbo.TBL_HouseFile.Modify_Date) AS Modify_Date, dbo.TBL_HouseFile.HouseFor, "
                                       + "dbo.TBL_HouseFile.TypeHouse, dbo.TBL_City.CityName_Fa, dbo.TBL_Part.PartName_Fa, dbo.TBL_HouseFile.Few_estate, dbo.TBL_HouseFile.FH_estateNo, dbo.TBL_HouseFile.Few_unitAll, "
                                       + "dbo.TBL_HouseFile.FH_Submeter, dbo.DigitSeparator(dbo.TBL_HouseFile.Price_HouseAll) AS Price_HouseAllStr, dbo.TBL_HouseFile.Price_HouseAll, "
                                       + "dbo.DigitSeparator(dbo.TBL_HouseFile.Price_Mortgage) + ' - ' + dbo.DigitSeparator(dbo.TBL_HouseFile.Price_Rent) AS Price_MR, dbo.TBL_HouseFile.Price_Mortgage, "
                                       + "dbo.TBL_HouseFile.Price_Rent, dbo.TBL_HouseFile.FH_BedRoomFew, dbo.TBL_HouseFile.FH_Parking, dbo.TBL_HouseFile.FH_StoreRoom, dbo.TBL_HouseFile.CH_Elevator, "
                                       + "dbo.TBL_HouseFile.RH_Bldage, dbo.TBL_HouseFile.RH_UseType, dbo.TBL_HouseFile.RH_DocUse, dbo.TBL_HouseFile.OH_LordExist, dbo.TBL_HouseFile.CH_Cooler, "
                                       + "dbo.TBL_HouseFile.CH_Heat, dbo.TBL_HouseFile.FH_AifoonVideo, dbo.TBL_HouseFile.FH_UnitNo "
                            + "FROM dbo.TBL_HouseFile "
                            + "LEFT OUTER JOIN dbo.TBL_Part ON dbo.TBL_Part.PartID = dbo.TBL_HouseFile.Lord_Part "
                            + "LEFT OUTER JOIN dbo.TBL_City ON dbo.TBL_City.CityID = dbo.TBL_Part.CityID "
                            + "Where (FileStatus = 0) "
                            + ListWhereSearch;
                            //+ " ORDER BY dbo.TBL_HouseFile.FilePriority";
                    DataTable retValue = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(SqCmd);
                    da.Fill(retValue);
                    dataGridView_ListHouse.DataSource = retValue;
                    SqConn.Close();
                }
                catch { }
            }
            
            try
            {
                dataGridView_ListHouse.CurrentCell = dataGridView_ListHouse.Rows[RowFocus].Cells[dataGridView_ListHouse.CurrentCell.ColumnIndex];
            }
            catch
            {
                try { dataGridView_ListHouse.CurrentCell = dataGridView_ListHouse.Rows[0].Cells[0]; }
                catch { }
            }

        }
        #endregion


        
        #region All Buttons
        private void buttonItem_ForMemorundom_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListHouse.RowCount != 0)
            {
                int RFocus = dataGridView_ListHouse.CurrentRow.Index;
                if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل جهت قولنامه ارسال شود؟")) return;
                int HsID = Convert.ToInt32(dataGridView_ListHouse.CurrentRow.Cells["HouseID"].Value);
                NEConclusion_frm NEC = new NEConclusion_frm();
                NEC.HouseID = HsID;
                NEC.NewOrEditConclusion = 1;
                NEC.FileNo = dataGridView_ListHouse.CurrentRow.Cells[FileNoFieldStr].Value.ToString();
                NEC.PriceHAll = dataGridView_ListHouse.CurrentRow.Cells["Price_HouseAllStr"].Value.ToString();
                NEC.PriceM = dataGridView_ListHouse.CurrentRow.Cells["Price_Mortgage"].Value.ToString();
                NEC.PriceR = dataGridView_ListHouse.CurrentRow.Cells["Price_Rent"].Value.ToString();
                NEC.checkBox_ListConclusion.Visible = true;
                if (NEC.ShowDialog() == DialogResult.OK)
                {
                    TBL_HouseFile thf = DCMDC.TBL_HouseFiles.First(hf => hf.HouseID.Equals(HsID));
                    thf.FileStatus = 2;
                    DCMDC.SubmitChanges();

                    DCSDC.InsDelRecordHouseFile_Sp(HsID, true, 2);
                    DCSDC.SubmitChanges();

                    ShowListHouse(RFocus - 1);
                }
            }
        }

        private void buttonItem_Del_Click(object sender, EventArgs e)
        {

            if (dataGridView_ListHouse.RowCount != 0)
            {
                int SelCount = dataGridView_ListHouse.SelectedRows.Count;
                if (SelCount == 1)
                {
                    int RFocus = dataGridView_ListHouse.CurrentRow.Index;
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل حذف شود؟")) return;
                    DCSDC.InsDelRecordHouseFile_Sp(Convert.ToInt32(dataGridView_ListHouse.CurrentRow.Cells["HouseID"].Value), true, 3);
                    DCSDC.SubmitChanges();
                    ShowListHouse(RFocus - 1);
                }
                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این" + SelCount.ToString() + " فایل انتخاب شده حذف شوند؟ ")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        DCSDC.InsDelRecordHouseFile_Sp(Convert.ToInt32(dataGridView_ListHouse.SelectedRows[SelCount].Cells["HouseID"].Value), true, 3);
                        DCSDC.SubmitChanges();
                    }
                    ShowListHouse(0);
                }
            }

        }

        private void buttonItem_StatusOK_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListHouse.RowCount != 0)
            {
                int RFocus = dataGridView_ListHouse.CurrentRow.Index;
                if (!Global_Cls.CheckShamsiDate(textboxitem_status.TextBox.Text))
                    textboxitem_status.TextBox.Focus();
                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل تا تاریخ " + textboxitem_status.TextBox.Text + " بایگانی شود؟ ")) return;
                    TBL_HouseFile thf = DCMDC.TBL_HouseFiles.First(hf => hf.HouseID.Equals(dataGridView_ListHouse.CurrentRow.Cells["HouseID"].Value));
                    thf.FileStatus = 1;
                    thf.NonActive_Date = Global_Cls.ShamsiDateToMiladi(textboxitem_status.TextBox.Text);
                    DCMDC.SubmitChanges();

                    DCSDC.InsDelRecordHouseFile_Sp(Convert.ToInt32(dataGridView_ListHouse.CurrentRow.Cells["HouseID"].Value), true, 1);
                    DCSDC.SubmitChanges();
                    ShowListHouse(RFocus - 1);

                }
            }
        }

        private void buttonItem_NonActive_MouseMove(object sender, MouseEventArgs e)
        {
            textboxitem_status.TextBox.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(365));
        }

        private void button_PrintFile_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListHouse.RowCount > 0)
                try
                {
                    ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", false) + "Where HouseID = " + dataGridView_ListHouse.CurrentRow.Cells["HouseID"].Value.ToString(),
                    "ملک", ReportClass_Cls.FindReportDesign_HouseType(Convert.ToString(dataGridView_ListHouse.CurrentRow.Cells["TypeHouse"].Value)));//Global_Cls.ReportDesignAddress[0]);//Application.StartupPath + @"\Report\Main.frx");*/
                }
                catch { }
        }

        private void button_PrintList_Click(object sender, EventArgs e)
        {
            ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "فعال", false) + "Where (FileStatus = 0) " + ListWhereSearch,
              "فعال", Global_Cls.ReportDesignAddress[7]);//Global_Cls.ReportDesignAddress[0]);//Application.StartupPath + @"\Report\Main.frx");*/
        }

        private void button_AdvertisementFile_Click(object sender, EventArgs e)
        {
            string StrSend = SelectRow_Grid(true);
            Global_Cls.SendSMS_Advertisment(false, StrSend,"");
        }


        private string SelectRow_Grid(bool RowOrGrid)
        {
            string StrSend = "";
            int I = 0;

            string[] str = new string[Global_Cls.Adver_FieldName.Count];
            Global_Cls.Adver_FieldName.CopyTo(str, 0);
            if (RowOrGrid)
            {
                while (I < str.Count())
                {
                    try
                    {
                        string StrData = Convert.ToString(dataGridView_ListHouse.CurrentRow.Cells[str[I].ToString()].Value);
                        if (StrData != "" && StrData != "0")
                        {
                            StrSend += " ";
                            if (str[I].ToString() == "FH_estateNo") StrSend += "طبقه ";
                            if (str[I].ToString() == "PartName_Fa") StrSend += "منطقه ";
                            if (str[I].ToString() == "FH_UnitNo") StrSend += "واحد ";
                            if (str[I].ToString() == "Few_estate") StrSend += "در ";
                            if (str[I].ToString() == "Few_unitAll") StrSend += "در ";

                            StrSend += StrData;

                            if (str[I].ToString() == "FH_Submeter") StrSend += " متر";
                            if (str[I].ToString() == "Few_estate") StrSend += " طبقه";
                            if (str[I].ToString() == "Few_unitAll") StrSend += " واحد";
                            if (str[I].ToString() == "FH_BedRoomFew") StrSend += " خوابه";
                            if (str[I].ToString() == "RH_Bldage") StrSend += " ساله";
                            StrSend += " ";

                            if (I != str.Count() - 1) StrSend += Global_Cls.Adver_separator;
                        }
                    }
                    catch { }//MessageBox.Show(I.ToString()); }
                    I++;
                }
            }
            else
            {
                int J = 0;
                while (J < dataGridView_ListHouse.RowCount)
                {
                    while (I < str.Count())
                    {
                        try
                        {
                            StrSend += " ";
                            if (str[I].ToString() == "FH_estateNo") StrSend += "طبقه ";
                            if (str[I].ToString() == "PartName_Fa") StrSend += "منطقه ";
                            if (str[I].ToString() == "FH_UnitNo") StrSend += "واحد ";
                            if (str[I].ToString() == "Few_estate") StrSend += "در ";
                            if (str[I].ToString() == "Few_unitAll") StrSend += "در ";

                            StrSend += dataGridView_ListHouse.Rows[J].Cells[str[I].ToString()].Value.ToString();

                            if (str[I].ToString() == "FH_Submeter") StrSend += " متر";
                            if (str[I].ToString() == "Few_estate") StrSend += " طبقه";
                            if (str[I].ToString() == "Few_unitAll") StrSend += " واحد";
                            if (str[I].ToString() == "FH_BedRoomFew") StrSend += " خوابه";
                            if (str[I].ToString() == "RH_Bldage") StrSend += " ساله";
                            StrSend += " ";

                            if (I != str.Count() - 1) StrSend += Global_Cls.Adver_separator;
                        }
                        catch { }//MessageBox.Show(J.ToString()+","+I.ToString()); }
                        I++;
                    }
                    StrSend = StrSend + "  ";
                    J++;
                    I = 0;
                }
            }

            return StrSend;
        }
        #endregion


        
        #region Search

        TextBox tx = new TextBox();
        private void textBox_AHPrice_KeyPress(object sender, KeyPressEventArgs e)
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
                tx.Text = str.Replace(" ","");
                tx.SelectionStart = ts + 1;
            }

        }

        private void textBox_SubBuild1_KeyPress(object sender, KeyPressEventArgs e)
        {
            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar == '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchOrNo = 1;
            ShowListHouse(0);
            try
            {
                dataGridView_ListHouse.CurrentCell = dataGridView_ListHouse.Rows[dataGridView_ListHouse.RowCount - 1].Cells[dataGridView_ListHouse.CurrentCell.ColumnIndex];
            }
            catch
            { }

        }

        private void dataGridView_ListHouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                SearchOrNo = 0;
                ShowListHouse(dgRowCnt-1);

                textBox_AHPrice1.Text = "0";            textBox_AHPrice2.Text = "0";
                textBox_SubBuild1.Text = "0";           textBox_SubBuild2.Text = "0";
                comboBox_TypeHouse.Text = "";           comboBox_HouseFor.Text = "";
                comboBox_UseType.SelectedIndex = -1;

                nUpDown_Estate.Value = 0; nUpDown_Units.Value = 0;
                nUpDown_BldAge.Value = 0; nUpDown_FBedRoom.Value = 0;

                checkBox_Parking.CheckState = CheckState.Indeterminate;
                checkBox_StRoom.CheckState = CheckState.Indeterminate;
                checkBox_AV.CheckState = CheckState.Indeterminate;
                checkBox_Cooler.CheckState = CheckState.Indeterminate;
                checkBox_Elevatoor.CheckState = CheckState.Indeterminate;
                checkBox_Heat.CheckState = CheckState.Indeterminate;
                checkBox_DocUse.CheckState = CheckState.Indeterminate;
                checkBox_LordExist.CheckState = CheckState.Indeterminate;

                exPanel_Search.Expanded = false;
            }
        }

        #endregion

        
        private void button_SendToSite_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListHouse.RowCount != 0)
            {
                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا می خواهید فایل شماره " + dataGridView_ListHouse.CurrentRow.Cells[FileNoFieldStr].Value.ToString() + " به سایت ارسال شود؟"))
                {
                    SendFileToViewSite_frm SFVSF = new SendFileToViewSite_frm();
                    SFVSF.HouseID = dataGridView_ListHouse.CurrentRow.Cells["HouseID"].Value.ToString();
                    SFVSF.FileNo = dataGridView_ListHouse.CurrentRow.Cells[FileNoFieldStr].Value.ToString();
                    SFVSF.ModifyDate = dataGridView_ListHouse.CurrentRow.Cells["ModifyDate"].Value.ToString();
                    SFVSF.TypeHouse = dataGridView_ListHouse.CurrentRow.Cells["TypeHouse"].Value.ToString();
                    SFVSF.HouseFor = dataGridView_ListHouse.CurrentRow.Cells["HouseFor"].Value.ToString();
                    SFVSF.PartName = Convert.ToString(dataGridView_ListHouse.CurrentRow.Cells["PartName_Fa"].Value);
                    SFVSF.CityName = Convert.ToString(dataGridView_ListHouse.CurrentRow.Cells["CityName_Fa"].Value);
                    SFVSF.ShowDialog();
                }
            }
            
        }

        private void button_ChartPos_Click(object sender, EventArgs e)
        {
            Function_Cls.SearchInternet(2);
        }

        private void buttonItemSMS_Click(object sender, EventArgs e)
        {
            string StrSend = SelectRow_Grid(true);
            if (dataGridView_ListHouse.RowCount != 0)
                Global_Cls.SendSMS_Advertisment(true, StrSend, Convert.ToString(dataGridView_ListHouse.CurrentRow.Cells["Lord_Mobile"].Value));
            else Global_Cls.SendSMS_Advertisment(true, StrSend, "");

        }

        private void buttonItemEmail_Click(object sender, EventArgs e)
        {
            string StrSend = SelectRow_Grid(true);
            if (dataGridView_ListHouse.RowCount != 0)
                Global_Cls.SendEmail(StrSend);
            else Global_Cls.SendEmail(StrSend);
        }

        private void buttonItemAllHouseEmail_Click(object sender, EventArgs e)
        {
            string StrSend = SelectRow_Grid(false);
            Global_Cls.SendEmail(StrSend);
        }

        private void buttonItemAllHouseSMS_Click(object sender, EventArgs e)
        {
            string StrSend = SelectRow_Grid(false);
            Global_Cls.SendSMS_Advertisment(true, StrSend, "");
        }

    }
}

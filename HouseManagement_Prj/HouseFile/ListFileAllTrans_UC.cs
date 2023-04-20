using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;

namespace HouseManagement_Prj
{
    public partial class ListFileAllTrans_UC : UserControl
    {
        public ListFileAllTrans_UC()
        {
            InitializeComponent();
        }
        
        public int FileStatus;
        DataClassesSecondDataContext DCSDC = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        public bool SearchOrNo = false, ReminderAlrm = false;
        public string ListWhereSearch = "";
        private bool LoadStatus = false;//ContexMenu
        int dgRowCnt = 0;


        #region Load & UI
        private void ListFileAllTrans_UC_Load(object sender, EventArgs e)
        {
            //fileno visible
            dataGridView_ListFileAllTrans.Columns["FileNO"].Visible = !Global_Cls.FileNoFlage;
            dataGridView_ListFileAllTrans.Columns["FileNOInt"].Visible = Global_Cls.FileNoFlage;
            //

            InterFaceChange();
            ShowListHouse(0);
            try
            {
                dgRowCnt = dataGridView_ListFileAllTrans.RowCount;
                dataGridView_ListFileAllTrans.CurrentCell = dataGridView_ListFileAllTrans.Rows[dgRowCnt - 1].Cells[dataGridView_ListFileAllTrans.CurrentCell.ColumnIndex];
            }
            catch { }

            FillContexMenuItem_StatusFile(FileStatus);
            LoadStatus = true;//ContexMenu
        }

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(button_Transmutation.Name + FileStatus.ToString())) button_Transmutation.Enabled = false;
                if (UPer.Contains(buttonItem_Active.Name + FileStatus.ToString())) buttonItem_Active.Enabled = false;
                if (UPer.Contains(buttonItem_NonActive.Name + FileStatus.ToString())) buttonItem_NonActive.Enabled = false;
                if (UPer.Contains(buttonItem_Del.Name + FileStatus.ToString())) buttonItem_Del.Enabled = false;
                if (UPer.Contains(buttonItem_ForMemorundom.Name + FileStatus.ToString())) buttonItem_ForMemorundom.Enabled = false;
                if (UPer.Contains(button_ShiftDel.Name)) button_ShiftDel.Enabled = false;

                if (UPer.Contains(button_SendSMS.Name)) button_SendSMS.Enabled = false;
                if (UPer.Contains(buttonItemHouseEmail.Name)) buttonItemHouseEmail.Enabled = false;
                if (UPer.Contains(buttonItemHouseSMS.Name)) buttonItemHouseSMS.Enabled = false;
            }

            button_ShiftDel.Visible = (FileStatus == 3);
            if (FileStatus != 3) exPanel_Action.Height = 102;
            buttonItem_Del.Visible = (FileStatus != 3);
            buttonItem_NonActive.Visible = (FileStatus != 1);
            buttonItem_ForMemorundom.Visible = (FileStatus == 1);

            //new
            comboBox_TypeHouse.Items.Add("");
            comboBox_HouseFor.Items.Add("");
            for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
                comboBox_TypeHouse.Items.Add(Global_Cls.TypeHouseAllCases[i]);
            for (int i = 0; i < Global_Cls.HouseForPrm.Count; i++)//new
                comboBox_HouseFor.Items.Add(Global_Cls.HouseForPrm[i]);//new
            //new

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S")) buttonItemHouseSMS.Enabled = false;
            if (Global_Cls.SoftwareCode == "Trial" || Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1")) 
                buttonItemHouseEmail.Enabled = false;
            //codeing

        }

        private void FillContexMenuItem_StatusFile(int StsFile)
        {
            System.Collections.Specialized.StringCollection StrColection = null;

            if (StsFile == 1) 
            { 
                StrColection = Global_Cls.AllSelectField_NonActiveHouse;
                dataGridView_ListFileAllTrans.Columns["NonActive_DateStr"].Visible = true;
            }
            else if (StsFile == 2) StrColection = Global_Cls.AllSelectField_ForMemorundom;
            else if (StsFile == 3) StrColection = Global_Cls.AllSelectField_DelHouse;
            
            for (int i = 0; i < dataGridView_ListFileAllTrans.ColumnCount; i++)
                if (dataGridView_ListFileAllTrans.Columns[i].Visible)
                {
                    ToolStripMenuItem TSI = new ToolStripMenuItem();
                    TSI.Alignment = ToolStripItemAlignment.Right;
                    TSI.CheckOnClick = true;
                    TSI.Name = dataGridView_ListFileAllTrans.Columns[i].Name;
                    TSI.Text = dataGridView_ListFileAllTrans.Columns[i].HeaderText;
                    TSI.Checked = true;
                    if (StrColection.Count != 0)
                        try
                        {
                            if (!StrColection.Contains(TSI.Name))
                            {
                                TSI.Checked = false;
                                dataGridView_ListFileAllTrans.Columns[i].Visible = false;
                            }
                        }
                        catch { }
                    contextMenuStrip_AllTrans.Items.Add(TSI);
                }
        }

        private void ListFileAllTrans_UC_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                int RowCnt = dataGridView_ListFileAllTrans.RowCount;
                int RFocus = dataGridView_ListFileAllTrans.CurrentRow.Index;
                ShowListHouse(RFocus);
                if (RowCnt != dataGridView_ListFileAllTrans.RowCount)
                {
                    dataGridView_ListFileAllTrans.CurrentCell = dataGridView_ListFileAllTrans.Rows[dataGridView_ListFileAllTrans.RowCount - 1].Cells[dataGridView_ListFileAllTrans.CurrentCell.ColumnIndex];
                    dgRowCnt = dataGridView_ListFileAllTrans.RowCount;
                }

            }
            catch { }

            if (LoadStatus)
            {
                System.Collections.Specialized.StringCollection StrColection = null;

                if (FileStatus == 1) StrColection = Global_Cls.AllSelectField_NonActiveHouse;
                else if (FileStatus == 2) StrColection = Global_Cls.AllSelectField_ForMemorundom;
                else if (FileStatus == 3) StrColection = Global_Cls.AllSelectField_DelHouse;
                
                StrColection.Clear();
                for (int i = 0; i < contextMenuStrip_AllTrans.Items.Count; i++)
                    if ((contextMenuStrip_AllTrans.Items[i] as ToolStripMenuItem).Checked)
                        StrColection.Add((contextMenuStrip_AllTrans.Items[i] as ToolStripMenuItem).Name);
            }

        }

        private void ListFileAllTrans_UC_Leave(object sender, EventArgs e)
        {
            Global_Cls.SndHouseIDChangeEdit = -100;
        }

        private void dataGridView_ListFileAllTrans_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                if (dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value != null)
                    Global_Cls.SndHouseIDChangeEdit = Convert.ToInt32(dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value);
            }
            catch { }
        }

        private void buttonItem_NonActive_MouseMove(object sender, MouseEventArgs e)
        {
            textboxitem_status.TextBox.Text = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(365));
        }

        private void contextMenuStrip_AllTrans_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                dataGridView_ListFileAllTrans.Columns[e.ClickedItem.Name].Visible = (e.ClickedItem as ToolStripMenuItem).CheckState == CheckState.Unchecked;
            }
            catch { }
        }


        #endregion


        #region Search
        private void ShowListHouse(int RowFocus)
        {
            if (SearchOrNo)
            {

/*                string HouseFor = "";
                if (checkBox_Buy.Checked) HouseFor = "فروش";
                else if (checkBox_Rent.Checked && checkBox_Mortgage.Checked) HouseFor = "رهن و اجاره";
                else if (checkBox_Mortgage.Checked) HouseFor = "رهن";
                else if (checkBox_Rent.Checked) HouseFor = "اجاره";
                else if (checkBox_PreBuy.Checked) HouseFor = "پیش فروش";
                else if (checkBox_Prtpc.Checked) HouseFor = "مشارکت";

                string TypeHouse = "";
                if (radioButton_Apartmnt.Checked) TypeHouse = "آپارتمان";
                else if (radioButton_Dila.Checked) TypeHouse = "کلنگی";
                else if (radioButton_Garden.Checked) TypeHouse = "باغ";
                else if (radioButton_Ln.Checked) TypeHouse = "زمین";
                else if (radioButton_PLn.Checked) TypeHouse = "زمین نیمه کاره";
                else if (radioButton_SGarden.Checked) TypeHouse = "باغچه";
                else if (radioButton_Shop.Checked) TypeHouse = "مغازه";
                else if (radioButton_SR.Checked) TypeHouse = "انبار";
                else if (radioButton_St.Checked) TypeHouse = "سوئیت";
                else if (radioButton_Tent.Checked) TypeHouse = "مستغلات";
                else if (radioButton_Villa.Checked) TypeHouse = "ویلا";
                else if (radioButton_WR.Checked) TypeHouse = "دفتر کار";
                */
                //new


                var SUS = from prd in DCSDC.ListSecondHouse_Vws
                          select prd;
                          /*where (prd.FileStatus == FileStatus)&&(prd.HouseFor == HouseForStr) && (prd.TypeHouse == TypeHouseStr)
                          && (prd.Price_HouseAll <= Convert.ToInt64(textBox_AHPrice.Text.Replace(",", "")))
                          && (prd.Price_Mortgage <= Convert.ToInt64(textBox_AHPrice.Text.Replace(",", "")))
                          && (prd.Price_Rent <= Convert.ToInt64(textBox_RentPrice.Text.Replace(",", "")))
                          //&& (prd.Lord_Part == Convert.ToInt32(comboBox_Part.SelectedValue))
                          select new
                          {
                              prd.SndHouseID,
                              prd.HouseFor,
                              prd.TypeHouse,
                              prd.Price_HouseAll,
                              prd.FileNO,
                              prd.FH_Submeter,
                              prd.FH_estateNo,
                              prd.Modify_Date,
                              prd.Price_MR,
                              prd.Few_estate
                          };*/


                SUS = SUS.Where(m => m.FileStatus == FileStatus);
                ListWhereSearch += " And (FileStatus = " + FileStatus + ")";

                if (ReminderAlrm)
                {
                    SUS = SUS.Where(m => m.NonActive_Date.Value <= DateTime.Now.AddDays(Global_Cls.NonActive_Day));
                    ListWhereSearch += " And (NonActive_Date <= getdate() + " + Global_Cls.NonActive_Day.ToString() + ") ";
                }

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

                dataGridView_ListFileAllTrans.DataSource = SUS;
            }
            else
            {
                ListWhereSearch = "";
                if (!ReminderAlrm)
                {
                    var SUN = from prd in DCSDC.ListSecondHouse_Vws
                              where prd.FileStatus == FileStatus
                              select prd;
                              /*select new
                              {
                                  prd.SndHouseID,
                                  prd.HouseFor,
                                  prd.TypeHouse,
                                  prd.Price_HouseAll,
                                  prd.FileNO,
                                  prd.FH_Submeter,
                                  prd.FH_estateNo,
                                  prd.Modify_Date,
                                  prd.Price_MR,
                                  prd.Few_estate
                              };*/
                    //New
                    if (Global_Cls.MainForm.UserPrmHouseFor != "admin")
                    {
                        SUN = SUN.Where(m => System.Data.Linq.SqlClient.SqlMethods.Like(Global_Cls.MainForm.UserPrmHouseFor, "%" + m.HouseFor + "%"));
                        ListWhereSearch += " And (patindex('%'+HouseFor+'%',N'" + Global_Cls.MainForm.UserPrmHouseFor + "')>0 )";
                    }
                    //New

                    dataGridView_ListFileAllTrans.DataSource = SUN;
                }
                else
                {
                    var SUN = from prd in DCSDC.ListSecondHouse_Vws
                              where (prd.FileStatus == FileStatus)
                                && (prd.NonActive_Date.Value <= DateTime.Now.AddDays(Global_Cls.NonActive_Day))
                              select prd;
                              /*select new
                              {
                                  prd.SndHouseID,
                                  prd.HouseFor,
                                  prd.TypeHouse,
                                  prd.Price_HouseAll,
                                  prd.FileNO,
                                  prd.FH_Submeter,
                                  prd.FH_estateNo,
                                  prd.Modify_Date,
                                  prd.Price_MR,
                                  prd.Few_estate,
                              };*/
                    //New
                    if (Global_Cls.MainForm.UserPrmHouseFor != "admin")
                    {
                        SUN = SUN.Where(m => System.Data.Linq.SqlClient.SqlMethods.Like(Global_Cls.MainForm.UserPrmHouseFor, "%" + m.HouseFor + "%"));
                        ListWhereSearch += " And (patindex('%'+HouseFor+'%',N'" + Global_Cls.MainForm.UserPrmHouseFor + "')>0 )";
                    }
                    //New

                    dataGridView_ListFileAllTrans.DataSource = SUN;

                    ListWhereSearch += " And (NonActive_Date <= getdate() + " + Global_Cls.NonActive_Day.ToString() + ") ";
                }
            }

            try
            {
                dataGridView_ListFileAllTrans.CurrentCell = dataGridView_ListFileAllTrans.Rows[RowFocus].Cells[dataGridView_ListFileAllTrans.CurrentCell.ColumnIndex];
            }
            catch
            {
                try
                {
                    dataGridView_ListFileAllTrans.CurrentCell = dataGridView_ListFileAllTrans.Rows[0].Cells[dataGridView_ListFileAllTrans.CurrentCell.ColumnIndex];
                }
                catch { }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchOrNo = true;
            ShowListHouse(0);
            try
            {
                dataGridView_ListFileAllTrans.CurrentCell = dataGridView_ListFileAllTrans.Rows[dataGridView_ListFileAllTrans.RowCount-1].Cells[dataGridView_ListFileAllTrans.CurrentCell.ColumnIndex];
            }
            catch
            { }
        }

        private void dataGridView_ListFileAllTrans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                SearchOrNo = false;
                ShowListHouse(dgRowCnt-1);
                textBox_AHPrice1.Text = "0"; textBox_AHPrice2.Text = "0";
                textBox_SubBuild1.Text = "0"; textBox_SubBuild2.Text = "0";
                comboBox_TypeHouse.Text = ""; comboBox_HouseFor.Text = "";
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

                exPanel_FTSearch.Expanded = false;
            }
        }

        #endregion


        #region All Buttons
        private void buttonItem_StatusOK_Click(object sender, EventArgs e)
        {
            
            if (dataGridView_ListFileAllTrans.Rows.Count == 0) return;
            if (!Global_Cls.CheckShamsiDate(textboxitem_status.TextBox.Text))
                textboxitem_status.TextBox.Focus();
            else
            {
                int RFocus = dataGridView_ListFileAllTrans.CurrentRow.Index;
                if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل تا تاریخ " + textboxitem_status.TextBox.Text + " بایگانی شود؟ ")) return;

                TBL_SecondHouseFile tshf = DCSDC.TBL_SecondHouseFiles.First(hf => hf.SndHouseID.Equals(dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value));
                tshf.FileStatus = 1;
                tshf.NonActive_Date = Global_Cls.ShamsiDateToMiladi(textboxitem_status.TextBox.Text);
                DCSDC.SubmitChanges();
                ShowListHouse(RFocus-1);
            }

        }

        private void buttonItem_Active_Click(object sender, EventArgs e)
        {

            /*if (dataGridView_ListFileAllTrans.Rows.Count == 0) return;
            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل فعال شود؟ ")) return;

            int RFocus = dataGridView_ListFileAllTrans.CurrentRow.Index;
            TBL_SecondHouseFile tshf = DCSDC.TBL_SecondHouseFiles.First(hf => hf.SndHouseID.Equals(dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value));
            tshf.FileStatus = 0;
            DCSDC.SubmitChanges();

            DCSDC.InsDelRecordHouseFile_Sp(Convert.ToInt32(dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value), false, 0);
            DCSDC.SubmitChanges();
            ShowListHouse(RFocus - 1);
            */


            if (dataGridView_ListFileAllTrans.RowCount != 0)
            {
                int SelCount = dataGridView_ListFileAllTrans.SelectedRows.Count;
                if (SelCount == 1)
                {
                    int RFocus = dataGridView_ListFileAllTrans.CurrentRow.Index;
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل فعال شود؟")) return;
                    DCSDC.InsDelRecordHouseFile_Sp(Convert.ToInt32(dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value), false, 0);
                    DCSDC.SubmitChanges();
                    ShowListHouse(RFocus - 1);
                }
                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این" + SelCount.ToString() + " فایل انتخاب شده فعال شوند؟ ")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        DCSDC.InsDelRecordHouseFile_Sp(Convert.ToInt32(dataGridView_ListFileAllTrans.SelectedRows[SelCount].Cells["SndHouseID"].Value), false, 0);
                        DCSDC.SubmitChanges();
                    }
                    ShowListHouse(0);
                }
            }

        }

        private void buttonItem_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListFileAllTrans.RowCount != 0)
            {
                int SelCount = dataGridView_ListFileAllTrans.SelectedRows.Count;
                if (SelCount == 1)
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل حذف شود؟")) return;
                    int RFocus = dataGridView_ListFileAllTrans.CurrentRow.Index;
                    TBL_SecondHouseFile thsf = DCSDC.TBL_SecondHouseFiles.First(hf => hf.SndHouseID.Equals(dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value));
                    thsf.FileStatus = 3;
                    DCSDC.SubmitChanges();
                    ShowListHouse(RFocus - 1);
                }

                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این" + SelCount.ToString() + " فایل انتخاب شده حذف شوند؟")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        TBL_SecondHouseFile thsf = DCSDC.TBL_SecondHouseFiles.First(hf => hf.SndHouseID.Equals(dataGridView_ListFileAllTrans.SelectedRows[SelCount].Cells["SndHouseID"].Value));
                        thsf.FileStatus = 3;
                        DCSDC.SubmitChanges();
                    }
                    ShowListHouse(0);
                }
            }

        }

        private void buttonItem_ForMemorundom_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListFileAllTrans.Rows.Count == 0) return;
            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل جهت قولنامه ارسال شود؟ ")) return;
            int RFocus = dataGridView_ListFileAllTrans.CurrentRow.Index;
            int SHsID = Convert.ToInt32(dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value);
            NEConclusion_frm NEC = new NEConclusion_frm();
            NEC.HouseID = SHsID;
            NEC.NewOrEditConclusion = 1;
            NEC.FileNo = dataGridView_ListFileAllTrans.CurrentRow.Cells["FileNO"].Value.ToString();
            NEC.checkBox_ListConclusion.Visible = true;
            if (NEC.ShowDialog() == DialogResult.OK)
            {
                TBL_SecondHouseFile thsf = DCSDC.TBL_SecondHouseFiles.First(hf => hf.SndHouseID.Equals(SHsID));
                thsf.FileStatus = 2;
                DCSDC.SubmitChanges();
                ShowListHouse(RFocus-1);
            }
        }

        private void button_ShiftDel_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListFileAllTrans.RowCount != 0)
            {
                int SelCount = dataGridView_ListFileAllTrans.SelectedRows.Count;
                if (SelCount == 1)
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل به طور کامل از سیستم حذف شود؟ ")) return;
                    int RFocus = dataGridView_ListFileAllTrans.CurrentRow.Index;
                    TBL_SecondHouseFile thsf = DCSDC.TBL_SecondHouseFiles.First(hf => hf.SndHouseID.Equals(dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value));
                    DCSDC.TBL_SecondHouseFiles.DeleteOnSubmit(thsf);
                    DCSDC.SubmitChanges();
                    ShowListHouse(RFocus - 1);
                }
                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این " + SelCount.ToString() + " فایل به طور کامل از سیستم حذف شوند؟ ")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        TBL_SecondHouseFile thsf = DCSDC.TBL_SecondHouseFiles.First(hf => hf.SndHouseID.Equals(dataGridView_ListFileAllTrans.SelectedRows[SelCount].Cells["SndHouseID"].Value));
                        DCSDC.TBL_SecondHouseFiles.DeleteOnSubmit(thsf);
                        DCSDC.SubmitChanges();
                    }
                    ShowListHouse(0);
                }
            }
        }

        private void button_PrintFile_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListFileAllTrans.Rows.Count != 0)
                ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "ملک", false) + "Where SndHouseID = " + dataGridView_ListFileAllTrans.CurrentRow.Cells["SndHouseID"].Value.ToString(),
                    "ملک", ReportClass_Cls.FindReportDesign_HouseType(Convert.ToString(dataGridView_ListFileAllTrans.CurrentRow.Cells["TypeHouse"].Value)));//Global_Cls.ReportDesignAddress[0]);

        }

        private void button_PrintList_Click(object sender, EventArgs e)
        {            
            if (FileStatus == 1)
                ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "بایگانی", false) + " Where (FileStatus = 1) " + ListWhereSearch,
                    "بایگانی", Global_Cls.ReportDesignAddress[8]);
            else if (FileStatus == 2)
                ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "قراردادشده", false) + " Where (FileStatus = 2) " + ListWhereSearch,
                    "قراردادشده", Global_Cls.ReportDesignAddress[9]);
            else if (FileStatus == 3)
                ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "حذفی", false) + " Where (FileStatus = 3) " + ListWhereSearch,
                    "حذفی", Global_Cls.ReportDesignAddress[10]);
        }

        #endregion 
        
        
        #region Other

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
                tx.Text = str.Replace(" ", "");
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

        #endregion

        private void dataGridView_ListFileAllTrans_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_ListFileAllTrans.RowCount != 0)
            {
                HouseViewer_frm HVf = new HouseViewer_frm();
                HVf.LoadDataAndShow(" And (FileStatus = " + FileStatus + ")"+ListWhereSearch, dataGridView_ListFileAllTrans.CurrentRow.Index.ToString(),1);
            }
        }

        private void buttonItemHouseSMS_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListFileAllTrans.RowCount != 0)
                Global_Cls.SendSMS_Advertisment(true, "", Convert.ToString(dataGridView_ListFileAllTrans.CurrentRow.Cells["Lord_Mobile"].Value));
            else Global_Cls.SendSMS_Advertisment(true, "", "");
        }

        private void buttonItemHouseEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("");
        }


    }
}

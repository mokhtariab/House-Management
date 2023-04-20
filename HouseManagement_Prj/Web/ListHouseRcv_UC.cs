using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;
using System.Data.SqlClient;

namespace HouseManagement_Prj
{
    public partial class ListHouseRcv_UC: UserControl
    {
        public ListHouseRcv_UC()
        {
            InitializeComponent();
        }
        DataClasses_WebServiceDataContext DCWS = new DataClasses_WebServiceDataContext(Global_Cls.ConnectionStr);
        public int SearchOrNo = 0;
        public string ListWhereSearch = "";
        private bool LoadStatus = false;//ContexMenu
        int dgRowCnt = 0;


        #region Load & UI
        private void ListHouseRcv_UC_Load(object sender, EventArgs e)
        {
            //new
            comboBox_TypeHouse.Items.Add("");
            comboBox_HouseFor.Items.Add("");
            for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
                comboBox_TypeHouse.Items.Add(Global_Cls.TypeHouseAllCases[i]);
            for (int i = 0; i < Global_Cls.HouseForPrm.Count; i++) //new
                comboBox_HouseFor.Items.Add(Global_Cls.HouseForPrm[i]); //new
            //new

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(button_HFAddAll.Name)) button_HFAddAll.Enabled = false;
                if (UPer.Contains(button_HFAddSelect.Name)) button_HFAddSelect.Enabled = false;
                if (UPer.Contains(button_HFDel.Name)) button_HFDel.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
                button_SendSMS.Enabled = false;
            //codeing

            ShowListHouse(-1);
            try
            {
                dgRowCnt = dataGridView_ListTmpHouse.RowCount;
                dataGridView_ListTmpHouse.CurrentCell = dataGridView_ListTmpHouse.Rows[dgRowCnt - 1].Cells[dataGridView_ListTmpHouse.CurrentCell.ColumnIndex];
            }
            catch { }

            //ContexMenu
            for (int i = 0; i < dataGridView_ListTmpHouse.ColumnCount; i++)
                if (dataGridView_ListTmpHouse.Columns[i].Visible)
                {
                    ToolStripMenuItem TSI = new ToolStripMenuItem();
                    TSI.Alignment = ToolStripItemAlignment.Right;
                    TSI.CheckOnClick = true;
                    TSI.Name = dataGridView_ListTmpHouse.Columns[i].Name;
                    TSI.Text = dataGridView_ListTmpHouse.Columns[i].HeaderText;
                    TSI.Checked = true;

                    if (Global_Cls.AllSelectField_TmpHouse.Count != 0)
                        try
                        {
                            if (!Global_Cls.AllSelectField_TmpHouse.Contains(TSI.Name))
                            {
                                TSI.Checked = false;
                                dataGridView_ListTmpHouse.Columns[i].Visible = false;
                            }
                        }
                        catch { }
                    contextMenuStrip_LTmpHouse.Items.Add(TSI);
                }
            LoadStatus = true;
            //ContexMenu

        }

        private void contextMenuStrip_LTmpHouse_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                dataGridView_ListTmpHouse.Columns[e.ClickedItem.Name].Visible = (e.ClickedItem as ToolStripMenuItem).CheckState == CheckState.Unchecked;
            }
            catch { }
        }

        private void ListHouseRcv_UC_Layout(object sender, LayoutEventArgs e)
        {

            if (LoadStatus)
            {
                Global_Cls.AllSelectField_TmpHouse.Clear();
                for (int i = 0; i < contextMenuStrip_LTmpHouse.Items.Count; i++)
                    if ((contextMenuStrip_LTmpHouse.Items[i] as ToolStripMenuItem).Checked)
                        Global_Cls.AllSelectField_TmpHouse.Add((contextMenuStrip_LTmpHouse.Items[i] as ToolStripMenuItem).Name);
            }
        }


        #endregion



        #region Show List
        private void ShowListHouse(int RowFocus)
        {
            if (SearchOrNo == 1)
            {
                var SUS = from prd in DCWS.ListTmpHouse_Vws
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


                dataGridView_ListTmpHouse.DataSource = SUS;
            }
            else if (SearchOrNo == 0)
            {
                ListWhereSearch = "";
                var SUN = from prd in DCWS.ListTmpHouse_Vws
                          select prd;
                //New
                if (Global_Cls.MainForm.UserPrmHouseFor != "admin")
                {
                    SUN = SUN.Where(m => System.Data.Linq.SqlClient.SqlMethods.Like(Global_Cls.MainForm.UserPrmHouseFor, "%" + m.HouseFor + "%"));
                    ListWhereSearch += " And (patindex('%'+HouseFor+'%',N'" + Global_Cls.MainForm.UserPrmHouseFor + "')>0 )";
                }
                //New

                dataGridView_ListTmpHouse.DataSource = SUN;
            }

            try
            {
                dataGridView_ListTmpHouse.CurrentCell = dataGridView_ListTmpHouse.Rows[RowFocus].Cells[dataGridView_ListTmpHouse.CurrentCell.ColumnIndex];
            }
            catch
            {
                try { dataGridView_ListTmpHouse.CurrentCell = dataGridView_ListTmpHouse.Rows[0].Cells[0]; }
                catch { }
            }

        }
        #endregion



        #region All Buttons

        private void button_HFDel_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpHouse.RowCount != 0)
            {
                int SelCount = dataGridView_ListTmpHouse.SelectedRows.Count;
                if (SelCount == 1)
                {
                    int RFocus = dataGridView_ListTmpHouse.CurrentRow.Index;
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل حذف شود؟")) return;

                    TBL_TmpHouseFile tthf = DCWS.TBL_TmpHouseFiles.First(hf => hf.HouseID.Equals(dataGridView_ListTmpHouse.CurrentRow.Cells["HouseID"].Value));
                    DCWS.TBL_TmpHouseFiles.DeleteOnSubmit(tthf);
                    DCWS.SubmitChanges();
                    ShowListHouse(RFocus - 1);
                }

                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این" + SelCount.ToString() + " فایل انتخاب شده حذف شوند؟ ")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        TBL_TmpHouseFile tthf = DCWS.TBL_TmpHouseFiles.First(hf => hf.HouseID.Equals(dataGridView_ListTmpHouse.SelectedRows[SelCount].Cells["HouseID"].Value));
                        DCWS.TBL_TmpHouseFiles.DeleteOnSubmit(tthf);
                        DCWS.SubmitChanges();
                    }
                    ShowListHouse(0);
                }
            }
        }
        

        private void button_SendSMS_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpHouse.RowCount != 0)
                Global_Cls.SendSMS_Advertisment(true, "", Convert.ToString(dataGridView_ListTmpHouse.CurrentRow.Cells["Lord_Mobile"].Value));
            else Global_Cls.SendSMS_Advertisment(true, "", "");
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

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchOrNo = 1;
            ShowListHouse(0);
            try
            {
                dataGridView_ListTmpHouse.CurrentCell = dataGridView_ListTmpHouse.Rows[dataGridView_ListTmpHouse.RowCount - 1].Cells[dataGridView_ListTmpHouse.CurrentCell.ColumnIndex];
            }
            catch
            { }

        }

        private void dataGridView_ListTmpHouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                SearchOrNo = 0;
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

                exPanel_Search.Expanded = false;
            }
        }

        #endregion


        #region WebTransaction

        private bool NoMessage = false;
        private void button_HFAddAll_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpHouse.RowCount == 0) return;

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید کل فایلها به لیست اصلی اضافه شوند؟ تکراری ها اضافه نمی شوند!")) return;
            int i = 0, HsID = 0, RecCnt = dataGridView_ListTmpHouse.RowCount;
            string TypeHouseStr = "", HouseForStr = "";

            NoMessage = true;
            while (RecCnt > 0)
            {
                dataGridView_ListTmpHouse.CurrentCell = dataGridView_ListTmpHouse.Rows[i].Cells[dataGridView_ListTmpHouse.CurrentCell.ColumnIndex];
                i++;
                RecCnt--;


                HsID = Convert.ToInt32(dataGridView_ListTmpHouse.CurrentRow.Cells["HouseID"].Value);
                TypeHouseStr = dataGridView_ListTmpHouse.CurrentRow.Cells["TypeHouse"].Value.ToString();
                HouseForStr = dataGridView_ListTmpHouse.CurrentRow.Cells["HouseFor"].Value.ToString();
                
                InsertToListHouseFile(HsID, TypeHouseStr, HouseForStr);

            }
            NoMessage = false;
            ShowListHouse(0);
        }


        private void button_HFAddSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpHouse.RowCount != 0)
            {
                int SelCount = dataGridView_ListTmpHouse.SelectedRows.Count;

                if (SelCount == 1)
                {
                    int RFocus = dataGridView_ListTmpHouse.CurrentRow.Index;
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این فایل به لیست اصلی اضافه شود؟")) return;
                    int HsID = Convert.ToInt32(dataGridView_ListTmpHouse.CurrentRow.Cells["HouseID"].Value);

                    string TypeHouseStr = dataGridView_ListTmpHouse.CurrentRow.Cells["TypeHouse"].Value.ToString();
                    string HouseForStr = dataGridView_ListTmpHouse.CurrentRow.Cells["HouseFor"].Value.ToString();
                    InsertToListHouseFile(HsID, TypeHouseStr, HouseForStr);

                    ShowListHouse(RFocus - 1);
                }
                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این" + SelCount.ToString() + " فایل انتخاب شده به لیست اصلی اضافه شوند؟ ")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        int HsID = Convert.ToInt32(dataGridView_ListTmpHouse.SelectedRows[SelCount].Cells["HouseID"].Value);

                        string TypeHouseStr = dataGridView_ListTmpHouse.SelectedRows[SelCount].Cells["TypeHouse"].Value.ToString();
                        string HouseForStr = dataGridView_ListTmpHouse.SelectedRows[SelCount].Cells["HouseFor"].Value.ToString();
                        InsertToListHouseFile(HsID, TypeHouseStr, HouseForStr);
                    }

                    ShowListHouse(0);
                }

            }

        }

        private void InsertToListHouseFile(int HsID, string TypeHouseStr, string HouseForStr)
        {
            DataClasses_WebServiceDataContext DWS = new DataClasses_WebServiceDataContext(Global_Cls.ConnectionStr);
            try
            {
                DWS.InsRecTmpHFileToHFile_Sp(HsID, Global_Cls.UserCode_Exist);
                DWS.SubmitChanges();
            }
            catch (Exception ex)
            {
                if (!NoMessage)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                    else if (ex.Message.IndexOf("Duplicated Tbl_Second!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده در لیست بایگانی، حذفیات و یا قراردادها وجود دارد!");
                }
                
                if (ex.Message.IndexOf("TypeHouse!") > -1)
                {
                    Global_Cls.TypeHouseAllCases.Insert(Global_Cls.TypeHouseAllCases.Count, TypeHouseStr);
                    DataClassesSecondDataContext da = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
                    var dd = da.TBL_SetDefaultSettings.First(c => c.SetID == 1);
                    dd.TypeHouse += TypeHouseStr + ";";
                    da.SubmitChanges();
                    InsertToListHouseFile(HsID, TypeHouseStr, HouseForStr);
                }


                if (ex.Message.IndexOf("HouseFor!") > -1)
                {
                    Global_Cls.HouseFor.Insert(Global_Cls.HouseFor.Count, HouseForStr);
                    Global_Cls.HouseForPrm.Insert(Global_Cls.HouseForPrm.Count, HouseForStr);//new
                    DataClassesSecondDataContext da = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
                    var dd = da.TBL_SetDefaultSettings.First(c => c.SetID == 1);
                    dd.HouseFor += HouseForStr + ";";
                    da.SubmitChanges();
                    InsertToListHouseFile(HsID, TypeHouseStr, HouseForStr);
                }

            }
        }

        #endregion

       
        private void dataGridView_ListTmpHouse_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpHouse.RowCount != 0)
            {
                HouseViewer_frm HVf = new HouseViewer_frm();
                HVf.LoadDataAndShow(ListWhereSearch, dataGridView_ListTmpHouse.CurrentRow.Index.ToString(),2);
            }

        }

    }
}

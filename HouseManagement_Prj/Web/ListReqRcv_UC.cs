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
    public partial class ListReqRcv_UC : UserControl
    {
        public ListReqRcv_UC()
        {
            InitializeComponent();
        }
        DataClasses_WebServiceDataContext DCWS = new DataClasses_WebServiceDataContext(Global_Cls.ConnectionStr);
        public int SearchOrNo = 0;
        public string ListWhereSearch = "";
        private bool LoadStatus = false;//ContexMenu
        int dgRowCnt = 0;


        #region Load
        private void ListReqRcv_UC_Load(object sender, EventArgs e)
        {
            //new
            comboBox_TypeHouse.Items.Add("");
            comboBox_ReqFor.Items.Add("");
            for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
                comboBox_TypeHouse.Items.Add(Global_Cls.TypeHouseAllCases[i]);
            for (int i = 0; i < Global_Cls.RequestFor.Count; i++)
                comboBox_ReqFor.Items.Add(Global_Cls.RequestFor[i]);
            //new

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(button_AddAllCu.Name)) button_AddAllCu.Enabled = false;
                if (UPer.Contains(button_AddSelCu.Name)) button_AddSelCu.Enabled = false;
                if (UPer.Contains(button_TCuDelete.Name)) button_TCuDelete.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
                button_SendSMS.Enabled = false;
            //codeing

            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(30));
            comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
            comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            ShowListCustomer(0);
            try
            {
                dgRowCnt = dataGridView_ListTmpCustomer.RowCount;
                dataGridView_ListTmpCustomer.CurrentCell = dataGridView_ListTmpCustomer.Rows[dgRowCnt - 1].Cells[dataGridView_ListTmpCustomer.CurrentCell.ColumnIndex];
            }
            catch { }

            //ContexMenu
            for (int i = 0; i < dataGridView_ListTmpCustomer.ColumnCount; i++)
                if (dataGridView_ListTmpCustomer.Columns[i].Visible)
                {
                    ToolStripMenuItem TSI = new ToolStripMenuItem();
                    TSI.Alignment = ToolStripItemAlignment.Right;
                    TSI.CheckOnClick = true;
                    TSI.Name = dataGridView_ListTmpCustomer.Columns[i].Name;
                    TSI.Text = dataGridView_ListTmpCustomer.Columns[i].HeaderText;
                    TSI.Checked = true;
                    if (Global_Cls.AllSelectField_TmpCustomer.Count != 0)
                        try
                        {
                            if (!Global_Cls.AllSelectField_TmpCustomer.Contains(TSI.Name))
                            {
                                TSI.Checked = false;
                                dataGridView_ListTmpCustomer.Columns[i].Visible = false;
                            }
                        }
                        catch { }
                    contextMenuStrip_TCu.Items.Add(TSI);
                }
            LoadStatus = true;
            //ContexMenu
        }

        private void contextMenuStrip_TCu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                dataGridView_ListTmpCustomer.Columns[e.ClickedItem.Name].Visible = (e.ClickedItem as ToolStripMenuItem).CheckState == CheckState.Unchecked;
            }
            catch { }
        }

        #endregion


        #region Search
        private void ShowListCustomer(int RowFocus)
        {
            if (SearchOrNo == 1)
            {

                var SUS = from prd in DCWS.ListTmpCustomer_Vws
                          select prd;


                ListWhereSearch = " Where (1=1) ";
                if (checkBox_ReqNo.Checked)
                {
                    SUS = SUS.Where(i => Convert.ToInt32(i.Request_NO) >= nUpDown_ReqNo1.Value && Convert.ToInt32(i.Request_NO) <= nUpDown_ReqNo2.Value);
                    ListWhereSearch += " And (Convert(Int,Request_NO) >= " + nUpDown_ReqNo1.Value + ")And(Convert(Int,Request_NO) <= " + nUpDown_ReqNo2.Value + ")";
                }

                if (checkBox_CName.Checked)
                {
                    SUS = SUS.Where(m => m.Customer_Name.Contains(textBox_CName.Text));
                    ListWhereSearch += " And (Customer_Name+Customer_Family Like N'%" + textBox_CName.Text + "%')";
                }

                if (comboBox_TypeHouse.Text != "")
                {
                    SUS = SUS.Where(m => m.TypeHouseReq == comboBox_TypeHouse.Text);
                    ListWhereSearch += " And (TypeHouseReq = N'" + comboBox_TypeHouse.Text + "')";
                }

                if (comboBox_ReqFor.Text != "")
                {
                    SUS = SUS.Where(m => m.HouseReqFor == comboBox_ReqFor.Text);
                    ListWhereSearch += " And (HouseReqFor = N'" + comboBox_ReqFor.Text + "')";
                }

                if (nUpDown_People.Value != 0)
                {
                    SUS = SUS.Where(m => m.FewPerson_Rent <= nUpDown_People.Value);
                    ListWhereSearch += " And (FewPerson_Rent <= " + nUpDown_People.Value.ToString() + ")";
                }

                if (comboBox_ReqUse.Text != "")
                {
                    SUS = SUS.Where(m => m.Request_Use == comboBox_ReqUse.Text);
                    ListWhereSearch += " And (Request_Use = N'" + comboBox_ReqUse.Text + "')";
                }

                if (comboBox_TGBuy.Text != "")
                {
                    SUS = SUS.Where(m => m.TypeGive_Buy == comboBox_TGBuy.Text);
                    ListWhereSearch += " And (TypeGive_Buy = N'" + comboBox_TGBuy.Text + "')";
                }

                if (checkBox_ExpireDate.Checked)
                {
                    SUS = SUS.Where(m => m.Expired_Date.Value <= Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text));
                    ListWhereSearch += " And (Expired_Date <= '" + Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text).ToShortDateString() + "') ";
                }

                if (checkBox_CSubbuild.Checked)
                {
                    SUS = SUS.Where(m => m.Req_SubMeter1 >= (double)((textBox_CSubBuild1.Text == "") ? 0 : (double.Parse(textBox_CSubBuild1.Text))) && m.Req_SubMeter2 <= (double)((textBox_CSubBuild2.Text == "") ? 0 : (double.Parse(textBox_CSubBuild2.Text))));
                    ListWhereSearch += " And (Req_SubMeter1 >= " + (string)((textBox_CSubBuild1.Text == "") ? "0" : (textBox_CSubBuild1.Text)) + ") And (Req_SubMeter2 <= " + (string)((textBox_CSubBuild2.Text == "") ? "0" : (textBox_CSubBuild2.Text)) + ")";
                }


                Int64 Cost1 = 0, Cost2 = 0;
                try { Cost1 = Convert.ToInt64(textBox_Cost1.Text.Replace(",", "")); }
                catch { }
                try { Cost2 = Convert.ToInt64(textBox_Cost2.Text.Replace(",", "")); }
                catch { }

                if (Cost1 != 0 || Cost2 != 0)
                {
                    if (radioButton_CPrice.Checked)
                    {
                        SUS = SUS.Where(m => m.Bodget_Buy1 >= Cost1 && m.Bodget_Buy2 <= Cost2);
                        ListWhereSearch += " And (Bodget_Buy1 >= " + Cost1.ToString() + ")And(Bodget_Buy2 <= " + Cost2.ToString() + ")";
                    }
                    else if (radioButton_CMtg.Checked)
                    {
                        SUS = SUS.Where(m => m.Bodget_Mortgage1 >= Cost1 && m.Bodget_Mortgage2 <= Cost2);
                        ListWhereSearch += " And (Bodget_Mortgage1 >= " + Cost1.ToString() + ")And(Bodget_Mortgage2 <= " + Cost2.ToString() + ")";
                    }
                    else if (radioButton_CRent.Checked)
                    {
                        SUS = SUS.Where(m => m.Bodget_Rent1 >= Cost1 && m.Bodget_Rent2 <= Cost2);
                        ListWhereSearch += " And (Bodget_Rent1 >= " + Cost1.ToString() + ")And(Bodget_Rent2 <= " + Cost2.ToString() + ")";
                    }
                }

                dataGridView_ListTmpCustomer.DataSource = SUS;
            }
            else if (SearchOrNo == 0)
            {
                ListWhereSearch = "";
                var SUN = from prd in DCWS.ListTmpCustomer_Vws
                          select prd;
                dataGridView_ListTmpCustomer.DataSource = SUN;
            }

            try
            {
                dataGridView_ListTmpCustomer.CurrentCell = dataGridView_ListTmpCustomer.Rows[RowFocus].Cells[dataGridView_ListTmpCustomer.CurrentCell.ColumnIndex];
            }
            catch
            {
                try
                {
                    dataGridView_ListTmpCustomer.CurrentCell = dataGridView_ListTmpCustomer.Rows[0].Cells[0];
                }
                catch { }
            }
        }

        private void dataGridView_ListTmpCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                SearchOrNo = 0;
                ShowListCustomer(dgRowCnt - 1);

                nUpDown_ReqNo1.Value = 0;
                nUpDown_ReqNo2.Value = 0;
                nUpDown_People.Value = 0;

                comboBox_TypeHouse.Text = "";
                comboBox_ReqFor.Text = "";
                comboBox_TGBuy.Text = "";
                comboBox_ReqUse.Text = "";
                textBox_CSubBuild1.Text = "0";
                textBox_CSubBuild2.Text = "0";

                textBox_Cost1.Text = "0";
                textBox_Cost2.Text = "0";

                textBox_CName.Text = "";

                exPanel_CSearch.Expanded = false;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchOrNo = 1;
            ShowListCustomer(0);
            try
            {
                dataGridView_ListTmpCustomer.CurrentCell = dataGridView_ListTmpCustomer.Rows[dataGridView_ListTmpCustomer.RowCount - 1].Cells[dataGridView_ListTmpCustomer.CurrentCell.ColumnIndex];
            }
            catch
            { }

        }

        #endregion


        #region All Buttons

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpCustomer.RowCount != 0)
            {
                int SelCount = dataGridView_ListTmpCustomer.SelectedRows.Count;
                if (SelCount == 1)
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این متقاضی حذف شود؟")) return;
                    int RFocus = dataGridView_ListTmpCustomer.CurrentRow.Index;
                    TBL_TmpHouseRequest tthr = DCWS.TBL_TmpHouseRequests.First(hr => hr.RequestID.Equals(dataGridView_ListTmpCustomer.CurrentRow.Cells["RequestID"].Value));
                    DCWS.TBL_TmpHouseRequests.DeleteOnSubmit(tthr);

                    DCWS.SubmitChanges();
                    ShowListCustomer(RFocus - 1);
                }
                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این" + SelCount.ToString() + " متقاضی انتخاب شده حذف شوند؟")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        TBL_TmpHouseRequest tthr = DCWS.TBL_TmpHouseRequests.First(hr => hr.RequestID.Equals(dataGridView_ListTmpCustomer.SelectedRows[SelCount].Cells["RequestID"].Value));
                        DCWS.TBL_TmpHouseRequests.DeleteOnSubmit(tthr);
                        DCWS.SubmitChanges();
                    }
                    ShowListCustomer(0);
                }

            }

        }

        private void button_SendSMS_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpCustomer.RowCount != 0)
                Global_Cls.SendSMS_Advertisment(true, "", Convert.ToString(dataGridView_ListTmpCustomer.CurrentRow.Cells["Customer_Mobile"].Value));
            else Global_Cls.SendSMS_Advertisment(true, "", "");
        }

        #endregion


        #region Other
        private void panel_Date_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }

        TextBox tx = new TextBox();
        private void textBox_Subbuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar == '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }

        private void textBox_Cost1_TextChanged(object sender, EventArgs e)
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

        private void textBox_Cost1_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion


        #region Transaction
        private void ListReqRcv_UC_Layout(object sender, LayoutEventArgs e)
        {
            if (LoadStatus)
            {
                Global_Cls.AllSelectField_TmpCustomer.Clear();
                for (int i = 0; i < contextMenuStrip_TCu.Items.Count; i++)
                    if ((contextMenuStrip_TCu.Items[i] as ToolStripMenuItem).Checked)
                        Global_Cls.AllSelectField_TmpCustomer.Add((contextMenuStrip_TCu.Items[i] as ToolStripMenuItem).Name);
            }

        }

        #endregion


        #region WebTransaction

        private bool NoMessage = false;
        private void button_AddAllCu_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpCustomer.RowCount == 0) return;

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید کل متقاضیان به لیست اصلی اضافه شوند؟ تکراری ها اضافه نمی شوند!")) return;
            int i = 0, ReqID = 0, RecCnt = dataGridView_ListTmpCustomer.RowCount;
            string TypeHouseStr = "", RequestForStr = "";

            NoMessage = true;
            while (RecCnt > 0)
            {
                dataGridView_ListTmpCustomer.CurrentCell = dataGridView_ListTmpCustomer.Rows[i].Cells[dataGridView_ListTmpCustomer.CurrentCell.ColumnIndex];
                RecCnt--;
                i++;

                ReqID = Convert.ToInt32(dataGridView_ListTmpCustomer.CurrentRow.Cells["RequestID"].Value);
                TypeHouseStr = dataGridView_ListTmpCustomer.CurrentRow.Cells["TypeHouseReq"].Value.ToString();
                RequestForStr = dataGridView_ListTmpCustomer.CurrentRow.Cells["HouseReqFor"].Value.ToString();

                InsertToListCustomer(ReqID, TypeHouseStr, RequestForStr);

            }
            NoMessage = false;
            ShowListCustomer(0);
        }

        private void button_AddSelCu_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListTmpCustomer.RowCount != 0)
            {
                int SelCount = dataGridView_ListTmpCustomer.SelectedRows.Count;

                if (SelCount == 1)
                {
                    int RFocus = dataGridView_ListTmpCustomer.CurrentRow.Index;
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این متقاضی به لیست اصلی اضافه شود؟")) return;
                    int ReqID = Convert.ToInt32(dataGridView_ListTmpCustomer.CurrentRow.Cells["RequestID"].Value);

                    string TypeHouseStr = dataGridView_ListTmpCustomer.CurrentRow.Cells["TypeHouseReq"].Value.ToString();
                    string RequestForStr = dataGridView_ListTmpCustomer.CurrentRow.Cells["HouseReqFor"].Value.ToString();
                    InsertToListCustomer(ReqID, TypeHouseStr, RequestForStr);

                    ShowListCustomer(RFocus - 1);
                }
                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این" + SelCount.ToString() + " متقاضی انتخاب شده به لیست اصلی اضافه شوند؟ ")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        int ReqID = Convert.ToInt32(dataGridView_ListTmpCustomer.SelectedRows[SelCount].Cells["RequestID"].Value);

                        string TypeHouseStr = dataGridView_ListTmpCustomer.SelectedRows[SelCount].Cells["TypeHouseReq"].Value.ToString();
                        string RequestForStr = dataGridView_ListTmpCustomer.SelectedRows[SelCount].Cells["HouseReqFor"].Value.ToString();
                        InsertToListCustomer(ReqID, TypeHouseStr, RequestForStr);
                    }
                    ShowListCustomer(0);
                }

            }
        }

        private void InsertToListCustomer(int ReqID, string TypeHouseStr, string RequestForStr)
        {
            DataClasses_WebServiceDataContext DWS = new DataClasses_WebServiceDataContext(Global_Cls.ConnectionStr);
            try
            {
                DWS.InsRecTmpHRequestToHRequest_Sp(ReqID, Global_Cls.UserCode_Exist);
                DWS.SubmitChanges();
            }
            catch (Exception ex)
            {
                if (!NoMessage)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                }

                if (ex.Message.IndexOf("TypeHouse!") > -1)
                {
                    Global_Cls.TypeHouseAllCases.Insert(Global_Cls.TypeHouseAllCases.Count, TypeHouseStr);
                    DataClassesSecondDataContext da = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
                    var dd = da.TBL_SetDefaultSettings.First(c => c.SetID == 1);
                    dd.TypeHouse += TypeHouseStr + ";";
                    da.SubmitChanges();
                    InsertToListCustomer(ReqID, TypeHouseStr, RequestForStr);
                }


                if (ex.Message.IndexOf("RequestFor!") > -1)
                {
                    Global_Cls.RequestFor.Insert(Global_Cls.RequestFor.Count, RequestForStr);
                    DataClassesSecondDataContext da = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
                    var dd = da.TBL_SetDefaultSettings.First(c => c.SetID == 1);
                    dd.RequestFor += RequestForStr + ";";
                    da.SubmitChanges();
                    InsertToListCustomer(ReqID, TypeHouseStr, RequestForStr);
                }

            }
        }
        #endregion

    }
}

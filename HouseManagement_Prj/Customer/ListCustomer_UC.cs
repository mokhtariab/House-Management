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
    public partial class ListCustomer_UC : UserControl
    {
        public ListCustomer_UC()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        public int SearchOrNo = 0;
        public string ListWhereSearch = "";
        private bool LoadStatus = false;//ContexMenu
        int dgRowCnt = 0;


        #region Load
        private void ListCustomer_UC_Load(object sender, EventArgs e)
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
                if (UPer.Contains(button_SendSMS.Name)) button_SendSMS.Enabled = false;
                if (UPer.Contains(buttonItemCustomerSMS.Name)) buttonItemCustomerSMS.Enabled = false;
                if (UPer.Contains(buttonItemCustomerEmail.Name)) buttonItemCustomerEmail.Enabled = false;
                if (UPer.Contains(button_Delete.Name)) button_Delete.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S")) buttonItemCustomerSMS.Enabled = false;
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1")) buttonItemCustomerEmail.Enabled = false;
            if (Global_Cls.SoftwareCode == "Trial") buttonItemCustomerEmail.Enabled = false;
            //codeing

            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(30));
            comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString(); 
            comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
            comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            dgRowCnt = dataGridView_ListCustomer.RowCount;
            ShowListCustomer(dgRowCnt - 1);

            //ContexMenu
            for (int i = 0; i < dataGridView_ListCustomer.ColumnCount; i++)
                if (dataGridView_ListCustomer.Columns[i].Visible)
                {
                    ToolStripMenuItem TSI = new ToolStripMenuItem();
                    TSI.Alignment = ToolStripItemAlignment.Right;
                    TSI.CheckOnClick = true;
                    TSI.Name = dataGridView_ListCustomer.Columns[i].Name;
                    TSI.Text = dataGridView_ListCustomer.Columns[i].HeaderText;
                    TSI.Checked = true;
                    if (Global_Cls.AllSelectField_Customer.Count != 0)
                        try
                        {
                            if (!Global_Cls.AllSelectField_Customer.Contains(TSI.Name))
                            {
                                TSI.Checked = false;
                                dataGridView_ListCustomer.Columns[i].Visible = false;
                            }
                        }
                        catch { }
                    contextMenuStrip_Cu.Items.Add(TSI);
                }
            LoadStatus = true;
            //ContexMenu
        }

        private void contextMenuStrip_Cu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                dataGridView_ListCustomer.Columns[e.ClickedItem.Name].Visible = (e.ClickedItem as ToolStripMenuItem).CheckState == CheckState.Unchecked;
            }
            catch { }
        }

        #endregion

        
        #region Search
        private void ShowListCustomer(int RowFocus)
        {
            if (SearchOrNo == 1)
            {

/*                string RequestFor = "";
                if (checkBox_Buy.Checked) RequestFor = "خرید";
                else if (checkBox_Rent.Checked && checkBox_Mortgage.Checked) RequestFor = "رهن و اجاره";
                else if (checkBox_Mortgage.Checked) RequestFor = "رهن";
                else if (checkBox_Rent.Checked) RequestFor = "اجاره";
                else if (checkBox_PreBuy.Checked) RequestFor = "پیش خرید";
                else if (checkBox_Prtpc.Checked) RequestFor = "مشارکت";

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


                var SUS = from prd in DCDC.ListCustomer_Vws
                          select prd;
                          
                                                    /*where (prd.HouseReqFor == HouseReqForStr) && (prd.TypeHouseReq == TypeHouseReqStr)
                          && (prd.Request_Use == comboBox_ReqFor.Text)
                          && (prd.TypeGive_Buy == comboBox_TGBuy.Text)
                          && (prd.Req_SubMeter <= Convert.ToDouble(textBox_Subbuild.Text))
                          && (prd.Expired_Date <= Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text))
                          && (prd.Approach_Type == radioButton_Facing.Checked)

                          new{
                              prd.Bodget_Buy,
                              prd.Bodget_MR,
                              prd.Customer_Mobile,
                              prd.Customer_Name,
                              prd.FewPerson_Rent,
                              prd.PartRequest1,
                              prd.Req_SubMeter,
                              prd.RequestDate,
                              prd.HouseReqFor,
                              prd.RequestID,
                              prd.TypeHouseReq
                          };*/

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
                
                if (comboBox_Approch.Text != "")
                {
                    SUS = SUS.Where(m => m.Approach_Type == comboBox_Approch.Text);
                    ListWhereSearch += " And (Approach_Type = " + Convert.ToBoolean(comboBox_Approch.SelectedIndex == 1) + ")";
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
                    SUS = SUS.Where(m => m.Expired_Date.Value <= Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text) );
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

                dataGridView_ListCustomer.DataSource = SUS;
            }
            else if (SearchOrNo==0)
            {
                ListWhereSearch = "";
                var SUN = from prd in DCDC.ListCustomer_Vws
                          select prd;
                          /*new
                          {
                              prd.Bodget_Buy,
                              prd.Bodget_MR,
                              prd.Customer_Mobile,
                              prd.Customer_Name,
                              prd.FewPerson_Rent,
                              //prd.PartRequest1,
                              prd.Req_SubMeter,
                              prd.RequestDate,
                              prd.HouseReqFor,
                              prd.RequestID,
                              prd.TypeHouseReq
                          };*/
                dataGridView_ListCustomer.DataSource = SUN;
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

                    SqCmd.CommandText = " SELECT  dbo.TBL_HouseRequest.RequestID, dbo.TBL_HouseRequest.Request_NO, dbo.MiladiToShamsi(dbo.TBL_HouseRequest.RequestDate) AS RequestDate, (ISNULL(dbo.TBL_HouseRequest.Customer_Name, '') "
                           +" + ' ' + ISNULL(dbo.TBL_HouseRequest.Customer_Family, '')) COLLATE DATABASE_DEFAULT AS Customer_Name, dbo.TBL_HouseRequest.Customer_Mobile, "
                           +" N' از ' + CAST(dbo.TBL_HouseRequest.Req_SubMeter1 AS varchar) + N' تا ' + CAST(dbo.TBL_HouseRequest.Req_SubMeter2 AS varchar) AS Req_SubMeterStr, "
                           +" dbo.TBL_HouseRequest.Req_SubMeter1, dbo.TBL_HouseRequest.Req_SubMeter2, N' از ' + dbo.DigitSeparator(dbo.TBL_HouseRequest.Bodget_Buy1) "
                           +" + N' تا ' + dbo.DigitSeparator(dbo.TBL_HouseRequest.Bodget_Buy2) AS Bodget_BuyStr, N' از ' + dbo.DigitSeparator(dbo.TBL_HouseRequest.Bodget_Rent1) "
                           +" + N' تا ' + dbo.DigitSeparator(dbo.TBL_HouseRequest.Bodget_Rent2) AS Bodget_RentStr, N' از ' + dbo.DigitSeparator(dbo.TBL_HouseRequest.Bodget_Mortgage1) "
                           +" + N' تا ' + dbo.DigitSeparator(dbo.TBL_HouseRequest.Bodget_Mortgage2) AS Bodget_MortgageStr, ISNULL(P1.PartName_Fa, '') + '-' + ISNULL(P2.PartName_Fa, '')" 
                           +" + '-' + ISNULL(P3.PartName_Fa, '') + '-' + ISNULL(P4.PartName_Fa, '') AS PartRequest, (CASE WHEN Approach_Type = 1 THEN N'حضوری' ELSE N'غیر حضوری' END) AS Approach_Type, "
                           +" dbo.MiladiToShamsi(dbo.TBL_HouseRequest.Expired_Date) AS Expired_DateStr, dbo.TBL_HouseRequest.TypeGive_Buy, dbo.TBL_HouseRequest.FewPerson_Rent, "
                           +" dbo.TBL_HouseRequest.Request_Use, dbo.TBL_HouseRequest.HouseReqFor, dbo.TBL_HouseRequest.TypeHouseReq, dbo.TBL_HouseRequest.Bodget_Buy1, "
                           +" dbo.TBL_HouseRequest.Bodget_Rent1, dbo.TBL_HouseRequest.Bodget_Mortgage1, dbo.TBL_HouseRequest.Bodget_Buy2, dbo.TBL_HouseRequest.Bodget_Rent2, "
                           +" dbo.TBL_HouseRequest.Bodget_Mortgage2, dbo.TBL_HouseRequest.Expired_Date"
                           +" FROM     dbo.TBL_HouseRequest LEFT OUTER JOIN"
                           +" dbo.TBL_Part AS P1 ON P1.PartID = dbo.TBL_HouseRequest.PartRequest1 LEFT OUTER JOIN"
                           +" dbo.TBL_Part AS P2 ON P2.PartID = dbo.TBL_HouseRequest.PartRequest2 LEFT OUTER JOIN"
                           +" dbo.TBL_Part AS P3 ON P3.PartID = dbo.TBL_HouseRequest.PartRequest3 LEFT OUTER JOIN"
                           +" dbo.TBL_Part AS P4 ON P4.PartID = dbo.TBL_HouseRequest.PartRequest4 "
                           +" WHERE (1=1) "
                   + ListWhereSearch;
                    DataTable retValue = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(SqCmd);
                    da.Fill(retValue);
                    dataGridView_ListCustomer.DataSource = retValue;
                    SqConn.Close();
                }
                catch { }
            }

            try
            {
                dataGridView_ListCustomer.CurrentCell = dataGridView_ListCustomer.Rows[RowFocus].Cells[dataGridView_ListCustomer.CurrentCell.ColumnIndex];
            }
            catch
            {
                try
                {
                    dataGridView_ListCustomer.CurrentCell = dataGridView_ListCustomer.Rows[0].Cells[0];
                }
                catch { }
            }
        }

        private void dataGridView_ListCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                SearchOrNo = 0;
                ShowListCustomer(dgRowCnt-1);

                nUpDown_ReqNo1.Value = 0;
                nUpDown_ReqNo2.Value = 0;
                nUpDown_People.Value = 0;

                comboBox_TypeHouse.Text = "";
                comboBox_ReqFor.Text = "";
                comboBox_TGBuy.Text = "";
                comboBox_ReqUse.Text = "";
                comboBox_Approch.Text = "";
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
                dataGridView_ListCustomer.CurrentCell = dataGridView_ListCustomer.Rows[dataGridView_ListCustomer.RowCount - 1].Cells[dataGridView_ListCustomer.CurrentCell.ColumnIndex];
            }
            catch
            { }

        }

        #endregion


        #region All Buttons
        private void dataGridView_ListCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_ListCustomer.RowCount != 0)
                Global_Cls.MainForm.EditCustomer_Function(Convert.ToInt32(dataGridView_ListCustomer.CurrentRow.Cells["RequestID"].Value));
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListCustomer.RowCount != 0)
            {
                int SelCount = dataGridView_ListCustomer.SelectedRows.Count;
                if (SelCount == 1)
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این متقاضی حذف شود؟")) return;
                    int RFocus = dataGridView_ListCustomer.CurrentRow.Index;
                    TBL_HouseRequest thr = DCDC.TBL_HouseRequests.First(hr => hr.RequestID.Equals(dataGridView_ListCustomer.CurrentRow.Cells["RequestID"].Value));
                    DCDC.TBL_HouseRequests.DeleteOnSubmit(thr);

                    DCDC.SubmitChanges();
                    ShowListCustomer(RFocus - 1);
                }
                else
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این" + SelCount.ToString() + " متقاضی انتخاب شده حذف شوند؟ ")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        TBL_HouseRequest thr = DCDC.TBL_HouseRequests.First(hr => hr.RequestID.Equals(dataGridView_ListCustomer.SelectedRows[SelCount].Cells["RequestID"].Value));
                        DCDC.TBL_HouseRequests.DeleteOnSubmit(thr);
                        DCDC.SubmitChanges();
                    }
                    ShowListCustomer(0);
                }
            }

        }

        private void button_PrintList_Click(object sender, EventArgs e)
        {
            ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateRequestTbl_Report("متقاضیان", false) + ListWhereSearch,// " SELECT * FROM ListCustomer_Vw" + ListWhereSearch,
               "متقاضیان", Global_Cls.ReportDesignAddress[11]);//Application.StartupPath + @"\Report\Customer\ListCustomer.frx");
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
        private void ListCustomer_UC_Leave(object sender, EventArgs e)
        {
            Global_Cls.RequestIDChangeEdit = -100;
        }

        private void dataGridView_ListCustomer_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                if (dataGridView_ListCustomer.CurrentRow.Cells["RequestID"].Value != null)
                    Global_Cls.RequestIDChangeEdit = Convert.ToInt32(dataGridView_ListCustomer.CurrentRow.Cells["RequestID"].Value);
            }
            catch { }
        }

        private void ListCustomer_UC_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                int RowCnt = dataGridView_ListCustomer.RowCount;
                int RFocus = 0;
                if (RowCnt != 0) RFocus = dataGridView_ListCustomer.CurrentRow.Index;
                ShowListCustomer(RFocus);
                if (RowCnt != dataGridView_ListCustomer.RowCount)
                {
                    dataGridView_ListCustomer.CurrentCell = dataGridView_ListCustomer.Rows[dataGridView_ListCustomer.RowCount - 1].Cells[dataGridView_ListCustomer.CurrentCell.ColumnIndex];
                    dgRowCnt = dataGridView_ListCustomer.RowCount;
                }
            }
            catch { }

            if (LoadStatus)
            {
                Global_Cls.AllSelectField_Customer.Clear();
                for (int i = 0; i < contextMenuStrip_Cu.Items.Count; i++)
                    if ((contextMenuStrip_Cu.Items[i] as ToolStripMenuItem).Checked)
                        Global_Cls.AllSelectField_Customer.Add((contextMenuStrip_Cu.Items[i] as ToolStripMenuItem).Name);
            }

        }

        #endregion

        private void buttonItemCustomerSMS_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListCustomer.RowCount != 0)
                Global_Cls.SendSMS_Advertisment(true, "", Convert.ToString(dataGridView_ListCustomer.CurrentRow.Cells["Customer_Mobile"].Value));
            else Global_Cls.SendSMS_Advertisment(true, "", "");

        }

        private void buttonItemCustomerEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("");
        }
    }
}

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
    public partial class ListConclusion_UC : UserControl
    {
        public ListConclusion_UC()
        {
            InitializeComponent();
        }

        DataClassesSecondDataContext DCMD = new DataClassesSecondDataContext(Global_Cls.ConnectionStr);
        public bool SearchOrNo = false;
        public string ListWhereSearch = "";
        private bool LoadStatus = false;//ContexMenu
        int dgRowCnt = 0;


        #region Load & UI
        private void ListConclusion_UC_Load(object sender, EventArgs e)
        {
            LoadStatus = true;//ContexMenu
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(button_EditCnlu.Name)) button_EditCnlu.Enabled = false;
                if (UPer.Contains(button_DeleteCnlu.Name)) button_DeleteCnlu.Enabled = false;
            }

            ShowConclusionList(0);
            try
            {
                dgRowCnt = dataGridView_ListCnclu.RowCount;
                dataGridView_ListCnclu.CurrentCell = dataGridView_ListCnclu.Rows[dgRowCnt - 1].Cells[dataGridView_ListCnclu.CurrentCell.ColumnIndex];
            }
            catch { }


            //date Text
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString(); comboBox_Year2.Text = comboBox_Year1.Text;
            comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString(); comboBox_Month2.Text = comboBox_Month1.Text;
            comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString(); comboBox_day2.Text = comboBox_day1.Text;

            //ContexMenu
            for (int i = 0; i < dataGridView_ListCnclu.ColumnCount; i++)
                if (dataGridView_ListCnclu.Columns[i].Visible)
                {
                    ToolStripMenuItem TSI = new ToolStripMenuItem();
                    TSI.Alignment = ToolStripItemAlignment.Right;
                    TSI.CheckOnClick = true;
                    TSI.Name = dataGridView_ListCnclu.Columns[i].Name;
                    TSI.Text = dataGridView_ListCnclu.Columns[i].HeaderText;
                    TSI.Checked = true;

                    if (Global_Cls.AllSelectField_Conclusion.Count != 0)
                        try
                        {
                            if (!Global_Cls.AllSelectField_Conclusion.Contains(TSI.Name))
                            {
                                TSI.Checked = false;
                                dataGridView_ListCnclu.Columns[i].Visible = false;
                            }
                        }
                        catch { }
                    contextMenuStrip_LC.Items.Add(TSI);
                }
        }

        private void contextMenuStrip_LC_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                dataGridView_ListCnclu.Columns[e.ClickedItem.Name].Visible = (e.ClickedItem as ToolStripMenuItem).CheckState == CheckState.Unchecked;
            }
            catch { }
        }

        private void ListConclusion_UC_Layout(object sender, LayoutEventArgs e)
        {
            if (LoadStatus)
            {
                Global_Cls.AllSelectField_Conclusion.Clear();
                for (int i = 0; i < contextMenuStrip_LC.Items.Count; i++)
                    if ((contextMenuStrip_LC.Items[i] as ToolStripMenuItem).Checked)
                        Global_Cls.AllSelectField_Conclusion.Add((contextMenuStrip_LC.Items[i] as ToolStripMenuItem).Name);
            }

        }

        #endregion


        #region Search
        private void ShowConclusionList(int RowFocus)
        {
            if (SearchOrNo)
            {
                ListWhereSearch = " Where (1=1) ";
                var NEC = from prd in DCMD.Tbl_HouseConclusions
                         select new
                        {
                            prd.ConclusionID,
                            prd.Hc_No,
                            prd.Hc_Type,
                            prd.HF_FileNo,
                            LordName = prd.Hc_LName + " " + prd.Hc_LFamily,
                            CustomerName = prd.Hc_CName + " " + prd.Hc_CFamily,
                            CommissionCost = Global_Cls.DigitSeparator(prd.Hc_CommissionCost.Value.ToString()),
                            CostPrice = Global_Cls.DigitSeparator(prd.Hc_CostPrice.Value.ToString()),
                            DutyCost = Global_Cls.DigitSeparator(prd.Hc_DutyCost.Value.ToString()),
                            DateCnclu = Global_Cls.MiladiDateToShamsi(prd.Hc_Date.Value),
                            CostMtgRent = Global_Cls.DigitSeparator(prd.Hc_CostMtg.Value.ToString(), prd.Hc_CostRent.Value.ToString()),
                            prd.Interception_Code,

                            prd.Hc_RentMonth,
                            prd.Hc_CostMtg,
                            prd.Hc_CostRent,
                            prd.Hc_Date,
                            prd.Hc_CommissionCost,
                            prd.Hc_CostPrice,
                            prd.Hc_DutyCost,
                        };

                int CncluFNo1 = (short)((textBox_CncluFNo1.Text == "") ? 0 : Int32.Parse(textBox_CncluFNo1.Text));
                int CncluFNo2 = (short)((textBox_CncluFNo2.Text == "") ? 0 : Int32.Parse(textBox_CncluFNo2.Text));
                if (CncluFNo1 != 0 || CncluFNo2 != 0)
                {
                    if (radioButton_HCNo.Checked)
                    {
                        NEC = NEC.Where(i => Convert.ToInt32(i.Hc_No) >= CncluFNo1 && Convert.ToInt32(i.Hc_No) <= CncluFNo2);
                        ListWhereSearch += " And (Hc_No >= " + CncluFNo1 + ")And(Hc_No <= " + CncluFNo2 + ")";
                    }
                    else if (radioButton_FileNo.Checked)
                    {
                        NEC = NEC.Where(i => Convert.ToInt32(i.HF_FileNo) >= CncluFNo1 && Convert.ToInt32(i.HF_FileNo) <= CncluFNo2);
                        ListWhereSearch += " And (HF_FileNo >= " + CncluFNo1 + ")And(HF_FileNo <= " + CncluFNo2 + ")";
                    }
                }


                if (checkBox_date.Checked)
                {
                    NEC = NEC.Where(m => m.Hc_Date.Value >= Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text) && m.Hc_Date.Value <= Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_day2.Text));
                    ListWhereSearch += " And (Hc_Date >= '" + Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text).ToShortDateString() + "') And (Hc_Date <= '" + Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_day2.Text).ToShortDateString() + "')";
                }

                if (comboBox_Type.Text != "")
                {
                    NEC = NEC.Where(m => m.Hc_Type == comboBox_Type.Text);
                    ListWhereSearch += " And (Hc_Type = N'" + comboBox_Type.Text + "')";
                }

                if (nUpDown_RentMonth.Value != 0)
                {
                    NEC = NEC.Where(m => m.Hc_RentMonth <= nUpDown_RentMonth.Value);
                    ListWhereSearch += " And (Hc_RentMonth <= " + nUpDown_RentMonth.Value.ToString() + ")";
                }

                if (textBox_LCName.Text != "")
                {
                    if (radioButton_Lord.Checked)
                    {
                        NEC = NEC.Where(m => m.LordName.Contains(textBox_LCName.Text));
                        ListWhereSearch += " And (Hc_LName+Hc_LFamily Like N'%" + textBox_LCName.Text + "%')";
                    }
                    else if (radioButton_Customer.Checked)
                    {
                        NEC = NEC.Where(m => m.CustomerName.Contains(textBox_LCName.Text));
                        ListWhereSearch += " And (Hc_CName+Hc_CFamily Like N'%" + textBox_LCName.Text + "%')";
                    }
                }

                Int64 Cost1 = 0, Cost2 = 0;
                try { Cost1 = Convert.ToInt64(textBox_Cost1.Text.Replace(",", "")); }
                catch { }
                try { Cost2 = Convert.ToInt64(textBox_Cost2.Text.Replace(",", "")); }
                catch { }

                if ( Cost1!= 0 || Cost2 != 0)
                {
                    if (radioButton_CPrice.Checked)
                    {
                        NEC = NEC.Where(m => m.Hc_CostPrice >= Cost1 && m.Hc_CostPrice <= Cost2);
                        ListWhereSearch += " And (Hc_CostPrice >= " + Cost1.ToString() + ")And(Hc_CostPrice <= " + Cost2.ToString() + ")";
                    }
                    else if (radioButton_CMtg.Checked)
                    {
                        NEC = NEC.Where(m => m.Hc_CostMtg >= Cost1 && m.Hc_CostMtg <= Cost2);
                        ListWhereSearch += " And (Hc_CostMtg >= " + Cost1.ToString() + ")And(Hc_CostMtg <= " + Cost2.ToString() + ")";
                    }
                    else if (radioButton_CRent.Checked)
                    {
                        NEC = NEC.Where(m => m.Hc_CostRent >= Cost1 && m.Hc_CostRent <= Cost2);
                        ListWhereSearch += " And (Hc_CostRent >= " + Cost1.ToString() + ")And(Hc_CostRent <= " + Cost2.ToString() + ")";
                    }
                    else if (radioButton_CCommision.Checked)
                    {
                        NEC = NEC.Where(m => m.Hc_CommissionCost >= Cost1 && m.Hc_CommissionCost <= Cost2);
                        ListWhereSearch += " And (Hc_CommissionCost >= " + Cost1.ToString() + ")And(Hc_CommissionCost <= " + Cost2.ToString() + ")";
                    }
                    else if (radioButton_CDuty.Checked)
                    {
                        NEC = NEC.Where(m => m.Hc_DutyCost >= Cost1 && m.Hc_DutyCost <= Cost2);
                        ListWhereSearch += " And (Hc_DutyCost >= " + Cost1.ToString() + ")And(Hc_DutyCost <= " + Cost2.ToString() + ")";
                    }
                }
                
                dataGridView_ListCnclu.DataSource = NEC;
            }
            else
            {
                ListWhereSearch = "";
                var HC = from prd in DCMD.Tbl_HouseConclusions
                         select new
                         {
                             prd.ConclusionID,
                             prd.Hc_No,
                             prd.Hc_Type,
                             prd.HF_FileNo,
                             LordName = prd.Hc_LName + " " + prd.Hc_LFamily,
                             CustomerName = prd.Hc_CName + " " + prd.Hc_CFamily,
                             CommissionCost = Global_Cls.DigitSeparator(prd.Hc_CommissionCost.Value.ToString()),
                             CostPrice = Global_Cls.DigitSeparator(prd.Hc_CostPrice.Value.ToString()),
                             DutyCost = Global_Cls.DigitSeparator(prd.Hc_DutyCost.Value.ToString()),
                             DateCnclu = Global_Cls.MiladiDateToShamsi(prd.Hc_Date.Value),
                             CostMtgRent = Global_Cls.DigitSeparator(prd.Hc_CostMtg.Value.ToString(), prd.Hc_CostRent.Value.ToString()),
                             prd.Interception_Code,
                             
                             prd.Hc_RentMonth,
                             prd.Hc_CostMtg,
                             prd.Hc_CostRent,
                             prd.Hc_Date,
                             prd.Hc_CommissionCost,
                             prd.Hc_CostPrice,
                             prd.Hc_DutyCost,
                         };
                dataGridView_ListCnclu.DataSource = HC;
            }

            try
            {
                dataGridView_ListCnclu.CurrentCell = dataGridView_ListCnclu.Rows[RowFocus].Cells[dataGridView_ListCnclu.CurrentCell.ColumnIndex];
            }
            catch
            {
                try
                {
                    dataGridView_ListCnclu.CurrentCell = dataGridView_ListCnclu.Rows[0].Cells[0];
                }
                catch { }
            }

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchOrNo = true;
            ShowConclusionList(0);
            try
            {
                dataGridView_ListCnclu.CurrentCell = dataGridView_ListCnclu.Rows[dataGridView_ListCnclu.RowCount - 1].Cells[dataGridView_ListCnclu.CurrentCell.ColumnIndex];
            }
            catch
            { }

        }

        private void dataGridView_ListCnclu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                SearchOrNo = false;
                ShowConclusionList(dgRowCnt-1);
                textBox_CncluFNo1.Text = "0";
                textBox_CncluFNo2.Text = "0";
                textBox_LCName.Text = "";
                textBox_Cost1.Text = "0";
                textBox_Cost2.Text = "0";
                nUpDown_RentMonth.Value = 0;
                comboBox_Type.Text = "";

                exPanel_CLSearch.Expanded = false;
            }
        }

        #endregion


        #region Buttons Controls
        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListCnclu.RowCount != 0)
            {
                int RFocus = dataGridView_ListCnclu.CurrentRow.Index;
                NEConclusion_frm NEC = new NEConclusion_frm();
                NEC.NewOrEditConclusion = 2;
                NEC.CncluID = Convert.ToInt32(dataGridView_ListCnclu.CurrentRow.Cells["ConclusionID"].Value);
                NEC.ShowDialog();
                ShowConclusionList(RFocus);
            }
        }

        private void button_PrintList_Click(object sender, EventArgs e)
        {
            ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateConclutionTbl_Report("قراردادها", false) + ListWhereSearch,// " SELECT * FROM Tbl_HouseConclusion " + ListWhereSearch,
                "قراردادها", Global_Cls.ReportDesignAddress[12]);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_ListCnclu.RowCount != 0)
            {
                int SelCount = dataGridView_ListCnclu.SelectedRows.Count;
                if (SelCount == 1)
                {
                    int RFocus = dataGridView_ListCnclu.CurrentRow.Index;
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این قرارداد حذف شود؟")) return;
                    int CncluID = Convert.ToInt32(dataGridView_ListCnclu.CurrentRow.Cells["ConclusionID"].Value);
                    Tbl_HouseConclusion thc = DCMD.Tbl_HouseConclusions.First(th => th.ConclusionID.Equals(CncluID));
                    DCMD.Tbl_HouseConclusions.DeleteOnSubmit(thc);
                    DCMD.SubmitChanges();
                    ShowConclusionList(RFocus - 1);
                }
                else 
                {
                    if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این " + SelCount.ToString() + " قرارداد حذف شوند؟ ")) return;
                    while (SelCount > 0)
                    {
                        SelCount--;
                        Tbl_HouseConclusion thc = DCMD.Tbl_HouseConclusions.First(th => th.ConclusionID.Equals(dataGridView_ListCnclu.SelectedRows[SelCount].Cells["ConclusionID"].Value));
                        DCMD.Tbl_HouseConclusions.DeleteOnSubmit(thc);
                        DCMD.SubmitChanges();
                    }
                    ShowConclusionList(0);
                }
            }
        }

        #endregion


        #region Other
        private void panel_CDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }

        private void panel_CDate2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month2.Text) > 6 && Convert.ToInt16(comboBox_day2.Text) == 31) comboBox_day2.Text = "30";
            if (Convert.ToInt16(comboBox_Month2.Text) == 12 && (Convert.ToInt16(comboBox_day2.Text) == 31 || Convert.ToInt16(comboBox_day2.Text) == 30)) comboBox_day2.Text = "29";
        }

        TextBox tx = new TextBox();
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

        private void textBox_CncluFNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back)
            { e.KeyChar = '\0'; return; }
        }
        #endregion

    }
}

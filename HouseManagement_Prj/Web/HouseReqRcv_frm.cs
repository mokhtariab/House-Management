using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using HouseManagement_Prj.Properties;
using System.Threading;


namespace HouseManagement_Prj
{
    public partial class HouseReqRcv_frm : Form
    {
        public HouseReqRcv_frm()
        {
            InitializeComponent();
        }

        public int InterfaceMode = 1;//1 FHouseRcv; 2 FReqRcv 
        private void timer_Sleep_Tick(object sender, EventArgs e)
        {
            if (label_3Dot.Text == "...") label_3Dot.Text = "";
            else if (label_3Dot.Text == "") label_3Dot.Text = ".";
            else if (label_3Dot.Text == ".") label_3Dot.Text = "..";
            else if (label_3Dot.Text == "..") label_3Dot.Text = "...";

            label_XazY.Text = Function_Cls.WebHouseReqFewRowEffect + "  از  " + Function_Cls.WebHouseReqRowCount;
        }

        private void HouseRcv_frm_Shown(object sender, EventArgs e)
        {
            textBox_AllFewConnect.Text = Settings.Default.AllFewConnectRCV.ToString();
            textBox_FewConnect.Text = Settings.Default.FewConnectRCV.ToString();
            textBox_LastDate.Text = Global_Cls.MiladiDateToShamsi(Settings.Default.LastDateConnectRCV);

            if (InterfaceMode == 2) Text = "دریافت فایل متقاضی";

            SetDateToModules();
            try
            {
                PartFillWebHouse(Global_Cls.SetWebHousePart[0], Global_Cls.SetWebHousePart[1], Global_Cls.SetWebHousePart[2],
                    Global_Cls.SetWebHousePart[3], Global_Cls.SetWebHousePart[4], Global_Cls.SetWebHousePart[5],
                    Global_Cls.SetWebHousePart[6], Global_Cls.SetWebHousePart[7]);
            }
            catch { }

        }

        private void PartFillWebHouse(string PartID1, string PartID2, string PartID3, string PartID4,
                            string PartID5, string PartID6, string PartID7, string PartID8)
        {
            string PrtReq = "0";
            if (PartID1 != "0") PrtReq = PartID1;
            if (PartID2 != "0") PrtReq = PartID2;
            if (PartID3 != "0") PrtReq = PartID3;
            if (PartID4 != "0") PrtReq = PartID4;
            if (PartID5 != "0") PrtReq = PartID5;
            if (PartID6 != "0") PrtReq = PartID6;
            if (PartID7 != "0") PrtReq = PartID7;
            if (PartID8 != "0") PrtReq = PartID8;

            if (PrtReq != "0")
            {
                comboBox_Country_Enter(this, null);
                comboBox_HCountry.SelectedValue = Convert.ToInt32(PrtReq.Substring(0, 1));
                comboBox_Country_Leave(this, null);

                comboBox_State_Enter(this, null);
                comboBox_HState.SelectedValue = Convert.ToInt32(PrtReq.Substring(0, 3));
                comboBox_State_Leave(this, null);

                comboBox_City_Enter(this, null);
                comboBox_HCity.SelectedValue = Convert.ToInt32(PrtReq.Substring(0, 5));
                comboBox_City_Leave(this, null);

                comboBox_Part1_Enter(this, null);
                comboBox_HPart1.SelectedValue = Convert.ToInt32(PartID1);
                comboBox_Part2_Enter(this, null);
                comboBox_HPart2.SelectedValue = Convert.ToInt32(PartID2);
                comboBox_Part3_Enter(this, null);
                comboBox_HPart3.SelectedValue = Convert.ToInt32(PartID3);
                comboBox_Part4_Enter(this, null);
                comboBox_HPart4.SelectedValue = Convert.ToInt32(PartID4);
                comboBox_Part5_Enter(this, null);
                comboBox_HPart5.SelectedValue = Convert.ToInt32(PartID5);
                comboBox_Part6_Enter(this, null);
                comboBox_HPart6.SelectedValue = Convert.ToInt32(PartID6);
                comboBox_Part7_Enter(this, null);
                comboBox_HPart7.SelectedValue = Convert.ToInt32(PartID7);
                comboBox_Part8_Enter(this, null);
                comboBox_HPart8.SelectedValue = Convert.ToInt32(PartID8);
            }
        }


        #region Set Date Module

        private void SetDateToModules()
        {
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBox_HYear1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString(); comboBox_HYear2.Text = comboBox_HYear1.Text;
            comboBox_HMonth1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString(); comboBox_HMonth2.Text = comboBox_HMonth1.Text;
            comboBox_Hday1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString(); comboBox_Hday2.Text = comboBox_Hday1.Text;
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

        #endregion

        #region  Select Part
        private DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        private int CntID, StID, CyID;
        private void comboBox_Country_Enter(object sender, EventArgs e)
        {
            if (comboBox_HCountry.DataSource == null)
            {
                var hh = from prd in DCDC.TBL_Countries
                         select prd;
                comboBox_HCountry.DataSource = hh;
            }
        }

        private void comboBox_Country_Leave(object sender, EventArgs e)
        {
            CntID = Convert.ToInt32(comboBox_HCountry.SelectedValue);
        }

        private void comboBox_State_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HState.Tag.Equals(CntID))
            {
                comboBox_HState.Tag = CntID;
                var hh = from prd in DCDC.TBL_States
                         where prd.CountryID == CntID
                         select prd;
                comboBox_HState.DataSource = hh;
            }
        }

        private void comboBox_State_Leave(object sender, EventArgs e)
        {
            StID = Convert.ToInt32(comboBox_HState.SelectedValue);
        }

        private void comboBox_City_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HCity.Tag.Equals(StID))
            {
                comboBox_HCity.Tag = StID;
                var hh = from prd in DCDC.TBL_Cities
                         where prd.StateID == StID
                         select prd;
                comboBox_HCity.DataSource = hh;
            }
        }

        private void comboBox_City_Leave(object sender, EventArgs e)
        {
            CyID = Convert.ToInt32(comboBox_HCity.SelectedValue);
        }

        private void comboBox_Part1_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart1.Tag.Equals(CyID))
            {
                comboBox_HPart1.Tag = CyID;
                var h1 = from prd in DCDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart1.DataSource = h1;
            }
        }

        private void comboBox_Part2_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart2.Tag.Equals(CyID))
            {
                comboBox_HPart2.Tag = CyID;
                var h2 = from prd in DCDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart2.DataSource = h2;
            }
        }

        private void comboBox_Part3_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart3.Tag.Equals(CyID))
            {
                comboBox_HPart3.Tag = CyID;
                var h3 = from prd in DCDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart3.DataSource = h3;
            }
        }

        private void comboBox_Part4_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart4.Tag.Equals(CyID))
            {
                comboBox_HPart4.Tag = CyID;
                var h4 = from prd in DCDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart4.DataSource = h4;
            }
        }

        private void comboBox_Part5_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart5.Tag.Equals(CyID))
            {
                comboBox_HPart5.Tag = CyID;
                var h5 = from prd in DCDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart5.DataSource = h5;
            }
        }

        private void comboBox_Part6_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart6.Tag.Equals(CyID))
            {
                comboBox_HPart6.Tag = CyID;
                var h6 = from prd in DCDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart6.DataSource = h6;
            }
        }

        private void comboBox_Part7_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart7.Tag.Equals(CyID))
            {
                comboBox_HPart7.Tag = CyID;
                var h7 = from prd in DCDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart7.DataSource = h7;
            }
        }

        private void comboBox_Part8_Enter(object sender, EventArgs e)
        {
            if (!comboBox_HPart8.Tag.Equals(CyID))
            {
                comboBox_HPart8.Tag = CyID;
                var h8 = from prd in DCDC.TBL_Parts
                         where prd.CityID == CyID
                         orderby prd.PartName_Fa
                         select prd;
                comboBox_HPart8.DataSource = h8;
            }
        }

        #endregion



        private void button_OK_Click(object sender, EventArgs e)
        {
            panel_HDate1_Leave(this, null);
            panel_HDate2_Leave(this, null);

            Function_Cls.CloseFormDownLoad = false;
            if (Global_Cls.SetConnection())
            {
                SetTimer(true);
                label_XazY.Visible = true;
                label_Daryaftha.Visible = true;
                Function_Cls.WebHouseReqFewRowEffect = 0;
                Function_Cls.WebHouseReqRowCount = 0;
                if (Function_Cls.TestAccount_OKExpr(false))
                    if (SetTmpTableByFilterFromSourceDB())
                    {
                        Update_AgencyUsers();
                        if (InterfaceMode == 1)
                        {
                            ListHouseRcv_UC Uc = new ListHouseRcv_UC();
                            Global_Cls.MainForm.AddTabToTabControl("ListHouseRcv", " لیست دریافت املاک ", Uc);
                        }
                        else
                        {
                            ListReqRcv_UC Uc = new ListReqRcv_UC();
                            Global_Cls.MainForm.AddTabToTabControl("ListReqRcv_UC", " لیست دریافت متقاضیان ", Uc);
                        }
                        Close();
                    }
            }
        }

        private void SetTimer(bool TF)
        {
            timer_Sleep.Enabled = TF;
            label_3Dot .Visible = TF;
            label_Sleep.Visible = TF;
        }

        private bool SetTmpTableByFilterFromSourceDB()
        {
            if (Global_Cls.Lock_Data == "Test")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در حالت تست امکان اتصال وجود ندارد!");
                return false;
            }

            Function_Cls.UpdatePart(Function_Cls.Agency_CityIDRCV.ToString());

            DateTime DateYMD1 = Global_Cls.ShamsiDateToMiladi(comboBox_HYear1.Text, comboBox_HMonth1.Text, comboBox_Hday1.Text);
            DateTime DateYMD2 = Global_Cls.ShamsiDateToMiladi(comboBox_HYear2.Text, comboBox_HMonth2.Text, comboBox_Hday2.Text);

            //WorkerThreadDownLoadFile wd = new WorkerThreadDownLoadFile();
            //Int16 a=-1;
            //while (a==-1)
           // {
            //    Application.DoEvents();
            //    a=Convert.ToInt16( wd.Main(DateYMD1, DateYMD2, InterfaceMode) );
           // }
            //return Convert.ToBoolean(a);
            
            
            
            return Function_Cls.DownLoadFile(DateYMD1, DateYMD2, InterfaceMode);
        }


        private bool Update_AgencyUsers()
        {
            string StrConn = Function_Cls.ConnStrWeb;
            SqlConnection SqConn = new SqlConnection(StrConn);
            SqlCommand SqCmd = new SqlCommand();
            SqCmd.Connection = SqConn;

            try
            {
                SqConn.Open();
                SqCmd.CommandType = CommandType.StoredProcedure;
                SqCmd.CommandText = " dbo.Update_AgencyUsers N'" + Function_Cls.AgencyCodeStr + "', N'" + Function_Cls.AgencyPassStr + "', N'" + Global_Cls.Lock_Data + "_SN' , " + Function_Cls.WebHouseReqFewRowEffect;
                SqlDataAdapter SDA = new SqlDataAdapter(SqCmd.CommandText, SqConn);
                SDA.UpdateCommand = new SqlCommand(SqCmd.CommandText, SqConn);
                SDA.UpdateCommand.ExecuteReader();
                SqConn.Close();
            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "اطلاعات آژانس بروز رسانی نشد",ex.ToString());
                SqConn.Close();
                return false;
            }
            return true;
        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Function_Cls.CloseFormDownLoad = true;
            Close();
        }


    }
}

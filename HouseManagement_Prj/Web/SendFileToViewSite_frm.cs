using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;
using System.Data.SqlClient;

namespace HouseManagement_Prj
{
    public partial class SendFileToViewSite_frm : Form
    {
        public SendFileToViewSite_frm()
        {
            InitializeComponent();
        }

        public string HouseID, FileNo, ModifyDate, TypeHouse, HouseFor, PartName, CityName;
        private void SendFileToViewSite_frm_Load(object sender, EventArgs e)
        {
            SetDateToModules();

            Label_fileNO.Text = FileNo;
            Label_ModifyDate.Text = ModifyDate;
            label_HouseFor.Text = HouseFor;
            label_HouseType.Text = TypeHouse;
            label_Part.Text = PartName;

            label_AgName.Text = Global_Cls.Agancy_Name;
            label_AgAdminName.Text = Global_Cls.AgancyAdmin_Name;
            label_AgTel.Text = Global_Cls.Agancy_Tel.Replace("\r\n", " - ");
            label_AgMobile.Text = Global_Cls.Agancy_Mobile.Replace("\r\n", " - ");
            label_AgAddress.Text = Global_Cls.Agancy_Address.Replace("\r\n", " - ");
            label_AgEmail.Text = Global_Cls.Agancy_Email;
        }

        #region Set Date Module

        private void SetDateToModules()
        {
            string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today.AddDays(30));
            comboBox_HYear1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString(); 
            comboBox_HMonth1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString(); 
            comboBox_Hday1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString(); 
        }

        private void panel_ExpDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_HMonth1.Text) > 6 && Convert.ToInt16(comboBox_Hday1.Text) == 31) comboBox_Hday1.Text = "30";
            if (Convert.ToInt16(comboBox_HMonth1.Text) == 12 && (Convert.ToInt16(comboBox_Hday1.Text) == 31 || Convert.ToInt16(comboBox_Hday1.Text) == 30)) comboBox_Hday1.Text = "29";
        }

        #endregion

        private void SendFileToViewSite_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Global_Cls.SetConnection())
            {
                SetTimer(true);
                if (Function_Cls.TestAccount_OKExpr(true))
                    if (InsertFileToViewHouseFileToSourceDB())
                        Close();
            }
        }


        private bool InsertFileToViewHouseFileToSourceDB()
        {
            if (Global_Cls.Lock_Data == "Test")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در حالت تست امکان اتصال وجود ندارد!");
                return false;
            }

            string StrConnWeb = Function_Cls.ConnStrWeb;

            try
            {
                string StrConn = Global_Cls.ConnectionStr;

                SqlConnection SqConn = new SqlConnection(StrConn);

                SqlCommand SqCmd = new SqlCommand();
                SqCmd.Connection = SqConn;
                SqConn.Open();
                /*SqCmd.CommandType = CommandType.StoredProcedure;
                SqCmd.CommandText = " dbo.InsertToTBLViewHouseFileToWeb_Sp '"
                    + StrConnWeb + "', "
                    + HouseID + ", N'"
                    + label_AgName.Text + "', N'"
                    + label_AgAdminName.Text + "', N'"
                    + label_AgAddress.Text + "', N'"
                    + label_AgTel.Text + "', N'"
                    + label_AgMobile.Text + "', N'"
                    + label_AgEmail.Text + "', N'"

                    + CityName + "', N'"
                    + PartName + "', '"
                    + Global_Cls.ShamsiDateToMiladi(comboBox_HYear1.Text, comboBox_HMonth1.Text, comboBox_Hday1.Text).ToShortDateString() + "', N'"
                    + textBox_AgDescription.Text + "', "
                    + Global_Cls.Money_Change/10 + " ";*/

                SqCmd.CommandText = StoreProceText.InsertToTBLViewHouseFileToWeb_Sp(
                    StrConnWeb,    HouseID.ToString(),    label_AgName.Text,
                    label_AgAdminName.Text,    label_AgAddress.Text,    label_AgTel.Text,
                    label_AgMobile.Text,    label_AgEmail.Text,

                    CityName,    PartName,
                    Global_Cls.ShamsiDateToMiladi(comboBox_HYear1.Text, comboBox_HMonth1.Text, comboBox_Hday1.Text).ToShortDateString(),
                    textBox_AgDescription.Text,    (Global_Cls.Money_Change / 10).ToString());


                SqlDataAdapter SDA = new SqlDataAdapter(SqCmd.CommandText, SqConn);
                SDA.UpdateCommand = new SqlCommand(SqCmd.CommandText, SqConn);
                try
                {
                    SDA.UpdateCommand.ExecuteReader();
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "فایل ارسال شد");
                    SqConn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
                SqConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

            return false;
        }




        private void timer_Sleep_Tick(object sender, EventArgs e)
        {
            if (label_3Dot.Text == "...") label_3Dot.Text = "";
            else if (label_3Dot.Text == "") label_3Dot.Text = ".";
            else if (label_3Dot.Text == ".") label_3Dot.Text = "..";
            else if (label_3Dot.Text == "..") label_3Dot.Text = "...";
        }

        private void SetTimer(bool TF)
        {
            timer_Sleep.Enabled = TF;
            label_3Dot.Visible = TF;
            label_Sleep.Visible = TF;
        }


    }
}

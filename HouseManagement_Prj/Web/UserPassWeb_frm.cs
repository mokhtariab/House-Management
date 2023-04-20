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
using System.Threading;

namespace HouseManagement_Prj
{
    public partial class UserPassWeb_frm : Form
    {
        public UserPassWeb_frm()
        {
            InitializeComponent();
        }

        public bool AccountStatus = false;
        public bool SendOrReciveFile = false;

        private void UserPassWeb_frm_Load(object sender, EventArgs e)
        {
            textBox_AgencyCode.Text = Settings.Default.AgencyCode;
            textBox_AgencyPass.Text = Settings.Default.AgencyPass;
            label_LastChargeDate.Text = Settings.Default.LastChargeDate;
            label_ExpChargeDate.Text = Settings.Default.ExpChargeDate;
            checkBox_SaveCodePass.Checked = Settings.Default.Chbox_SaveCodePass;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_AgencyCode.Text == "")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "کد آژانس را وارد نمایید!");
                textBox_AgencyCode.Focus();
                return;
            }
            if (textBox_AgencyPass.Text == "")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "رمز عبور را وارد نمایید!");
                textBox_AgencyPass.Focus();
                return;
            }

            if (SetUserAccountFromSourceDB())
            {
                AccountStatus = true;
                Function_Cls.AgencyCodeStr = textBox_AgencyCode.Text;
                Function_Cls.AgencyPassStr = textBox_AgencyPass.Text;

                //Set Setting
                Settings.Default.Chbox_SaveCodePass = checkBox_SaveCodePass.Checked;
                if (checkBox_SaveCodePass.Checked)
                {
                    Settings.Default.AgencyCode = textBox_AgencyCode.Text;
                    Settings.Default.AgencyPass = textBox_AgencyPass.Text;
                }
                else
                {
                    Settings.Default.AgencyCode = "";
                    Settings.Default.AgencyPass = "";
                }


                Settings.Default.LastChargeDate = label_LastChargeDate.Text;
                Settings.Default.ExpChargeDate = label_ExpChargeDate.Text;
                Settings.Default.Save();
                Close();
            }

        }



        public bool SetUserAccountFromSourceDB()
        {
            if (Global_Cls.Lock_Data == "Test")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در حالت تست امکان اتصال وجود ندارد!");
                return false;
            }


            string StrConWeb = Function_Cls.ConnStrWeb;

            SqlConnection SqConWeb = new SqlConnection(StrConWeb);
            SqlCommand SqCmd = new SqlCommand();
            SqCmd.Connection = SqConWeb;

            try
            {
                SqConWeb.Open();
                SqCmd.CommandText = " select ChargeDateAcntRet, ExpiredDateAcntRet, FileReqRcvRegionRet, Agency_CityIDRet, DefStrRet, FewConnectRet, LastDateConnectRet, AllFewConnectRet, Level_UseRet "
                    + "from dbo.TestUserAccount_fn(N'" + textBox_AgencyCode.Text + "', N'" + textBox_AgencyPass.Text + "', N'" + Global_Cls.Lock_Data + "_SN')";

                SqlDataReader SDR = SqCmd.ExecuteReader();
                SDR.Read();

                if (Convert.ToString(SDR[4]) == "UserOrPPass")
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "کد آژانس و یا رمز عبور اشتباه می باشد!");
                    textBox_AgencyCode.Focus();
                    textBox_AgencyPass.Text = "";

                    SqConWeb.Close();
                    return false;
                }
                else if (Convert.ToString(SDR[4]) == "SoftSerialNo")
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "قفل متصل نمی باشد و یا اطلاعات قفل اشتباه می باشد! لطفا با شرکت تماس بگیرید");

                    SqConWeb.Close();
                    return false;
                }
                else if (Convert.ToString(SDR[4]) == "NonActive")
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "کاربری شما غیر فعال است! لطفا با شرکت تماس بگیرید");
                    SqConWeb.Close();
                    return false;
                }


                label_LastChargeDate.Text = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(SDR[0]));
                label_ExpChargeDate.Text = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(SDR[1]));

                if (SendOrReciveFile) return true;

                if (Convert.ToString(SDR[4]) == "ExpDate")
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "تاریخ شارژ به پایان رسیده است.");
                    SqConWeb.Close();
                    return false;
                }
                else if (Convert.ToString(SDR[4]) == "FewConnectEXP")
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "شما از حداکثر اتصال به بانک در امروز استفاده کرده اید و دیگر مجاز به اتصال نمی باشید!");
                    SqConWeb.Close();
                    return false;
                }

                Function_Cls.LastChargeDateRCV = Convert.ToDateTime(SDR[0]);
                Function_Cls.FileReqRcvRegionRCV = Convert.ToString(SDR[2]);
                Function_Cls.Agency_CityIDRCV = Convert.ToInt32(SDR[3]);

                Settings.Default.FewConnectRCV = Convert.ToInt32(SDR[5]) + 1;
                Settings.Default.LastDateConnectRCV = Convert.ToDateTime(SDR[6]);
                if (Convert.ToInt32(SDR[5]) == 0) Settings.Default.LastDateConnectRCV = Settings.Default.LastDateConnectRCV.AddDays(1);
                Settings.Default.AllFewConnectRCV = Convert.ToInt32(SDR[7]) + 1;
                Function_Cls.Level_Use = Convert.ToInt16(SDR[8]);

                SqConWeb.Close();

            }
            catch (Exception ex)
            {
                SqConWeb.Close();
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در اتصال به سرور", ex.ToString());
                return false;
            }

            return true;
        }

        private void UserPassWeb_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }




    }

}



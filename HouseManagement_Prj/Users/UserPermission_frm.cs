﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;

namespace HouseManagement_Prj
{
    public partial class UserPermission_frm : Form
    {
        public UserPermission_frm()
        {
            InitializeComponent();
        }

        public int UserIDIndex;
        public string PerUser;
        private bool CloseOK = false;


        public void UserPermission_LoadDataAndForm(int EnterId)
        {
            UserIDIndex = EnterId;

            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            //Check user's admin
            TBL_User thf = DCDC.TBL_Users.First(th => th.UserCode.Equals(UserIDIndex));
            if (thf.UserPermission == "admin")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "امکان تغییر در سطح دسترسی کاربر اصلی وجود ندارد!"); 
                return;
            }

            for (int j = 0; j < tabControl_Permission.Controls.Count; j++)
                for (int i = 0; i < tabControl_Permission.Controls[j].Controls.Count; i++)
                    if (tabControl_Permission.Controls[j].Controls[i].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabControl_Permission.Controls[j].Controls[i];
                        if (thf.UserPermission == null || !(thf.UserPermission.Contains(chb.Name + ",")))
                            chb.Checked = true;

                    }


            for (int i = 0; i < Global_Cls.HouseFor.Count; i++)
            {
                DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
                Ch.Name = i.ToString();
                Ch.Text = Global_Cls.HouseFor[i];
                if (thf.UserPrmHouseFor != null && thf.UserPrmHouseFor.Contains(Ch.Text + ";"))
                    Ch.Checked = true;

                itemPanel_HouseFor.Items.Add(Ch, i);
                itemPanel_HouseFor.Refresh();
            }

            ShowDialog();
        }

        private void buttonItem_AllSel_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < tabControl_Permission.Controls.Count; j++)
                for (int i = 0; i < tabControl_Permission.Controls[j].Controls.Count; i++)
                    if (tabControl_Permission.Controls[j].Controls[i].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabControl_Permission.Controls[j].Controls[i];
                        chb.Checked = true;
                    }
        }

        private void buttonItem_AllDeSel_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < tabControl_Permission.Controls.Count; j++)
                for (int i = 0; i < tabControl_Permission.Controls[j].Controls.Count; i++)
                    if (tabControl_Permission.Controls[j].Controls[i].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabControl_Permission.Controls[j].Controls[i];
                        chb.Checked = false;
                    }
        }

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {

            string StrUnCHK = "";
            for (int j = 0; j < tabControl_Permission.Controls.Count; j++)
                for (int i = 0; i < tabControl_Permission.Controls[j].Controls.Count; i++)
                    if (tabControl_Permission.Controls[j].Controls[i].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chbx = (DevComponents.DotNetBar.Controls.CheckBoxX)tabControl_Permission.Controls[j].Controls[i];
                        if (!chbx.Checked)
                            StrUnCHK += chbx.Name + ",";
                    }

            //new
            string StrCHKHouseFor = "";
            for (int i = 0; i < itemPanel_HouseFor.Items.Count; i++)
            {
                if ((itemPanel_HouseFor.Items[i] as DevComponents.DotNetBar.CheckBoxItem).Checked)
                    StrCHKHouseFor += itemPanel_HouseFor.Items[i].Text + ";";
            }
            //new

            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            TBL_User thf = DCDC.TBL_Users.First(th => th.UserCode.Equals(UserIDIndex));
            thf.UserPermission = StrUnCHK;
            thf.UserPrmHouseFor = StrCHKHouseFor;//new
            DCDC.SubmitChanges();

            CloseOK = true;
            this.Close();
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPermission_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar( Keys.Escape )) this.Close();
        }

        private void UserPermission_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }


    }
}

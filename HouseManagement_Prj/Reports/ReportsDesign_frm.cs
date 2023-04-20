using System;
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
    public partial class ReportsDesign_frm : Form
    {
        public ReportsDesign_frm()
        {
            InitializeComponent();
        }

        #region Load & UI

        DevComponents.DotNetBar.ExpandablePanel exPanel = null;
        private void expandablePanel1_ExpandedChanging(object sender, DevComponents.DotNetBar.ExpandedChangeEventArgs e)
        {
            exPanel = (DevComponents.DotNetBar.ExpandablePanel)sender;
            if (!exPanel.Expanded)
            {
                foreach (System.Windows.Forms.Panel c in this.Controls["groupPanel_Design"].Controls)
                {
                    if ((c.GetType().FullName == "DevComponents.DotNetBar.ExpandablePanel") && (c != exPanel))
                    {
                        DevComponents.DotNetBar.ExpandablePanel exPnl = (DevComponents.DotNetBar.ExpandablePanel)c;
                        exPnl.Expanded = false;
                    }
                }
            }
        }

        private void ReportsDesign_frm_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
                {
                    comboBox_Case1.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case11.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case12.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case2.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case21.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case22.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case3.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case31.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case32.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case4.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case41.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case42.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case5.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case51.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case52.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case6.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case61.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                    comboBox_Case62.Items.Add(Global_Cls.TypeHouseAllCases[i]);
                }


                string Str1 = Global_Cls.ReportDesignHouseType[0];
                comboBox_Case1.Text = Str1.Substring(0, Str1.IndexOf(","));
                comboBox_Case11.Text = Str1.Substring(Str1.IndexOf(",") + 1, Str1.LastIndexOf(",") - Str1.IndexOf(",") - 1);
                comboBox_Case12.Text = Str1.Substring(Str1.LastIndexOf(",") + 1, Str1.Length - Str1.LastIndexOf(",") - 1);


                string Str2 = Global_Cls.ReportDesignHouseType[1];
                comboBox_Case2.Text = Str2.Substring(0, Str2.IndexOf(","));
                comboBox_Case21.Text = Str2.Substring(Str2.IndexOf(",") + 1, Str2.LastIndexOf(",") - Str2.IndexOf(",") - 1);
                comboBox_Case22.Text = Str2.Substring(Str2.LastIndexOf(",") + 1, Str2.Length - Str2.LastIndexOf(",") - 1);

                string Str3 = Global_Cls.ReportDesignHouseType[2];
                comboBox_Case3.Text = Str3.Substring(0, Str3.IndexOf(","));
                comboBox_Case31.Text = Str3.Substring(Str3.IndexOf(",") + 1, Str3.LastIndexOf(",") - Str3.IndexOf(",") - 1);
                comboBox_Case32.Text = Str3.Substring(Str3.LastIndexOf(",") + 1, Str3.Length - Str3.LastIndexOf(",") - 1);

                string Str4 = Global_Cls.ReportDesignHouseType[3];
                comboBox_Case4.Text = Str4.Substring(0, Str4.IndexOf(","));
                comboBox_Case41.Text = Str4.Substring(Str4.IndexOf(",") + 1, Str4.LastIndexOf(",") - Str4.IndexOf(",") - 1);
                comboBox_Case42.Text = Str4.Substring(Str4.LastIndexOf(",") + 1, Str4.Length - Str4.LastIndexOf(",") - 1);

                string Str5 = Global_Cls.ReportDesignHouseType[4];
                comboBox_Case5.Text = Str5.Substring(0, Str5.IndexOf(","));
                comboBox_Case51.Text = Str5.Substring(Str5.IndexOf(",") + 1, Str5.LastIndexOf(",") - Str5.IndexOf(",") - 1);
                comboBox_Case52.Text = Str5.Substring(Str5.LastIndexOf(",") + 1, Str5.Length - Str5.LastIndexOf(",") - 1);

                string Str6 = Global_Cls.ReportDesignHouseType[5];
                comboBox_Case6.Text = Str6.Substring(0, Str6.IndexOf(","));
                comboBox_Case61.Text = Str6.Substring(Str6.IndexOf(",") + 1, Str6.LastIndexOf(",") - Str6.IndexOf(",") - 1);
                comboBox_Case62.Text = Str6.Substring(Str6.LastIndexOf(",") + 1, Str6.Length - Str6.LastIndexOf(",") - 1);

            }
            catch { }

            try
            {
                label_Main.Text = Global_Cls.ReportDesignAddress[0];
                label_Case1.Text = Global_Cls.ReportDesignAddress[1];
                label_Case2.Text = Global_Cls.ReportDesignAddress[2];
                label_Case3.Text = Global_Cls.ReportDesignAddress[3];
                label_Case4.Text = Global_Cls.ReportDesignAddress[4];
                label_Case5.Text = Global_Cls.ReportDesignAddress[5];
                label_Case6.Text = Global_Cls.ReportDesignAddress[6];

                label_ActiveHouse.Text = Global_Cls.ReportDesignAddress[7];
                label_NonActiveHouse.Text = Global_Cls.ReportDesignAddress[8];
                label_MemHouse.Text = Global_Cls.ReportDesignAddress[9];
                label_DelHouse.Text = Global_Cls.ReportDesignAddress[10];

                label_Customer.Text = Global_Cls.ReportDesignAddress[11];
                label_CnculList.Text = Global_Cls.ReportDesignAddress[12];
                label_UserList.Text = Global_Cls.ReportDesignAddress[13];
                label_TelNoteBook.Text = Global_Cls.ReportDesignAddress[14];
                label_Advertisment.Text = Global_Cls.ReportDesignAddress[15];

            }
            catch { }
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReportsDesign_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global_Cls.ReportDesignAddress.Clear();
            Global_Cls.ReportDesignAddress.Insert(0, label_Main.Text);
            Global_Cls.ReportDesignAddress.Insert(1, label_Case1.Text);
            Global_Cls.ReportDesignAddress.Insert(2, label_Case2.Text);
            Global_Cls.ReportDesignAddress.Insert(3, label_Case3.Text);
            Global_Cls.ReportDesignAddress.Insert(4, label_Case4.Text);
            Global_Cls.ReportDesignAddress.Insert(5, label_Case5.Text);
            Global_Cls.ReportDesignAddress.Insert(6, label_Case6.Text);

            Global_Cls.ReportDesignAddress.Insert(7, label_ActiveHouse.Text);
            Global_Cls.ReportDesignAddress.Insert(8, label_NonActiveHouse.Text);
            Global_Cls.ReportDesignAddress.Insert(9, label_MemHouse.Text);
            Global_Cls.ReportDesignAddress.Insert(10, label_DelHouse.Text);

            Global_Cls.ReportDesignAddress.Insert(11, label_Customer.Text);
            Global_Cls.ReportDesignAddress.Insert(12, label_CnculList.Text);
            Global_Cls.ReportDesignAddress.Insert(13, label_UserList.Text);
            Global_Cls.ReportDesignAddress.Insert(14, label_TelNoteBook.Text);
            Global_Cls.ReportDesignAddress.Insert(15, label_Advertisment.Text);


            Global_Cls.ReportDesignHouseType.Clear();
            Global_Cls.ReportDesignHouseType.Insert(0, comboBox_Case1.Text + "," + comboBox_Case11.Text + "," + comboBox_Case12.Text);
            Global_Cls.ReportDesignHouseType.Insert(1, comboBox_Case2.Text + "," + comboBox_Case21.Text + "," + comboBox_Case22.Text);
            Global_Cls.ReportDesignHouseType.Insert(2, comboBox_Case3.Text + "," + comboBox_Case31.Text + "," + comboBox_Case32.Text);
            Global_Cls.ReportDesignHouseType.Insert(3, comboBox_Case4.Text + "," + comboBox_Case41.Text + "," + comboBox_Case42.Text);
            Global_Cls.ReportDesignHouseType.Insert(4, comboBox_Case5.Text + "," + comboBox_Case51.Text + "," + comboBox_Case52.Text);
            Global_Cls.ReportDesignHouseType.Insert(5, comboBox_Case6.Text + "," + comboBox_Case61.Text + "," + comboBox_Case62.Text);

            Function_Cls.WriteToXmlFiles();
        }

        private void ReportsDesign_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) Close();
        }

        #endregion


        #region All Button Click

        private void button_Main_Click(object sender, EventArgs e)
        {
            label_Main.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", true),
                "ملک", label_Main.Text);
            label_Main.Text = label_Main.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }


        private void button_Case1_Click(object sender, EventArgs e)
        {
            label_Case1.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", true),//" SELECT * FROM TBL_HouseFile ",
                "ملک", label_Case1.Text);
            label_Case1.Text = label_Case1.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_Case2_Click(object sender, EventArgs e)
        {
            label_Case2.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", true),//" SELECT * FROM TBL_HouseFile ",
                "ملک", label_Case2.Text);
            label_Case2.Text = label_Case2.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_Case3_Click(object sender, EventArgs e)
        {
            label_Case3.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", true),//" SELECT * FROM TBL_HouseFile ",
                "ملک", label_Case3.Text);
            label_Case3.Text = label_Case3.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_Case4_Click(object sender, EventArgs e)
        {
            label_Case4.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", true),//" SELECT * FROM TBL_HouseFile ",
                "ملک", label_Case4.Text);
            label_Case4.Text = label_Case4.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_Case5_Click(object sender, EventArgs e)
        {
            label_Case5.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", true),//" SELECT * FROM TBL_HouseFile ",
                "ملک", label_Case5.Text);
            label_Case5.Text = label_Case5.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_Case6_Click(object sender, EventArgs e)
        {
            label_Case6.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", true),//" SELECT * FROM TBL_HouseFile ",
                "ملک", label_Case6.Text);
            label_Case6.Text = label_Case6.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }


        private void button_ActiveHouse_Click(object sender, EventArgs e)
        {
            label_ActiveHouse.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "فعال", true) + " Where FileStatus = 0 ",//" SELECT * FROM TBL_HouseFile where FileStatus = 0 ",
                "فعال", label_ActiveHouse.Text);
            label_ActiveHouse.Text = label_ActiveHouse.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_NonActiveHouse_Click(object sender, EventArgs e)
        {
            label_NonActiveHouse.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "بایگانی", true) + " Where FileStatus = 1 ",//" SELECT * FROM TBL_SecondHouseFile where FileStatus = 1 ",
                "بایگانی", label_NonActiveHouse.Text);
            label_NonActiveHouse.Text = label_NonActiveHouse.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_MemHouse_Click(object sender, EventArgs e)
        {
            label_MemHouse.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "قراردادشده", true) + " Where FileStatus = 2 ",//" SELECT * FROM TBL_SecondHouseFile where FileStatus = 2 ",
                "قراردادشده", label_MemHouse.Text);
            label_MemHouse.Text = label_MemHouse.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_DelHouse_Click(object sender, EventArgs e)
        {
            label_DelHouse.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateHouseFile_Report("TBL_SecondHouseFile", "حذفی", true) + " Where FileStatus = 3 ",//" SELECT * FROM TBL_SecondHouseFile where FileStatus = 3 ",
                "حذفی", label_DelHouse.Text);
            label_DelHouse.Text = label_DelHouse.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_Customer_Click(object sender, EventArgs e)
        {
            label_Customer.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateRequestTbl_Report("متقاضیان",true),//" SELECT * FROM TBL_HouseRequest ",
                "متقاضیان", label_Customer.Text);
            label_Customer.Text = label_Customer.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_CnculList_Click(object sender, EventArgs e)
        {
            label_CnculList.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateConclutionTbl_Report("قراردادها",true),//" SELECT * FROM Tbl_HouseConclusion ",
                "قراردادها", label_CnculList.Text);
            label_CnculList.Text = label_CnculList.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_UserList_Click(object sender, EventArgs e)
        {
            label_UserList.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreateUsersTbl_Report("کاربران",true),//" SELECT * FROM TBL_Users ",
                "کاربران", label_UserList.Text);
            label_UserList.Text = label_UserList.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_TelNoteBook_Click(object sender, EventArgs e)
        {
            label_TelNoteBook.Text = ReportClass_Cls.FileReportCreate_Rep(false, ReportClass_Cls.TableCreatePerTelMobTbl_Report("دفترتلفن",true),//" SELECT * FROM TBL_PersonTelMob ",
                "دفترتلفن", label_TelNoteBook.Text);
            label_TelNoteBook.Text = label_TelNoteBook.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }

        private void button_Advertisment_Click(object sender, EventArgs e)
        {
            label_Advertisment.Text = ReportClass_Cls.ReportForAdvertisment(false, "آگهی", label_Advertisment.Text);
            label_Advertisment.Text = label_Advertisment.Text.Replace(Global_Cls.RootSaveLoad() + "\\", "");
        }
        #endregion

    }
}

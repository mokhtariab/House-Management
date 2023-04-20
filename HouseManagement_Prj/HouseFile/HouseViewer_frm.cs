using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace HouseManagement_Prj
{
    public partial class HouseViewer_frm : Form
    {
        public HouseViewer_frm()
        {
            InitializeComponent();
        }

        public void LoadDataAndShow(string ListWhere, string startpos, int HouseListEnter)
        {
            //0: ListHouse
            //1: ListFileAllTrans
            //2: ListHouseRCV
            label_TypeFee.Text = Global_Cls.Money_Unit;
            try
            {
                string StrConn = Global_Cls.ConnectionStr;

                SqlConnection SqConn = new SqlConnection(StrConn);
                SqConn.Open();

                SqlCommand SqCmd = new SqlCommand();
                SqCmd.Connection = SqConn;

                if (HouseListEnter == 0) 
                    SqCmd.CommandText = " select * from HouseView_Vw Where (1=1) " + ListWhere;
                else if (HouseListEnter == 1) 
                    SqCmd.CommandText = " select * from HouseSecondView_Vw Where (1=1) " + ListWhere;
                else if (HouseListEnter == 2) 
                    SqCmd.CommandText = " select * from HouseTmpFileView_Vw Where (1=1) " + ListWhere;

                DataTable retValue = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(SqCmd);
                da.Fill(retValue);

                houseView_VwBindingSource.DataSource = retValue;

                SqConn.Close();

                houseView_VwBindingSource.Position = Convert.ToInt32(startpos);
                //houseView_VwBindingNavigator.PositionItem.MergeIndex = Convert.ToInt32( startpos);
                //bindingNavigatorMoveLastItem.Checked = true;//.Text = startpos;
                //bindingNavigatorPositionItem.SelectionStart = Convert.ToInt32( startpos );

                ShowDialog();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

           
        }

        private void houseView_VwBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //pics & films
            
            try
            {
                LoadPics_Films(Convert.ToInt32(comboBox_HouseID.Text));
            }
            catch { }

        }

        private void HouseViewer_frm_Shown(object sender, EventArgs e)
        {
            houseView_VwBindingSource_CurrentChanged(this, null);
        }

        private void toolStripButton_Print_Click(object sender, EventArgs e)
        {
            ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreateHouseFile_Report("TBL_HouseFile", "ملک", false) + "Where HouseID = " + comboBox_HouseID.Text,
                "ملک", ReportClass_Cls.FindReportDesign_HouseType(comboBox_TypeHouse.Text));

        }

        #region Pics & Films

        private PictureBox ImgPic = null;

        private void LoadPics_Films(int HouseID)
        {
            int PicCounter = 0, MaxPicIDExist = 0;
            int FilmCounter = 0, MaxFilmIDExist = 0;
            imageList_LargePic.Images.Clear(); listView_Pic.Items.Clear();
            imageList_SmallPic.Images.Clear();
            imageList_LargeFilm.Images.Clear(); listView_Film.Items.Clear();
            imageList_SmallFilm.Images.Clear();
            ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(Global_Cls.RootSaveLoad() + @"\PicsFilms\"));
            foreach (string PicFilmRoot in ROC)
            {
                //pics
                if (PicFilmRoot.Contains("PIC") && PicFilmRoot.Contains("ID" + HouseID.ToString() + "."))
                {
                    string FileNameExist = PicFilmRoot.Substring(PicFilmRoot.IndexOf("\\PicsFilms\\") + 11);
                    string Maxstr = FileNameExist.Substring(3, FileNameExist.IndexOf("ID") - 3);
                    if (MaxPicIDExist < Convert.ToInt32(Maxstr)) MaxPicIDExist = Convert.ToInt32(Maxstr);

                    AddToListViewPic(FileNameExist, PicFilmRoot, PicCounter);
                    PicCounter++;
                }

                //films
                if (PicFilmRoot.Contains("FILM") && PicFilmRoot.Contains("ID" + HouseID.ToString() + "."))
                {
                    string FileNameExist = PicFilmRoot.Substring(PicFilmRoot.IndexOf("\\PicsFilms\\") + 11);
                    string Maxstr = FileNameExist.Substring(4, FileNameExist.IndexOf("ID") - 4);
                    if (MaxFilmIDExist < Convert.ToInt32(Maxstr)) MaxFilmIDExist = Convert.ToInt32(Maxstr);

                    AddToListViewFilm(FileNameExist, PicFilmRoot, FilmCounter);
                    FilmCounter++;
                }

            }
        }


        //pics

        private void AddToListViewPic(string PicFileName, string ItemName, int PicCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Load(ItemName);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(ItemName, PicFileName, PicCnt);
        }

        private void listView_Pic_DoubleClick(object sender, EventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0) Process.Start(listView_Pic.SelectedItems[0].Name);
        }


        //films

        private void AddToListViewFilm(string FilmFileName, string ItemName, int FilmCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Load(Global_Cls.RootSaveLoad() + @"\PicsFilms\Templete.png");
            imageList_LargeFilm.Images.Add(ImgPic.Image);
            imageList_SmallFilm.Images.Add(ImgPic.Image);
            listView_Film.Items.Add(ItemName, FilmFileName, FilmCnt);
        }


        private void listView_Film_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listView_Film.SelectedItems.Count != 0) Process.Start(listView_Film.SelectedItems[0].Name);
            }
            catch { }
        }

        #endregion


    }
}

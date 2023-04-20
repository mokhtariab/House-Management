using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using HouseManagement_Prj.Properties;
using Microsoft.VisualBasic.FileIO;
using Stimulsoft.Report;


namespace HouseManagement_Prj
{
    public class ReportClass_Cls
    {

        #region Functions For Report Creator&Show

        /*static public string FileReportCreate_FastRep(bool ShowOrDesign, string CommandText, string TableName, string ReportRoot)
        {
               " try
            {
                string StrConn = "Data Source=.;Initial Catalog=House_Management;Integrated Security=True";

                SqlConnection SqConn = new SqlConnection(StrConn);
                SqConn.Open();

                SqlCommand SqCmd = new SqlCommand();
                SqCmd.Connection = SqConn;

                SqCmd.CommandText = CommandText;
                DataTable retValue = new DataTable(TableName);
                SqlDataAdapter da = new SqlDataAdapter(SqCmd);
                da.Fill(retValue);

                FastReport.Report Rprt = new FastReport.Report();
                Rprt.RegisterData(retValue, TableName);

                try
                {
                    Rprt.Load(ReportRoot);
                    //try
                    //{
                      //  FastReport.PictureObject mypic = Rprt.FindObject("PicLogo") as FastReport.PictureObject;
                      //  mypic.ImageLocation = Application.StartupPath + "\\PicsFilms\\" + Settings.Default.Agancy_LogoName.ToString();
                   // }
                   // catch { }

                }
                catch
                {
                    try
                    {
                        Rprt.Load(Application.StartupPath + "\\" + ReportRoot);
                    }
                    catch
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "فایل یافت نشد");
                        Rprt.Report.CreateUniqueName();
                    }
                }

                if (ShowOrDesign) { Rprt.Prepare(); Rprt.ShowPrepared(); }
                else Rprt.Design();

                SqCmd.Clone();
                SqConn.Close();

                return Rprt.Report.FileName;
            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در گزارش گیری: فایل گزارش جابجا شده و یا طراحی نشده است!", ex.ToString());
            }
            return null;
        }

        static public string FastReportForAdvertisment(bool ShowOrDesign, string CommandText, string ReportRoot)
        {
            try
            {
                FastReport.Report Rprt = new FastReport.Report();

                try
                {
                    Rprt.Load(ReportRoot);
                    Rprt.Parameters[0].Value = CommandText;
                }
                catch
                {
                    try
                    {
                        Rprt.Load(Application.StartupPath + "\\" + ReportRoot);
                    }
                    catch
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "فایل یافت نشد");
                        Rprt.Report.CreateUniqueName();
                    }
                }

                 if (ShowOrDesign) { Rprt.Prepare(); Rprt.ShowPrepared(); }                
                 else Rprt.Design();

                 return Rprt.Report.FileName;

            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در گزارش گیری: فایل گزارش جابجا شده و یا طراحی نشده است!", ex.ToString());
            }
            return null;

        }
        */

        static public string FileReportCreate_Rep(bool ShowOrDesign, string CommandText, string TableName, string ReportRoot)
        {
            try
            {
                string StrConn = Global_Cls.ConnectionStr;

                SqlConnection SqConn = new SqlConnection(StrConn);
                SqConn.Open();
                SqlCommand SqCmd = new SqlCommand();
                SqCmd.Connection = SqConn;

                SqCmd.CommandText = CommandText;
                DataTable retValue = new DataTable(TableName);
                SqlDataAdapter da = new SqlDataAdapter(SqCmd);
                da.Fill(retValue);

                StiReport report = new StiReport();

                report.RegData(TableName, retValue);

                try
                {
                    report.Load(ReportRoot);
                }
                catch (Exception ex)
                {
                    try
                    {
                        report.Load(Global_Cls.RootSaveLoad() + "\\" + ReportRoot);
                    }
                    catch (Exception ex1)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "فایل یافت نشد", ex.ToString() +"   "+ ex1.ToString());
                        report.CreateReportInNewAppDomain();
                    }
                }

                if (ShowOrDesign) { report.Show(); }
                else report.Design();

                SqCmd.Clone();
                SqConn.Close();

                return report.ReportFile;
            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در گزارش گیری: فایل گزارش جابجا شده و یا طراحی نشده است!", ex.ToString());
            }
            return null;
        }


        static public string ReportForAdvertisment(bool ShowOrDesign, string CommandText, string ReportRoot)
        {
            try
            {
                StiReport Rprt = new StiReport();

                try
                {
                    Rprt.Load(ReportRoot);
                    Rprt.Dictionary.Variables[0].Value = CommandText;
                }
                catch
                {
                    try
                    {
                        Rprt.Load(Global_Cls.RootSaveLoad() + "\\" + ReportRoot);
                    }
                    catch
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "فایل یافت نشد");
                        Rprt.CreateReportInNewAppDomain();
                    }
                }

                if (ShowOrDesign) { Rprt.Show(); }
                else Rprt.Design();

                return Rprt.ReportFile;

            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در گزارش گیری: فایل گزارش جابجا شده و یا طراحی نشده است!", ex.ToString());
            }
            return null;

        }

        
        #endregion


        //ملک ...
        static public string TableCreateHouseFile_Report(string TableName, string TableNameStr, bool DesignSelect)
        {
            string PicStr = ", '' as 'لوگوی آژانس'";
            if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString()))
                PicStr = ", (Select BulkColumn from Openrowset( Bulk '" + Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString() + "', Single_Blob) as EmployeePicture) as 'لوگوی آژانس'";

            string StrHouseFor = "";
            for (int i = 0; i < Global_Cls.HouseFor.Count; i++)
                StrHouseFor += ", (case when [HouseFor]= N'" + Global_Cls.HouseFor[i] + "' then cast(1 as bit) else cast(0 as bit) end) as '" + Global_Cls.HouseFor[i] + "' ";

            string StrTypeHouse = "";
            for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
                StrTypeHouse += ", (case when [TypeHouse]= N'" + Global_Cls.TypeHouseAllCases[i] + "' then cast(1 as bit) else cast(0 as bit) end) as '" + Global_Cls.TypeHouseAllCases[i] + "' ";

            string DesignRow = "";
            if (DesignSelect) DesignRow = " TOP (10) ";
            return "SELECT "+DesignRow
                     + " dbo.MiladiToShamsi(Modify_Date) as 'تاریخ'"
                     + ",[FileNO]as 'شماره فایل'"
                     + ",[Lord_Name]as 'نام مالک'"
                     + ",[Lord_Family]as 'فامیل مالک'"
                     + ",[Lord_Address]as 'آدرس مالک'"

                     + ",[Lord_Telephone]as 'تلفن مالک'"
                     + ",[Lord_Mobile]as 'تلفن همراه مالک'"
                     + ",[Lord_Email]as 'پست الکترونیکی'"
                     + ",tbl_part.PartName_Fa as 'نام منطقه'"
                     + StrHouseFor
                     + ",[HouseFor] As '*ملک جهت' "
                     + StrTypeHouse
                     + ",[TypeHouse] As '*نوع ملک' "
                     + ",[P_Northern]as 'شمالی'"
                     + ",[P_Southern]as 'جنوبی'"
                     + ",[P_Eastern]as 'شرقی'"
                     + ",[P_Western]as 'غربی'"
                     + ",(case when [P_Northern]=1 then N'شمالی' when [P_Southern]=1 then N'جنوبی' when [P_Eastern]=1 then N'شرقی' when [P_Western]=1 then N'غربی' else '' end) as 'موقعیت ملک'"
                     + ",[Few_estate]as 'تعداد طبقه'"
                     + ",[Few_estateunit]as 'تعداد واحد هر طبقه'"
                     + ",[Few_unitAll]as 'تعداد کل واحدها'"

                     + ",dbo.DigitSeparator(cast(Price_HouseMeter as varchar)) as 'قیمت - متری'"
                     + ",dbo.DigitSeparator(cast(Price_HouseAll as varchar)) as 'قیمت کل'"
                     + ",dbo.DigitSeparator(cast([Price_Mortgage]as varchar)) as 'مبلغ رهن'"
                     + ",dbo.DigitSeparator(cast([Price_Rent]as varchar)) as 'مبلغ اجاره'"
                     + ", N'" + Global_Cls.Money_Unit + "' as 'واحد پول'"

                     + ",[Complex]as 'مجتمع'"
                     + ",(case when Complex=1 then N'می باشد' else '' end) as '*مجتمع'"
                     + ",[Few_ComplexBld]as 'تعداد ساختمانهای مجتمع'"
                     + ",[FH_estateNo]as 'طبقه'"
                     + ",[FH_UnitNo]as 'واحد'"
                     + ",[FH_Submeter]as 'زیربنا'"
                     + ",[FH_BedRoomFew]as 'تعداد خواب'"
                     + ",[FH_RcRoomFew]as 'تعداد پذیرایی'"
                     + ",[FH_BedRoom]as 'کف خواب'"
                     + ",[FH_RcRoom]as 'کف پذیرایی'"
                     + ",[FH_BldLow]as 'کف پوش ساختمان'"
                     + ",[FH_WallCover]as 'پوشش دیوارها'"
                     + ",[FH_KitchenModel]as 'مدل آشپزخانه'"
                     + ",[FH_CupbrdType]as 'نوع کابینت'"
                     + ",[FH_KitchenFew]as 'تعداد آشپزخانه'"
                     + ",[FH_WcFewIr]as 'تعداد سرویس ایرانی'"
                     + ",[FH_WcFewFg]as 'تعداد سرویس فرنگی'"
                     + ",[FH_WcIrani]as 'سرویس ایرانی'"
                     + ",(case when [FH_WcIrani]=1 then N'دارد' else '' end) as '*سرویس ایرانی'"
                     + ",[FH_WcForeign] as 'سرویس فرنگی'"
                     + ",(case when [FH_WcForeign]=1 then N'دارد' else '' end) as '*سرویس فرنگی'"
                     + ",(case when ([FH_WcForeign]=1 and [FH_WcIrani]=1) then N'ایرانی-فرنگی' when [FH_WcIrani]=1 then N'سرویس ایرانی' when [FH_WcForeign]=1 then N'سرویس فرنگی' end) as 'نوع سرویس'"
                     + ",[FH_SmallKitchen]as 'آبدارخانه'"
                     + ",(case when [FH_SmallKitchen]=1 then N'دارد' else '' end) as '*آبدارخانه'"
                     + ",[FH_Telephone]as 'تلفن'"
                     + ",(case when [FH_Telephone]=1 then N'دارد' else '' end) as '*تلفن'"
                     + ",[FH_TelFew]as 'تعداد تلفن'"
                     + ",[FH_Balcony]as 'بالکن'"
                     + ",(case when [FH_Balcony]=1 then N'دارد' else '' end) as '*بالکن'"
                     + ",[FH_BalconyMeter]as 'متراژ بالکن'"
                     + ",[FH_FirePlace]as 'شومینه'"
                     + ",(case when [FH_FirePlace]=1 then N'دارد' else '' end) as '*شومینه'"
                     + ",[FH_FirePlaceFew]as 'تعداد شومینه'"
                     + ",[FH_Parking]as 'پارکینگ'"
                     + ",(case when [FH_Parking]=1 then N'دارد' else '' end) as '*پارکینگ'"
                     + ",[FH_ParkingFew]as 'تعداد پارکینگ'"
                     + ",[FH_StoreRoom]as 'انباری'"
                     + ",(case when [FH_StoreRoom]=1 then N'دارد' else '' end) as '*انباری'"
                     + ",[FH_StRoomMeter]as 'متراژ انباری'"
                     + ",[FH_Decoration]as 'دکوراسیون'"
                     + ",[FH_Cellar]as 'زیرزمین'"
                     + ",(case when [FH_Cellar]=1 then N'دارد' else '' end) as '*زیرزمین'"
                     + ",[FH_CellarMeter]as 'متراژ زیرزمین'"
                     + ",[FH_Yard]as 'حیاط'"
                     + ",(case when [FH_Yard]=1 then N'دارد' else '' end) as '*حیاط'"
                     + ",[FH_YardMeter]as 'متراژ حیاط'"
                     + ",[FH_BackYard]as 'حیاط خلوت'"
                     + ",(case when [FH_BackYard]=1 then N'دارد' else '' end) as '*حیاط خلوت'"
                     + ",[FH_BackYardMeter]as 'متراژ حیاط خلوت'"
                     + ",[FH_AifoonVideo]as 'آیفون تصویری'"
                     + ",(case when [FH_AifoonVideo]=1 then N'دارد' else '' end) as '*آیفون تصویری'"
                     + ",[FH_RemotingDoor]as 'درب ریموت'"
                     + ",(case when [FH_RemotingDoor]=1 then N'دارد' else '' end) as '*درب ریموت'"
                     + ",[FH_AerialCenter]as 'آنتن مرکزی'"
                     + ",(case when [FH_AerialCenter]=1 then N'دارد' else '' end) as '*آنتن مرکزی'"
                     + ",[FH_Patio]as 'پاسیو'"
                     + ",(case when [FH_Patio]=1 then N'دارد' else '' end) as '*پاسیو'"
                     + ",[FH_PatioMeter]as 'متراژ پاسیو'"
                     + ",[FH_Bldface]as 'نمای ساختمان'"
                     + ",[FH_EmployeeSrv]as 'سرویس مستخدم'"
                     + ",(case when [FH_EmployeeSrv]=1 then N'دارد' else '' end) as '*سرویس مستخدم'"
                     + ",[FH_RubShooting]as'شوتینگ زباله'"
                     + ",(case when [FH_RubShooting]=1 then N'دارد' else '' end) as '*شوتینگ زباله'"
                     + ",[CH_Water] as 'آب'"
                     + ",(case when [CH_Water]=1 then N'دارد' else '' end) as '*آب'"
                     + ",[CH_Electricity] as 'برق'"
                     + ",(case when [CH_Electricity]=1 then N'دارد' else '' end) as '*برق'"
                     + ",[CH_Gaz] as 'گاز'"
                     + ",(case when [CH_Gaz]=1 then N'دارد' else '' end) as '*گاز'"
                     + ",[CH_Heat] as 'شوفاژ'"
                     + ",(case when [CH_Heat]=1 then N'دارد' else '' end) as '*شوفاژ'"
                     + ",[CH_Cooler] as 'کولر'"
                     + ",(case when [CH_Cooler]=1 then N'دارد' else '' end) as '*کولر'"
                     + ",[CH_FanCoel] as 'فن کوئل'"
                     + ",(case when [CH_FanCoel]=1 then N'دارد' else '' end) as '*فن کوئل'"
                     + ",[CH_Chiler] as 'چیلر'"
                     + ",(case when [CH_Chiler]=1 then N'دارد' else '' end) as '*چیلر'"
                     + ",[CH_Pakage] as 'پکیج'"
                     + ",(case when [CH_Pakage]=1 then N'دارد' else '' end) as '*پکیج'"
                     + ",[CH_Elevator] as 'آسانسور'"
                     + ",(case when [CH_Elevator]=1 then N'دارد' else '' end) as '*آسانسور'"
                     + ",[CH_Sauna] as 'سونا'"
                     + ",(case when [CH_Sauna]=1 then N'دارد' else '' end) as '*سونا'"
                     + ",[CH_Jacuzzi] as 'جکوزی'"
                     + ",(case when [CH_Jacuzzi]=1 then N'دارد' else '' end) as '*جکوزی'"
                     + ",[CH_Pool] as 'استخر'"
                     + ",(case when [CH_Pool]=1 then N'دارد' else '' end) as '*استخر'"
                     + ",[CH_PoolType] as 'نوع استخر'"
                     + ",[CH_ElevatorFew] as 'تعداد آسانسور'"
                     + ",[RH_LandArea] as 'مساحت زمین'"
                     + ",[RH_SideWidth] as 'طول بر'"
                     + ",[RH_Arena] as 'عرصه'"
                     + ",[RH_Upscale] as 'اعیانی'"
                     + ",[RH_Height] as 'ارتفاع'"
                     + ",[RH_Pressure] as 'تراکم'"
                     + ",[RH_Corrective] as 'اصلاحی'"
                     + ",[RH_Walled] as 'محصور'"
                     + ",[RH_Bldage] as 'عمر ساختمان'"
                     + ",[RH_UseType] as 'نوع کاربری'"
                     + ",[RH_LicenceType] as 'نوع جواز'"
                     + ",[RH_DocUse] as 'وضعیت سند'"
                     + ",(case when [RH_DocUse]=1 then N'دارد' else N'ندارد' end) as '*وضعیت سند'"
                     + ",[RH_DocType] as 'نوع سند'"
                     + ",[RH_LicenceConfig] as 'جواز ساخت'"
                     + ",[RH_Property] as 'مالکیت'"
                     + ",(case when [RH_Property]=1 then N'دارد' else '' end) as '*مالکیت'"
                     + ",[RH_KeyMoney] as 'سرقفلی'"
                     + ",(case when [RH_KeyMoney]=1 then N'می باشد' else '' end) as '*سرقفلی'"
                     + ",[OH_Discharge] as 'تخلیه'"
                     + ",(case when [OH_Discharge]=1 then N'می باشد' else '' end) as '*تخلیه'"
                     + ",dbo.MiladiToShamsi([OH_DischargeDate]) as 'زمان تخلیه مستاجر فعلی'"
                     + ",[OH_HolderName] as 'نام مستاجر فعلی'"
                     + ",[OH_HolderTel] as 'شماره تماس مستاجر فعلی'"
                     + ",[OH_RentUse] as 'تحت اجاره'"
                     + ",(case when [OH_RentUse]=1 then N'می باشد' else '' end) as '*تحت اجاره'"
                     + ",[OH_LordExist] as 'سکونت مالک'"
                     + ",(case when [OH_LordExist]=1 then N'سکونت دارد' else '' end) as '*سکونت مالک'"
                     + ",[OH_VisitAllow] as 'بازدید'"
                     + ",[OH_Specify] as 'مشخصات بنای نیمه کاره'"
                     + ",[OH_MaxPeople] as 'حداکثر تعداد افراد تحت اجاره'"
                     + ",[OH_MapDictation] as 'دستور نقشه'"
                     + ",[InformationSource] as 'منبع اطلاعاتی'"
                     + ",dbo.MiladiToShamsi([NonActive_Date]) as 'تاریخ فعال شدن'"
                     + ",[Description] as 'توضیحات'"

                     + ",(tbl_users.FirstName+' '+tbl_users.LastName) as 'تنظیم کننده'"

                     + ", N'" + Global_Cls.Agancy_Name + "' as 'نام آژانس'"
                     + ", N'" + Global_Cls.Agancy_Tel + "' as 'تلفن های آژانس'"
                     + ", N'" + Global_Cls.Agancy_Mobile + "' as 'موبایل آژانس'"
                     + ", N'" + Global_Cls.Agancy_Address + "' as 'آدرس آژانس'"
                     + PicStr 

                 + " FROM " + TableName + " as " + TableNameStr
                 + " Left Join tbl_users on tbl_users.Usercode = " + TableNameStr + ".User_Code"
                 + " Left Join tbl_part on tbl_part.PartID = " + TableNameStr + ".[Lord_Part] ";
        }


        static public string FindReportDesign_HouseType(string p)
        {
            string ReturnStr = Global_Cls.ReportDesignAddress[0];
            if (p == "") return ReturnStr;
            for (int i = 0; i < Global_Cls.ReportDesignHouseType.Count; i++)
                if (Global_Cls.ReportDesignHouseType[i].Contains(p))
                {
                    ReturnStr = Global_Cls.ReportDesignAddress[i + 1];
                    break;
                }
            return ReturnStr;
        }


        //متقاضیان
        static public string TableCreateRequestTbl_Report(string TableNameStr, bool DesignSelect)
        {
            string PicStr = ", '' as 'لوگوی آژانس'";
            if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString()))
                PicStr = ", (Select BulkColumn from Openrowset( Bulk '" + Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString() + "', Single_Blob) as EmployeePicture) as 'لوگوی آژانس'";

            string StrReqFor = "";
            for (int i = 0; i < Global_Cls.RequestFor.Count; i++)
                StrReqFor += ", (case when [HouseReqFor]= N'" + Global_Cls.RequestFor[i] + "' then cast(1 as bit) else cast(0 as bit) end) as '" + Global_Cls.RequestFor[i] + "' ";

            string StrTypeReqHouse = "";
            for (int i = 0; i < Global_Cls.TypeHouseAllCases.Count; i++)
                StrTypeReqHouse += ", (case when [TypeHouseReq]= N'" + Global_Cls.TypeHouseAllCases[i] + "' then cast(1 as bit) else cast(0 as bit) end) as '" + Global_Cls.TypeHouseAllCases[i] + "' ";

            string DesignRow = "";
            if (DesignSelect) DesignRow = " TOP (10) ";
            return "SELECT " + DesignRow
                     + " [Request_NO] As 'شماره تقاضا'"
                    + " ,dbo.MiladiToShamsi([RequestDate]) As 'تاریخ تقاضا'"
                    + " ,(case when [Approach_Type]=1 then N'حضوری' else N'غیرحضوری' end) As 'نوع مراجعه'"
                    + " ,(case when [Approach_Type]=1 then cast(1 as bit) else cast(0 as bit) end) As 'مراجعه حضوری'"
                    + " ,[Customer_Name] As 'نام متقاضی'"
                    + " ,[Customer_Family] As 'فامیلی متقاضی'"
                    + " ,[Customer_Tel] As 'تلفن متقاضی'"
                    + " ,[Customer_Mobile] As 'موبایل متقاضی'"
                    + " ,[Customer_Email] As 'Email'"
                    + StrReqFor
                    + " ,[HouseReqFor] as '*درخواست ملک جهت'"
                    + StrTypeReqHouse
                    + " ,[TypeHouseReq] as '*نوع ملک'"

                    + " ,[PR_Northern] as 'شمالی'"
                    + " ,[PR_Southern] as 'جنوبی'"
                    + " ,[PR_Eastern] as 'شرقی'"
                    + " ,[PR_Western] as 'غربی'"
                     + ",(case when [PR_Northern]=1 then N'شمالی' when [PR_Southern]=1 then N'جنوبی' when [PR_Eastern]=1 then N'شرقی' when [PR_Western]=1 then N'غربی' else '' end) as 'موقعیت ملک'"

                    + " ,[Req_SubMeter1] as 'زیر بنا از'"
                    + " ,[Req_SubMeter2] as 'زیر بنا تا'"
                    + " ,[Type_Use] as 'نوع کاربری'"
                    + " ,[Type_Document] as 'نوع سند'"
                    + " ,[Document_Exist] as 'سند دار'"
                    + " ,(case when [Document_Exist]=1 then N'می باشد' else '' end) as '*سند دار'"
                    + " ,[FewPerson_Rent] as 'تعداد نفرات اجاره'"

                    + " ,dbo.DigitSeparator(cast([Bodget_Buy1] as varchar)) as 'بودجه خرید از'"
                    + " ,dbo.DigitSeparator(cast([Bodget_Buy2] as varchar)) as 'بودجه خرید تا'"
                    + " ,dbo.DigitSeparator(cast([Bodget_Rent1] as varchar)) as 'بودجه اجاره از'"
                    + " ,dbo.DigitSeparator(cast([Bodget_Rent2] as varchar)) as 'بودجه اجاره تا'"
                    + " ,dbo.DigitSeparator(cast([Bodget_Mortgage1] as varchar)) as 'بودجه رهن از'"
                    + " ,dbo.DigitSeparator(cast([Bodget_Mortgage2] as varchar)) as 'بودجه رهن تا'"
                    + ", N'" + Global_Cls.Money_Unit + "' as 'واحد پول'"

                    + " ,[Request_Use] as 'مورد استفاده'"
                    + " ,[TypeGive_Buy] as 'نحوه خرید'"
                    + " ,dbo.MiladiToShamsi([Expired_Date]) as 'آخرین مهلت'"

                    + " ,[Description] as 'توضیحات'"

                    + " ,(tbl_users.FirstName+' '+tbl_users.LastName) as 'تنظیم کننده'"
                    + " ,p1.PartName_Fa as 'نام منطقه 1'"
                    + " ,p2.PartName_Fa as 'نام منطقه 2'"
                    + " ,p3.PartName_Fa as 'نام منطقه 3'"
                    + " ,p4.PartName_Fa as 'نام منطقه 4'"

                    + ", N'" + Global_Cls.Agancy_Name + "' as 'نام آژانس'"
                    + ", N'" + Global_Cls.Agancy_Tel + "' as 'تلفن های آژانس'"
                    + ", N'" + Global_Cls.Agancy_Mobile + "' as 'موبایل آژانس'"
                    + ", N'" + Global_Cls.Agancy_Address + "' as 'آدرس آژانس'"
                    + PicStr 

             + " FROM [TBL_HouseRequest] as "+TableNameStr
             + " Left Join tbl_users on tbl_users.Usercode = "+TableNameStr+".User_Code	"
             + " Left Join tbl_part p1 on p1.PartID = " + TableNameStr + ".[PartRequest1] "
             + " Left Join tbl_part p2 on p2.PartID = " + TableNameStr + ".[PartRequest2] "
             + " Left Join tbl_part p3 on p3.PartID = " + TableNameStr + ".[PartRequest3] "
             + " Left Join tbl_part p4 on p4.PartID = " + TableNameStr + ".[PartRequest4] ";
        }


        //قراردادها
        static public string TableCreateConclutionTbl_Report(string TableNameStr, bool DesignSelect)
        {
            string PicStr = ", '' as 'لوگوی آژانس'";
            if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString()))
                PicStr = ", (Select BulkColumn from Openrowset( Bulk '" + Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString() + "', Single_Blob) as EmployeePicture) as 'لوگوی آژانس'";
            
            string DesignRow = "";
            if (DesignSelect) DesignRow = " TOP (10) ";
            return "SELECT "+DesignRow
                     + " [ConclusionID] AS 'شماره قرارداد'"
                     + ",[Hc_LName] AS 'نام مالک'"
                     + ",[Hc_LFamily] AS 'نام فامیل مالک'"
                     + ",[Hc_LFathername] AS 'نام پدر مالک'"
                     + ",[Hc_LMelicode] AS 'کد ملی مالک'"
                     + ",[Hc_CName] AS 'نام متقاضی'"
                     + ",[Hc_CFamily] AS 'فامیل متقاضی'"
                     + ",[Hc_CFathername] AS 'نام پدر متقاضی'"
                     + ",[Hc_CMelicode] AS 'کد ملی متقاضی'"

                     + ",dbo.MiladiToShamsi([Hc_Date]) AS 'تاریخ قرار داد'"
                     + ",[Hc_No] AS 'شماره برگه قرارداد'"
                     + ",[HF_FileNo] AS 'شماره فایل قرار داده شده'"
                     + ",[Hc_Type] AS 'نوع قرار داد'"

                     + ",dbo.DigitSeparator(cast([Hc_CostPrice] as varchar)) AS 'قیمت کل'"
                     + ",dbo.DigitSeparator(cast([Hc_CostRent] as varchar)) AS 'میزان اجاره بها'"
                     + ",dbo.DigitSeparator(cast([Hc_CostMtg] as varchar)) AS 'میزان رهن'"
                     + ",dbo.DigitSeparator(cast([Hc_CommissionCost] as varchar)) AS 'مبلغ کمسیون'"
                     + ",dbo.DigitSeparator(cast([Hc_DutyCost] as varchar)) AS 'مالیات'"
                     + ", N'" + Global_Cls.Money_Unit + "' as 'واحد پول'"

                     + ",[Hc_RentMonth] AS 'مدت قرار داد اجاره'"
                     + ",[Interception_Code] AS 'کد رهگیری'"
                     + ",(tbl_users.FirstName+' '+tbl_users.LastName) as 'تنظیم کننده'"
                     + ",[Hc_Description] AS 'توضیحات'"

                     + ", N'" + Global_Cls.Agancy_Name + "' as 'نام آژانس'"
                     + ", N'" + Global_Cls.Agancy_Tel + "' as 'تلفن های آژانس'"
                     + ", N'" + Global_Cls.Agancy_Mobile + "' as 'موبایل آژانس'"
                     + ", N'" + Global_Cls.Agancy_Address + "' as 'آدرس آژانس'"
                     + PicStr

                + " FROM [House_Management].[dbo].[Tbl_HouseConclusion] AS " + TableNameStr
                + " Left join tbl_users on tbl_users.Usercode = " + TableNameStr + ".User_Code ";
        }


        //دفترتلفن
        static public string TableCreatePerTelMobTbl_Report(string TableNameStr, bool DesignSelect)
        {
            string PicStr = ", '' as 'لوگوی آژانس'";
            if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString()))
                PicStr = ", (Select BulkColumn from Openrowset( Bulk '" + Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString() + "', Single_Blob) as EmployeePicture) as 'لوگوی آژانس'";

            string DesignRow = "";
            if (DesignSelect) DesignRow = " TOP (10) ";
            return "SELECT " + DesignRow
                     + " [PersonID] AS 'شماره شخص'"
                     + ",[FirstName] AS 'نام'"
                     + ",[LastName] AS 'نام خانوادگی'"
                     + ",[Telephone] AS 'تلفن ثابت'"
                     + ",[Mobile] AS 'موبایل'"
                     + ",[Email] AS 'پست الکترونیک'"
                     + ",[Address] AS 'آدرس'"
                     + ",[Description] AS 'توضیحات'"
                     + ", N'" + Global_Cls.Agancy_Name + "' as 'نام آژانس'"
                     + ", N'" + Global_Cls.Agancy_Tel + "' as 'تلفن های آژانس'"
                     + ", N'" + Global_Cls.Agancy_Mobile + "' as 'موبایل آژانس'"
                     + ", N'" + Global_Cls.Agancy_Address + "' as 'آدرس آژانس'"
                     + PicStr

                + " FROM [TBL_PersonTelMob] AS " + TableNameStr;
        }


        //کاربران
        static public string TableCreateUsersTbl_Report(string TableNameStr, bool DesignSelect)
        {
            string PicStr = ", '' as 'لوگوی آژانس'";
            if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString()))
                PicStr = ", (Select BulkColumn from Openrowset( Bulk '" + Global_Cls.RootSaveLoad() + "\\PicsFilms\\" + Global_Cls.Agancy_LogoName.ToString() + "', Single_Blob) as EmployeePicture) as 'لوگوی آژانس'";
            
            string DesignRow = "";
            if (DesignSelect) DesignRow = " TOP (10) ";
            return "SELECT " + DesignRow
                      + " [UserCode] AS 'شماره کاربر'"
                      + ",[FirstName] AS 'نام کاربر'"
                      + ",[LastName] AS 'فامیل کاربر'"
                      + ",[UserName] AS 'نام کاربری'"
                      + ",dbo.MiladiToShamsi([CreateDate]) AS 'تاریخ ایجاد'"
                      + ", N'" + Global_Cls.Agancy_Name + "' as 'نام آژانس'"
                      + ", N'" + Global_Cls.Agancy_Tel + "' as 'تلفن های آژانس'"
                      + ", N'" + Global_Cls.Agancy_Mobile + "' as 'موبایل آژانس'"
                      + ", N'" + Global_Cls.Agancy_Address + "' as 'آدرس آژانس'"
                      + PicStr
                 + " FROM [TBL_Users] AS " + TableNameStr;
        }

    }

    public class StoreProceText
    {
        static public string InsertFromTBLWebHouseReqToLocal_sp(string ConnectionStr, string WhereEnter)
        {

           return
            " INSERT INTO House_Management.dbo.TBL_TmpHouseRequest " +
            " 	( [Request_NO] " +
               ",[RequestDate] " +
               ",[Customer_Name] " +
               ",[Customer_Family] " +
               ",[Customer_Tel] " +
               ",[Customer_Mobile] " +
               ",[Customer_Email] " +
               ",[HouseReqFor] " +
               ",[TypeHouseReq] " +
               ",[PR_Northern] " +
               ",[PR_Southern] " +
               ",[PR_Eastern] " +
               ",[PR_Western] " +
               ",[Req_SubMeter1] " +
               ",[Req_SubMeter2] " +
               ",[Type_Use] " +
               ",[Type_Document] " +
               ",[Document_Exist] " +
               ",[FewPerson_Rent] " +
               ",[Bodget_Buy1] " +
               ",[Bodget_Rent1] " +
               ",[Bodget_Mortgage1] " +
               ",[Bodget_Buy2] " +
               ",[Bodget_Rent2] " +
               ",[Bodget_Mortgage2] " +
               ",[Request_Use] " +
               ",[TypeGive_Buy] " +
               ",[Expired_Date] " +
               ",[PartRequest1] " +
               ",[PartRequest2] " +
               ",[PartRequest3] " +
               ",[PartRequest4] " +
               ",[Description] ) " +
            " Select * FROM  OPENROWSET('SQLNCLI'," +
                        "'"+ConnectionStr+"'," +
                        "'SELECT Top 5 [Request_NO] " +
               ",[RequestDate] " +
               ",[Customer_Name] " +
               ",[Customer_Family] " +
               ",[Customer_Tel] " +
               ",[Customer_Mobile] " +
               ",[Customer_Email] " +
               ",[HouseReqFor] " +
               ",[TypeHouseReq] " +
               ",[PR_Northern] " +
               ",[PR_Southern] " +
               ",[PR_Eastern] " +
               ",[PR_Western] " +
               ",[Req_SubMeter1] " +
               ",[Req_SubMeter2] " +
               ",[Type_Use] " +
               ",[Type_Document] " +
               ",[Document_Exist] " +
               ",[FewPerson_Rent] " +

               ",Convert(bigint,[Bodget_Buy1] * 10/" + Global_Cls.Money_Change + ")" +
               ",Convert(bigint,[Bodget_Rent1] * 10/" + Global_Cls.Money_Change + ")" +
               ",Convert(bigint,[Bodget_Mortgage1] * 10/" + Global_Cls.Money_Change + ")" +
               ",Convert(bigint,[Bodget_Buy2] * 10/" + Global_Cls.Money_Change + ")" +
               ",Convert(bigint,[Bodget_Rent2] * 10/" + Global_Cls.Money_Change + ")" +
               ",Convert(bigint,[Bodget_Mortgage2] * 10/" + Global_Cls.Money_Change + ")" +
                              
               ",[Request_Use] " +
               ",[TypeGive_Buy] " +
               ",[Expired_Date] " +
               ",[PartRequest1] " +
               ",[PartRequest2] " +
               ",[PartRequest3] " +
               ",[PartRequest4] " +
               ",[Description] " +
            " FROM HouseManagement_SR.dbo.TBL_WebHouseRequest Where "+WhereEnter+"  Order by RequestID ') ";

        }

        static public string InsertToTBLViewHouseFileToWeb_Sp(string ConnectionStr,
					string HouseID,string Agency_Name,string Agancy_AdminName,string Agency_Address,
					string Agency_Telephone,string Agency_Mobile,string Agency_Email,string City_Name,
					string Part_Name,string ExpireDate,string AgancyDescription,string ChangeToman)
        {

            return

                    "	INSERT INTO OPENROWSET('SQLNCLI', " +
                    "	'" + ConnectionStr + "', " +
                        "'SELECT [Modify_Date] " +
                           ",[Agency_Name] " +
                           ",[Agancy_AdminName] " +
                           ",[Agency_Address] " +
                           ",[Agency_Telephone] " +
                           ",[Agency_Mobile] " +
                           ",[Agency_Email] " +
                           ",[City_Name] " +
                           ",[Part_Name] " +
                           ",[HouseFor] " +
                           ",[TypeHouse] " +
                           ",[P_Northern] " +
                           ",[P_Southern] " +
                           ",[P_Eastern] " +
                           ",[P_Western] " +
                           ",[Few_estate] " +
                           ",[Few_estateunit] " +
                           ",[Few_unitAll] " +
                           ",[Price_HouseMeter] " +
                           ",[Price_HouseAll] " +
                           ",[Price_Mortgage] " +
                           ",[Price_Rent] " +
                           ",[Complex] " +
                           ",[Few_ComplexBld] " +
                           ",[FH_estateNo] " +
                           ",[FH_UnitNo] " +
                           ",[FH_Submeter] " +
                           ",[FH_BedRoomFew] " +
                           ",[FH_RcRoomFew] " +
                           ",[FH_BedRoom] " +
                           ",[FH_RcRoom] " +
                           ",[FH_BldLow] " +
                           ",[FH_WallCover] " +
                           ",[FH_KitchenModel] " +
                           ",[FH_CupbrdType] " +
                           ",[FH_KitchenFew] " +
                           ",[FH_WcFewIr] " +
                           ",[FH_WcFewFg] " +
                           ",[FH_WcIrani] " +
                           ",[FH_WcForeign] " +
                           ",[FH_SmallKitchen] " +
                           ",[FH_Telephone] " +
                           ",[FH_TelFew] " +
                           ",[FH_Balcony] " +
                           ",[FH_BalconyMeter] " +
                           ",[FH_FirePlace] " +
                           ",[FH_FirePlaceFew] " +
                           ",[FH_Parking] " +
                           ",[FH_ParkingFew] " +
                           ",[FH_StoreRoom] " +
                           ",[FH_StRoomMeter] " +
                           ",[FH_Decoration] " +
                           ",[FH_Cellar] " +
                           ",[FH_CellarMeter] " +
                           ",[FH_Yard] " +
                           ",[FH_YardMeter] " +
                           ",[FH_BackYard] " +
                           ",[FH_BackYardMeter] " +
                           ",[FH_AifoonVideo] " +
                           ",[FH_RemotingDoor] " +
                           ",[FH_AerialCenter] " +
                           ",[FH_Patio] " +
                           ",[FH_PatioMeter] " +
                           ",[FH_Bldface] " +
                           ",[FH_EmployeeSrv] " +
                           ",[FH_RubShooting] " +
                           ",[CH_Water] " +
                           ",[CH_Electricity] " +
                           ",[CH_Gaz] " +
                           ",[CH_Heat] " +
                           ",[CH_Cooler] " +
                           ",[CH_FanCoel] " +
                           ",[CH_Chiler] " +
                           ",[CH_Pakage] " +
                           ",[CH_Elevator] " +
                           ",[CH_Sauna] " +
                           ",[CH_Jacuzzi] " +
                           ",[CH_Pool] " +
                           ",[CH_PoolType] " +
                           ",[CH_ElevatorFew] " +
                           ",[RH_LandArea] " +
                           ",[RH_SideWidth] " +
                           ",[RH_Arena] " +
                           ",[RH_Upscale] " +
                           ",[RH_Height] " +
                           ",[RH_Pressure] " +
                           ",[RH_Corrective] " +
                           ",[RH_Walled] " +
                           ",[RH_Bldage] " +
                           ",[RH_UseType] " +
                           ",[RH_LicenceType] " +
                           ",[RH_DocUse] " +
                           ",[RH_DocType] " +
                           ",[RH_LicenceConfig] " +
                           ",[RH_Property] " +
                           ",[RH_KeyMoney] " +
                           ",[OH_Discharge] " +
                           ",[OH_DischargeDate] " +
                           ",[OH_HolderName] " +
                           ",[OH_HolderTel] " +
                           ",[OH_RentUse] " +
                           ",[OH_LordExist] " +
                           ",[OH_VisitAllow] " +
                           ",[OH_Specify] " +
                           ",[OH_MaxPeople] " +
                           ",[OH_MapDictation] " +
                           ",[InformationSource] " +
                           ",[Description] " +
                           ",[ExpireDate] " +
                           ",[AgancyDescription] " +
                 " FROM HouseManagement_SR.dbo.TBL_ViewHouseFile' ) " +

                        " SELECT [Modify_Date] " +
                           ",N'" + Agency_Name + "' " +
                           ",N'" + Agancy_AdminName + "' " +
                           ",N'" + Agency_Address + "' " +
                           ",N'" + Agency_Telephone + "' " +
                           ",N'" + Agency_Mobile + "' " +
                           ",N'" + Agency_Email + "' " +
                           ",N'" + City_Name + "' " +
                           ",N'" + Part_Name + "' " +
                           ",[HouseFor] " +
                           ",[TypeHouse] " +
                           ",[P_Northern] " +
                           ",[P_Southern] " +
                           ",[P_Eastern] " +
                           ",[P_Western] " +
                           ",[Few_estate] " +
                           ",[Few_estateunit] " +
                           ",[Few_unitAll] " +
                           ",Convert(bigint,[Price_HouseMeter]*" + ChangeToman + ") " +
                           ",Convert(bigint,[Price_HouseAll]*" + ChangeToman + ") " +
                           ",Convert(bigint,[Price_Mortgage]*" + ChangeToman + ") " +
                           ",Convert(bigint,[Price_Rent]*" + ChangeToman + ") " +
                           ",[Complex] " +
                           ",[Few_ComplexBld] " +
                           ",[FH_estateNo] " +
                           ",[FH_UnitNo] " +
                           ",[FH_Submeter] " +
                           ",[FH_BedRoomFew] " +
                           ",[FH_RcRoomFew] " +
                           ",[FH_BedRoom] " +
                           ",[FH_RcRoom] " +
                           ",[FH_BldLow] " +
                           ",[FH_WallCover] " +
                           ",[FH_KitchenModel] " +
                           ",[FH_CupbrdType] " +
                           ",[FH_KitchenFew] " +
                           ",[FH_WcFewIr] " +
                           ",[FH_WcFewFg] " +
                           ",[FH_WcIrani] " +
                           ",[FH_WcForeign] " +
                           ",[FH_SmallKitchen] " +
                           ",[FH_Telephone] " +
                           ",[FH_TelFew] " +
                           ",[FH_Balcony] " +
                           ",[FH_BalconyMeter] " +
                           ",[FH_FirePlace] " +
                           ",[FH_FirePlaceFew] " +
                           ",[FH_Parking] " +
                           ",[FH_ParkingFew] " +
                           ",[FH_StoreRoom] " +
                           ",[FH_StRoomMeter] " +
                           ",[FH_Decoration] " +
                           ",[FH_Cellar] " +
                           ",[FH_CellarMeter] " +
                           ",[FH_Yard] " +
                           ",[FH_YardMeter] " +
                           ",[FH_BackYard] " +
                           ",[FH_BackYardMeter] " +
                           ",[FH_AifoonVideo] " +
                           ",[FH_RemotingDoor] " +
                           ",[FH_AerialCenter] " +
                           ",[FH_Patio] " +
                           ",[FH_PatioMeter] " +
                           ",[FH_Bldface] " +
                           ",[FH_EmployeeSrv] " +
                           ",[FH_RubShooting] " +
                           ",[CH_Water] " +
                           ",[CH_Electricity] " +
                           ",[CH_Gaz] " +
                           ",[CH_Heat] " +
                           ",[CH_Cooler] " +
                           ",[CH_FanCoel] " +
                           ",[CH_Chiler] " +
                           ",[CH_Pakage] " +
                           ",[CH_Elevator] " +
                           ",[CH_Sauna] " +
                           ",[CH_Jacuzzi] " +
                           ",[CH_Pool] " +
                           ",[CH_PoolType] " +
                           ",[CH_ElevatorFew] " +
                           ",[RH_LandArea] " +
                           ",[RH_SideWidth] " +
                           ",[RH_Arena] " +
                           ",[RH_Upscale] " +
                           ",[RH_Height] " +
                           ",[RH_Pressure] " +
                           ",[RH_Corrective] " +
                           ",[RH_Walled] " +
                           ",[RH_Bldage] " +
                           ",[RH_UseType] " +
                           ",[RH_LicenceType] " +
                           ",[RH_DocUse] " +
                           ",[RH_DocType] " +
                           ",[RH_LicenceConfig] " +
                           ",[RH_Property] " +
                           ",[RH_KeyMoney] " +
                           ",[OH_Discharge] " +
                           ",[OH_DischargeDate] " +
                           ",[OH_HolderName] " +
                           ",[OH_HolderTel] " +
                           ",[OH_RentUse] " +
                           ",[OH_LordExist] " +
                           ",[OH_VisitAllow] " +
                           ",[OH_Specify] " +
                           ",[OH_MaxPeople] " +
                           ",[OH_MapDictation] " +
                           ",[InformationSource] " +
                           ",[Description] " +
                           ",convert(datetime,'" + ExpireDate + "') " +
                           ",N'" + AgancyDescription + "' " +
                 " FROM dbo.TBL_HouseFile " +
                 " where HouseID = " + HouseID ;


        }


        static public string InsertFromTBLWebHouseFileToLocal_sp(string ConnectionStr, string WhereEnter)
        {

            return

              " INSERT INTO House_Management.dbo.TBL_TmpHouseFile " +
              " ( FileNo " +
              ",[Modify_Date] " +
              ",[Lord_Name] " +
              ",[Lord_Family] " +
              ",[Lord_Address] " +
              ",[Lord_Part] " +
              ",[Lord_PartName] " +
              ",[Lord_CityName] " +
              ",[Lord_Telephone] " +
              ",[Lord_Mobile] " +
              ",[Lord_Email] " +
              ",[HouseFor] " +
              ",[TypeHouse] " +
              ",[P_Northern] " +
              ",[P_Southern] " +
              ",[P_Eastern] " +
              ",[P_Western] " +
              ",[Few_estate] " +
              ",[Few_estateunit] " +
              ",[Few_unitAll] " +
              ",[Price_HouseMeter] " +
              ",[Price_HouseAll] " +
              ",[Price_Mortgage] " +
              ",[Price_Rent] " +
              ",[Complex] " +
              ",[Few_ComplexBld] " +
              ",[FH_estateNo] " +
              ",[FH_UnitNo] " +
              ",[FH_Submeter] " +
              ",[FH_BedRoomFew] " +
              ",[FH_RcRoomFew] " +
              ",[FH_BedRoom] " +
              ",[FH_RcRoom] " +
              ",[FH_BldLow] " +
              ",[FH_WallCover] " +
              ",[FH_KitchenModel] " +
              ",[FH_CupbrdType] " +
              ",[FH_KitchenFew] " +
              ",[FH_WcFewIr] " +
              ",[FH_WcFewFg] " +
              ",[FH_WcIrani] " +
              ",[FH_WcForeign] " +
              ",[FH_SmallKitchen] " +
              ",[FH_Telephone] " +
              ",[FH_TelFew] " +
              ",[FH_Balcony] " +
              ",[FH_BalconyMeter] " +
              ",[FH_FirePlace] " +
              ",[FH_FirePlaceFew] " +
              ",[FH_Parking] " +
              ",[FH_ParkingFew] " +
              ",[FH_StoreRoom] " +
              ",[FH_StRoomMeter] " +
              ",[FH_Decoration] " +
              ",[FH_Cellar] " +
              ",[FH_CellarMeter] " +
              ",[FH_Yard] " +
              ",[FH_YardMeter] " +
              ",[FH_BackYard] " +
              ",[FH_BackYardMeter] " +
              ",[FH_AifoonVideo] " +
              ",[FH_RemotingDoor] " +
              ",[FH_AerialCenter] " +
              ",[FH_Patio] " +
              ",[FH_PatioMeter] " +
              ",[FH_Bldface] " +
              ",[FH_EmployeeSrv] " +
              ",[FH_RubShooting] " +
              ",[CH_Water] " +
              ",[CH_Electricity] " +
              ",[CH_Gaz] " +
              ",[CH_Heat] " +
              ",[CH_Cooler] " +
              ",[CH_FanCoel] " +
              ",[CH_Chiler] " +
              ",[CH_Pakage] " +
              ",[CH_Elevator] " +
              ",[CH_Sauna] " +
              ",[CH_Jacuzzi] " +
              ",[CH_Pool] " +
              ",[CH_PoolType] " +
              ",[CH_ElevatorFew] " +
              ",[RH_LandArea] " +
              ",[RH_SideWidth] " +
              ",[RH_Arena] " +
              ",[RH_Upscale] " +
              ",[RH_Height] " +
              ",[RH_Pressure] " +
              ",[RH_Corrective] " +
              ",[RH_Walled] " +
              ",[RH_Bldage] " +
              ",[RH_UseType] " +
              ",[RH_LicenceType] " +
              ",[RH_DocUse] " +
              ",[RH_DocType] " +
              ",[RH_LicenceConfig] " +
              ",[RH_Property] " +
              ",[RH_KeyMoney] " +
              ",[OH_Discharge] " +
              ",[OH_DischargeDate] " +
              ",[OH_HolderName] " +
              ",[OH_HolderTel] " +
              ",[OH_RentUse] " +
              ",[OH_LordExist] " +
              ",[OH_VisitAllow] " +
              ",[OH_Specify] " +
              ",[OH_MaxPeople] " +
              ",[OH_MapDictation] " +
              ",[InformationSource] " +
              ",[Description] " +
              ",[NonActive_Date] ) " +

             " Select * FROM  OPENROWSET('SQLNCLI','" + ConnectionStr + "', " +
                      " 'SELECT top 5 FileNo " +
              ",[Modify_Date] " +
              ",[Lord_Name] " +
              ",[Lord_Family] " +
              ",[Lord_Address] " +
              ",[Lord_Part] " +
              ",[Lord_PartName] " +
              ",[Lord_CityName] " +
              ",[Lord_Telephone] " +
              ",[Lord_Mobile] " +
              ",[Lord_Email] " +
              ",[HouseFor] " +
              ",[TypeHouse] " +
              ",[P_Northern] " +
              ",[P_Southern] " +
              ",[P_Eastern] " +
              ",[P_Western] " +
              ",[Few_estate] " +
              ",[Few_estateunit] " +
              ",[Few_unitAll] " +

              ",Convert(bigint,[Price_HouseMeter] * 10/" + Global_Cls.Money_Change + ")" +
              ",Convert(bigint,[Price_HouseAll] * 10/" + Global_Cls.Money_Change + ")" +
              ",Convert(bigint,[Price_Mortgage] * 10/" + Global_Cls.Money_Change + ")" +
              ",Convert(bigint,[Price_Rent] * 10/" + Global_Cls.Money_Change + ")" +

              ",[Complex] " +
              ",[Few_ComplexBld] " +
              ",[FH_estateNo] " +
              ",[FH_UnitNo] " +
              ",[FH_Submeter] " +
              ",[FH_BedRoomFew] " +
              ",[FH_RcRoomFew] " +
              ",[FH_BedRoom] " +
              ",[FH_RcRoom] " +
              ",[FH_BldLow] " +
              ",[FH_WallCover] " +
              ",[FH_KitchenModel] " +
              ",[FH_CupbrdType] " +
              ",[FH_KitchenFew] " +
              ",[FH_WcFewIr] " +
              ",[FH_WcFewFg] " +
              ",[FH_WcIrani] " +
              ",[FH_WcForeign] " +
              ",[FH_SmallKitchen] " +
              ",[FH_Telephone] " +
              ",[FH_TelFew] " +
              ",[FH_Balcony] " +
              ",[FH_BalconyMeter] " +
              ",[FH_FirePlace] " +
              ",[FH_FirePlaceFew] " +
              ",[FH_Parking] " +
              ",[FH_ParkingFew] " +
              ",[FH_StoreRoom] " +
              ",[FH_StRoomMeter] " +
              ",[FH_Decoration] " +
              ",[FH_Cellar] " +
              ",[FH_CellarMeter] " +
              ",[FH_Yard] " +
              ",[FH_YardMeter] " +
              ",[FH_BackYard] " +
              ",[FH_BackYardMeter] " +
              ",[FH_AifoonVideo] " +
              ",[FH_RemotingDoor] " +
              ",[FH_AerialCenter] " +
              ",[FH_Patio] " +
              ",[FH_PatioMeter] " +
              ",[FH_Bldface] " +
              ",[FH_EmployeeSrv] " +
              ",[FH_RubShooting] " +
              ",[CH_Water] " +
              ",[CH_Electricity] " +
              ",[CH_Gaz] " +
              ",[CH_Heat] " +
              ",[CH_Cooler] " +
              ",[CH_FanCoel] " +
              ",[CH_Chiler] " +
              ",[CH_Pakage] " +
              ",[CH_Elevator] " +
              ",[CH_Sauna] " +
              ",[CH_Jacuzzi] " +
              ",[CH_Pool] " +
              ",[CH_PoolType] " +
              ",[CH_ElevatorFew] " +
              ",[RH_LandArea] " +
              ",[RH_SideWidth] " +
              ",[RH_Arena] " +
              ",[RH_Upscale] " +
              ",[RH_Height] " +
              ",[RH_Pressure] " +
              ",[RH_Corrective] " +
              ",[RH_Walled] " +
              ",[RH_Bldage] " +
              ",[RH_UseType] " +
              ",[RH_LicenceType] " +
              ",[RH_DocUse] " +
              ",[RH_DocType] " +
              ",[RH_LicenceConfig] " +
              ",[RH_Property] " +
              ",[RH_KeyMoney] " +
              ",[OH_Discharge] " +
              ",[OH_DischargeDate] " +
              ",[OH_HolderName] " +
              ",[OH_HolderTel] " +
              ",[OH_RentUse] " +
              ",[OH_LordExist] " +
              ",[OH_VisitAllow] " +
              ",[OH_Specify] " +
              ",[OH_MaxPeople] " +
              ",[OH_MapDictation] " +
              ",[InformationSource] " +
              ",[Description] " +
              ",[NonActive_Date] " +

             " FROM HouseManagement_SR.dbo.TBL_WebHouseFile " +
             " Where " + WhereEnter + "  Order by HouseID ') ";
        }
    
    }
}

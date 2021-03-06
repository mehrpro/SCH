﻿namespace SchoolApp
{
    public static class PublicVar
    {
        public static string SuccessSaveToDatabase { get; set; } = "اطلاعات با موفقیت در بانک ذخیره شد";
        public static string ErrorSaveToDatabase { get; set; } = "عملیات ثبت انجام نشد با مدیر سیستم تماس بگیرید";
        public static string SchoolName { get; set; }
        public static string DublicateRecord { get; set; } = "شناسه تکراری است پس از بررسی مجدداً ثبت کنید ";

        public static string NoSuccessLogin { get; set; } = "شناسه کاربری یا رمز ورود شما اشتباه است ";

        public static string NoComplateForm { get; set; } = "مقادیر فرم را کامل کنید";
        public static  int UserID { get; set;  } 
        /// <summary>
        /// شناسه سال تحصیلی
        /// </summary>
        public static int AcademicYearsID { get; set; }
        /// <summary>
        /// نام سال تحصیلی
        /// </summary>
        public static string YearsName { get; set; }
        /// <summary>
        /// شناسه مدررسه
        /// </summary>
        public static int schoolid { get; set; }


    }
}
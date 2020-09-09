using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;


namespace SchoolApp
{
    public interface ISetupProcess
    {
        /// <summary>
        /// تنظیمات اولیه کاربر مدیر
        /// </summary>
        /// <returns></returns>
        Task<bool> GetAdminUsers();
        /// <summary>
        /// دریافت نام مدرسه - در صورت راه اندازی اولیه مقادیر پیش فرض به صورت اتوماتیک ثبت میشود
        /// </summary>
        /// <returns></returns>
        Task<school> GetSchoolInformation();
        /// <summary>
        /// بروزرسانی مشخصات مدرسه
        /// </summary>
        /// <param name="schoolName">شی مدرسه</param>
        /// <returns></returns>
        Task<bool> ModifySchoolInformation(school schoolName);
        /// <summary>
        /// تایید کاربر
        /// </summary>
        /// <param name="user">کاربری</param>
        /// <param name="pass">رمزعبور</param>
        /// <returns></returns>
        Task<bool> SuccessAccount(string user, string pass);
        /// <summary>
        /// بررسی سال تحصیلی 
        /// </summary>
        /// <returns></returns>
        Task<academic_year> AcadamicYears();
    }

    public class SetupProcess : ISetupProcess
    {
        private readonly schooldbEntities db;
        public SetupProcess(schooldbEntities db)
        {
            this.db = db;
        }
        public async Task<bool> GetAdminUsers()
        {
            var qry = await db.users.FirstOrDefaultAsync(x => x.UserName == "admin");
            if (qry == null)
            {
                var newAdmin = new user()
                {
                    UserName = "admin",
                    FName = "مدیر",
                    LName = "مدرسه",
                    Mobile = "09186620474",
                    Password = "admin"
                };
                db.users.Add(newAdmin);
                var result = await db.SaveChangesAsync();
                return Convert.ToBoolean(result);
            }
            return false;
        }
        public async Task<school> GetSchoolInformation()
        {
            var qry = await db.schools.FirstOrDefaultAsync();
            if (qry == null)
            {
                var newSchool = new school();
                newSchool.SchoolName = "مدارس سما - مدرسه ثبت نشده است";
                newSchool.SchoolAddress = "تهران - مرکز دانشگاه آزاد";
                newSchool.SchoolTel = "02111223344";
                db.schools.Add(newSchool);
                var result = await db.SaveChangesAsync();
                return newSchool;
            }
            return qry;
        }
        public async Task<bool> ModifySchoolInformation(school schoolName)
        {
            try
            {
                db.Entry(schoolName).State = EntityState.Modified;
                var result = await db.SaveChangesAsync();
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> SuccessAccount(string user, string pass)
        {
            var qry = await db.users.SingleOrDefaultAsync(x => x.UserName == user && x.Password == pass);
            if (qry == null)
            {
                return false;
            }
            return true;
        }

        public async Task<academic_year> AcadamicYears()
        {
            var pc = new PersianCalendar();
            var start_years = pc.GetYear(DateTime.Now);
            var finish_years = start_years + 1;
            var years_name = $"{start_years}-{finish_years}";
            var start = new DateTime(start_years, 7, 1, pc);
            var finish = new DateTime(finish_years, 6, 31, pc);
            var qry = await db.academic_year.SingleOrDefaultAsync(x => x.years_start == start);
            if (qry == null)
            {
                var newAcadamic = new academic_year()
                {
                    years_start = start,
                    years_finish = finish,
                    years_name = years_name,
                    enabled = true,
                };
                db.academic_year.Add(newAcadamic);
                db.SaveChangesAsync();
                return newAcadamic;
            }
            return qry;
        }
    }
}
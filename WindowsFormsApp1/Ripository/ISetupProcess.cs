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
        bool GetAdminUsers();
        /// <summary>
        /// دریافت نام مدرسه - در صورت راه اندازی اولیه مقادیر پیش فرض به صورت اتوماتیک ثبت میشود
        /// </summary>
        /// <returns></returns>
        School GetSchoolInformation();
        /// <summary>
        /// بروزرسانی مشخصات مدرسه
        /// </summary>
        /// <param name="schoolName">شی مدرسه</param>
        /// <returns></returns>
        Task<bool> ModifySchoolInformation(School schoolName);
        /// <summary>
        /// تایید کاربر
        /// </summary>
        /// <param name="user">کاربری</param>
        /// <param name="pass">رمزعبور</param>
        /// <returns></returns>
        bool SuccessAccount(string user, string pass);
        /// <summary>
        /// بررسی سال تحصیلی 
        /// </summary>
        /// <returns></returns>
        AcademicYear AcadamicYears();
    }

    public class SetupProcess : ISetupProcess
    {
        private readonly schooldbEntities db;
        public SetupProcess(schooldbEntities db)
        {
            this.db = db;
        }
        public bool GetAdminUsers()
        {
            var qry =  db.Users.FirstOrDefault(x => x.UserName == "admin");
            if (qry == null)
            {
                var newAdmin = new User()
                {
                    UserName = "admin",
                    FName = "مدیر",
                    LName = "مدرسه",
                    Mobile = "09186620474",
                    Password = "admin"
                };
                db.Users.Add(newAdmin);
                var result =  db.SaveChanges();
                return Convert.ToBoolean(result);
            }
            return false;
        }
        public School GetSchoolInformation()
        {
            var qry =  db.Schools.FirstOrDefault();
            if (qry == null)
            {
                var newSchool = new School();
                newSchool.SchoolName = "مدارس سما - مدرسه ثبت نشده است";
                newSchool.SchoolAddress = "تهران - مرکز دانشگاه آزاد";
                newSchool.SchoolTel = "02111223344";
                db.Schools.Add(newSchool);
                var result =  db.SaveChangesAsync();
                return newSchool;
            }
            return qry;
        }
        public async Task<bool> ModifySchoolInformation(School schoolName)
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
        public  bool SuccessAccount(string user, string pass)
        {
            var qry =  db.Users.SingleOrDefaultAsync(x => x.UserName == user && x.Password == pass);
            if (qry != null) return true;
            return false;
        }

        public AcademicYear AcadamicYears()
        {
            var pc = new PersianCalendar();
            var start_years = pc.GetYear(DateTime.Now);
            var finish_years = start_years + 1;
            var years_name = $"{start_years}-{finish_years}";
            var start = new DateTime(start_years, 7, 1, pc);
            var finish = new DateTime(finish_years, 6, 31, pc);
            var qry =  db.AcademicYears.SingleOrDefault(x => x.years_start == start);
            if (qry == null)
            {
                var newAcadamic = new AcademicYear()
                {
                    years_start = start,
                    years_finish = finish,
                    years_name = years_name,
                    enabled = true,
                };
                db.AcademicYears.Add(newAcadamic);
                db.SaveChanges();
                return newAcadamic;
            }
            return qry;
        }
    }
}
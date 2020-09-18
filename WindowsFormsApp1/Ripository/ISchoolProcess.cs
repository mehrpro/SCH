using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp
{
    public interface ISchoolProcess
    {
        /// <summary>
        /// لیست کلاس های مدرسه بر اساس مقطع  تحصیلی
        /// </summary>
        /// <param name="level">مقطع تحصیلی</param>
        /// <returns></returns>
        Task<List<ClassRoom>> GetClassRoomByLevel();
        /// <summary>
        /// ذخیره کلاس درس
        /// </summary>
        /// <param name="classroomItem">شی کلاس درس</param>
        /// <returns></returns>
        Task<bool> ClassRoomCRUD(ClassRoom classroomItem);
        Task<ClassRoom> GetClassroomByClassId(int classID);
        /// <summary>
        /// لیست مقاطع تحصیلی
        /// </summary>
        /// <returns></returns>
        Task<List<ClassLevel>> ListLevelClass();
        /// <summary>
        /// افزودن یا بروزرسانی یک دانش آموز
        /// </summary>
        /// <param name="newstudent">شی دانش آموز</param>
        /// <returns></returns>
        Task<bool> AppendStudent(Student newstudent);
        /// <summary>
        /// لیست دانش آموزان
        /// </summary>
        /// <returns></returns>
        Task<List<Student>> GetAllStudent();
        /// <summary>
        /// انتخاب یک دانش آموز بر اساس شناسه
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <returns></returns>
        Task<Student> GetStudentById(int id);
        /// <summary>
        /// لیست کلاس های فعال
        /// </summary>
        /// <returns></returns>
        Task<List<ViewList_ClassRoom>> GetAllClassRoomByLevel();
        /// <summary>
        /// لیست دانش آموزان مدرسه
        /// </summary>
        /// <returns></returns>
        Task<List<ViewList_Student>> GetAllStudentForComboBox();

        /// <summary>
        /// ثبت دانش آموز در کلاس درس
        /// </summary>
        /// <param name="studentRegistered">شی</param>
        /// <returns></returns>
        bool AppendRegisterdStudent(Registered studentRegistered);

        /// <summary>
        /// لیست دانش آموزان ثبت شده در هر کلاس
        /// </summary>
        /// <param name="classroomId">کلاس درس</param>
        /// <returns></returns>
        Task<List<Registered>> GetRegisterListByClassRoomId(int classroomId);
        /// <summary>
        /// بررسی ثبت نام  دانش آموز 
        /// </summary>
        /// <param name="stidentId"></param>
        /// <returns></returns>
        Task<bool> RegisterdSudent(int stidentId);

        bool DisableRegister(int id);
        /// <summary>
        /// تگ های قابل استفاده
        /// </summary>
        /// <returns></returns>
        Task<List<Tag>> GetAllNoEnabled();

        /// <summary>
        /// وجود تگ فعال برای این دانش آموز
        /// </summary>
        /// <param name="studentId">شناسه دانش آموز</param>
        /// <returns></returns>
        Task<StudentTAG> GetStudentTAGById(int studentId);
        /// <summary>
        /// تغییر کارت دانش آموز
        /// </summary>
        /// <param name="lastID">شناسه  قبلی</param>
        /// <param name="newStudentTag">تگ جدید</param>
        /// <returns></returns>
        Task<bool> ChangeStudentTAG(int lastID, StudentTAG newStudentTag);
        /// <summary>
        /// ثبت کارت جدید برای دانش آموز
        /// </summary>
        /// <param name="studentTag">کارت</param>
        /// <returns></returns>
        Task<bool> AddStudentTAG(StudentTAG studentTag);
    }

    public class SchoolProcess : ISchoolProcess
    {

        private schooldbEntities db;
        public SchoolProcess(schooldbEntities db)
        {
            this.db = db;
        }
        public async Task<List<ClassRoom>> GetClassRoomByLevel()
        {
            return await db.ClassRooms.Where(x => x.ClassRoomEnable).ToListAsync();
        }

        public async Task<bool> ClassRoomCRUD(ClassRoom classroomItem)
        {
            if (classroomItem.ClassID > 0)
            {
                try
                {
                    db.Entry(classroomItem).State = EntityState.Modified;
                    var result = await db.SaveChangesAsync();
                    return Convert.ToBoolean(result);
                }
                catch
                {
                    return false;
                }

            }
            try
            {
                db.ClassRooms.Add(classroomItem);
                var result = await db.SaveChangesAsync();
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false;
            }
        }

        public async Task<ClassRoom> GetClassroomByClassId(int classID)
        {
            return await db.ClassRooms.FindAsync(classID);
        }

        public async Task<List<ClassLevel>> ListLevelClass()
        {
            return await db.ClassLevels.OrderBy(x=>x.ID).ToListAsync();
        }

        public async Task<bool> AppendStudent(Student newstudent)
        {
            if (newstudent.ID > 0)
            {
                try
                {
                    db.Entry(newstudent).State = EntityState.Modified;
                    var result = await db.SaveChangesAsync();
                    return Convert.ToBoolean(result);
                }
                catch
                {
                    return false;
                }
            }
            try
            {
                db.Students.Add(newstudent);
                var result = await db.SaveChangesAsync();
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Student>> GetAllStudent()
        {
            return await db.Students.Where(x=>x.Enabled).ToListAsync();
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await db.Students.FindAsync(id);
        }

        public async Task<List<ViewList_ClassRoom>> GetAllClassRoomByLevel()
        {
            var qry = await db.ClassRooms.Where(x=> x.ClassRoomEnable).ToListAsync();
            var list = new List<ViewList_ClassRoom>();
            foreach (var item in qry)
            {
                list.Add(new ViewList_ClassRoom()
                {
                    شناسه_کلاس = item.ClassID,
                    مقطع_تحصیلی = item.ClassLevel.ClassLevel1,
                    نام_کلاس = item.ClassName,
                });
            }

            return list;
        }

        public async Task<List<ViewList_Student>> GetAllStudentForComboBox()
        {
            var qry = await db.Students.ToListAsync();
            var qryRemoveList = await db.Registereds.Where(x=>x.Enabled).ToListAsync();
            foreach (var itemRemove in qryRemoveList)
            {
                var selectRemove = qry.Find(x => x.ID == itemRemove.School_FK);
                qry.Remove(selectRemove);
            }
            var list = new List<ViewList_Student>();
            foreach (var student in qry)
            {
                var item = new ViewList_Student();
                item.شناسه = student.ID;
                item.نام = student.FullName;
                item.کدملی = student.StudentNatinalCode;
                item.متولد = student.BrithDate.ConvertDateToPersian();
                item.نام_پدر = student.FatherName;
                list.Add(item);
            }



            return list;
        }

        public  bool AppendRegisterdStudent(Registered studentRegistered)
        {
            try
            {
                db.Registereds.Add(studentRegistered);
                  db.SaveChanges();
                  return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Registered>> GetRegisterListByClassRoomId(int classroomId)
        {
            var qry = await db.Registereds.Where(x => x.Class_FK == classroomId && x.Enabled).ToListAsync();
            return qry;
        }

        public async Task<bool> RegisterdSudent(int stidentId)
        {
            return  await db.Registereds.AnyAsync(x => x.Student_FK == stidentId);
        }

        public bool DisableRegister(int id)
        {
            try
            {
                var sele= db.Registereds.Find(id);
                sele.Enabled = false;
                db.Entry(sele).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<List<Tag>> GetAllNoEnabled()
        {
            return await db.Tags.Where(x => x.DeleteTAG == false && x.Enabled == false).ToListAsync();
        }

        public async Task<StudentTAG> GetStudentTAGById(int studentId)
        {
            return await db.StudentTAGs.SingleOrDefaultAsync(x => x.Student_FK == studentId && x.Enabled);
        }

        public async Task<bool> ChangeStudentTAG(int lastID, StudentTAG newStudentTag)
        {
            try
            {
                var studentTag = db.StudentTAGs.Find(lastID);
                studentTag.Enabled = false;
                var tag = db.Tags.Find(studentTag.Tag.ID);
                tag.DeleteTAG = true;
                tag.Enabled = true;
                db.StudentTAGs.Add(newStudentTag);
                await db.SaveChangesAsync();
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public async Task<bool> AddStudentTAG(StudentTAG studentTag)
        {
            try
            {
                var tag = db.Tags.Find(studentTag.TagID_FK);
                tag.Enabled = true;
                db.StudentTAGs.Add(studentTag);
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class ViewList_ClassRoom
    {
        public int شناسه_کلاس { get; set; }
        public string مقطع_تحصیلی { get; set; }
        public string نام_کلاس { get; set; }
    }

    public class ViewList_Student
    {
        public int شناسه { get; set; }
        public string   نام { get; set; }
        public string کدملی { get; set; }
        public string  متولد { get; set; }
        public string نام_پدر { get; set; }
    }
}



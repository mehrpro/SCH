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
        Task<List<classroom>> GetClassRoomByLevel(SByte level);
        /// <summary>
        /// ذخیره کلاس درس
        /// </summary>
        /// <param name="classroomItem">شی کلاس درس</param>
        /// <returns></returns>
        Task<bool> ClassRoomCRUD(classroom classroomItem);
        Task<classroom> GetClassroomByClassId(int classID);
        /// <summary>
        /// لیست مقاطع تحصیلی
        /// </summary>
        /// <returns></returns>
        Task<List<classlevel>> ListLevelClass();
        /// <summary>
        /// افزودن یا بروزرسانی یک دانش آموز
        /// </summary>
        /// <param name="newstudent">شی دانش آموز</param>
        /// <returns></returns>
        Task<bool> AppendStudent(student newstudent);
        /// <summary>
        /// لیست دانش آموزان
        /// </summary>
        /// <returns></returns>
        Task<List<student>> GetAllStudent();
        /// <summary>
        /// انتخاب یک دانش آموز بر اساس شناسه
        /// </summary>
        /// <param name="id">شناسه</param>
        /// <returns></returns>
        Task<student> GetStudentById(long id);
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
        Task<bool> AppendRegisterdStudent(registered studentRegistered);

        /// <summary>
        /// لیست دانش آموزان ثبت شده در هر کلاس
        /// </summary>
        /// <param name="classroomId">کلاس درس</param>
        /// <returns></returns>
        Task<List<registered>> GetRegisterListByClassRoomId(byte classroomId);
        /// <summary>
        /// بررسی ثبت نام  دانش آموز 
        /// </summary>
        /// <param name="stidentId"></param>
        /// <returns></returns>
        Task<bool> RegisterdSudent(long stidentId);
    }

    public class SchoolProcess : ISchoolProcess
    {

        private schooldbEntities db;
        public SchoolProcess(schooldbEntities db)
        {
            this.db = db;
        }
        public async Task<List<classroom>> GetClassRoomByLevel(SByte level)
        {
            return await db.classrooms.Where(x => x.ClassLevel == level).ToListAsync();
        }

        public async Task<bool> ClassRoomCRUD(classroom classroomItem)
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
                db.classrooms.Add(classroomItem);
                var result = await db.SaveChangesAsync();
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false;
            }
        }

        public async Task<classroom> GetClassroomByClassId(int classID)
        {
            return await db.classrooms.FindAsync(classID);
        }

        public async Task<List<classlevel>> ListLevelClass()
        {
            return await db.classlevels.OrderBy(x=>x.ID).ToListAsync();
        }

        public async Task<bool> AppendStudent(student newstudent)
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
                db.students.Add(newstudent);
                var result = await db.SaveChangesAsync();
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<student>> GetAllStudent()
        {
            return await db.students.ToListAsync();
        }

        public async Task<student> GetStudentById(long id)
        {
            return await db.students.FindAsync(id);
        }

        public async Task<List<ViewList_ClassRoom>> GetAllClassRoomByLevel()
        {
            var qry = await db.classrooms.ToListAsync();
            var list = new List<ViewList_ClassRoom>();
            foreach (var item in qry)
            {
                list.Add(new ViewList_ClassRoom()
                {
                    شناسه_کلاس = item.ClassID,
                    مقطع_تحصیلی = item.classlevel1.ClassLevel1,
                    نام_کلاس = item.ClassName,
                });
            }

            return list;
        }

        public async Task<List<ViewList_Student>> GetAllStudentForComboBox()
        {
            var qry = await db.students.ToListAsync();
            var list = new List<ViewList_Student>();
            foreach (var student in qry)
            {
                var item = new ViewList_Student();
                item.شناسه = student.ID;
                item.نام = student.FullName;
                item.کدملی = student.StudentNatinalCode;
                item.متولد = student.BrithDate.Value.ConvertDateToPersian();
                item.نام_پدر = student.FatherName;
                list.Add(item);
            }

            return list;
        }

        public async Task<bool> AppendRegisterdStudent(registered studentRegistered)
        {
            if (studentRegistered.id > 0)
            {
                try
                {
                    db.Entry(studentRegistered).State = EntityState.Modified;
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
                db.registereds.Add(studentRegistered);
                var result = await db.SaveChangesAsync();
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<registered>> GetRegisterListByClassRoomId(byte classroomId)
        {
            var qry = await db.registereds.Where(x => x.class_fk == classroomId).ToListAsync();
            return qry;
        }

        public async Task<bool> RegisterdSudent(long stidentId)
        {
            return  await db.registereds.AnyAsync(x => x.student_fk == stidentId);
        }
    }

    public class ViewList_ClassRoom
    {
        public byte شناسه_کلاس { get; set; }
        public string مقطع_تحصیلی { get; set; }
        public string نام_کلاس { get; set; }
    }

    public class ViewList_Student
    {
        public long شناسه { get; set; }
        public string   نام { get; set; }
        public string کدملی { get; set; }
        public string  متولد { get; set; }
        public string نام_پدر { get; set; }
    }
}



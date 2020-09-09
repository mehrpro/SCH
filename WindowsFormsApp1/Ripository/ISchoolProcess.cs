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
    }
}



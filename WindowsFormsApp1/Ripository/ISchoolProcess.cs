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
        Task<List<classroom>> GetClassRoomByLevel(string level);
        /// <summary>
        /// ذخیره کلاس درس
        /// </summary>
        /// <param name="classroomItem">شی کلاس درس</param>
        /// <returns></returns>
        Task<bool> ClassRoomCRUD(classroom classroomItem);

        Task<classroom> GetClassroomByClassId(int classID);
    }

    public class SchoolProcess : ISchoolProcess
    {
        private schooldbEntities db;
        public SchoolProcess(schooldbEntities db)
        {
            this.db = db;
        }
        public async Task<List<classroom>> GetClassRoomByLevel(string level)
        {
            return await db.classrooms.Where(x => x.ClassLevel == level).ToListAsync();
        }

        public async Task<bool> ClassRoomCRUD(classroom classroomItem)
        {
            if (classroomItem.ClassID >0)
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
                var result =await db.SaveChangesAsync();
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
    }
}

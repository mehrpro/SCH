using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.Frames;

namespace SchoolApp
{
    public interface IRfid_Class
    {
        /// <summary>
        /// بررسی تکراری بودن تگ
        /// </summary>
        /// <param name="string_tagid">شناسه تگ </param>
        /// <returns></returns>
        Task<Tag> GetRFID_ByTagID(string string_tagid);

        Task<bool> AddNewTagCard(Tag tagCard);
        /// <summary>
        /// لیست جدید تگ ها
        /// </summary>
        /// <returns></returns>
        Task<List<string>> GetNewTags();

    }

    public class RfidClass : IRfid_Class
    {
        private readonly schooldbEntities db;
        public RfidClass(schooldbEntities db)
        {
            this.db = db;
        }
        public async Task<Tag> GetRFID_ByTagID(string string_tagid)
        {
            return await db.Tags.SingleOrDefaultAsync(x => x.TagID_HEX == string_tagid);
        }

        public async Task<bool> AddNewTagCard(Tag tagCard)
        {
            try
            {
                db.Tags.Add(tagCard);
                var result = await db.SaveChangesAsync();
                return Convert.ToBoolean(result);
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<string>> GetNewTags()
        {
            var resultRemove =  db.Tags.Select(x => x.TagID_HEX).ToList();
            var qry =  db.TagRecorders.Select(x => x.TagID).ToList();
            var result = RemoveDuplicates(qry);
            resultRemove.RemoveAll(item => result.Contains(item));
            return result;
        }
        private static List<T> RemoveDuplicates<T>(List<T> items)
        {
            return (from s in items select s).Distinct().ToList();
        }
    }
}
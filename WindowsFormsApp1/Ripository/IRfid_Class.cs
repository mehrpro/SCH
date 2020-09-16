using System;
using System.Data.Entity;
using System.Threading.Tasks;
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
            catch (Exception e)
            {
                return false;
            }
        }
   }
}
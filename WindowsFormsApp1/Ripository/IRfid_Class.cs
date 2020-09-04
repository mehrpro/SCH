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
        Task<tagid> GetRFID_ByTagID(string string_tagid);

        Task<bool> AddNewTagCard(tagid tagCard);
    }

   public class RfidClass : IRfid_Class
   {
       private readonly schooldbEntities db;
        public RfidClass(schooldbEntities db)
        {
            this.db = db;
        }
        public async Task<tagid> GetRFID_ByTagID(string string_tagid)
        {
            return await db.tagids.SingleOrDefaultAsync(x => x.tagid_hex == string_tagid);
        }

        public async Task<bool> AddNewTagCard(tagid tagCard)
        {
            try
            {
                db.tagids.Add(tagCard);
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
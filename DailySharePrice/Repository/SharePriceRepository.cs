using DailySharePrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Repository
{
    public class SharePriceRepository:ISharePriceRepository
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(SharePriceRepository));

        private readonly SharePriceContext db;
        public SharePriceRepository(SharePriceContext _db)
        {
            db = _db;
        }
        public DailyStockDetails GetShareByNameRepository(string shareName)
        {
            DailyStockDetails shareData = null;
            
            shareData= db.DailyStockDetails.Where(x => x.StockName == shareName).FirstOrDefault();
            return shareData;
        }
        public List <DailyStockDetails> GetAllstocks()
        {
            return db.DailyStockDetails.ToList();
        }
        
    }
}

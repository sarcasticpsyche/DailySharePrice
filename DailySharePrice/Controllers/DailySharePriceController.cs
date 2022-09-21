using DailySharePrice.Models;
using DailySharePrice.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailySharePriceController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(DailySharePriceController));
        private readonly ISharePriceRepository sharePriceRepository;
        public DailySharePriceController(ISharePriceRepository _sharePriceRepository)
        {
            _log4net.Info("DailySharePriceController Initiated");
            sharePriceRepository = _sharePriceRepository;
        }
        [HttpGet]
        [Route("stockname")]
        public IActionResult GetStockByName(string stockname)
        {
            try
            {
                _log4net.Info("In DailySharePrice Controller, HttpGet GetStockByName and " + stockname + " is searched");
                if (stockname == null)
                {
                    _log4net.Info("DailySharePriceController Null Name");
                    return BadRequest("Null or Empty Name is passed");
                }
                _log4net.Info("In DailySharePrice Controller, " + stockname + " is searched");
                var shareData = sharePriceRepository.GetShareByNameRepository(stockname);
                if (shareData == null)
                {
                    _log4net.Info(stockname + " is invalid StockName.");
                    return BadRequest("Invalid Stock Name");
                }
                else
                {
                    _log4net.Info(stockname + " Stock Found.");
                    return Ok(shareData);
                }
            }
            catch (Exception exception)
            {
                _log4net.Error("Exception Found=" + exception.Message);
                return new StatusCodeResult(500);
            }
        }
        [HttpGet]
        public ActionResult GetAllStocks()
        {
            var l = sharePriceRepository.GetAllstocks();
            return Ok(l);
        }
    }
}

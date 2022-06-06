using code_test_api.Models;
using code_test_api.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace code_test_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        private DataSourceService DataSourceService;
        public PriceController()
        {
            DataSourceService = new DataSourceService();
        }

        [HttpGet("price-source")]
        public IEnumerable<LookUps> GetPriceSorces()
        {
            return DataSourceService.GetPriceSources();
        }

        [HttpGet("ticker")]
        public IEnumerable<LookUps> GetTicker()
        {
            return DataSourceService.GetTickers();
        }

        [HttpGet("price-details")]
        public IEnumerable<PriceDetails> GetPriceDetails(int priceId, int tickerId)
        {
            return DataSourceService.GetPriceDetails(priceId, tickerId);
        }
    }
}

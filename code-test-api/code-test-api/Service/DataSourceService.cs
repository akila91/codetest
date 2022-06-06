using code_test_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_test_api.Service
{
    public class DataSourceService
    {
        readonly List<LookUps> priceSources = new List<LookUps>();
        readonly List<LookUps> tickers = new List<LookUps>();
        readonly List<PriceDetails> priceDetails = new List<PriceDetails>();
        public DataSourceService()
        {
            priceSources.Add(new LookUps() { Id = 1, Key = "SRC2" });
            priceSources.Add(new LookUps() { Id = 2, Key = "SRC1" });
            tickers.Add(new LookUps() { Id = 1, Key = "IBM UN" });
            tickers.Add(new LookUps() { Id = 2, Key = "UN" });
            priceDetails.Add(new PriceDetails { Pice = 139.87, Ticker = 1, PriceSorce = 1, Time = new DateTime(2022, 06, 01).AddMinutes(4) });
            priceDetails.Add(new PriceDetails { Pice = 139.81, Ticker = 1, PriceSorce = 1, Time = new DateTime(2022, 06, 01).AddMinutes(3) });
            priceDetails.Add(new PriceDetails { Pice = 139.95, Ticker = 1, PriceSorce = 1, Time = new DateTime(2022, 06, 01).AddMinutes(2) });
            priceDetails.Add(new PriceDetails { Pice = 139.24, Ticker = 1, PriceSorce = 1, Time = new DateTime(2022, 06, 01).AddMinutes(1) });
            priceDetails.Add(new PriceDetails { Pice = 139.33, Ticker = 1, PriceSorce = 1, Time = new DateTime(2022, 06, 01) });
        }

        public List<LookUps> GetPriceSources()
        {
            return priceSources;
        }

        public List<LookUps> GetTickers()
        {
            return tickers;
        }

        public List<PriceDetails> GetPriceDetails(int priceId, int tickerId )
        {
            return priceDetails.Where(x=>x.PriceSorce == priceId && x.Ticker == tickerId).ToList();
        }
    }
}

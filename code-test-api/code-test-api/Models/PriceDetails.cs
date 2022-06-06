using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_test_api.Models
{
    public class PriceDetails
    {
        public int PriceSorce { get; set; }
        public int Ticker { get; set; }
        public double Pice { get; set; }
        public DateTime Time { get; set; }
    }
}

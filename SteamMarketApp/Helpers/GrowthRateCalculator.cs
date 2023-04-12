using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Helpers
{
    public static class GrowthRateCalculator
    {
        public static double Calculate(IEnumerable<double> prices)
        {
            var sortedPrices = prices.OrderBy(x => x).ToList();
            int middleIndex = sortedPrices.Count / 2;
            double median = (sortedPrices.Count % 2 != 0) ? sortedPrices[middleIndex] : (sortedPrices[middleIndex] + sortedPrices[middleIndex - 1]) / 2;

            Func<double,bool> predicate = x => 
            { 
                var coef = x / median;
                return coef > 0.01 && coef < 100;
            };
            return prices.Last(predicate) / prices.First(predicate) - 1;
        }
    }
}

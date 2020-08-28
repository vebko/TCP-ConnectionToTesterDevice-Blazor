using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebView.Data
{
    public class AmountService
    {
        public Task<double[]> GetAmountAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 6).Select(index => Math.Round(rng.NextDouble()*1000,2)).ToArray());
        }
    }
}

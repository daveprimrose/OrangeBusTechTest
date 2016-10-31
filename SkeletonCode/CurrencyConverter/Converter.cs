using System;
using System.Collections.Generic;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{
	    public Dictionary<string, decimal> CurrenyRates { get; set; }

	    public Converter()
	    {
            CurrenyRates = new Dictionary<string, decimal>()
            {
                ["GBP"] = 1m,
                ["USD"] = 1.25m
            };
	    }

		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
		    decimal? inputRate = null;
		    decimal? outputRate = null;
            
		    foreach (var currency in CurrenyRates)
		    {
		        if (inputCurrency == currency.Key)
		            inputRate = currency.Value;
                if (outputCurrency == currency.Key)
                    outputRate = currency.Value;
            }
            if (inputRate == null || outputRate == null)
                throw new Exception("Currency not found");

		    amount = (amount * outputRate.Value) / inputRate.Value;
            return amount;
		}
	}
}

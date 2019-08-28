using System;

namespace Patterns.Examples.Facade.Services
{
    class MarketClient
    {
        public bool BuyProduct(string product, int units)
        {
            return new Random().Next(6) != 0;
        }
    }
}
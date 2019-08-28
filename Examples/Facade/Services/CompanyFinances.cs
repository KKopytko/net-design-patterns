using System;

namespace Patterns.Examples.Facade.Services
{
    class CompanyFinances
    {
        public bool CanAffordToSpend(decimal amountOfMoney)
        {
            return new Random().Next(6) != 0;
        }
    }
}
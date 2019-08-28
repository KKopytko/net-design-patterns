using System;
using Patterns.Examples.Facade.Services;

namespace Patterns.Examples.Facade
{
    [Flags]
    enum OrderResult
    {
        Success = 0,
        Fail    = 1,
        NotEnoughMoney = Fail | 2,
        AlreadyHaveEnoughUnits = Fail | 4,
        ProductIsNotAvailableToBuy = Fail | 8,
        NotEnoughSpace = Fail | 16
    }

    class Warehouse
    {
        // Of course these dependencies should have been injected in constructor!
        CompanyFinances companyFinances = new CompanyFinances();
        MarketClient marketClient = new MarketClient();
        WarehouseVirtualShelves warehouseVirtualShelves = new WarehouseVirtualShelves();

        public OrderResult OrderProduct(Product product, int desiredAmount)
        {
            if (!warehouseVirtualShelves.DoWeHaveAlreadyEnough(product, desiredAmount))
            {
                return OrderResult.AlreadyHaveEnoughUnits;
            }

            var unitsToBuy = desiredAmount - product.Units;
            if (!warehouseVirtualShelves.DoWeHaveSpaceFor(product, unitsToBuy))
            {
                return OrderResult.NotEnoughSpace;
            }

            var amountToSpend = unitsToBuy * product.UnitPrice;
            if (!companyFinances.CanAffordToSpend(amountToSpend))
            {
                return OrderResult.NotEnoughMoney;
            }

            if (!marketClient.BuyProduct(product.Name, unitsToBuy))
            {
                return OrderResult.ProductIsNotAvailableToBuy;
            }

            return OrderResult.Success;
        }
    }
}
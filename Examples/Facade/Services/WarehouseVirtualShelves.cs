using System;

namespace Patterns.Examples.Facade.Services
{
    class WarehouseVirtualShelves
    {
        public bool DoWeHaveAlreadyEnough(Product product, int desiredAmount)
        {
            return new Random().Next(6) != 0;
        }

        public bool DoWeHaveSpaceFor(Product product, int desiredAmount)
        {
            return new Random().Next(6) != 0;
        }
    }
}
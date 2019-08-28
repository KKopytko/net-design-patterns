using System;

namespace Patterns.Examples.Facade
{
    public class FacadeExample : IRunnableExample
    {
        public string Name => "Facade";

        public void Run()
        {
            var product = new Product("Fish", 30, 6.55M);

            var warehouse = new Warehouse();
            
            var orderReslt = warehouse.OrderProduct(product, 50);

            Console.WriteLine($"Warehouse replied with message: {orderReslt.ToString()}");
        }
    }
}
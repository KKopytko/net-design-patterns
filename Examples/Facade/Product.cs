namespace Patterns.Examples.Facade
{
    class Product
    {
        public string Name { get; private set; }
        public int Units { get; set; }
        public decimal UnitPrice { get; private set; }

        public Product(string name, int units, decimal unitPrice)
        {
            Name = name;
            Units = units;
            UnitPrice = unitPrice;
        }
    }
}
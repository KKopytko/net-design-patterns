namespace Patterns.Examples.AbstractFactory
{
    class AbstractFactoryExample : IRunnableExample
    {
        public string Name => "Abstract factory";

        public void Run()
        {
            BMWFactory factory = new E36();
            Order order = new Order(factory);
            order.InstallParts();

            factory = new X6();
            order = new Order(factory);
            order.InstallParts();
        }
    }
}
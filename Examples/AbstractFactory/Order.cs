namespace Patterns.Examples.AbstractFactory
{
    class Order
    {
        private Window window;
        private Body body;

        public Order(BMWFactory factory)
        {
            window = factory.CreateWindow();
            body = factory.CreateBody();
        }

        public void InstallParts()
        {
            body.InstallWindow(window);
        }
    }
}
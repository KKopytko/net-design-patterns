namespace Patterns.Examples.AbstractFactory
{
    class X6 : BMWFactory
    {
        public override Body CreateBody() => new SUV();

        public override Window CreateWindow() => new ElectricWindow();
    }
}
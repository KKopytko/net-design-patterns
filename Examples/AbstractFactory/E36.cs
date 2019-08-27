namespace Patterns.Examples.AbstractFactory
{
    class E36 : BMWFactory
    {
        public override Body CreateBody() => new RectangularBody();

        public override Window CreateWindow() => new ManualWindows();
    }
}
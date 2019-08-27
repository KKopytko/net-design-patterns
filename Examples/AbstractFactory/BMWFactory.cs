namespace Patterns.Examples.AbstractFactory
{
    abstract class BMWFactory
    {
        public abstract Body CreateBody();
        public abstract Window CreateWindow();
    }
}
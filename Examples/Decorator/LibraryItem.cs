namespace Patterns.Examples.Decorator
{
    abstract class LibraryItem
    {
        public int NumberOfCopies { get; set; }

        public abstract void PresentInfo();
    }
}
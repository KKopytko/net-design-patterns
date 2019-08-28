namespace Patterns.Examples.Decorator
{
    class LibraryItemDecorator : LibraryItem
    {
        protected readonly LibraryItem libraryItem;

        public LibraryItemDecorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void PresentInfo()
        {
            libraryItem.PresentInfo();
        }
    }
}
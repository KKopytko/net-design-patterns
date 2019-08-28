using System;

namespace Patterns.Examples.Decorator
{
    class Book : LibraryItem
    {
        public string Author { get; private set; }
        public string Title { get; private set; }

        public Book(string author, string title, int numberOfCopies)
        {
            Author = author;
            Title = title;
            NumberOfCopies = numberOfCopies;
        }

        public override void PresentInfo()
        {
            var info = $"[Book]\n  Author: {Author}\n  Title: {Title}\n  Copies: {NumberOfCopies}";
            
            Console.WriteLine(info);
        }
    }
}
using System;

namespace Patterns.Examples.Decorator
{
    class Video : LibraryItem
    {
        public string Director { get; private set; }
        public string Title { get; private set; }
        public int LengthInMinutes { get; private set; }

        public Video(string director, string title, int lengthInMinutes, int numberOfCopies)
        {
            Director = director;
            Title = title;
            LengthInMinutes = lengthInMinutes;
            NumberOfCopies = numberOfCopies;
        }

        public override void PresentInfo()
        {
            var info = $"[Video]\n  Director: {Director}\n  Title: {Title}\n  Playtime: {LengthInMinutes}\n  Copies: {NumberOfCopies}";
            
            Console.WriteLine(info);
        }
    }
}
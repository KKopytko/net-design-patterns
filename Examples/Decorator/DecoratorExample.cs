namespace Patterns.Examples.Decorator
{
    public class DecoratorExample : IRunnableExample
    {
        public string Name => "Decorator";

        public void Run()
        {
            var book = new Book("Jonas", "Deep space", 3);
            var video = new Video("Andrej Jasky", "Final wood", 240, 7);

            var borrowableVideo = new Borrowable(video);
            borrowableVideo.Borrow("Stefan");
            borrowableVideo.Borrow("Michael");
            
            borrowableVideo.Return("Stefan");

            borrowableVideo.PresentInfo();
        }
    }
}
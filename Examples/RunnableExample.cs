using System.Text.RegularExpressions;

namespace Patterns.Examples
{
    abstract class RunnableExample
    {
        public string Name => Regex.Replace(GetType().Name.Replace("Example", ""), "[A-Z]", " $0").Trim();

        public abstract void Run();
    }
}
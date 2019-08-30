using System.Collections.Generic;

namespace Patterns.Examples.Strategy
{
    class FirstInFirstOut : QueueStrategy
    {
        public override void Add(LinkedList<string> list, string person)
        {
            list.AddLast(person);
        }
    }
}
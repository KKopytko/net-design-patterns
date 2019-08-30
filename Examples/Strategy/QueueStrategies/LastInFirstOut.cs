using System.Collections.Generic;

namespace Patterns.Examples.Strategy
{
    class LastInFirstOut : QueueStrategy
    {
        public override void Add(LinkedList<string> list, string person)
        {
            list.AddFirst(person);
        }
    }
}
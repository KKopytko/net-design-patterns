using System.Collections.Generic;

namespace Patterns.Examples.Strategy
{
    abstract class QueueStrategy
    {
        public abstract void Add(LinkedList<string> list, string person);
        public string Pop(LinkedList<string> list)
        {
            if (list.Count == 0)
            {
                return null;
            }

            var person = list.Last.Value;
            list.RemoveLast();

            return person;
        }
    }
}
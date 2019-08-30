using System;

namespace Patterns.Examples.Strategy
{
    class StrategyExample : RunnableExample
    {
        public override void Run()
        {
            var queuedList = new QueuedList();
            
            queuedList.SetQueueStrategy(new FirstInFirstOut());
            queuedList.Add("Andrzej");
            queuedList.Add("Bartosz");
            queuedList.Pop();
            queuedList.Add("Cezary");
            
            queuedList.Clear();

            queuedList.SetQueueStrategy(new LastInFirstOut());
            queuedList.Add("Andrzej");
            queuedList.Add("Bartosz");
            queuedList.Pop();
            queuedList.Add("Cezary");
        }
    }
}
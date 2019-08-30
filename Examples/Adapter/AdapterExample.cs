using System;

namespace Patterns.Examples.Adapter
{
    class AdapterExample : RunnableExample
    {
        public override void Run()
        {
            WorkPlanner planner = new AdvancedWorkPlanner();
            planner.Add(new DateTime(2019, 05, 02));
            planner.Add(new DateTime(2019, 01, 06));
            planner.Add(new DateTime(2020, 07, 03));
            planner.Add(new DateTime(2019, 11, 11));

            foreach(var dayLine in planner.FormattedTimeTable())
            {
                Console.WriteLine(dayLine);
            }
        }
    }
}
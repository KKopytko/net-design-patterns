using System;
using System.Collections.Generic;

namespace Patterns.Examples.Adapter
{
    public class WorkPlanner
    {
        // private for purpose. This "library" must have poor functionality and extendability.
        private SortedSet<DateTime> workDays = new SortedSet<DateTime>();

        public WorkPlanner()
        {
        }

        public void Add(DateTime day)
        {
            workDays.Add(day);
        }

        public virtual IEnumerable<string> FormattedTimeTable()
        {
            foreach(var workDay in workDays)
            {
                yield return workDay.ToShortDateString();
            }
        }
    }
}
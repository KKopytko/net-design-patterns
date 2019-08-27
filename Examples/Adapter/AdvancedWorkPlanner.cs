using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Examples.Adapter
{
    public class AdvancedWorkPlanner : WorkPlanner
    {
        private PublicHolidaysRepository publicHolidays = new PublicHolidaysRepository();

        public override IEnumerable<string> FormattedTimeTable()
        {
            foreach(var stringDay in base.FormattedTimeTable())
            {
                var day = DateTime.Parse(stringDay);
                
                var stringBuilder = new StringBuilder(stringDay);

                var holiday = publicHolidays.GetHolidayAt(day);
                if (holiday != null)
                {
                    stringBuilder.Append($" | It's holiday: {holiday}");
                }

                var isWeekend = (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday);
                if (isWeekend)
                {
                    stringBuilder.Append($" | It's weekend: ({day.DayOfWeek.ToString()})");
                }

                yield return stringBuilder.ToString();
            }
        }
    }
}
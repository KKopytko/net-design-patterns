using System;
using System.Collections.Generic;

namespace Patterns.Examples.Adapter
{
    public class PublicHolidaysRepository
    {
        private static readonly IDictionary<DateTime, string> holidays;

        static PublicHolidaysRepository()
        {
            holidays = new Dictionary<DateTime, string>
            {
                { new DateTime(2019, 01, 01), "Nowy Rok" },
                { new DateTime(2019, 01, 06), "Trzech Króli" },
                { new DateTime(2019, 04, 21), "Wielkanoc" },
                { new DateTime(2019, 04, 22), "Poniedziałek Wielkanocny" },
                { new DateTime(2019, 05, 01), "Święto Pracy" },
                { new DateTime(2019, 05, 03), "Święto Konstytucji 3 Maja" },
                { new DateTime(2019, 06, 09), "Zesłanie Ducha Świętego" },
                { new DateTime(2019, 06, 20), "Boże Ciało" },
                { new DateTime(2019, 08, 15), "Święto Wojska Polskiego" },
                { new DateTime(2019, 11, 01), "Wszystkich Świętych" },
                { new DateTime(2019, 11, 11), "Święto Niepodległości" },
                { new DateTime(2019, 12, 25), "Boże Narodzenie" },
                { new DateTime(2019, 12 ,26), "Boże Narodzenie" },
            };
        }

        public string GetHolidayAt(DateTime date)
        {
            string holidayName;
            if (holidays.TryGetValue(date, out holidayName)) {
                return holidayName;
            }

            return null;
        }
    }
}
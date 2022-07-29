using System.Collections.Generic;

namespace Task6.Models
{
    public class WeekService: IDay
    {
        private List<string> days = new List<string>
        {
        "Sunday",
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
        };

        public List<string> GetDays() => days;
    }
}

using System.Collections.Generic;

namespace Task6.Models
{
    public class MonthService : IMonth
    {
        private List<string> months = new List<string>
        {
        "January",
        "February",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December",
        };

        public List<string> GetMonths() => months;
    }
}

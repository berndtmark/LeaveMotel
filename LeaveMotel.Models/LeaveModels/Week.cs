using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveMotel.Models.LeaveModels
{
    public class Week
    {
        public Week()
        {
            Day = new List<Day>();
        }

        public int WeekNumber { get; set; }

        public IList<Day> Day { get; set; }
    }
}

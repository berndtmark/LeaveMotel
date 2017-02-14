using LeaveMotel.Models.Enums;
using LeaveMotel.Models.LeaveModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LeaveMotel.BusinessLayer.LeaveFactory
{
    public abstract class LMCalandar
    {
        Calendar cal = CultureInfo.InvariantCulture.Calendar;

        public LMCalandar(int year, MonthName startMonth)
        {
            Months = new List<Month>();

            GenerateCalandar(year, startMonth);
        }

        public IList<Month> Months { get; set; }

        public Month CurrentMonth
        {
            get
            {
                return Months.First();
            }
        }

        public abstract void GenerateCalandar(int year, MonthName startMonth);

        protected Month GetMonth(DateTime date)
        {
            var month = new Month();
            var weeks = new List<Week>();

            while (!IsLastDayOfMonth(date))
            {
                var week = new Week();
                var initialWeekNumber = cal.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                var weekNumber = initialWeekNumber;

                while (weekNumber == initialWeekNumber)
                {
                    var day = new Day()
                    {
                        Name = cal.GetDayOfWeek(date),
                        DayNumber = cal.GetDayOfMonth(date)
                    };

                    week.WeekNumber = weekNumber;
                    week.Day.Add(day);

                    if (IsLastDayOfMonth(date))
                    {
                        break;
                    }

                    date = date.AddDays(1);
                    weekNumber = cal.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);
                }

                weeks.Add(week);
            }

            month.Weeks = weeks;
            return month;
        }

        private bool IsLastDayOfMonth(DateTime date)
        {
            return cal.GetDaysInMonth(date.Year, date.Month) == cal.GetDayOfMonth(date);
        }
    }
}

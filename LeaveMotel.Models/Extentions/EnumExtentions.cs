using LeaveMotel.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveMotel.Models.Extentions
{
    public static class EnumExtentions
    {
        public static MonthName Next(this MonthName month)
        {
            var nextMonth = (int)month + 1;

            return nextMonth == 13 ? MonthName.January : (MonthName)nextMonth;
        }
    }
}

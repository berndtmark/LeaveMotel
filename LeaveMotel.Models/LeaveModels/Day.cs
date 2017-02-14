using LeaveMotel.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveMotel.Models.LeaveModels
{
    public class Day
    {
        public DayOfWeek Name { get; set; }

        public int DayNumber { get; set; }

        public LeaveType LeaveType { get; set; }

        public bool IsWorkDay
        {
            get
            {
                return (Name != DayOfWeek.Saturday || Name != DayOfWeek.Sunday) && LeaveType == LeaveType.None;
            }
        }

    }
}

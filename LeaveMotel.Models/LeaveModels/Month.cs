using LeaveMotel.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveMotel.Models.LeaveModels
{
    public class Month
    {
        public Month()
        {
            Weeks = new List<Week>();
        }

        public string Name { get; set; }

        public IList<Week> Weeks { get; set; }
    }
}

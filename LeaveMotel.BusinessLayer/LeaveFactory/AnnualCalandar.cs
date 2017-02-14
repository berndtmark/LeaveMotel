using System;
using System.Collections.Generic;
using System.Text;
using LeaveMotel.Models.Enums;
using LeaveMotel.Models.LeaveModels;

namespace LeaveMotel.BusinessLayer.LeaveFactory
{
    public class AnnualCalandar : LMCalandar
    {
        private const int duration = 12;

        public AnnualCalandar(int year, MonthName startMonth) : base(year, startMonth)
        {
        }

        public override void GenerateCalandar(int year, MonthName startMonth)
        {
            var date = new DateTime(year, (int)startMonth, 1);

            for (int m = 1; m <= duration; m++)
            {
                var month = GetMonth(date);

                Months.Add(month);
            }
        }
    }
}

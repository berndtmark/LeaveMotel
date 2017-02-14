using System;
using System.Collections.Generic;
using System.Text;
using LeaveMotel.Models.Enums;

namespace LeaveMotel.BusinessLayer.LeaveFactory
{
    public class CurrentLeaveCalandar : CalandarCreator
    {
        public override LMCalandar Create(CalandarType calandar)
        {
            var currentDateTime = DateTime.Now;

            switch (calandar)
            {
                case CalandarType.Annual:
                    return new AnnualCalandar(currentDateTime.Year, (MonthName)currentDateTime.Month);
 
                case CalandarType.Month:
                    return new MonthCalandar(currentDateTime.Year, (MonthName)currentDateTime.Month);
                    
                default:
                    throw new NotImplementedException();
            }
        }
    }
}

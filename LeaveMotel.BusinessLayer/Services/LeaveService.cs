using LeaveMotel.BusinessLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using LeaveMotel.Models.Enums;
using LeaveMotel.Models.LeaveModels;
using System.Globalization;
using LeaveMotel.BusinessLayer.LeaveFactory;

namespace LeaveMotel.BusinessLayer.Services
{
    public class LeaveService : ILeaveService
    {
        public LMCalandar GetLeaveCalandar(int year, MonthName month)
        {
            throw new NotImplementedException();
        }
    }
}

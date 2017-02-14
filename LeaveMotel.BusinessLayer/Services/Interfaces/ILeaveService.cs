using LeaveMotel.BusinessLayer.LeaveFactory;
using LeaveMotel.Models.Enums;
using LeaveMotel.Models.LeaveModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveMotel.BusinessLayer.Services.Interfaces
{
    public interface ILeaveService
    {
        LMCalandar GetLeaveCalandar(int year, MonthName month);
    }
}

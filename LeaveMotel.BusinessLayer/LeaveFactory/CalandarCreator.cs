using LeaveMotel.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveMotel.BusinessLayer.LeaveFactory
{
    public abstract class CalandarCreator
    {
        public abstract LMCalandar Create(CalandarType calandar);
    }
}

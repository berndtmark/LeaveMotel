using LeaveMotel.BusinessLayer.LeaveFactory;
using LeaveMotel.Models.Enums;
using System;
using System.Linq;
using Xunit;

namespace LeaveMotel.FactoryTests.UnitTests
{
    public class CurrentLeaveCalandarTests
    {
        [Fact]
        public void LeaveCalandar_CorrectDaysInMonth()
        {
            // Arrange
            var leaveCalandar = new CurrentLeaveCalandar();
            var daysInCurrentMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            // Act
            var result = leaveCalandar.Create(CalandarType.Month);

            // Assert
            var daysInMonth = result.CurrentMonth.Weeks.SelectMany(w => w.Day).Count();

            Assert.Equal(daysInCurrentMonth, daysInMonth);
        }

        [Fact]
        public void LeaveCalandar_AnnualCalandar_CorrectMonthsReturned()
        {
            // Arrange
            var leaveCalandar = new CurrentLeaveCalandar();
            var daysInCurrentMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            // Act
            var result = leaveCalandar.Create(CalandarType.Annual);

            // Assert
            Assert.Equal(12, result.Months.Count);
        }
    }
}

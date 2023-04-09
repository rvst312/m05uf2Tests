using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class DayOfTheWeek_Tests
    {
        [TestMethod]
        public void DayOfTheWeek_Test()
        {
            //Arrange
            DateTime time = new DateTime(2000, 1, 1).AddDays(Utils.random.Next(365 * 7));
            DayOfWeek resultOK = time.DayOfWeek;
            //Act
            int result = DayOfTheWeek.Program.DayOfTheWeek(time.Year, time.Month, time.Day);
            DayOfWeek resultEnum = (DayOfWeek)((result + 6) % 7);
            //Assert
            Assert.AreEqual(resultOK, resultEnum);
        }
    }
}

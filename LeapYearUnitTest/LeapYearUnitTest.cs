using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYearConsole;
using System;

namespace LeapYearUnitTest
{
    [TestClass]
    public class LeapYearUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ISLessTanOrZeroThroughException()
        {
          
            var t = LeapYearConsole.Program.IsLeapYear(0);
        }
        [TestMethod]
        public void IsDividedBy4()
        {
            var r1 = LeapYearConsole.Program.IsLeapYear(3);
            Assert.AreEqual(false, r1);

            var r2 = LeapYearConsole.Program.IsLeapYear(4);
            Assert.AreEqual(true, r2);

            var r3 = LeapYearConsole.Program.IsLeapYear(5);
            Assert.AreEqual(false, r3);

            var r4 = LeapYearConsole.Program.IsLeapYear(6);
            Assert.AreEqual(false, r4);

            var r5 = LeapYearConsole.Program.IsLeapYear(7);
            Assert.AreEqual(false, r5);

            var r6 = LeapYearConsole.Program.IsLeapYear(8);
            Assert.AreEqual(true, r6);
        }
        [TestMethod]
        public void IsDividedBy100Nad400()
        {
            var r1 = LeapYearConsole.Program.IsLeapYear(1700);
            Assert.AreEqual(false, r1);

            var r2 = LeapYearConsole.Program.IsLeapYear(1800);
            Assert.AreEqual(false, r2);
            var r3 = LeapYearConsole.Program.IsLeapYear(1700);
            Assert.AreEqual(false, r3);
            var r4 = LeapYearConsole.Program.IsLeapYear(1900);
            Assert.AreEqual(false, r4);
            var r5 = LeapYearConsole.Program.IsLeapYear(2000);
            Assert.AreEqual(true, r5);

        }
    }
}

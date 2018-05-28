using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock.Tests
{
    [TestClass()]
    public class ClockTests
    {
        Clock myClockTest = new Clock();

        [TestMethod()]
        public void CreateClockTest()
        {
            Assert.AreEqual("00:00:00", myClockTest.DrawClock());
        }

        [TestMethod()]
        public void IncrementClockTest()
        {
            myClockTest.IncrementClockSec();
            Assert.AreEqual("00:00:01", myClockTest.DrawClock());
        }
        [TestMethod()]
        public void IncrementClockOvrFloSecTest()
        {
            for (int i = 0; i < 60; i++)
            {
                myClockTest.IncrementClockSec();
            }
            Assert.AreEqual("00:01:00", myClockTest.DrawClock());
        }
        [TestMethod()]
        public void IncrementClockOvrFloMinTest()
        {
            for (int i = 0; i < (60*60); i++)
            {
                myClockTest.IncrementClockSec();
            }
            Assert.AreEqual("01:00:00", myClockTest.DrawClock());
        }
        [TestMethod()]
        public void IncrementClockOvrFloHrsTest()
        {
            for (int i = 0; i < (60 * 60 * 24); i++)
            {
                myClockTest.IncrementClockSec();
            }
            Assert.AreEqual("00:00:00", myClockTest.DrawClock());
        }
    }
}
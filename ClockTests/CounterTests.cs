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
    public class CounterTests
    { 
        Counter TestCounter = new Counter("TestCounter", 60);
        //ensures the counter is created with a value of 0
        [TestMethod()]
        public void CounterTest()
        {
            Assert.AreEqual(0, TestCounter.Count);
        }
        [TestMethod()]
        public void IncrementTest()
        {
            TestCounter.Increment();
            Assert.AreEqual(1, TestCounter.Count);
            TestCounter.Increment();
            Assert.AreEqual(2, TestCounter.Count);
        }
        [TestMethod()]
        public void IncrementMultiTest()
        {
            for (int i = 0; i<50; i++)
            {              
                Assert.AreEqual(i, TestCounter.Count);
                TestCounter.Increment();
            }
        }

        [TestMethod()]
        public void ResetTest()
        {
            TestCounter.Reset();
            Assert.AreEqual(0, TestCounter.Count);
        }
    }
}
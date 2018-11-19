using System;
using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PoorPigsUnitTest
    {
        [TestMethod]
        public void PoorPigsTestMethod()
        {
            var logresult1 = Math.Log(8,2);
            Assert.AreEqual(3, logresult1);

            var ceilingresult1 = Math.Ceiling(2.8);
            Assert.AreEqual(3, ceilingresult1);

            var poorPigs = new PoorPigs();
            var bucket1 = 1000;
            var minutesToDie1 = 15;
            var minutesToTest = 60;
            var expected1 = 5;
            var actual1 = poorPigs.PoorPigsSln(bucket1, minutesToDie1, minutesToTest);
            Assert.AreEqual(expected1, actual1);
        }
    }
}
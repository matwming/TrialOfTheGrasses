using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class HammingDistanceUnitTest
    {
        [TestMethod]
        public void HammingDistanceTestMethod()
        {
            HammingDistance hammingDistance = new HammingDistance();
            Assert.AreEqual(2, hammingDistance.HammingDistanceSolution(1, 4));
        }
    }
}

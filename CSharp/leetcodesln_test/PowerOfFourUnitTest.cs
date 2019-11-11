using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class PowerOfFourUnitTest
    {
        public PowerOfFour powerOfFour { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            powerOfFour = new PowerOfFour();
        }

        [TestMethod]
        public void PowerOfFourTestMethod1()
        {
            var input = 16;
            var expected = true;
            var actual = powerOfFour.IsPowerOfFour(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfFourTestMethod2()
        {
            var input = 5;
            var expected = false;
            var actual = powerOfFour.IsPowerOfFour(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

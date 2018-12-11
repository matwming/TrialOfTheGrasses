using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class PowerOfThreeUnitTest
    {
        public PowerOfThree powerOfThree { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            powerOfThree = new PowerOfThree();
        }

        [TestMethod]
        public void PowerOfThreeTestMethod1()
        {
            var input = 27;
            var expected = true;
            var actual = powerOfThree.IsPowerOfThree(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfThreeTestMethod2()
        {
            var input = 0;
            var expected = false;
            var actual = powerOfThree.IsPowerOfThree(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfThreeTestMethod3()
        {
            var input = 9;
            var expected = true;
            var actual = powerOfThree.IsPowerOfThree(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfThreeTestMethod4()
        {
            var input = 45;
            var expected = false;
            var actual = powerOfThree.IsPowerOfThree(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfThreeTestMethod5()
        {
            var input = 1;
            var expected = true;
            var actual = powerOfThree.IsPowerOfThree(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

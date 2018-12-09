using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class PowerOfTwoUnitTest
    {
        public PowerOfTwo powerOfTwo { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            powerOfTwo = new PowerOfTwo();
        }

        [TestMethod]
        public void PowerOfTwoTestMethod1()
        {
            var input = 1;
            var expected = true;
            var actual = powerOfTwo.IsPowerOfTwo(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfTwoTestMethod2()
        {
            var input = 16;
            var expected = true;
            var actual = powerOfTwo.IsPowerOfTwo(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfTwoTestMethod3()
        {
            var input = 218;
            var expected = false;
            var actual = powerOfTwo.IsPowerOfTwo(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfTwoTestMethod4()
        {
            var input = 20;
            var expected = false;
            var actual = powerOfTwo.IsPowerOfTwo(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfTwoTestMethod5()
        {
            var input = 3;
            var expected = false;
            var actual = powerOfTwo.IsPowerOfTwo(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfTwoTestMethod6()
        {
            var input = 19;
            var expected = false;
            var actual = powerOfTwo.IsPowerOfTwo(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PowerOfTwoTestMethod7()
        {
            var input = -1;
            var expected = false;
            var actual = powerOfTwo.IsPowerOfTwo(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

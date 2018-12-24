using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class NumberOf1BitsUnitTest
    {
        public NumberOf1Bits numberOf1Bits { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            numberOf1Bits = new NumberOf1Bits();
        }

        [TestMethod]
        public void NumberOf1BitsTestMethod1()
        {
            var input = "00000000000000000000000000001011";
            uint input_uint = Convert.ToUInt32(input,2);
            var expected = 3;
            var actual = numberOf1Bits.HammingWeight(input_uint);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberOf1BitsTestMethod2()
        {
            var input = "00000000000000000000000010000000";
            uint input_uint = Convert.ToUInt32(input, 2);
            var expected = 1;
            var actual = numberOf1Bits.HammingWeight(input_uint);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NumberOf1BitsTestMethod3()
        {
            var input = "00000000000000000000000000000111";
            uint input_uint = Convert.ToUInt32(input, 2);
            var expected = 3;
            var actual = numberOf1Bits.HammingWeight(input_uint);
            Assert.AreEqual(expected, actual);
        }
    }
}

using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ReverseStringIIUnitTest
    {
        [TestMethod]
        public void ReverseStringIITestMethod()
        {
            var reverseStringII = new ReverseStringII();
            var input1_s = "abcdefg";
            var input1_k = 2;
            var expected1 = "bacdfeg";
            var actual1 = reverseStringII.ReverseStr(input1_s, input1_k);
            Assert.AreEqual(expected1, actual1);

            var input2_s = "abc";
            var input2_k = 2;
            var expected2 = "bac";
            var actual2 = reverseStringII.ReverseStr(input2_s, input2_k);
            Assert.AreEqual(expected2, actual2);

            var input3_s = "abcd";
            var input3_k = 2;
            var expected3 = "bacd";
            var actual3 = reverseStringII.ReverseStr(input3_s, input3_k);
            Assert.AreEqual(expected3, actual3);

            var input4_s = "abcdefg";
            var input4_k = 1;
            var expected4 = "abcdefg";
            var actual4 = reverseStringII.ReverseStr(input4_s, input4_k);
            Assert.AreEqual(expected4, actual4);

            var input5_s = "abcdefg";
            var input5_k = 4;
            var expected5 = "dcbaefg";
            var actual5 = reverseStringII.ReverseStr(input5_s, input5_k);
            Assert.AreEqual(expected5, actual5);

            var input6_s = "abcdefg";
            var input6_k = 3;
            var expected6 = "cbadefg";
            var actual6 = reverseStringII.ReverseStr(input6_s, input6_k);
            Assert.AreEqual(expected6, actual6);
        }
    }
}

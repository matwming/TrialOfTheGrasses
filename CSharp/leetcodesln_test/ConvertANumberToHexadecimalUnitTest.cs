using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ConvertANumberToHexadecimalUnitTest
    {
        public ConvertANumberToHexadecimal convertANumberToHexadecimal { get; set; }
        [TestInitialize]
        public void BeforeEach()
        {
            convertANumberToHexadecimal = new ConvertANumberToHexadecimal();
        }


        [TestMethod, Timeout(10_000)]
        public void convertANumberToHexadecimalTestMethod1()
        {
            var input = 26;
            var expected = "1a";
            var actual = convertANumberToHexadecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void convertANumberToHexadecimalTestMethod2()
        {
            var input = -1;
            var expected = "ffffffff";
            var actual = convertANumberToHexadecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void convertANumberToHexadecimalTestMethod3()
        {
            var input = 12;
            var expected = "c";
            var actual = convertANumberToHexadecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void convertANumberToHexadecimalTestMethod4()
        {
            var input = 0;
            var expected = "0";
            var actual = convertANumberToHexadecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void convertANumberToHexadecimalTestMethod5()
        {
            var input = -123;
            var expected = "ffffff85";
            var actual = convertANumberToHexadecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

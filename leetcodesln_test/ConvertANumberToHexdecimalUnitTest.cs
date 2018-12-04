using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ConvertANumberToHexdecimalUnitTest
    {
        public ConvertANumberToHexdecimal convertANumberToHexdecimal { get; set; }
        [TestInitialize]
        public void BeforeEach()
        {
            convertANumberToHexdecimal = new ConvertANumberToHexdecimal();
        }


        [TestMethod, Timeout(10_000)]
        public void ConvertANumberToHexdecimalTestMethod1()
        {
            var input = 26;
            var expected = "1a";
            var actual = convertANumberToHexdecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void ConvertANumberToHexdecimalTestMethod2()
        {
            var input = -1;
            var expected = "ffffffff";
            var actual = convertANumberToHexdecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void ConvertANumberToHexdecimalTestMethod3()
        {
            var input = 12;
            var expected = "c";
            var actual = convertANumberToHexdecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void ConvertANumberToHexdecimalTestMethod4()
        {
            var input = 0;
            var expected = "0";
            var actual = convertANumberToHexdecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(10_000)]
        public void ConvertANumberToHexdecimalTestMethod5()
        {
            var input = -123;
            var expected = "ffffff85";
            var actual = convertANumberToHexdecimal.ToHex(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

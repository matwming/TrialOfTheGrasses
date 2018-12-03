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
    }
}

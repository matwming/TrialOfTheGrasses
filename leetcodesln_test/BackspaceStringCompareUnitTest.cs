using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class BackspaceStringCompareUnitTest
    {
        [TestMethod]
        public void BackspaceStringCompareTestMethod()
        {
            var backspaceStringCompare = new BackspaceStringCompare();
            var inputS1 = "ab#c";
            var inputT1 = "ad#c";
            var expected1 = true;
            var actual1 = backspaceStringCompare.BackspaceCompare(inputS1, inputT1);
            Assert.AreEqual(expected1, actual1);

            var inputS2 = "a##c";
            var inputT2 = "#a#c";
            var expected2 = true;
            var actual2 = backspaceStringCompare.BackspaceCompare(inputS2, inputT2);
            Assert.AreEqual(expected2, actual2);

            var inputS3 = "y#fo##f";
            var inputT3 = "y#f#0##f";
            var expected3 = true;
            var actual3 = backspaceStringCompare.BackspaceCompare(inputS3, inputT3);
            Assert.AreEqual(expected3, actual3);

        }

        [TestMethod]
        public void BackspaceStringCompareTwoPointersTestMethod()
        {
            var backspaceStringCompare = new BackspaceStringCompare();
            var inputS1 = "ab#c";
            var inputT1 = "ad#c";
            var expected1 = true;
            var actual1 = backspaceStringCompare.BackspaceCompareTwoPointers(inputS1, inputT1);
            Assert.AreEqual(expected1, actual1);

            var inputS2 = "a##c";
            var inputT2 = "#a#c";
            var expected2 = true;
            var actual2 = backspaceStringCompare.BackspaceCompareTwoPointers(inputS2, inputT2);
            Assert.AreEqual(expected2, actual2);

            var inputS3 = "y#fo##f";
            var inputT3 = "y#f#0##f";
            var expected3 = true;
            var actual3 = backspaceStringCompare.BackspaceCompareTwoPointers(inputS3, inputT3);
            Assert.AreEqual(expected3, actual3);

        }
    }
}

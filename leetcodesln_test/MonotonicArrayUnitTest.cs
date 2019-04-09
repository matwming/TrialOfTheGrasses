using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MonotonicArrayUnitTest
    {
        [TestMethod]
        public void MonotonicArrayTestMethod()
        {
            var monotonicArray = new MonotonicArray();
            var input1 = new int[] { 1, 2, 2, 3 };
            var expected1 = true;
            var actual1 = monotonicArray.IsMonotonic(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = new int[] { 6, 5, 4, 4 };
            var expected2 = true;
            var actual2 = monotonicArray.IsMonotonic(input2);
            Assert.AreEqual(expected2, actual2);

            var input3 = new int[] { 1, 3, 2 };
            var expected3 = false;
            var actual3 = monotonicArray.IsMonotonic(input3);
            Assert.AreEqual(expected3, actual3);

            var input4 = new int[] { 1, 2, 4, 5 };
            var expected4 = true;
            var actual4 = monotonicArray.IsMonotonic(input4);
            Assert.AreEqual(expected4, actual4);

            var input5 = new int[] { 1, 1, 1 };
            var expected5 = true;
            var actual5 = monotonicArray.IsMonotonic(input5);
            Assert.AreEqual(expected5, actual5);

            var input6 = new int[] { 1, 1, 0 };
            var expected6 = true;
            var actual6 = monotonicArray.IsMonotonic(input6);
            Assert.AreEqual(expected6, actual6);

            var input7 = new int[] { 11, 11, 9, 4, 3, 3, 3, 1, -1, -1, 3, 3, 3, 5, 5, 5 };
            var expected = false;
            var actual = monotonicArray.IsMonotonic(input7);
            Assert.AreEqual(expected, actual);

        }


    }
}

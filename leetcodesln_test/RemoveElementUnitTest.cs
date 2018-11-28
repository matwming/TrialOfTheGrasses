using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RemoveElementUnitTest
    {
        [TestMethod]
        public void RemoveElementSlnTestMethod()
        {
            var removeElement = new RemoveElement();
            var input_nums1 = new int[] { 3, 2, 2, 3 };
            var input_val1 = 3;
            var expected1 = 2;
            var actual1 = removeElement.RemoveElementSln(input_nums1, input_val1);
            Assert.AreEqual(expected1, actual1);

            var input_nums2 = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var input_val2 = 2;
            var expected2 = 5;
            var actual2 = removeElement.RemoveElementSln(input_nums2, input_val2);
            Assert.AreEqual(expected2, actual2);

            var input_nums3 = new int[] { };
            var input_val3 = 2;
            var expected3 = 0;
            var actual3 = removeElement.RemoveElementSln(input_nums3, input_val3);
            Assert.AreEqual(expected3, actual3);

            var input_nums4 = new int[] {2,2,2,2,2,2,2,2 };
            var input_val4 = 2;
            var expected4 = 0;
            var actual4 = removeElement.RemoveElementSln(input_nums4, input_val4);
            Assert.AreEqual(expected4, actual4);

            var input_nums5 = new int[] { 2};
            var input_val5 = 3;
            var expected5 = 1;
            var actual5 = removeElement.RemoveElementSln(input_nums5, input_val5);
            Assert.AreEqual(expected5, actual5);

            var input_nums6 = new int[] { 3,3 };
            var input_val6 = 5;
            var expected6 = 2;
            var actual6 = removeElement.RemoveElementSln(input_nums6, input_val6);
            Assert.AreEqual(expected6, actual6);
        }
    }
}

using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class KthLargestElementInAStreamUnitTest
    {

        [TestMethod]
        public void KthLargestElementInAStreamTestMethod1()
        {
            int k = 3;
            int[] arr = new int[] { 4, 5, 8, 2 };
            var kthLargestElementInAStream = new KthLargestElementInAStream(k, arr);

            Assert.AreEqual(4, kthLargestElementInAStream.Add(3));
            Assert.AreEqual(5, kthLargestElementInAStream.Add(5));
            Assert.AreEqual(5, kthLargestElementInAStream.Add(10));
            Assert.AreEqual(8, kthLargestElementInAStream.Add(9));
            Assert.AreEqual(8, kthLargestElementInAStream.Add(4));
        }

        [TestMethod]
        public void KthLargestElementInAStreamTestMethod2()
        {
            int k = 1;
            int[] arr = null; ;
            var kthLargestElementInAStream = new KthLargestElementInAStream(k, arr);

            Assert.AreEqual(-3, kthLargestElementInAStream.Add(-3));
            Assert.AreEqual(-2, kthLargestElementInAStream.Add(-2));
            Assert.AreEqual(-2, kthLargestElementInAStream.Add(-4));
            Assert.AreEqual(0, kthLargestElementInAStream.Add(0));
            Assert.AreEqual(4, kthLargestElementInAStream.Add(4));
        }
    }
}

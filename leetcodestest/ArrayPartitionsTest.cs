using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcodesln;

namespace leetcodestest
{
    [TestClass]
    public class ArrayPartitionsTest
    {
        [TestMethod]
        public void ArrayPartitionsTestMethod()
        {
            ArrayPartitions arrayPartitions = new ArrayPartitions();
            int[] arr = { 1,4,3,2 };
            Assert.AreEqual(4, arrayPartitions.ArrayPairSum(arr));
        }
    }
}

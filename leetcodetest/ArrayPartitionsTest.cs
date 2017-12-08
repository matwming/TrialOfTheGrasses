using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodetest
{
    [TestClass]
    public class ArrayPartitionsTest
    {
        [TestMethod]
        public void ArrayPartitionsTestMethod()
        {
            ArrayPartitions arrayPartitions = new ArrayPartitions();
            int[] arr = {1,4,3,2 };
            Assert.AreEqual(4, arrayPartitions.ArrayPairSum(arr));
        }
    }
   
}

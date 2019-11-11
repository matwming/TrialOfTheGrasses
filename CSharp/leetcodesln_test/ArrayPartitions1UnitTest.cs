using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class ArrayPartitions1UnitTest
    {
        [TestMethod]
        public void ArrayPartitions1TestMethod()
        {
            ArrayPartitions1 arrayPartitions1 = new ArrayPartitions1();
            int[] arr = { 1, 4, 3, 2 };
            Assert.AreEqual(4, arrayPartitions1.ArrayPairSum(arr));
        }
    }
}

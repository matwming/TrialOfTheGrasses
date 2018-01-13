using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RangeAddition2UnitTest
    {
        [TestMethod]
        public void RangeAddition2TestMethod()
        {
            RangeAddition2 rangeAddition2 = new RangeAddition2();
            Assert.AreEqual(4, rangeAddition2.MaxCount(3,3,new int[,] { { 2,2},{2,3 } }));
        }
    }
}

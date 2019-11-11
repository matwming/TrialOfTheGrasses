using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class BinaryNumberWithAlternatingBitsUnitTest
    {
        [TestMethod]
        public void BinaryNumberWithAlternatingBitsTestMethod()
        {
            BinaryNumberWithAlternatingBits binaryNumberWithAlternatingBits = new BinaryNumberWithAlternatingBits();
            Assert.AreEqual(true,binaryNumberWithAlternatingBits.HasAlternatingBits(5));
            Assert.AreEqual(false,binaryNumberWithAlternatingBits.HasAlternatingBits(7));
            Assert.AreEqual(false,binaryNumberWithAlternatingBits.HasAlternatingBits(11));
            Assert.AreEqual(true,binaryNumberWithAlternatingBits.HasAlternatingBits(10));
        }
    }
}

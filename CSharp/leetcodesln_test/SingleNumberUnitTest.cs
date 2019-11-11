using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SingleNumberUnitTest
    {
        public SingleNumber SingleNumber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SingleNumber = new SingleNumber();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var nums = new[] { 1, 2, 1 };
            var expected = 2;
            var actual = SingleNumber.SingleNum(nums);
            Assert.AreEqual(expected, actual);
        }
    }
}
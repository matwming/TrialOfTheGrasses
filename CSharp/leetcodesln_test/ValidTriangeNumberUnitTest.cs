using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ValidTriangleNumberUnitTest
    {
        public ValidTriangleNumber ValidTriangleNumber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ValidTriangleNumber = new ValidTriangleNumber();
        }

        [TestMethod, Timeout(10_000)]
        public void TestMethod1()
        {
            var nums = new[] {2, 2, 3, 4};
            var expected = 3;
            var actual = ValidTriangleNumber.TriangleNumber(nums);
            Assert.AreEqual(expected,actual);
        }
    }
}
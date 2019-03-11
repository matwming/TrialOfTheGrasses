using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ValidMountainArrayUnitTest
    {
        public ValidMountainArray ValidMountainArray { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ValidMountainArray = new ValidMountainArray();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 2, 1 };
            var expected = false;
            var actual = ValidMountainArray.IsValidMountainArray(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 3, 5, 5 };
            var expected = false;
            var actual = ValidMountainArray.IsValidMountainArray(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 0, 3, 2, 1 };
            var expected = true;
            var actual = ValidMountainArray.IsValidMountainArray(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var input = new int[] { 0, 1, 2, 1, 2 };
            var expected = false;
            var actual = ValidMountainArray.IsValidMountainArray(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

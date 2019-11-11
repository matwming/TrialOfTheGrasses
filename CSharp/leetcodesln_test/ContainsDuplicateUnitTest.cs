using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ContainsDuplicateUnitTest
    {
        public ContainsDuplicate ContainsDuplicate { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ContainsDuplicate = new ContainsDuplicate();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 1, 2, 3, 1 };
            var actual = ContainsDuplicate.ContainsDuplicateSln(input);
            Assert.IsTrue(actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1, 2, 3, 4 };
            var actual = ContainsDuplicate.ContainsDuplicateSln(input);
            Assert.IsFalse(actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            var actual = ContainsDuplicate.ContainsDuplicateSln(input);
            Assert.IsTrue(actual);
        }

    }
}

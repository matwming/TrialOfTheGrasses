using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ContainsDuplicateIIUnitTest
    {
        public ContainsDuplicateII ContainsDuplicateII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ContainsDuplicateII = new ContainsDuplicateII();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] {1,2,3,1};
            var k = 3;
            var expected = true;
            var actual = ContainsDuplicateII.ContainsNearbyDuplicate(input,k);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] {1,0,1,1};
            var k = 1;
            var expected = true;
            var actual = ContainsDuplicateII.ContainsNearbyDuplicate(input,k);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] {1,2,3,1,2,3};
            var k = 2;
            var expected = false;
            var actual = ContainsDuplicateII.ContainsNearbyDuplicate(input,k);
            Assert.AreEqual(expected,actual);
        }
    }
}
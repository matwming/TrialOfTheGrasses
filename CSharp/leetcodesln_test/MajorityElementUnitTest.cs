using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class MajorityElementUnitTest
    {
        public MajorityElement MajorityElement { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MajorityElement = new MajorityElement();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 3, 2, 3 };
            var expected = 3;
            var actual = MajorityElement.MajorityElementSln(input);
            Assert.AreEqual(expected, actual);
        }

    }
}

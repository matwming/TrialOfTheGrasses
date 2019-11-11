using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class SortColorsUnitTest
    {
        public SortColors SortColors { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            SortColors = new SortColors();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new[] { 2, 0, 2, 1, 1, 0 };
            var expected = new[] { 0, 0, 1, 1, 2, 2 };
            SortColors.SortColorsSln(input);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(input[i], expected[i]);
            }
        }

    }
}

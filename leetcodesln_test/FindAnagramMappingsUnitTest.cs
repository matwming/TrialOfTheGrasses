using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace leetcodesln_test
{
    [TestClass]
    public class FindAnagramMappingsUnitTest
    {
        [TestMethod]
        public void FindAnagramMappingsTestMethod()
        {
            FindAnagramMappings findAnagramMappings = new FindAnagramMappings();
            int[] expected = { 1, 4, 3, 2, 0 };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], findAnagramMappings.AnagramMappings(new int[] { 12, 28, 46, 32, 50 }, new int[] { 50, 12, 32, 46, 28 })[i]);
            }

            int[] expected2 = {0,0};
            for (int i = 0; i < expected2.Length; i++)
            {
                Assert.AreEqual(expected2[i], findAnagramMappings.AnagramMappings(new int[] { 40,40},new int[] { 40,40})[i]);
            }
        }

    }
}

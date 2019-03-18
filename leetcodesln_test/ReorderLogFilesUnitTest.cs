using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ReorderLogFilesUnitTest
    {
        public ReorderLogFiles ReorderLogFiles { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ReorderLogFiles = new ReorderLogFiles();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new string[] { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
            var expected = new string[] { "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7" };
            var actual = ReorderLogFiles.ReorderLogFilesSln(input);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new string[] { "j mo", "5 m w", "g 07", "o 2 0", "t q h" };
            var expected = new string[] { "j mo", "5 m w", "t q h", "g 07", "o 2 0" };
            var actual = ReorderLogFiles.ReorderLogFilesSln(input);

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}

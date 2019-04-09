using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace leetcodesln_test
{
    [TestClass]
    public class MoveZeroesUnitTest
    {
        public MoveZeroes MoveZeroes { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MoveZeroes = new MoveZeroes();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new int[] { 0, 1, 0, 3, 12 };
            var expected = new int[] { 1, 3, 12, 0, 0 };
            MoveZeroes.MoveZeroesSln(input);
            Assert.IsTrue(Enumerable.SequenceEqual<int>(expected, input));

        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new int[] { 1 };
            var expected = new int[] { 1 };
            MoveZeroes.MoveZeroesSln(input);
            Assert.IsTrue(Enumerable.SequenceEqual<int>(expected, input));

        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new int[] { 0, 0, 1 };
            var expected = new int[] { 1, 0, 0 };
            MoveZeroes.MoveZeroesSln(input);
            Assert.IsTrue(Enumerable.SequenceEqual<int>(expected, input));
        }

    }
}

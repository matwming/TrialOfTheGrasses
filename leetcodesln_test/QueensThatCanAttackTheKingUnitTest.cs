using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class QueensThatCanAttackTheKingUnitTest
    {
        public QueensThatCanAttackTheKing QueensThatCanAttackTheKing { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            QueensThatCanAttackTheKing = new QueensThatCanAttackTheKing();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var queens = new int[][]
            {
                new[]{ 0,1},
                new[]{ 1,0},
                new[]{ 4,0},
                new[]{ 0,4},
                new[]{ 3,3},
                new[]{ 2,4}
            };
            var king = new[] { 0, 0 };

            var expected = new int[][]
            {
                new[]{3,3},
                new[]{ 1,0},
                new[]{ 0,1}
            };
            var actual = QueensThatCanAttackTheKing.QueensAttacktheKing(queens, king);
            Assert.AreEqual(expected.Length, actual.Count());
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i][0], actual[i][0]);
                Assert.AreEqual(expected[i][1], actual[i][1]);
            }
        }

    }
}

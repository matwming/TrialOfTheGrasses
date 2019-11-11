using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FourSumUnitTest
    {
        public FourSum FourSum { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            FourSum = new FourSum();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var nums = new[] { 1, 0, -1, 0, -2, 2 };
            var target = 0;
            var expected = new int[][]
            {
                new []{ -2,-1,1,2},
                new []{ -2,0,0,2},
                new []{ -1,0,0,1}
            };
            var actual = FourSum.FourSumSln(nums, target);
            for (int i = 0; i < expected.Length; i++)
            {
                for (int j = 0; j < expected[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

    }
}

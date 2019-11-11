using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class CombinationSumUnitTest
    {
        public CombinationSum CombinationSum { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            CombinationSum = new CombinationSum();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var candidates = new[] { 2, 3, 6, 7 };
            var target = 7;
            var expected = new List<IList<int>> {
                new List<int> { 7},
                new List<int> { 2,2,3}
            };

            var actual = CombinationSum.CombinationSumSln(candidates, target);
        }

    }
}

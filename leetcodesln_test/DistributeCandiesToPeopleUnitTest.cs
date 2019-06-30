using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class DistributeCandiesToPeopleUnitTest
    {
        public DistributeCandiesToPeople DistributeCandiesToPeople { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DistributeCandiesToPeople = new DistributeCandiesToPeople();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var candies = 7;
            var num_people = 4;
            var expected = new[] { 1, 2, 3, 1 };
            var actual = DistributeCandiesToPeople.DistributeCandies(candies, num_people);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var candies = 10;
            var num_people = 3;
            var expected = new[] { 5,2,3 };
            var actual = DistributeCandiesToPeople.DistributeCandies(candies, num_people);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}

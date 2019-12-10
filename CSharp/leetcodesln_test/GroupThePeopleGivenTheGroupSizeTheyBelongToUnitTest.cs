using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class GroupThePeopleGivenTheGroupSizeTheyBelongToUnitTest
    {
        public GroupThePeopleGivenTheGroupSizeTheyBelongTo GroupThePeopleGivenTheGroupSizeTheyBelongTo { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            GroupThePeopleGivenTheGroupSizeTheyBelongTo = new GroupThePeopleGivenTheGroupSizeTheyBelongTo();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var groupSizes = new[] { 3, 3, 3, 3, 3, 1, 3 };
            var expected = new List<IList<int>>
            {
                new List<int>{0,1,2},
                new List<int>{5},
                new List<int>{3,4,6}
            };
            var actual = GroupThePeopleGivenTheGroupSizeTheyBelongTo.GroupThePeople(groupSizes);
            for (int i = 0; i < expected.Count; i++)
            {
                for (int j = 0; j < expected[i].Count; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }
        }

    }
}

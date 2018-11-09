using System.Collections.Generic;
using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PositionsOfLargeGroupsUnitTest
    {
        [TestMethod]
        public void PositionsOfLargeGroupsTestMethod()
        {
            var positionOfLargeGroups = new PositionsOfLargeGroups();
            var input1 = "abbxxxxzzy";
            var nestedlist1 = new List<int>{3,6};
            var expected1 = new List<IList<int>>();
            expected1.Add(nestedlist1);
            var actual1 = positionOfLargeGroups.LargeGroupPosition(input1);

            for (int i = 0; i < expected1.Count; i++)
            {
                for (int j = 0; j < expected1[i].Count; j++)
                {
                    Assert.AreEqual(expected1[i][j], actual1[i][j]);
                }
            }

             var input2 = "abcdddeeeeaabbbcd";
            var nestedlist21 = new List<int>{3,5};
            var nestedlist22 = new List<int>{6,9};
            var nestedlist23 = new List<int>{12,14};


            var expected2 = new List<IList<int>>();
            expected2.Add(nestedlist21);
            expected2.Add(nestedlist22);
            expected2.Add(nestedlist23);

            var actual2 = positionOfLargeGroups.LargeGroupPosition(input2);

            for (int i = 0; i < expected1.Count; i++)
            {
                for (int j = 0; j < expected1[i].Count; j++)
                {
                    Assert.AreEqual(expected2[i][j], actual2[i][j]);
                }
            }
        }
    }
}
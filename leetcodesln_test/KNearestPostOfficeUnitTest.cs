using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class KNearestPostOfficeUnitTest
    {
        public KNearestPostOffice KNearestPostOffice { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            KNearestPostOffice = new KNearestPostOffice();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var position = new[] { 0, 0 };
            var post_office = new int[6][];
            post_office[0] = new[] { -16, 5 };
            post_office[1] = new[] { -1, 2 };
            post_office[2] = new[] { 4, 3 };
            post_office[3] = new[] { 10, -2 };
            post_office[4] = new[] { 0, 3 };
            post_office[5] = new[] { -5, -9 };
            var k = 3;
            var expected = new int[3][];
            expected[0] = new[] { -1, 2 };
            expected[1] = new[] { 0, 3 };
            expected[2] = new[] { 4, 3 };
            var actual = KNearestPostOffice.NearestOffices(post_offices: post_office, k: k, position: position);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i][0], actual[i][0]);
                Assert.AreEqual(expected[i][1], actual[i][1]);
            }
        }
    }
}
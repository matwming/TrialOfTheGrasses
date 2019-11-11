using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FirstBadVersionUnitTest
    {
        [TestMethod, Timeout(20_000)]
        public void UnitTest1()
        {
            var init = new FirststBadVersion(5, 4);
            var expected = 4;
            var actual = init.FirstBadVersion(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void UnitTest2()
        {
            var init = new FirststBadVersion(6, 3);
            var expected = 3;
            var actual = init.FirstBadVersion(6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void UnitTest3()
        {
            var init = new FirststBadVersion(1, 1);
            var expected = 1;
            var actual = init.FirstBadVersion(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void UnitTest4()
        {
            var init = new FirststBadVersion(2, 1);
            var expected = 1;
            var actual = init.FirstBadVersion(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void UnitTest5()
        {
            var init = new FirststBadVersion(2, 2);
            var expected = 2;
            var actual = init.FirstBadVersion(2);
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod, Timeout(20_000)]
        //public void UnitTest6()
        //{
        //    var init = new _1stBadVersion(2_126_753_390, 1_702_766_719);
        //    var expected = 1_702_766_719;
        //    var actual = init.FirstBadVersion(2_126_753_390);
        //    Assert.AreEqual(expected, actual);
        //}

    }
}

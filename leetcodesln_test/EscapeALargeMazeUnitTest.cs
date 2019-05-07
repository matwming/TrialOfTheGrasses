using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class EscapeALargeMazeUnitTest
    {
        public EscapeALargeMaze EscapeALargeMaze { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            EscapeALargeMaze = new EscapeALargeMaze();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var blocked = new int[2][];
            blocked[0] = new int[] { 0, 1 };
            blocked[1] = new int[] { 1, 0 };
            var source = new int[] { 0, 0 };
            var target = new int[] { 0, 2 };
            var expected = false;
            var actual = EscapeALargeMaze.IsEscapePossible(blocked, source, target);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var blocked = new int[][] { };
            var source = new int[] { 0, 0 };
            var target = new int[] { 999999, 999999 };
            var expected = true;
            var actual = EscapeALargeMaze.IsEscapePossible(blocked, source, target);
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod, Timeout(5_000)]
        //public void TestMethod3()
        //{
        //    var blocked = new int[][] { new int[] { 961938,300406}, new int[] { 710196, 624190}, new int[] { 858790, 609485 }, new int[] { 268029, 225806}, new int[] { 200010, 18864}, new int[] { 132599, 612099}, new int[] { 329444, 633495}, new int[] { 196657, 757958}, new int[] { 628509, 883388} };
        //    var source = new int[] { 655988, 180910 };
        //    var target = new int[] { 267728, 840949 };
        //    var expected = true;
        //    var actual = EscapeALargeMaze.IsEscapePossible(blocked, source, target);
        //    Assert.AreEqual(expected, actual);
        //}

    }
}

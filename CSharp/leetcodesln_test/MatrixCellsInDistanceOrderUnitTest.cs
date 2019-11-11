using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MatrixCellsInDistanceOrderUnitTest
    {
        public MatrixCellsInDistanceOrder MatrixCellsInDistanceOrder { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MatrixCellsInDistanceOrder = new MatrixCellsInDistanceOrder();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var R = 1;
            var C = 2;
            var r0 = 0;
            var c0 = 0;
            var acutal = MatrixCellsInDistanceOrder.AllCellsDistOrder(R, C, r0, c0);
            var expected = new int[][] { new int[] { 0, 0 }, new int[] { 1,0} };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected[i], acutal[i]));
            }
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var R = 2;
            var C = 2;
            var r0 = 0;
            var c0 = 1;
            var acutal = MatrixCellsInDistanceOrder.AllCellsDistOrder(R, C, r0, c0);
            var expected = new int[][] { new int[] { 0,1 }, new int[] { 0, 0 }, new int[] { 1,1}, new int[] { 1,0} };
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsTrue(Helper<int>.HaveSameElementsForTwoCollections(expected[i], acutal[i]));
            }
        }

    }
}

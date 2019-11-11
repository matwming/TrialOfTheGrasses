using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class CarPoolingUnitTest
    {
        public CarPooling CarPooling { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            CarPooling = new CarPooling();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var trips = new int[][] { new int[] { 2, 1, 5 }, new int[] { 3, 3, 7 } };
            var capacity = 4;
            var expected = false;
            var actual = CarPooling.CarPoolingSln(trips, capacity);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var trips = new int[][] { new int[] { 2, 1, 5 }, new int[] { 3, 3, 7 } };
            var capacity = 5;
            var expected = true;
            var actual = CarPooling.CarPoolingSln(trips, capacity);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var trips = new int[][] { new int[] { 2, 1, 5 }, new int[] { 3, 5, 7 } };
            var capacity = 3;
            var expected = true;
            var actual = CarPooling.CarPoolingSln(trips, capacity);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod4()
        {
            var trips = new int[][] { new int[] { 3,2,7 }, new int[] { 3,7,9 }, new int[] { 8,3,9} };
            var capacity = 11;
            var expected = true;
            var actual = CarPooling.CarPoolingSln(trips, capacity);
            Assert.AreEqual(expected, actual);
        }

    }
}

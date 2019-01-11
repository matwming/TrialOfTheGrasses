using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MaximizeDistanceToClosestPersonUnitTest
    {
        public MaximizeDistanceToClosestPerson maximizeDistanceToClosestPerson { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            maximizeDistanceToClosestPerson = new MaximizeDistanceToClosestPerson();
        }

        [TestMethod, Timeout(20_000)]
        public void MaximizeDistanceToClosestPersonTestMethod1()
        {
            var input = new int[] { 1, 0, 0, 0, 1, 0, 1 };
            var expected = 2;
            var actual = maximizeDistanceToClosestPerson.MaxDistToClosest(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void MaximizeDistanceToClosestPersonTestMethod2()
        {
            var input = new int[] { 1, 0, 0, 0 };
            var expected = 3;
            var actual = maximizeDistanceToClosestPerson.MaxDistToClosest(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class HouseRobberUnitTest
    {
        public HouseRobber houseRobber { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            houseRobber = new HouseRobber();
        }

        [TestMethod, Timeout(20_000)]
        public void HouseRobberTestMethod1()
        {
            var input = new int[] { 1, 2, 3, 1 };
            var expected = 4;
            var actual = houseRobber.Rob(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void HouseRobberTestMethod2()
        {
            var input = new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            var expected = 0;
            var actual = houseRobber.Rob(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class RobotBoundedInCircleUnitTest
    {
        public RobotBoundedInCircle RobotBoundedInCircle { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            RobotBoundedInCircle = new RobotBoundedInCircle();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = "GGLLGG";
            var expected = true;
            var actual = RobotBoundedInCircle.IsRobotBounded(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = "GG";
            var expected = false;
            var actual = RobotBoundedInCircle.IsRobotBounded(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = "GL";
            var expected = true;
            var actual = RobotBoundedInCircle.IsRobotBounded(input);
            Assert.AreEqual(expected, actual);
        }

    }
}

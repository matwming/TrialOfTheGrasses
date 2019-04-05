using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class WalkingRobotSimulationUnitTest
    {
        public WalkingRobotSimulation WalkingRobotSimulation { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            WalkingRobotSimulation = new WalkingRobotSimulation();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var command = new int[] { 4, -1, 3 };
            var obstracles = new int[][] { };
            var expected = 25;
            var actual = WalkingRobotSimulation.RobotSim(command, obstracles);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var command = new int[] { 4, -1, 4, -2, 4 };
            var obstracles = new int[][] { new int[] { 2, 4 } };
            var expected = 65;
            var actual = WalkingRobotSimulation.RobotSim(command, obstracles);
            Assert.AreEqual(expected, actual);
        }
    }
}

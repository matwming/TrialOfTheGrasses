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

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            //             [-2,-1,8,9,6]
            // [[-1,3],[0,1],[-1,5],[-2,-4],[5,4],[-2,-3],[5,-1],[1,-1],[5,5],[5,2]]
            var command = new int[] { -2, -1, 8, 9, 6 };
            var obstracles = new int[][] {
                new int[] { -1,3 },
                new int[] { 0,1 },
                new int[] { -1,5 },
                new int[] { -2,-4 },
                new int[] { 5,4 },
                new int[] { -2,-3 },
                new int[] { 5,-1 },
                new int[] { 1,-1 },
                new int[] { 5,5},
                new int[] { 5,2 },
             };
            var expected = 0;
            var actual = WalkingRobotSimulation.RobotSim(command, obstracles);
            Assert.AreEqual(expected, actual);
        }
    }
}

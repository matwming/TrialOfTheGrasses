using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class DietPlanPerformanceUnitTest
    {
        public DietPlanPerformance DietPlanPerformance { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DietPlanPerformance = new DietPlanPerformance();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var calories = new[] { 1, 2, 3, 4, 5 };
            var k = 1;
            var lower = 3;
            var upper = 3;
            var expected = 0;
            var actual = DietPlanPerformance.DietPlanPerform(calories, k, lower, upper);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var calories = new[] { 3, 2 };
            var k = 2;
            var lower = 0;
            var upper = 1;
            var expected = 1;
            var actual = DietPlanPerformance.DietPlanPerform(calories, k, lower, upper);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var calories = new[] { 6, 5, 0, 0 };
            var k = 2;
            var lower = 1;
            var upper = 5;
            var expected = 0;
            var actual = DietPlanPerformance.DietPlanPerform(calories, k, lower, upper);
            Assert.AreEqual(expected, actual);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class PowerfulIntegersUnitTest
    {
        public PowerfulIntegers powerfulIntegers { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            powerfulIntegers = new PowerfulIntegers();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            int x = 2, y = 3, bound = 10;
            var expected = new List<int>(new int[] {2,3,4,5,7,9,10});
            var actual = powerfulIntegers.PowerfulIntegersSln(x,y,bound);
            var a = expected.All(actual.Contains) && expected.Count == actual.Count;
            Assert.IsTrue(a);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            int x = 1, y = 2, bound = 100;
            var expected = new List<int>(new int[] {2,3,4,5,7,9,10});
            var actual = powerfulIntegers.PowerfulIntegersSln(x,y,bound);
        }
    }
}
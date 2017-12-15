using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class JudgeRouteCircleUnitTest
    {
        [TestMethod]
        public void JudgeRouteCircleTestMethod()
        {
            JudgeRouteCircle judgeRouteCircle = new JudgeRouteCircle();
            Assert.AreEqual(true, judgeRouteCircle.JudgeRouteCircleSolution("UUDDRRLL"));
            Assert.AreEqual(false, judgeRouteCircle.JudgeRouteCircleSolution(""));
            Assert.AreEqual(false, judgeRouteCircle.JudgeRouteCircleSolution("UDDUURLRLLRRUDUDLLRLURLRLRLUUDLULRULRLDDDUDDDDLRRDDRDRLRLURRLLRUDURULULRDRDLURLUDRRLRLDDLUUULUDUUUUL"));
        }
    }
}

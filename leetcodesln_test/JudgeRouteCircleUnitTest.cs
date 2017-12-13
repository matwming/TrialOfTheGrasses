using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
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

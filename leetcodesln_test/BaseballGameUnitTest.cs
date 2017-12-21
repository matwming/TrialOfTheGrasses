using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class BaseballGameUnitTest
    {
        [TestMethod]
        public void BaseballGameTestMethod()
        {
            BaseballGame baseballGame = new BaseballGame();
            Assert.AreEqual(30,baseballGame.CalPoints(new string[] { "5", "2", "C", "D", "+" }));
            Assert.AreEqual(5,baseballGame.CalPoints(new string[] { "5"}));
            Assert.AreEqual(7,baseballGame.CalPoints(new string[] { "5","2"}));
        }
    }
}

using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodestest
{
    [TestClass]
    public class AddDigitsTest
    {
        [TestMethod]
        public void AddDigitssTestMethod()
        {
            AddDigits addDigits = new AddDigits();
            Assert.AreEqual(2, addDigits.AddDigitsMethod(38));
        }
    }
}

using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class AddDigitsUnitTest
    {
        [TestMethod]
        public void AddDigitsMethodTest()
        {
            AddDigits addDigits = new AddDigits();
            Assert.AreEqual(2,addDigits.AddDigitsMethod(38));
        }
    }
}

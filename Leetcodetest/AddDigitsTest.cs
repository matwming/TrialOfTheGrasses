using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodetest.AddDigitsTest
{
    [TestClass]
    public class AddDigitsTest
    {
        [TestMethod]
        public void AddDigitsTestMethod()
        {
            AddDigits addDigits = new AddDigits();
            Assert.AreEqual(2,addDigits.AddDigitsMethod(38));
        }
        
    }
}

using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class RotateStringUnitTest
    {
        [TestMethod]
        public void RotateStringTestMethod()
        {
            RotateString rotateString = new RotateString();

            Assert.AreEqual(true, rotateString.RotateStringSln("abcde", "cdeab"));
            Assert.AreEqual(false, rotateString.RotateStringSln("abcde", "abced"));
        }
    }
}

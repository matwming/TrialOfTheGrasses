using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class JewelsAndStonesUnitTest
    {
        [TestMethod]
        public void NumJewelsInStonesMethodTest()
        {
            JewelsAndStones jewelsAndStones = new JewelsAndStones();
            Assert.AreEqual(3, jewelsAndStones.NumJewelsInStones("aA", "aAAbbbb"));
            Assert.AreEqual(0, jewelsAndStones.NumJewelsInStones("z", "ZZ"));
        }
    }
}

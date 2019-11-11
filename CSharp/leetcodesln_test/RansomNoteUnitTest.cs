using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class RansomeNoteUnitTest
    {
        [TestMethod]
        public void RansomeNoteTestMethod()
        {
            RansomNote ransomNote = new RansomNote();
            Assert.AreEqual(false,ransomNote.CanConstruct("a","b")); 
            Assert.AreEqual(false,ransomNote.CanConstruct("a","b")); 
            Assert.AreEqual(true,ransomNote.CanConstruct("aa","aab")); 
        }
    }
}
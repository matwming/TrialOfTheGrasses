using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class _1BitAnd2BitCharactersUnitTest
    {
        [TestMethod]
        public void _1BitAnd2BitCharactersTestMethod()
        {
            _1BitAnd2BitCharacters _1BitAnd2BitCharacters = new _1BitAnd2BitCharacters();
            Assert.AreEqual(true, _1BitAnd2BitCharacters.IsOneBitCharacter(new int[] { 1, 0, 0 }));
            Assert.AreEqual(false,_1BitAnd2BitCharacters.IsOneBitCharacter(new int[] { 1,1,1,0}));
            Assert.AreEqual(true, _1BitAnd2BitCharacters.IsOneBitCharacter(new int[] { 0 }));
            Assert.AreEqual(true, _1BitAnd2BitCharacters.IsOneBitCharacter(new int[] { 0, 0 }));
        }
    }
}

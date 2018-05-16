using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class GoatLatinUnitTest
    {
        [TestMethod]
        public void GoatLatinTestMethod()
        {
            GoatLatin goatLatin = new GoatLatin();
            var expected = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";
            var actual = goatLatin.ToGoatLatin("I speak Goat Latin");
            Assert.AreEqual(expected, actual);

            var expected2 = "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa";
            var actual2 = goatLatin.ToGoatLatin("The quick brown fox jumped over the lazy dog");
            Assert.AreEqual(expected2, actual2);
        }
    }
}
using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ReverseWordsInAStringIIIUnitTest
    {
        public ReverseWordsInAStringIII reverseWordsInAStringIII { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            reverseWordsInAStringIII = new ReverseWordsInAStringIII();
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseWordsInAStringIIITestMethod1()
        {
            var input = "Let's take LeetCode contest";
            var expected = "s'teL ekat edoCteeL tsetnoc";
            var actual = reverseWordsInAStringIII.ReverseWords(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void ReverseWordsInAStringIIITestMethod2()
        {
            var input = "let";
            var expected = "tel";
            var actual = reverseWordsInAStringIII.ReverseWords(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

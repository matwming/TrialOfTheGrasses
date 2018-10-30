using System.Linq;
using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class UncommonWordsFromTwoSentencesUnitTest
    {
        [TestMethod]
        public void UncommonWordsFromTwoSentencesTestMethod()
        {
            var uncommonWordsFromTwoSentences = new UncommonWordsFromTwoSentences();
            var input1_A = "this apple is sweet";
            var input1_B = "this apple is sour";
            var expected1 = new string[] {"sweet", "sour"};
            var actual1 = uncommonWordsFromTwoSentences.UncommonFromSentences(input1_A, input1_B);
            Assert.AreEqual(expected1.Length, actual1.Length);
            foreach (var str in actual1)
            {
                Assert.IsTrue(expected1.ToList().Contains(str));
            }
        }
    }
}
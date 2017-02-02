using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class LongestWordInDictionaryUnitTest
    {
        [TestMethod]
        public void LongestWordInDictionaryTestMethod()
        {
            var longestWordInDictionary = new LongestWordInDictionary();
            var input1 = new string[] {"w", "b","wo", "wor", "worl", "world"};
            var actual1 = longestWordInDictionary.LongestWord(input1);
        }
    }
}
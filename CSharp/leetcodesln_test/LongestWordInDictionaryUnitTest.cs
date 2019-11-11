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
            var expected1 = "world";
            var actual1 = longestWordInDictionary.LongestWord(input1);
            Assert.AreEqual(expected1, actual1);

            var input2 = new string[] {  };
            var expected2 = "";
            var actual2 = longestWordInDictionary.LongestWord(input2);
            Assert.AreEqual(expected2, actual2);

            var input3 = new string[] {"a", "banana", "app", "appl", "ap", "apply", "apple"};
            var expected3 = "apple";
            var actual3 = longestWordInDictionary.LongestWord(input3);
            Assert.AreEqual(expected3, actual3);

            var input4 = new string[] { "m", "mo", "moc", "moch", "mocha", "l", "la", "lat", "latt", "latte", "c", "ca", "cat"};
            var expected4 = "latte";
            var actual4 = longestWordInDictionary.LongestWord(input4);
            Assert.AreEqual(expected4, actual4);

            var input5 = new string[] {"t", "ti", "tig", "tige", "tiger", "e", "en", "eng", "engl", "engli", "englis", "english", "h", "hi", "his", "hist", "histo", "histor", "history"};
            var expected5 = "english";
            var actual5 = longestWordInDictionary.LongestWord(input5);
            Assert.AreEqual(expected5, actual5);
        }
    }
}
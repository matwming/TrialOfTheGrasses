using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace leetcodesln_test
{
    [TestClass]
    public class LongestWordInDictionaryThroughDeletingUnitTest
    {
        public LongestWordInDictionaryThroughDeleting LongestWordInDictionaryThroughDeleting { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            LongestWordInDictionaryThroughDeleting = new LongestWordInDictionaryThroughDeleting();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var s = "abpcplea";
            var d = new List<string> { "ale", "apple", "monkey", "plea" };
            var expected = "apple";
            var actual = LongestWordInDictionaryThroughDeleting.FindLongestWord(s, d);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var s = "abpcplea";
            var d = new List<string> { "a", "b", "c" };
            var expected = "a";
            var actual = LongestWordInDictionaryThroughDeleting.FindLongestWord(s, d);
            Assert.AreEqual(expected, actual);
        }
    }
}

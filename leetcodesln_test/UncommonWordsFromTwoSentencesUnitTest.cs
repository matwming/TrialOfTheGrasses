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

            var input2_A = "abcd def abcd xyz";
            var input2_B = "ijk def ijk";
            var expected2 = new string[] { "xyz" };
            var actual2 = uncommonWordsFromTwoSentences.UncommonFromSentences(input2_A, input2_B);
            Assert.AreEqual(expected2.Length, actual2.Length);
            foreach (var str in actual2)
            {
                Assert.IsTrue(expected2.ToList().Contains(str));
            }

            var input3_A = "s z z z s";
            var input3_B = "s z ejt";
            var expected3 = new string[] { "ejt" };
            var actual3 = uncommonWordsFromTwoSentences.UncommonFromSentences(input3_A, input3_B);
            Assert.AreEqual(expected3.Length, actual3.Length);
            foreach (var str in actual3)
            {
                Assert.IsTrue(expected3.ToList().Contains(str));
            }
        }
    }
}
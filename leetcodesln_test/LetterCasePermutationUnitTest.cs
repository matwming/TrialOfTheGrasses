using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class LetterCasePermutationUnitTest
    {
        [TestMethod]
        public void LetterCasePermutationTestMethod()
        {
            LetterCasePermutation lcp = new LetterCasePermutation();
            List<string> expected = new List<string> { "a1b2", "a1B2", "A1b2", "A1B2" };
            var input = "a1b2";
            IList<string> actual = lcp.LetterCasePermutationSln(input);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}

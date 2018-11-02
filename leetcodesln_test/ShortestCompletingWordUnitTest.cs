using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ShortestCompletingWordUnitTest
    {
        [TestMethod]
        public void ShortestCompletingWordTestMethod()
        {
            var shortestCompletingWord = new ShortestCompletingWord();
            var input1_licenseplate = "1s3 PSt";
            var input1_words = new string[] { "step", "steps", "stripe", "stepple" };
            var expected1 = "steps";
            var actual1 = shortestCompletingWord.ShortestCompletingWordSln(input1_licenseplate, input1_words);
            Assert.AreEqual(expected1, actual1);

            var input2_licenseplate = "1s3 456";
            var input2_words = new string[] { "looks", "pest", "stew", "show" };
            var expected2 = "pest";
            var actual2 = shortestCompletingWord.ShortestCompletingWordSln(input2_licenseplate, input2_words);
            Assert.AreEqual(expected2, actual2);
        }
    }
}

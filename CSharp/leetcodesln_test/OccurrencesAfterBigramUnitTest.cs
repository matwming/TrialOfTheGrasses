using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class OccurrencesAfterBigramUnitTest
    {
        public OccurrencesAfterBigram OccurrencesAfterBigram { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            OccurrencesAfterBigram = new OccurrencesAfterBigram();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var text = "alice is a good girl she is a good student";
            var first = "a";
            var second = "good";
            var expected = new string[] { "girl", "student" };
            var actual = OccurrencesAfterBigram.FindOcurrences(text, first, second);
            Assert.IsTrue(Helper<string>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var text = "we will we will rock you";
            var first = "we";
            var second = "will";
            var expected = new string[] { "we", "rock" };
            var actual = OccurrencesAfterBigram.FindOcurrences(text, first, second);
            Assert.IsTrue(Helper<string>.HaveSameElementsForTwoCollections(expected, actual));
        }
    }
}

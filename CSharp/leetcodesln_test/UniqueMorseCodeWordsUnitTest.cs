using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class UniqueMorseCodeWordsUnitTest
    {
        [TestMethod]
        public void UniqueMorseCodeWordsTestMethod()
        {
            UniqueMorseCodeWords umcw = new UniqueMorseCodeWords();

            Assert.AreEqual(2, umcw.UniqueMorseRepresentations(new string[] { "gin", "zen", "gig", "msg" }));
        }
    }
}

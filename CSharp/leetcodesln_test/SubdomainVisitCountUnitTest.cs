using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class SubdomainVisitCountUnitTest
    {
        [TestMethod]
        public void SubdomainVisitCountTestMethod()
        {
            SubdomainVisitCount sdbc = new SubdomainVisitCount();
            var result = sdbc.SubdomainVisits(new string[]{ "9001 discuss.leetcode.com"});
            string[] excepted = { "9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com" };
            for (int i = 0; i < excepted.Length; i++)
            {
                Assert.AreEqual(excepted[i], result[i]);
            }
        }
    }
}

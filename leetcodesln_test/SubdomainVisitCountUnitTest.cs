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
            Assert.AreEqual(null, sdbc.SubdomainVisits(new string[]{ "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"}));
        }
    }
}

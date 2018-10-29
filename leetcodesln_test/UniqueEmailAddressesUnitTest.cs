using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class UniqueEmailAddressesUnitTest
    {
        [TestMethod]
        public void UniqueEmailAddressesTestMethod()
        {
            var uniqueEmailAddresses = new UniqueEmailAddresses();
            var input1 = new string[] {"test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"};
            var expected1 = 2;
            var actual1 = uniqueEmailAddresses.NumUniqueEmails(input1);
            Assert.AreEqual(expected1, actual1);
        }
    }
}
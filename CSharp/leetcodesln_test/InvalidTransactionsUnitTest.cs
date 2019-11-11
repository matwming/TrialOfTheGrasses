using leetcodesln;
using leetcodesln_test.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class InvalidTransactionsUnitTest
    {
        public InvalidTransactions InvalidTransactions { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            InvalidTransactions = new InvalidTransactions();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var transactions = new[] { "alice,20,800,mtv", "alice,50,100,beijing" };
            var expected = new[] { "alice,20,800,mtv", "alice,50,100,beijing" };
            var actual = InvalidTransactions.InvalidTranscationsSln(transactions);
            Assert.IsTrue(Helper<string>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var transactions = new[] { "alice,20,800,mtv", "alice,50,1200,mtv" };
            var expected = new[] { "alice,50,1200,mtv" };
            var actual = InvalidTransactions.InvalidTranscationsSln(transactions);
            Assert.IsTrue(Helper<string>.HaveSameElementsForTwoCollections(expected, actual));
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var transactions = new[] { "alice,20,800,mtv", "bob,50,1200,mtv" };
            var expected = new[] { "bob,50,1200,mtv" };
            var actual = InvalidTransactions.InvalidTranscationsSln(transactions);
            Assert.IsTrue(Helper<string>.HaveSameElementsForTwoCollections(expected, actual));
        }

    }
}

using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class DeleteColumnsToMakeSortedUnitTest
    {
        public DeleteColumnsToMakeSorted DeleteColumnsToMakeSorted { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            DeleteColumnsToMakeSorted = new DeleteColumnsToMakeSorted();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new string[] { "cba", "daf", "ghi" };
            var expected = 1;
            var actual = DeleteColumnsToMakeSorted.MinDeletionSize(input);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var input = new string[] { "a", "b" };
            var expected = 0;
            var actual = DeleteColumnsToMakeSorted.MinDeletionSize(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var input = new string[] { "zyx", "wvu", "tsr"};
            var expected = 3;
            var actual = DeleteColumnsToMakeSorted.MinDeletionSize(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

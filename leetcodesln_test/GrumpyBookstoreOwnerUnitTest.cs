using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class GrumpyBookstoreOwnerUnitTest
    {
        public GrumpyBookstoreOwner GrumpyBookstoreOwner { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            GrumpyBookstoreOwner = new GrumpyBookstoreOwner();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var customers = new int[] { 1, 0, 1, 2, 1, 1, 7, 5 };
            var grumpy = new int[] { 0, 1, 0, 1, 0, 1, 0, 1 };
            var X = 3;
            var expected = 16;
            var actual = GrumpyBookstoreOwner.MaxSatisfied(customers, grumpy, X);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod, Timeout(20_000)]
        public void TestMethod2()
        {
            var customers = new int[] { 1 };
            var grumpy = new int[] { 0 };
            var X = 1;
            var expected = 1;
            var actual = GrumpyBookstoreOwner.MaxSatisfied(customers, grumpy, X);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod3()
        {
            var customers = new int[] { 3 };
            var grumpy = new int[] { 1 };
            var X = 1;
            var expected = 3;
            var actual = GrumpyBookstoreOwner.MaxSatisfied(customers, grumpy, X);
            Assert.AreEqual(expected, actual);
        }
    }
}

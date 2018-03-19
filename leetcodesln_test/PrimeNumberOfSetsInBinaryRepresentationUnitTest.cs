using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class PrimeNumberOfSetsInBinaryRepresentationUnitTest
    {
        [TestMethod]
        public void PrimeNumberOfSetsInBinaryRepresentationTestMethod()
        {
            PrimeNumberOfSetBitsInBinaryRepresentation pndsbibr = new PrimeNumberOfSetBitsInBinaryRepresentation();

            Assert.AreEqual(4, pndsbibr.CountPrimeSetBits(6, 10));
            Assert.AreEqual(5, pndsbibr.CountPrimeSetBits(10, 15));
            Assert.AreEqual(21, pndsbibr.CountPrimeSetBits(567, 607));
        }
    }
}

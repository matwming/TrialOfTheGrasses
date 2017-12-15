using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class NumberComplementUnitTest
    {
        [TestMethod]
        public void NumberComplementTestMethod()
        {
            NumberComplement numberComplement = new NumberComplement();
            Assert.AreEqual(2,numberComplement.FindComplement(5));
            Assert.AreEqual(0,numberComplement.FindComplement(1));
        }
    }
}

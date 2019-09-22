using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class MimimumAbsoluteDifferenceUnitTest
    {
        public MinimumAbsoluteDifference MimimumAbsoluteDifference { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            MimimumAbsoluteDifference = new MinimumAbsoluteDifference();
        }

        [TestMethod, Timeout(20_000)]
        public void TestMethod1()
        {
            var input = new[] { 4, 2, 1, 3 };
            var actual = MimimumAbsoluteDifference.MinimumAbsDifference(input);
        }

    }
}

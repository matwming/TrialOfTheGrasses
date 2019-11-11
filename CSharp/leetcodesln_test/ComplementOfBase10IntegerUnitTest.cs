using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class ComplementOfBase10IntegerUnitTest
    {
        public ComplementOfBase10Integer ComplementOfBase10Integer { get; set; }

        [TestInitialize]
        public void BeforeEach()
        {
            ComplementOfBase10Integer = new ComplementOfBase10Integer();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var input = 5;
            var expected = 2;
            var actual = ComplementOfBase10Integer.BitwiseComplement(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var input = 7;
            var expected = 0;
            var actual = ComplementOfBase10Integer.BitwiseComplement(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var input = 10;
            var expected = 5;
            var actual = ComplementOfBase10Integer.BitwiseComplement(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var input = 0;
            var expected = 1;
            var actual = ComplementOfBase10Integer.BitwiseComplement(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
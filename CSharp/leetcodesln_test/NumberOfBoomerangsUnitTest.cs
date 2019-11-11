using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class NumberOfBoomerangsUnitTest
    {
        [TestMethod]
        public void NumberOfBoomerangsTestMethod()
        {
            NumberOfBoomerangs numberOfBoomerangs = new NumberOfBoomerangs();
            Assert.AreEqual(2, numberOfBoomerangs.NumberOfBoomerangsSln(new int[,] { {0,0},{1,0},{2,0} }));
        }
    }
}

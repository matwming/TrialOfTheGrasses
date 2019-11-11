using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class MinimumMovesToEqualArrayElementsUnitTest
    {
        [TestMethod]
        public void MinimumMovesToEqualArrayElementsTestMethod()
        {
            MinimumMovesToEqualArrayElements minimumMovesToEqualArrayElements = new MinimumMovesToEqualArrayElements();
            Assert.AreEqual(3,minimumMovesToEqualArrayElements.MinMoves(new int[]{1,2,3}));
            Assert.AreEqual(2147483646,minimumMovesToEqualArrayElements.MinMoves(new int[]{1,2147483647}));
        }
    }
}
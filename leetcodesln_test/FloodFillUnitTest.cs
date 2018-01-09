using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class FloodFillUnitTest
    {
        [TestMethod]
        public void FloodFillTestMethod()
        {
            FloodFill floodFill = new FloodFill();
            int[,] result = new int[,] { { 2, 2, 2 }, { 2, 2, 0 }, { 2, 0, 1 } };
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Assert.AreEqual(result[i, j], floodFill.FloodFillSln
                        (new int[,] { { 1, 1, 1 }, { 1, 1, 0 }, { 1, 0, 1 } }, 1, 1, 2)[i, j]);
                }
            }

            int[,] result2 = new int[,] { { 0,0,0}, { 0,1,1} };
            for (int i = 0; i < result2.GetLength(0); i++)
            {
                for (int j = 0; j < result2.GetLength(1); j++)
                {
                    Assert.AreEqual(result2[i, j], floodFill.FloodFillSln
                        (new int[,] { { 0,0,0}, { 0, 1, 1 } }, 1, 1, 1)[i, j]);
                }
            }
        }
    }
}

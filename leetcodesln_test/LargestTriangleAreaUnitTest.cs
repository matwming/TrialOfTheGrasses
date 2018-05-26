using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace leetcodesln_test
{
    [TestClass]
    public class LargestTriangleAreaUnitTest
    {
        [TestMethod]
        public void LargestTriangleAreaTestMethod()
        {
            LargestTriangleArea lta = new LargestTriangleArea();
            int[][] input = new int[5][];
            input[0] = new int[] {0,0};
            input[1] = new int[] {0,1};
            input[2] = new int[] {1,0};
            input[3] = new int[] {0,2};
            input[4] = new int[] {2,0};
            double expected = 2.0;
            double actual = lta.MaxTriangleArea(input);
            Assert.AreEqual(expected, actual);
                                    
        }
    }
}
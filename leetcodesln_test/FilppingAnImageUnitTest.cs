using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class FilppingAnImageUnitTest
    {
        [TestMethod]
        public void FilppingAnImageTestMethod()
        {
            FlippingAnImage flippingAnImage = new FlippingAnImage();
            int[][] expected = new int[4][];
            expected[0] = new int[] { 1, 1, 0, 0 };
            expected[1] = new int[] { 0, 1, 1, 0};
            expected[2] = new int[] { 0, 0, 0, 1};
            expected[3] = new int[] { 1, 0, 1, 0 };

            int[][] A = new int[4][];
            A[0] = new int[] { 1, 1, 0, 0 };
            A[1] = new int[] { 1, 0, 0, 1 };
            A[2] = new int[] { 0, 1, 1, 1 };
            A[3] = new int[] { 1, 0, 1, 0 };
            int[][] actual = flippingAnImage.FlipAndInvertImage(A);
            for (int i = 0; i < actual.Length; i++)
            {
                for (int j = 0; j < actual[i].Length; j++)
                {
                    Assert.AreEqual(expected[i][j], actual[i][j]);
                }
            }

        }
    }
}

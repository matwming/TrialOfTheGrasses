using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ToeplitzMatrixUnitTest
    {
        [TestMethod]
        public void ToeplitzMatrixTestMethod()
        {
            ToeplitzMatrix toeplitzMatrix = new ToeplitzMatrix();
            int[,] matrix1 = { { 1,2,3,4 }, { 5,1,2,3 }, { 9,5,1,2 } };
            int[,] matrix2 = { { 1, 2 }, { 2, 2 } };
            Assert.AreEqual(true, toeplitzMatrix.IsToeplitzMatrix(matrix1));
            Assert.AreEqual(false, toeplitzMatrix.IsToeplitzMatrix(matrix2));
        }
    }
}

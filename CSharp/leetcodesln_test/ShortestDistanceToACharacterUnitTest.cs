using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [TestClass]
    public class ShortestDistanceToACharacterUnitTest
    {
        [TestMethod]
        public void ShortestDistanceToACharacterTestMethod()
        {
            ShortestDistanceToACharacter shortestDistanceToACharacter = new ShortestDistanceToACharacter();
            //int[] expected = new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 };
            //int[] actual = shortestDistanceToACharacter.ShrtestToChar("loveleetcode", 'e');
            //for (int i = 0; i < expected.Length; i++)
            //{
            //    Assert.AreEqual(expected[i], actual[i]);
            //}

            int[] expected2 = new int[] { 1, 0, 1, 2 };
            int[] actual2 = shortestDistanceToACharacter.ShrtestToChar("abaa", 'b');
            for (int i = 0; i < expected2.Length; i++)
            {
                Assert.AreEqual(expected2[i], actual2[i]);
            }
        }
    }
}

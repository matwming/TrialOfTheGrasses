using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodesln_test
{
    [TestClass]
    public class NumberOfLinesToWriteStringUnitTest
    {
        [TestMethod]
        public void NumberOfLinesTestMethod()
        {
            NumberOfLinesToWriteString nfltws = new NumberOfLinesToWriteString();
            // case 1
            int[] expected1 = {3, 60};
            int[] result1 = nfltws.NumberOfLines(new int[] {10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10}, "abcdefghijklmnopqrstuvwxyz");
            for (int i = 0; i < expected1.Length; i++)
            {
                Assert.AreEqual(expected1[i], result1[i]);
            }
            // case 2
            int[] expected2 = {2, 4};
            int[] result2 = nfltws.NumberOfLines(new int[] {4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10}, "bbbcccdddaaa");
            for (int i = 0; i < expected2.Length; i++)
            {
                Assert.AreEqual(expected2[i], result2[i]);
            }
            //case 3
            int[] expected3 = {7, 69};
            int[] result3 = nfltws.NumberOfLines(new int[] {7,5,4,7,10,7,9,4,8,9,6,5,4,2,3,10,9,9,3,7,5,2,9,4,8,9}, "zlrovckbgjqofmdzqetflraziyvkvcxzahzuuveypqxmjbwrjvmpdxjuhqyktuwjvmbeswxuznumazgxvitdrzxmqzhaaudztgie");
            for (int i = 0; i < expected3.Length; i++)
            {
                Assert.AreEqual(expected3[i], result3[i]);
            }
        }
    }
}
using System.Collections.Generic;

namespace leetcodesln
{
    public class AddToArray_FormOfInteger
    {
        public IList<int> AddToArrayForm(int[] A, int K)
        {
            var carry = 0;
            var result = new List<int>();

            for (int i = A.Length - 1; i >= 0 || K != 0 || carry !=0; i--, K/=10)
            {
                var valueToBeInserted = (i >= 0 ? A[i] : 0) + carry + (K == 0 ? 0 : K % 10);

                carry = valueToBeInserted > 9 ? 1:0;

                result.Insert(0, valueToBeInserted % 10);
            }
            return result;
        }
    }
}
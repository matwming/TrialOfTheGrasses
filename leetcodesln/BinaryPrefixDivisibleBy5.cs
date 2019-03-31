using System.Collections.Generic;

namespace leetcodesln
{
    public class BinaryPrefixDivisibleBy5
    {

        // this method will result in Runtime Error (System.OverflowException: Value was either too large or too small for a UInt64.)
        //public IList<bool> PrefixesDivBy5(int[] A)
        //{
        //    var result = new List<bool>();

        //    for (int i = 1; i <= A.Length; i++)
        //    {
        //        var sb = new StringBuilder();
        //        for (int j = 0; j < i; j++)
        //        {
        //            sb.Append(A[j]);
        //        }
        //        var inte = Convert.ToDecimal(sb.ToString()); // overflow
        //        result.Add(inte % 5 == 0);
        //    }

        //    return result;
        //}

        public IList<bool> PrefixesDivBy5(int[] A)
        {
            var sum = 0;
            var result = new List<bool>();

            foreach (var bit in A)
            {
                sum <<= 1;
                sum += bit;
                result.Add(sum % 5 == 0);
                sum %= 5;  //prevent overflow
            }
            return result;
        }
    }
}

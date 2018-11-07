using System;
using System.Linq;

namespace leetcodesln
{
    public class FairCandySwap
    {
        public int[] FairSwap(int[] A, int[] B)
        {
            var totalcandy = A.Sum() + B.Sum();
            var fairnumber = totalcandy / 2;
            var suma = A.Sum();
            var sumb = B.Sum();
            foreach (var numa in A)
            {
                foreach (var numb in B)
                {
                    if (suma - numa + numb == sumb - numb + numa)
                    {
                        return new int[] { numa, numb };
                    }
                }
            }
            throw new Exception("cannot find a result");
        }
    }
}

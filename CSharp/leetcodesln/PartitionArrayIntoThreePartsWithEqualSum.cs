using System.Linq;

namespace leetcodesln
{
    public class PartitionArrayIntoThreePartsWithEqualSum
    {
        public bool CanThreePartsEqualSum(int[] A)
        {
            var total = A.Sum();
            if (total % 3 != 0) return false;

            var partialSum = total / 3;

            for (int i = 0, currentSum = 0, count = 0; i < A.Length; ++i)
            {
                currentSum += A[i];
                if (currentSum != partialSum) continue;
                if (++count == 3) return true;
                currentSum = 0;
            }
            return false;
        }
    }
}

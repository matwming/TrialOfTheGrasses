namespace leetcodesln
{
    public class ValidMountainArray
    {

        // one way climbing mountain solution
        //public bool IsValidMountainArray(int[] A)
        //{
        //    if (A.Length < 3) return false;
        //    if (A[0] > A[1]) return false;

        //    var turningPointCount = 0;

        //    for (int i = 2; i < A.Length; i++)
        //    {
        //        if (turningPointCount > 1) return false;

        //        if (A[i] - A[i - 1] >= 0)
        //        {
        //            if (turningPointCount != 0) return false;
        //        }
        //        if (A[i] - A[i - 1] < 0 && turningPointCount == 0)
        //        {
        //            turningPointCount++;
        //        }
        //    }
        //    return turningPointCount == 1;
        //}

        // two ways climbing mountain solution
        public bool IsValidMountainArray(int[] A)
        {
            int n = A.Length, left = 0, right = n - 1;
            while (left + 1 < n && A[left] < A[left + 1]) left++;
            while (right - 1 > 0 && A[right - 1] > A[right]) right--;
            return left > 0 && left == right && right < n - 1;
        }
    }
}

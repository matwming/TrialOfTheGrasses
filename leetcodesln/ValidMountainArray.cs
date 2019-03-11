namespace leetcodesln
{
    public class ValidMountainArray
    {
        public bool IsValidMountainArray(int[] A)
        {
            if (A.Length < 3) return false;
            if (A[0] > A[1]) return false;

            var turningPointCount = 0;

            for (int i = 2; i < A.Length; i++)
            {
                if (turningPointCount > 1) return false;

                if (A[i] - A[i - 1] >= 0)
                {
                    if (turningPointCount != 0) return false;
                }
                if (A[i] - A[i - 1] < 0 && turningPointCount == 0)
                {
                    turningPointCount++;
                }
            }
            return turningPointCount == 1;
        }
    }
}

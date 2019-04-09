namespace leetcodesln
{
    public class MonotonicArray
    {
        //two pass
        //public bool IsMonotonic(int[] A)
        //{
        //    return IsDecreasing(A) || IsIncreasing(A);
        //}

        //private bool IsIncreasing(int[] a)
        //{
        //    for (int i = 0; i < a.Length - 1; i++)
        //    {
        //        if (a[i] > a[i + 1]) return false;
        //    }
        //    return true;
        //}

        //private bool IsDecreasing(int[] a)
        //{
        //    for (int i = a.Length - 1; i >= 1; --i)
        //    {
        //        if (a[i] > a[i - 1]) return false;
        //    }
        //    return true;
        //}

        // one pass
        public bool IsMonotonic(int[] A)
        {
            int status = 0;

            for (int i = 0; i < A.Length - 1; ++i)
            {

                var sign = A[i].CompareTo(A[i + 1]);
                if (sign != 0)
                {
                    if (sign != status && status != 0) return false;
                    status = sign;
                }

            }
            return true;
        }
    }
}

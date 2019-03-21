using System;

namespace leetcodesln
{
    public class BuddyStrings
    {
        public bool BuddyStringsSln(string A, string B)
        {
            if (A.Length != B.Length) return false;

            bool isChecked = false;
            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (!isChecked)
                {
                    if (A[i] != B[i])
                    {
                        sum += A[i];
                        sum += B[i];
                        isChecked = true;
                    }
                }
                if (isChecked)
                {
                    if (A[i] != B[i])
                    {
                        sum -= A[i];
                        sum -= B[i];
                        break;
                    }
                }

            }
            return isChecked && sum == 0;
        }
    }
}
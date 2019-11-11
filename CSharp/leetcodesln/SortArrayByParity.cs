namespace leetcodesln
{
    public class SortArrayByParity
    {
        //public int[] SortArrayByParitySln(int[] A) 
        //{
        //    int[] result = new int[A.Length];
        //    for (int i = 0, j = A.Length -1, d = 0; i < A.Length; i++)
        //    {
        //        if(A[i]%2==0)
        //        {
        //            result[d] = A[i];
        //            d++;
        //        }
        //        else
        //        {
        //            result[j] = A[i];
        //            j--; 
        //        }
        //    }
        //    return result;    
        //}


        /// <summary>
        /// in-place swap solution
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int[] SortArrayByParitySln(int[] A)
        {
            var left = 0;
            var right = A.Length - 1;

            while (left <= right)
            {
                if (A[left] % 2 == 0 && A[right] % 2 == 0)
                {
                    ++left;
                }
                else if (A[left] % 2 == 1 && A[right] % 2 == 1)
                {
                    --right;
                }
                else if (A[left] % 2 == 1 && A[right] % 2 == 0)
                {
                    // swap
                    var temp = A[left];
                    A[left] = A[right];
                    A[right] = temp;
                }
                else
                {
                    ++left;
                    --right;
                }
            }
            return A;
        }
    }
}
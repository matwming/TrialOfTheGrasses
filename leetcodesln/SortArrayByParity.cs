namespace leetcodesln
{
    public class SortArrayByParity
{
    public int[] SortArrayByParitySln(int[] A) 
    {
        int[] result = new int[A.Length];
        for (int i = 0, j = A.Length -1, d = 0; i < A.Length; i++)
        {
            if(A[i]%2==0)
            {
                result[d] = A[i];
                d++;
            }
            else
            {
                result[j] = A[i];
                j--; 
            }
        }
        return result;    
    }
}
}
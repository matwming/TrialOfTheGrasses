namespace leetcodesln
{
    public class MagicalString
    {
        public int MagicalStringSln(int n)
        {
            if (n == 0) return 0;
            if (n <= 3) return 1;
            var arr = new int[2 * n];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 2;


            int tail = 2, head = tail + 1, num = 1, result = 1;

            while (head <= n - 1)
            {
                for (int i = 0; i < arr[tail]; ++i)
                {
                    arr[head] = num;
                    if (num == 1 && head < n) result++;
                    head++;
                }

                tail++;
                num = 3 - num;
            }
            return result;
        }
    }
}

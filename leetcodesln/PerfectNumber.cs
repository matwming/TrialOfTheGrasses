namespace leetcodesln
{
    public class PerfectNumber
    {
        // public bool CheckPerfectNumber(int num)
        // {
        //     if (num <= 0) return false;

        //     var count = 0;

        //     for (int i = 1; i < num; i++)
        //     {
        //         if (num % i == 0) count += i;
        //     }

        //     return num == count;
        // }

        // optimized answer
        public bool CheckPerfectNumber(int num)
        {
            if (num <= 0) return false;

            var count = 0;

            for (int i = 1; i * i < num; i++)
            {
                if (num % i == 0 && i * i != num)
                {
                    count+=i;
                    count += num/i;
                }
            }
            return count / 2 == num;
        }
    }
}

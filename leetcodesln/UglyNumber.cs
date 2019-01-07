namespace leetcodesln
{
    public class UglyNumber
    {
        public bool IsUgly(int num)
        {
            if (num == 1 || num == 2 || num == 3 || num == 5) return true;
            else if (num == 0) return false;
            else if (num % 2 == 0) return IsUgly(num / 2);
            else if (num % 3 == 0) return IsUgly(num / 3);
            else if (num % 5 == 0) return IsUgly(num / 5);
            else return false;
        }
    }
}

namespace leetcodesln
{
    public class PlusOne
    {
        public int[] PlusOneSln(int[] digits)
        {
            var startingIndex = digits.Length - 1;
            while (TryAddUp(ref digits, startingIndex))
            {
                startingIndex--;
            }
            return digits;

        }

        private bool TryAddUp(ref int[] digits, int index)
        {
            var res = false;
            if (index < 0)
            {
                digits = new int[digits.Length + 1];
                for (int i = 0; i < digits.Length; i++)
                {
                    if (i == 0)
                    {
                        digits[i] = 1;
                    }
                    else
                    {
                        digits[i] = 0;
                    }
                }
                return false;
            }
            else
            {
                if (digits[index] + 1 >= 10)
                {
                    digits[index] = 0;
                    res = true;
                }
                else
                {
                    digits[index] += 1;
                }
            }
            return res;
        }
    }
}

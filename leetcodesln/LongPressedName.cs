namespace leetcodesln
{
    public class LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int n = 0, t = 0;
            while (t < typed.Length)
            {
                if (n < name.Length && name[n] == typed[t])
                {
                    n++;
                    t++;
                }
                else if (n > 0 && name[n - 1] == typed[t]) t++;
                else return false;
            }
            return n == name.Length;
        }
    }
}

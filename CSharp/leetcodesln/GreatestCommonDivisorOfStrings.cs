namespace leetcodesln
{
    public class GreatestCommonDivisorOfStrings
    {
        //recursive
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1.Length < str2.Length) return GcdOfStrings(str2, str1);

            else if (str1.Substring(0, str2.Length) != str2) return string.Empty;
            else if (string.IsNullOrEmpty(str2)) return str1;
            else return GcdOfStrings(str1.Substring(str2.Length), str2);
        }
    }
}

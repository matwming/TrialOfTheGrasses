using System.Collections.Generic;

namespace leetcodesln
{
    public class RemoveAllAdjacentDuplicatesInString
    {
        //public string RemoveDuplicates(string S)
        //{
        //    var before = S;
        //    var after = RemoveProcess(S);
        //    while(before != after)
        //    {
        //        before = after;
        //        after = RemoveProcess(after);

        //    }
        //    return after;
        //}

        //private string RemoveProcess(string s)
        //{
        //    for (int i = 0; i < s.Length-1; i++)
        //    {
        //        if(s[i] == s[i+1])
        //        {
        //            return s.Remove(i, 2);
        //        }
        //    }
        //    return s;
        //}

        // best solution using stack
        // be wary that use string concatenation can cause TLE
        public string RemoveDuplicates(string S)
        {
            var stack = new Stack<char>();

            foreach (var chr in S)
            {

                if (stack.Count != 0 && stack.Peek() == chr) stack.Pop();
                else stack.Push(chr);
            }

            var word = new char[stack.Count];
            int reverseIndex = word.Length - 1;
            while (stack.Count != 0) word[reverseIndex--] = stack.Pop();

            return new string(word);
        }
    }
}

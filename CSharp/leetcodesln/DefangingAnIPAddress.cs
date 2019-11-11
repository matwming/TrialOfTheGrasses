using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class DefangingAnIPAddress
    {
        public string DefangIPaddr(string address)
        {
            var q = new Queue<char>(address);

            var ans = new StringBuilder();

            while (q.Count != 0)
            {
                if (q.Peek() != '.')
                {
                    ans.Append(q.Dequeue());
                }
                else
                {
                    ans.Append("[");
                    ans.Append(q.Dequeue());
                    ans.Append("]");
                }
            }
            return ans.ToString();
        }
    }
}

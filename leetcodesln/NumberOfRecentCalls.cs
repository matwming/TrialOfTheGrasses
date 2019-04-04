using System.Collections.Generic;

namespace leetcodesln
{
    public class NumberOfRecentCalls
    {
        private Queue<int> Calls { get; set; }

        public NumberOfRecentCalls()
        {
            Calls = new Queue<int>();
        }

        public int Ping(int t)
        {
            Calls.Enqueue(t);
            while (Calls.Peek() < (t - 3000))
            {
                Calls.Dequeue();
            }
            return Calls.Count;
        }
    }
}

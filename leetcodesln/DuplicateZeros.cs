using System.Collections.Generic;

namespace leetcodesln
{
    public class DuplicateZeros
    {
        public void DuplicateZerosSln(int[] arr)
        {
            var q = new Queue<int>(arr);
            int i = 0;
            while (q.Count != 0 && i < arr.Length)
            {
                var current = q.Peek();
                if (current == 0)
                {
                    arr[i++] = 0;
                    q.Dequeue();
                    if (i >= arr.Length) return;
                    arr[i++] = 0;
                }
                else
                {
                    arr[i++] = current;
                    q.Dequeue();
                }
            }
        }
    }
}

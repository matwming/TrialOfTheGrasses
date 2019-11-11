using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    public class RevealCardsInIncreasingOrder
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);
            int[] ans = new int[deck.Length];
            var q = new Queue<int>();
            for (int i = 0; i < deck.Length; i++)
            {
                q.Enqueue(i);
            }

            for (int i = 0; i < ans.Length; i++)
            {
                ans[q.Peek()] = deck[i];
                q.Dequeue();
                if(q.Count!=0)
                {
                    var next = q.Dequeue();
                    q.Enqueue(next);
                }
            }
            return ans;
        }
    }
}

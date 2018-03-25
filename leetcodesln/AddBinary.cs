using System;
using System.Text;

namespace leetcodesln
{
    public class AddBinary
    {
        public string AddBinarysln(string a, string b)
        {
            //Queue<int> aQueue = new Queue<int>();
            //Queue<int> bQueue = new Queue<int>();
            //Queue<int> newQueue = new Queue<int>();

            //foreach (var character in a)
            //{
            //    aQueue.Enqueue((int)(character - '0'));
            //}
            //foreach (var character in b)
            //{
            //    bQueue.Enqueue((int)(character - '0'));
            //}
            //int aLength = a.Length;
            //int bLength = b.Length;
            //int carry = 0;
            //for (int i = 0; i < (aLength>bLength?bLength:aLength); i++)
            //{

            //    switch (aQueue.Dequeue() + bQueue.Dequeue() +  carry)
            //    {
            //        case 0:
            //            newQueue.Enqueue(0 + carry);
            //            carry = 0;
            //            break;
            //        case 1:
            //            newQueue.Enqueue(1);
            //            carry = 0;
            //            break;
            //        case 2:
            //            newQueue.Enqueue(0);
            //            carry = 1;
            //            break;
            //    }
            //}

            //for (int j = (aLength>bLength?bLength:aLength); j < (aLength > bLength ? aLength : bLength); j++)
            //{
            //    newQueue.Enqueue((aLength > bLength ? aQueue : bQueue).Dequeue());
            //}
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < newQueue.Count; i++)
            //{
            //    sb.Append(newQueue.Dequeue());
            //}
            //return sb.ToString();

            StringBuilder sb = new StringBuilder();
            int carry = 0;
            for (int i = 1; i <= (a.Length > b.Length? a.Length: b.Length); i++)
            {

                int aa = 0;
                int bb = 0;
                if (a.Length - i >= 0)
                {
                    aa = (int)(a[a.Length - i] - '0');
                }
               
                if (b.Length - i >= 0)
                {
                    bb = (int)(b[b.Length - i] - '0');
                }
                if (aa + bb + carry >=2)
                {
                    sb.Append(0);
                    carry = 1;
                }
                else
                {
                    sb.Append(aa + bb + carry);
                    carry = 0;
                }
            }
            if (carry == 1)
            {
                sb.Append(1);
            }
            char[] chars = sb.ToString().ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}

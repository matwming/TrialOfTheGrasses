using System.Collections;
using System.Collections.Generic;

namespace leetcodesln
{
    public class LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            if (typed.Length < name.Length) return false;

            var t_ptr = 0;
            var previous = '1';

            int i = 0;
            while (i< name.Length && t_ptr< typed.Length)
            {
                if (typed[t_ptr] == name[i])
                {
                    while (i < name.Length && t_ptr< typed.Length && typed[t_ptr] == name[i])
                    {
                        t_ptr++;
                        previous = name[i];
                        i++;
                    }
                }
                else return false;

                if(t_ptr< typed.Length)
                {
                    if (typed[t_ptr] == previous)
                    {
                        while (t_ptr< typed.Length && typed[t_ptr] == previous)
                        {
                            t_ptr++;
                        }
                    }
                    else return false;
                }
                
            }
            return i == name.Length;
        }
    }
}
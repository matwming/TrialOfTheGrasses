using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln
{
    // this is a AC solution
    public class LemonadeChange
    {
        public bool LemonadeChangeSln(int[] bills)
        {
            var notes = new Dictionary<string, int>();
            notes.Add("5", 0);
            notes.Add("10", 0);
            notes.Add("20", 0);
            foreach (var bill in bills)
            {
                switch(bill)
                {
                    case 5:
                        notes["5"]++;
                        break;
                    case 10:
                        if (notes["5"]<=0)
                        {
                            return false;
                        }
                        notes["5"]--;
                        notes["10"]++;
                        break;
                    case 20:
                        if (notes["10"]>0)
                        {
                            if (notes["5"]>0)
                            {
                                notes["5"]--;
                                notes["10"]--;
                                notes["20"]++;
                                break;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (notes["5"]>=3)
                            {
                                notes["5"] -= 3;
                                notes["20"]++;
                                break;
                            }
                            else
                            {
                                return false;
                            }
                        }
                }
            }
            return true;
        }
    }
}

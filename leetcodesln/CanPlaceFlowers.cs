namespace leetcodesln
{
    public class CanPlaceFlowers
    {
        // public bool CanPlaceFlowersSln(int[] flowerbed, int n)
        // {

        //     for (int i = 0; i < flowerbed.Length; i++)
        //     {
        //         if (n == 0) return true;
        //         if (CanPlace(ref flowerbed, i)) n--;
        //     }
        //     return n == 0;
        // }

        // private bool CanPlace(ref int[] flowerbed, int pos)
        // {
        //     if (flowerbed[pos] == 0)
        //     {
        //         if (pos == 0)
        //         {
        //             if (pos + 1 >= flowerbed.Length || flowerbed[pos + 1] == 0)
        //             {
        //                 flowerbed[pos] = 1;
        //                 return true;
        //             }
        //         }
        //         else
        //         {
        //             if (flowerbed[pos - 1] == 0 && (pos + 1 >= flowerbed.Length || flowerbed[pos + 1] == 0))
        //             {
        //                 flowerbed[pos] = 1;
        //                 return true;
        //             }
        //         }
        //     }
        //     return false;
        // }

        public bool CanPlaceFlowersSln(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (n == 0) return true;
                if (flowerbed[i] == 0)
                {
                    int pre = i - 1 >= 0 ? flowerbed[i - 1] : 0;
                    int next = i + 1 < flowerbed.Length ? flowerbed[i + 1] : 0;
                    if (pre == 0 && next == 0)
                    {
                        flowerbed[i] = 1;
                        n--;
                    }
                }
            }
            return n == 0;
        }
    }
}

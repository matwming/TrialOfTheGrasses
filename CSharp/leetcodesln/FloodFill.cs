namespace leetcodesln
{
    public class FloodFill
    {
        public int[,] FloodFillSln(int[,] image, int sr, int sc, int newColor)
        {
            if (image[sr,sc] == newColor)
            {
                return image;
            }
            int startingPixel = image[sr, sc];
            image[sr, sc] = newColor;
            int[,] floodFilledMatrix = PerformFloodFill(image, sr, sc, newColor, startingPixel);
            return floodFilledMatrix;
        }

        private int[,] PerformFloodFill(int[,] image, int sr, int sc, int newColor,int startingPixel)
        {
            if (sr-1 >=0 && image[sr-1,sc]==startingPixel)
            {
                image[sr - 1, sc] = newColor;
                PerformFloodFill(image, sr - 1, sc, newColor,startingPixel);
            }
            if (sr+1<image.GetLength(0) && image[sr+1,sc] == startingPixel)
            {
                image[sr + 1, sc] = newColor;
                PerformFloodFill(image, sr + 1, sc, newColor,startingPixel);
            }
            if(sc-1>=0 && image[sr,sc-1] == startingPixel)
            {
                image[sr, sc - 1] = newColor;
                PerformFloodFill(image, sr, sc - 1, newColor,startingPixel);
            }
            if (sc + 1 < image.GetLength(1) && image[sr, sc + 1] == startingPixel)
            {
                image[sr, sc + 1] = newColor;
                PerformFloodFill(image, sr, sc + 1, newColor,startingPixel);
            }
            return image;
        }
    }
}

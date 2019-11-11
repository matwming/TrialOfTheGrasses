package questions;

/**
 * Created by user3301 on 9/2/2017.
 */
public class IslandPerimeter {

    public int islandPerimeter(int[][] grid) {
        if(grid.length==0) {return 0;}
        int perimeter = 0;
        for (int i = 0; i < grid.length; i++) {
            for (int j = 0; j < grid[i].length; j++) {
                if(grid[i][j]==1) {
                    perimeter +=4;
                    if(i>0&&grid[i-1][j]==1) {
                        perimeter-=2;
                    }
                    if(j>0&&grid[i][j-1]==1) {
                        perimeter-=2;
                    }
                }

            }

        }
        return perimeter;
    }
}

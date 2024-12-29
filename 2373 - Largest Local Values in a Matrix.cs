public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int n = grid.Length;
        int[][] l = new int[n - 2][];
        for (int i = 0; i < n - 2; i++) {
            l[i] = new int[n - 2]; 
        }
        for (int i = 0; i < n - 2; i++) {
            for (int j = 0; j < n - 2; j++) {
                int maxVal = int.MinValue;
                for (int x = 0; x < 3; x++) {
                    for (int y = 0; y < 3; y++) {
                        maxVal = Math.Max(maxVal, grid[i + x][j + y]);
                    }
                }
                l[i][j] = maxVal;
            }
        }
        return l;
    }
}

public class SubrectangleQueries {

    private int[][] rectangle;

    public SubrectangleQueries(int[][] rectangle) {
        this.rectangle = rectangle;
    }
    
    public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue) {
        for(int i = row1 ; i <= row2 ; i++){
            for(int j = col1 ; j <= col2 ; j++){
                this.rectangle[i][j] = newValue;
            }
        }
    }
    
    public int GetValue(int row, int col) {
        return this.rectangle[row][col];
    }
}

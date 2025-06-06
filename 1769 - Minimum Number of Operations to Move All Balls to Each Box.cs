public class Solution {
    public int[] MinOperations(string boxes) {
        int n = boxes.Length;
        int[] result = new int[n];
        for(int i = 0 ; i < n ; i++){
            int operations = 0;
            for(int j=0 ; j < n ;j++){
                if(j!=i){
                    if(boxes[j]=='1'){
                        operations += Math.Abs(i - j);
                    }
                }
            }
            result[i] = operations;
            operations = 0;
        }
        return result;
    }
}

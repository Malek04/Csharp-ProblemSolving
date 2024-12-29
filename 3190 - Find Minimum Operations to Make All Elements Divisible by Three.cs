public class Solution {
    public int MinimumOperations(int[] nums) {
        int op = 0;
        foreach(int n in nums){
            if(n % 3 != 0){
                op += 1;
            }
        }
        return op;
    }
}
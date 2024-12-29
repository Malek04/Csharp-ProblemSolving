public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int s = 0;
        int n = nums.Length;
        for(int i = 0 ; i < n ; i++){
            for(int j = 0 ; j < n ; j++){
                if(nums[i]==nums[j] && i < j){
                    s++;
                }
            }
        }
        return s;
    }
}
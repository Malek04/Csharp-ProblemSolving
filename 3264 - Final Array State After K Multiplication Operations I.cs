public class Solution {
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        int i = 0;
        while(i < k){
            for(int j = 0 ; j<nums.Length ;j++){
                if(nums[j]==nums.Min()){
                    nums[j]*=multiplier;
                    break;
                }
            }
            i++;
        }
        return nums;
    }
}
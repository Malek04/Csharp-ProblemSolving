public class Solution {
    public int WaysToSplitArray(int[] nums) {
        int n = nums.Length ;
        long total = nums.Sum(x => (long)x);
        long left = 0;
        long right = 0;
        int s = 0;
        for(int i=0 ; i<n-1 ; i++){
            left += nums[i];
            right = total - left;
            if(left >= right){
                s += 1;
            }
        }
        return s;
    }
}

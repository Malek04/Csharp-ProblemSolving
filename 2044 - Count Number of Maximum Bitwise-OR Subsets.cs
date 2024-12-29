public class Solution {
    public int CountMaxOrSubsets(int[] nums) {
        int maxOr = 0;
        foreach (int num in nums) {
            maxOr |= num; 
        }
        int n = nums.Length;
        int count = 0;
        for (int i = 1; i < (1 << n); i++) {
            int currentOr = 0;
            for (int j = 0; j < n; j++) {
                if ((i & (1 << j)) != 0) { 
                    currentOr |= nums[j];
                }
            }
            if (currentOr == maxOr) {
                count++;
            }
        }
        return count;
    }
}

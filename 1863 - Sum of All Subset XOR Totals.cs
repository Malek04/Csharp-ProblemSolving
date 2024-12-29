public class Solution {
    public int SubsetXORSum(int[] nums) {
        int n = nums.Length;
        int count = 0;
        for (int i = 1; i < (1 << n); i++) {
            int currentXor = 0;
            for (int j = 0; j < n; j++) {
                if ((i & (1 << j)) != 0) {
                    currentXor ^= nums[j];
                }
            }
            count += currentXor;
        }
        return count;

    }
}
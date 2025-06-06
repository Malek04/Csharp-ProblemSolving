public class Solution {
    public int SubsetXORSum(int[] nums) {
        int result = 0;
        int n = nums.Length;
        foreach (int num in nums) {
            result |= num;
        }
        return result * (int)Math.Pow(2, n - 1);
    }
}

public class Solution {
    public int MaxArea(int[] height) {
        int right = height.Length - 1;
        int left = 0;
        int max = 0;
        while (left < right){
            int Area = Math.Min(height[left], height[right]) * (right - left);
            max = Math.Max(max, Area);
            if (height[left] < height[right])
                left++;
            else
                right--;
        }
        return max;
    }
}

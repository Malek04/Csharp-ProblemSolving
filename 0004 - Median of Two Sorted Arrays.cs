public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] nums3 = nums1.Concat(nums2).OrderBy(x => x).ToArray();
        int n = nums3.Length;
        if (n % 2 != 0){
            return nums3[n / 2];
        }
        else{
            return (nums3[n / 2 - 1] + nums3[n / 2]) / 2.0;
        }
    }
}

public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] l = new int[n * 2];
        for(int i = 0 ; i < n ; i++){
            l[2 * i]=nums[i];
            l[2 * i + 1]=nums[i + n];
        }
        return l;
    }
}
public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        int n = nums.Length;
        List<int> less = new List<int>();
        List<int> equal = new List<int>();
        List<int> greater = new List<int>();

        for(int i=0; i<n ; i++){
            if(nums[i]<pivot){
                less.Add(nums[i]);
            }
            else if (nums[i]==pivot){
                equal.Add(nums[i]);
            }
            else{
                greater.Add(nums[i]);
            }
        }
        less.AddRange(equal);
        less.AddRange(greater);

        return less.ToArray();
    }
}

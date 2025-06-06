public class Solution {
    public int[] TransformArray(int[] nums) {
        List<int> l = new List<int>();
        int n = nums.Length;

        for(int i=0 ; i<n ;i++){
            if(nums[i]%2==0){
                l.Add(0);
            }
            else{
                l.Add(1);
            }
        }
        l.Sort();
        return l.ToArray();
    }
}

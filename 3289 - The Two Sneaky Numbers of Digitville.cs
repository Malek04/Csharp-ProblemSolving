public class Solution {
    public int[] GetSneakyNumbers(int[] nums) {
        HashSet <int> nb = new HashSet<int>();
        foreach(int n in nums){
            if(nums.Count(c => c == n)>1){
                nb.Add(n);
            }
        }
        return nb.ToArray();
    }
}
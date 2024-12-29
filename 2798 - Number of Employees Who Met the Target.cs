public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int result = 0;
        foreach(int h in hours){
            if(h>=target){
                result++;
            }
        }
        return result;
    }
}
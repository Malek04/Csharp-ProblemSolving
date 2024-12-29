public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxi = accounts[0].Sum();
        foreach(int[] account in accounts){
            if(account.Sum()>maxi){
                maxi = account.Sum();
            }
        }
        return maxi;
    }
}
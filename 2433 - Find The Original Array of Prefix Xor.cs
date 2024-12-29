public class Solution {
    public int[] FindArray(int[] pref) {
        int n = pref.Length;
        int xor = 0;
        int[] arr = new int[n];
        for(int i = 0 ;i<n ;i++){
            arr[i] = xor ^ pref[i] ;
            xor ^= arr[i];
        }
        return arr;
    }
}
public class Solution {
    public int ClimbStairs(int n) {
        if(n==1){
            return 1;
        }
        if(n==2){
            return 2;
        }
        int[] tab = new int[n + 1];
        tab[1] = 1;
        tab[2] = 2;
        for(int i = 3 ; i <= n ;i++){
            tab[i]= tab[i-1] + tab[i-2];
        }
        return tab[n];
    }
}

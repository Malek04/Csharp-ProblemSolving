public class Solution {
    public bool IsUgly(int n) {
        if(n<=0) return false;
        do {
            if (n % 2 == 0) {
                n /= 2;
            }
            if (n % 3 == 0) {
                n /= 3;
            }
            if (n % 5 == 0) {
                n /= 5;
            }
        } while (n % 2 == 0 || n % 3 == 0 || n % 5 == 0);
        return n==1;
    }
}

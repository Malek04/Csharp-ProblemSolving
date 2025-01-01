public class Solution {
    public int MaxScore(string s) {
        int right =0;
        int left = 0;
        int max = 0;
        string r = "" , l ="";
        
        for(int i=1 ; i<s.Length ;i++){

            r = s.Substring(i, s.Length - i);
            l = s.Substring(0, i); 

            right = r.Count(c => c == '1');
            left = l.Count(c => c == '0');

            if (right + left >= max) {
                max = right + left;
            }
        }
        return max;
    }
}
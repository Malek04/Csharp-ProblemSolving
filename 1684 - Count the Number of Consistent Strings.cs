public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int s = 0;
        int result = 0;
        foreach(string word in words){
            foreach(char c in word){
                if(allowed.Contains(c)){
                    s+=1;
                }
                if(s==word.Length){
                    result+=1;
                }
            }
            s=0;
        }
        return result;
    }
}

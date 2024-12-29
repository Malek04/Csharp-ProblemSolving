public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int s = 0 ;
        foreach(string ch in operations){
            if(ch.Contains("+")){
                s+=1;
            }
            else{
                s-=1;
            }
        }
        return s;
    }
}
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        int maxCandies = candies.Max();
        var newlist = new List<bool>();
        foreach(var candy in candies){
            if(candy + extraCandies >= maxCandies){
                newlist.Add(true);
            }
            else{
                newlist.Add(false);
            }
        }
        return newlist;
    }
}
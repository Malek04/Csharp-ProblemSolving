public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
        int maxScore = 0;
        int maxI = values[0];
        for (int j = 1; j < values.Length; j++) {

            maxScore = Math.Max(maxScore, maxI + values[j] - j);
            maxI = Math.Max(maxI, values[j] + j);
        }
        return maxScore;
    }
}

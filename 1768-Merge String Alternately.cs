public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string word = "";
        int i = 0;
        while (i < word1.Length && i < word2.Length) {
            word += word1[i];
            word += word2[i];
            i++;
        }
        if (i < word1.Length) {
            word += word1.Substring(i);
        }
        else {
            word += word2.Substring(i);
        }
        return word;
    }
}

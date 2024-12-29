public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        String[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
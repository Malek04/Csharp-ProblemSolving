public class Solution {
    public string ReverseVowels(string s) {
        List<char> vowels = new List<char> { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
        List<char> listVowels = new List<char>();
        foreach (char c in s) {
            if (vowels.Contains(c)) {
                listVowels.Add(c);
            }
        }
        listVowels.Reverse();
        StringBuilder result = new StringBuilder(s);
        int k = 0;
        for (int i = 0; i < s.Length; i++) {
            if (vowels.Contains(s[i])) {
                result[i] = listVowels[k];
                k++;
            }
        }
        return result.ToString();
    }
}

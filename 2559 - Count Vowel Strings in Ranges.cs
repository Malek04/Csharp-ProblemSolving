public class Solution
{
    public int[] VowelStrings(string[] words, int[][] queries)
    {
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        List<int> prefixSum = new List<int> { 0 };
        foreach (var word in words)
        {
            var startsWithVowel = vowels.Contains(word[0]);
            var endsWithVowel = vowels.Contains(word[^1]); // Using C# 8.0 index operator
            prefixSum.Add(prefixSum.Last() + (startsWithVowel && endsWithVowel ? 1 : 0));
        }

        List<int> result = new List<int>();
        foreach (var query in queries)
        {
            var start = query[0];
            var end = query[1];
            result.Add(prefixSum[end + 1] - prefixSum[start]);
        }
        return result.ToArray();
    }
}

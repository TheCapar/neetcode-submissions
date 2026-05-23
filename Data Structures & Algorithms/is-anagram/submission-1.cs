public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length || s == null || t == null || s== t) return false;
        string chars = s + s;
        return chars.Contains(t);
    }
}

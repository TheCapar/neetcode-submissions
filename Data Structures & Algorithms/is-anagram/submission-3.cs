public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length || s == null || t == null) return false;
        
        return s.Contains(t);
    }
}

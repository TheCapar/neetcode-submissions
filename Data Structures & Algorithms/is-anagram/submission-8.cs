public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length || s == null || t == null) return false;
        for(int i = 0; i<s.Length; i++){
            bool a = t.Contains(s[i]);
            if(a == false) return false;
        }
        return true;
    }
}

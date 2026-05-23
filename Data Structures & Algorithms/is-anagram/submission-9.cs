public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length || s == null || t == null) return false;
        for(int i = 0; i<s.Length; i++){
            int index = t.IndexOf(s[i]);
            if(index == -1) return false;
            t = t.Remove(index, 1);
        }
        return true;
    }
}

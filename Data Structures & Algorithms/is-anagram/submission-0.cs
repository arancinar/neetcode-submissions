public class Solution {
    public bool IsAnagram(string s, string t) {
            char[] listofchars_s = s.ToCharArray();
            char[] listofchars_t = t.ToCharArray();

                Array.Sort(listofchars_s);
    Array.Sort(listofchars_t);


            return listofchars_s.SequenceEqual(listofchars_t);
    }
}

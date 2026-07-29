public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

Dictionary<string,List<int>> stringlists = new Dictionary<string,List<int>>();
        int counter = 0;
        foreach (string str in strs){

           char[] chararray =  str.ToCharArray();
           Array.Sort(chararray);

           string sortedstring = new string(chararray);

            if (!stringlists.ContainsKey(sortedstring))
            {
                stringlists.Add(sortedstring, new List<int>());
            }
            stringlists[sortedstring].Add(counter);
            counter++;
        }
       List<List<string>> stringlist = new List<List<string>>();

        foreach(List<int> indexlist in stringlists.Values){
         List<string> templist = new List<string>();
            foreach(int index in indexlist){
                templist.Add(strs[index]);
            }
            stringlist.Add(templist);
        }
      

return stringlist;
    }
}

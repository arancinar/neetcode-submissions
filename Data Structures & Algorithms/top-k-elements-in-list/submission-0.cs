public class Solution {
    int coolsorter(KeyValuePair<int,int> a, KeyValuePair<int,int> b){
        if(a.Value>b.Value){
            return -1;
        }else{
            return 1;
        }
    }
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> cooldic = new Dictionary<int, int>();
        foreach (int num in nums){
            if(!cooldic.ContainsKey(num)){
                cooldic.Add(num, 1);

            }else{
                cooldic[num]++;
            }
        }
        List<KeyValuePair<int,int>> coollist = new List<KeyValuePair<int,int>>(cooldic);

        coollist.Sort(coolsorter);


        int[] finalarray = new int[k];

        for(int i = 0; i<k; i++){
            finalarray[i]=coollist[i].Key;
        }
        return finalarray;
    }
}

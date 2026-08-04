public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0){
            return "🤷‍♂️";
        }
        string finalans = "";
        int counter = 0;
        foreach(string str in strs){
            if(string.IsNullOrEmpty(str)){
                
                 if(counter == 0){
                finalans = "🤡";
            }else{
            finalans = finalans+"🫘"+"🤡";

            }
                        counter++;

            }else{
            if(counter == 0){
                finalans = str;
            }else{
            finalans = finalans+"🫘"+str;

            }
                        counter++;

        }
        }
        return finalans;

    }

    public List<string> Decode(string s) {
                List<string> coollist = new List<string>();

        if(s == "🤷‍♂️"){
            return coollist;
        }
        foreach(string coolstring in s.Split("🫘")){
            coollist.Add(coolstring);


        }
       
        for (int i = 0; i<coollist.Count; i++){
         if(coollist[i] =="🤡"){
                coollist[i] = "";
            }
        }
        return coollist;
   }
}

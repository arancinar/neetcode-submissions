public class Solution {

    public string Encode(IList<string> strs) {
        if(strs.Count == 0){
            return "aintnothinghere";
        }
        string finalans = "";
        int counter = 0;
        foreach(string str in strs){
            if(string.IsNullOrEmpty(str)){
                
                 if(counter == 0){
                finalans = "STUPIDSTRING";
            }else{
            finalans = finalans+"beans"+"STUPIDSTRING";

            }
                        counter++;

            }else{
            if(counter == 0){
                finalans = str;
            }else{
            finalans = finalans+"beans"+str;

            }
                        counter++;

        }
        }
        return finalans;

    }

    public List<string> Decode(string s) {
                List<string> coollist = new List<string>();

        if(s == "aintnothinghere"){
            return coollist;
        }
        foreach(string coolstring in s.Split("beans")){
            coollist.Add(coolstring);


        }
       
        for (int i = 0; i<coollist.Count; i++){
         if(coollist[i] =="STUPIDSTRING"){
                coollist[i] = "";
            }
        }
        return coollist;
   }
}

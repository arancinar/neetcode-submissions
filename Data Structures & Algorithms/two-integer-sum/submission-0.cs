public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map = new Dictionary<int, int>();
        Dictionary<int,int> numsweveseen = new Dictionary<int, int>();
        int counter = 0;
        foreach (int i in nums){
            
            if(numsweveseen.ContainsKey(target-i)){
                return  new int[] {numsweveseen[target-i], counter};
            }
                        numsweveseen[i] = counter;

            counter++;
        }
            return new int[] {0,0};

    }
}

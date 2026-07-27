public class Solution {
    public bool hasDuplicate(int[] nums) {
        Array.Sort(nums);
        int prevnum = -999;
        foreach (int num in nums){
                if(num == prevnum){
                    return true;
                }
                prevnum = num;
        }
        return false;

    }
}
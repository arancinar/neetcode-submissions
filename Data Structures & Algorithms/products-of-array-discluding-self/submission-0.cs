public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] finalarray = new int[nums.Length];

        int totalsumMinusZeroes = 1;
        int zerocount = 0;


        foreach(int i in nums){
            if(i== 0){
               zerocount ++;
            }

        }
        if (zerocount >1){
            return finalarray;
        }

        foreach(int i in nums){
            if(i!= 0){
                totalsumMinusZeroes *= i;
            }

        }

        for (int i = 0; i<nums.Length; i++){
            if(zerocount >0){
            if(nums[i]== 0){
                finalarray[i] = totalsumMinusZeroes;
            }else{
                finalarray[i] = 0 ;

            }
            }else{
            finalarray[i] = totalsumMinusZeroes/nums[i];
 
            }

        }
        return finalarray;
    }
}

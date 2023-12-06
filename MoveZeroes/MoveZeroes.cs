using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeChallanges.MoveZeroes
{
    public class MoveZeroes
    {
        public void MoveZeroesToEnd(int[] nums) {
                int i = nums.Length -1;
                for (int j = 0; j <= i; j++){
                    
                    if (nums[j]==0){
                        for(int k = j; k <= nums.Length - 1; k++){
                            if (nums[k]!=0){
                                nums[j] = nums[k];
                                nums[k] = 0;
                                break; 
                            }
                        }
                    }
                }
        }
    }
}
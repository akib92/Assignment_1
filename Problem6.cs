using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Assignment_1
{
    public class Problem6
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            Console.WriteLine("Q6: Enter the sentence to convert:");
            
            int[] target = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (index[i] == i)
                {
                    target[i] = nums[i];
                }
                else
                {
                    for (int j = i; j > index[i]; j--)
                    {
                        target[j] = target[j - 1];
                    }
                    target[index[i]] = nums[i];
                  
                }
            }
            return target;
        }
    }

}




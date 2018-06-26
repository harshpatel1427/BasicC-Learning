using System;
using System.Collections.Generic;

namespace FirstApp
{
    public class TwoSum
    {
        public TwoSum()
        {
        }

        public List<int> FindTwoSum(int[] nums, int target)
        {
            List<int> answer = new List<int>();

            ISet<int> set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(target - nums[i]))
                {
                    answer.Add(nums[i]);
                    answer.Add(Math.Abs(target - nums[i]));
                    break;
                }
                else
                {
                    set.Add(nums[i]);
                }

            }
            return answer;
        }
    }
}

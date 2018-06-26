using System;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Printing fibonaci number */
            System.Console.WriteLine("Printing Fibonaci Number");
            Fibonaci fibonaci = new Fibonaci();
            fibonaci.GetFibonaci(10);

            /* solving two sum problem */
            System.Console.WriteLine("Printing TWO SUM for target number...");
            int[] nums = { 1, 2, 3, 5, 8, 10 };
            int target = 18;
            TwoSum twoSum = new TwoSum();
            List<int> ans = twoSum.FindTwoSum(nums, target);

            foreach (int n in ans)
            {
                Console.WriteLine(n);
            }
        }
    }
}

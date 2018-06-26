using System;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String optionSelection = "Please select from following...\n" +
                                     "1. Fibonaci\n" +
                                     "2. TwoSum\n" +
                                     "3. Exit";

            String continueMessage = "Press Space key to continue...";

            Console.Clear();

            Console.WriteLine("Welcome to C# main function..let's get started!\n");

            while (true)
            {
                /* Print option selection menu */
                Console.WriteLine(optionSelection);

                int option = Console.Read();

                switch (option)
                {
                    case '1':
                        Program.RunFibonaci();
                        break;
                    case '2':
                        Program.RunTwoSum();
                        break;
                    case '3':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\ninvalid option\n");
                        break;
                }

                Console.WriteLine(continueMessage);
                ConsoleKeyInfo keyInfo;

                do
                {
                    keyInfo = Console.ReadKey();
                } while (keyInfo.Key != ConsoleKey.Spacebar);

                Console.Clear(); // clear console for next run
            }
        }

        private static void RunFibonaci()
        {
            /* Printing fibonaci number */
            Console.WriteLine("\nPrinting Fibonaci Number\n");
            Fibonaci fibonaci = new Fibonaci();
            fibonaci.GetFibonaci(10);
        }

        private static void RunTwoSum()
        {
            /* solving two sum problem */
            Console.WriteLine("\nPrinting TWO SUM for target number...\n");
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

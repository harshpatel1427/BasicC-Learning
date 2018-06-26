using System;
namespace FirstApp
{
    public class Fibonaci
    {
        public Fibonaci()
        {
        }

        public void GetFibonaci(int num)
        {
            int n1 = 0;
            int n2 = 1;
            int ans = 0;
            if (num == 0 || num == 1)
                Console.WriteLine(num);
            else
            {
                for (int i = 2; i < num; i++)
                {
                    ans = n1 + n2;
                    n1 = n2;
                    n2 = ans;
                    Console.WriteLine(ans);
                }
            }
        }
    }
}

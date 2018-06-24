using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            TestClass testClass = new TestClass(3);
            Console.WriteLine(testClass.Value);
        }
    }

    class TestClass
    {
        int value = 0;
        public TestClass(int value)
        {
            this.value = value;
        }

        public int Value
        {
            get
            {
                return this.value;
            }
            internal set
            {
                this.value = value;
            }
        }
    }
}

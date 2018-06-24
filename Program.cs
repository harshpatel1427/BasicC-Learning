using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            TestClass testClass = new TestClass();
            testClass.Value = 4;
            Console.WriteLine(testClass.Value);
        }
    }

    class TestClass
    {
        public int Value
        {
            get;
            internal set;
        }
    }
}

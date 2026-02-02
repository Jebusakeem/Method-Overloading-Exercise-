using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool dollar)
        {
            if (a + b > 1)
            {
                dollar = false;
                return $" {a + b} dollars";
                }
            if (a + b == 1)
            {
                dollar = true;
                return $"{a + b} dollar";
                }
        }
    }
}

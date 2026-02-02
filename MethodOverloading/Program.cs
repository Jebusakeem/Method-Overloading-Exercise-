using System.ComponentModel;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           Console.WriteLine(Add(4, 5));
           Console.WriteLine(Add(33.24m, 44.58m));
           Console.WriteLine(Add(1, 0, false));
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
            var sum = a + b;
            if (dollar == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (sum == 1 && dollar == true)
            {
                return $"{sum} dollar";
            } 
            else 
            {
                
                return sum.ToString();
            }
        }
    }
}

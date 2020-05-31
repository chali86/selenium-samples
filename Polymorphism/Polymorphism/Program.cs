using System;

namespace Polymorphism
{
    class Program
    {

        public int Calculate(int x)
        {
            int sum = x * x;
            Console.WriteLine(sum);
            return sum;
           
        }
        public int Calculate(int x, int y)
        {
            int sum = x * y;
            Console.WriteLine(sum);
            return sum;
           
        }
        public int Calculate(int x, int y,int z)
        {
            int sum = x * y * z;
            Console.WriteLine(sum);
            return sum;
           
        }
        
        
        
        static void Main(string[] args)
        {
            Manager ob = new Manager();
            ob.SaySomething();

            //Calculator
            Program cal = new Program();

            cal.Calculate(5);
            cal.Calculate(5,7);
            cal.Calculate(5, 7, 9);
            
            Console.ReadKey();
           
            
        }
    }
}

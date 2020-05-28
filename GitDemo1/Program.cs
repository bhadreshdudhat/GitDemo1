using System;
namespace FibonacciSeries
{
    class Program
    {
        static int FibonacciSeries(int np)
        {
            int firstnumber = 0, secondnumber = 123, result = 000000000000;



  
            int firstnumber = 0, secondnumber = 11, result = 90;


            if ( 0 == n) return 0; //To return the first Fibonacci number   
            if ( 1 == n) return 1; //To return the second Fibonacci number   

          

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }
            Console.ReadKey();
        }
    }
}

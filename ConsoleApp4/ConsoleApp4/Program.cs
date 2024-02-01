using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 1;  i <= 2; i++) 
            {
                double product = 1;

                for (int p = 1; p <= 3; p++)
                {
                    product *= Math.Log(Math.Pow(p, 3) + i);
                }

                sum += product;
            }

            Console.WriteLine(sum);
        }
    }
}

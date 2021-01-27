using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10, num2 = 5;

            if (num < num2)
            {
                Console.WriteLine("Numero " + num + " é menor que " + num2);
            }
            else if (num > num2)
            {
                Console.WriteLine("Numero " + num2 + " é menor que " + num);
            }
        }
    }
}

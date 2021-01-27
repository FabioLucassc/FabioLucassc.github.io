using System;

namespace Aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste");
            if (args.GetLongLength(0)>0)
            {
                Console.WriteLine(args.GetValue(0));
            }
        }
    }
}

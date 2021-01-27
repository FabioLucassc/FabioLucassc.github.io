using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_56
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> transporte = new LinkedList<string>();


            transporte.AddFirst("Carro");
            transporte.AddFirst("Aviao");
            transporte.AddFirst("Moto");
            transporte.AddFirst("Navio");

            transporte.AddLast("Bicicleta");

            LinkedListNode<string> no;
            no = transporte.FindLast("Aviao");
            transporte.AddAfter(no, "Patinete");

            foreach (string modo in transporte)
            {

                Console.WriteLine("Transporte: " + modo);


            }

            Console.ReadLine();
        }
    }
}

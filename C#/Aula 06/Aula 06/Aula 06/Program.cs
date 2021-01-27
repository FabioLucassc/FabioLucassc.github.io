using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            String produto = "Lanche";

            valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("Produto: ...........:{0,2}",produto);
            Console.WriteLine("Val.Compra: ...........:{0,2:c}",valorCompra);
            Console.WriteLine("Lucro: ...........:{0,2:p}",lucro);
            Console.WriteLine("Venda: ...........:{0,2:c}",valorVenda);

            Console.ReadLine();
        }
    }
}

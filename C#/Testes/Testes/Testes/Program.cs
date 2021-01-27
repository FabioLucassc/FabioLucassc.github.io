using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    class Program
    {

        static float calcularMedia(int n1, int n2){

            return (n1+n2)/2f;
        
        }
        
        
        static void Main(string[] args)
        {
            int num, num2;
            string nome;

 Console.WriteLine("insira o primeiro Número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o segundo Número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insira seu nome: ");
            nome = Console.ReadLine();


            if (num < num2)
            {
                Console.WriteLine("Numero " + num + " é menor que " + num2);
            }
            else
            {
                Console.WriteLine("Numero " + num2 + " é menor que " + num);
            }

            
            Console.WriteLine("Média é: "+calcularMedia(num,num2));
            Console.WriteLine(nome);            
        }
    }
}

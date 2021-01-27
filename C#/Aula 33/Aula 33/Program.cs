using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_33
{

    public class Teste
    {

        private int num;
        public Teste()
        {


        }

        public Teste(int num)
        {

            setNum(num * 2);

        }

        public int getNum()
        {

            return num;

        }

        public int setNum(int num)
        {
            return this.num = num;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {

            Teste numero = new Teste(2);
            Console.WriteLine(numero.getNum());


            Console.ReadLine();
        }
    }
}

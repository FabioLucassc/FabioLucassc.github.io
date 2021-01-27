using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_34
{

    class Veiculo
    { // BASE
        public int velMax;
        public int rodas;
        public bool ligado;


        public void Ligar()
        {
            ligado = true;

        }
        public void Desligar()
        {
            ligado = false;

        }
    }

    class Carro : Veiculo
    {

        string nome;
        string cor;
        public Carro(string name, string cor)
        {
            Desligar();
            rodas = 4;
            velMax = 120;
            nome = name;
            this.cor = cor;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

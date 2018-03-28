using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            casa CasaDoJoao = new casa();

            CasaDoJoao.Area = 5;

            Console.WriteLine("O atributo area da classe casa do objeto CasaDoJoao tem o valor de {0}", CasaDoJoao.Area);
        }
    }
}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.NumeroMatricula = 10;
            Console.WriteLine(funcionario.NumeroMatricula);

        }
    }
}

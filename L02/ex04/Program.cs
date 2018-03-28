using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            //a) 4 == 5                       b) 4! = 6
            //c) 4 > 5                        d) 4 < 5 && 6 > 10
            //e) 40 < 50 || 60 > 90           f) !(40 < 50 || 60 > 90)
            Console.WriteLine("Operações Lógicas");
            int num=5, num2=4;
            Console.WriteLine("Valor do primeiro número:{0}", num);
            Console.WriteLine("Valor do Segundo número:{0}", num2);
            

            Console.WriteLine("===================##================================");
            Console.WriteLine("(A)-Segundo número é o primeiro?{0}", num2 == num);
            Console.WriteLine("(B)-Segundo número é diferente de 6?{0}", num2 != 6);
            Console.WriteLine("(C)-Segundo número é maior que o primeiro?{0}", num2 > num);
            Console.WriteLine("(D)-Segunto número é menordo que o primeiro e sessenta é maior que noventa?{0}", 4 < 5 && 6 > 10);
            Console.WriteLine("(E)- Quarenta é menor que cinquenta ou 60 é menor que noventa?{0}", 40 < 50 || 60 > 90);
            Console.WriteLine("(F)-A negação de quarenta menos que cinquente ou sessente maior que novente é verdadeira?{0}", !(40 < 50 || 60 > 90));
            
            Console.WriteLine("===================##================================");



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            //O programa deve executar as seguintes conversções de tipos de dados.

            //a) Converta o double 99.56 para inteiro com um cast.

            //b) Converta a string “99” para inteiro, e some 1 a
            //este valor, então converta esse inteiro para string
            //verificando a quantidade de dígitos do resultado.

            #region conversãoCast
            Console.WriteLine("Exercício 01".ToUpper());
            double num1 = 99.56;
            int num2 = 0;
            Console.WriteLine("Número 1={0}", num1);
            Console.WriteLine("Número 2={0}", num2);

            num2 = (int)num1;
            Console.WriteLine("String convertida em número:"+num2);
            Console.WriteLine("~~#############//################~~");
            Console.WriteLine("~~#############//################~~");
            Console.WriteLine("Fim do exercício 01".ToUpper());
            #endregion

            #region outrasConversões
            Console.WriteLine("Exercício 02".ToUpper());
            string str1 = "99";
            int num;
            Console.WriteLine(str1);
            num = Convert.ToInt32(str1);
            num += 1;

            Console.WriteLine("----------------------------------");

            Console.Write("Exibição como número:");
            Console.WriteLine(num);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Exibição pós Conversão:");
            str1= Convert.ToString(num);
            Console.WriteLine(str1);

            Console.WriteLine("----------------------------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Verificação de quantidade de dígitos:");
            Console.WriteLine(" Número de dígitos:"+str1.Length);
            Console.WriteLine("~~#############//################~~");
            Console.WriteLine("~~#############//################~~");
            Console.WriteLine("Fim do segundo exercício de conversão.");
            #endregion


        }
    }
}

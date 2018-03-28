using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pesquise sobre as formatações e arredondamentos nos itens a seguir.

            //a) Exiba 3 formas de exibir um número de forma arredondada.
            //b) Exibe 3 formas de exibir números em porcentagens.
            //c) Exibe 5 formas de exibir a data e hora atuais do sistema.

            #region itemA
            float pi = 3.1415265f;

            Console.WriteLine("{0:F2}", pi);
            Console.WriteLine("{0, 4:F4}", pi);
            Console.WriteLine("{0, 4:F6}", pi);


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Exemplo do professor".ToUpper());
            Console.WriteLine("{0, 4:F2}", 4.78905);
            Console.WriteLine("{0, 4:F3}", 4.7);
            Console.WriteLine("{0, 4:F4}", 5.8954);
            Console.WriteLine("{0, 4:F5}", 5);
            Console.WriteLine();
            #endregion

            #region itemB
            float pc = 0.15f;
            Console.WriteLine("{0, 4:P}", pc);
            Console.WriteLine("{0, 4:P2}", pc);
            Console.WriteLine("{0, 4:P1}", pc);


            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Exemplo do professor".ToUpper());
            Console.WriteLine("{0, 4:P}", 0.456789);
            Console.WriteLine("{0, 4:P3}", 0.456789);
            Console.WriteLine("{0, 4:P1}", 0.456789);
            Console.WriteLine();
            #endregion

            #region itemC
            Console.WriteLine("Desenvolver essa função".ToUpper());            DateTime hoje = DateTime.Now;

            string datas = String.Format(
             "Short date".PadRight(26) + "{0:d}\n" +
             "Long date".PadRight(26) + "{0:D}\n" +
             "Short time".PadRight(26) + "{0:t}\n" +
             "Long time".PadRight(26) + "{0:T}\n" +
             "Full date/short time".PadRight(26) + "{0:f}\n" +
             "Full date/long time".PadRight(26) + "{0:F}\n" +
             "General date/short time".PadRight(26) + "{0:g}\n" +
             "General date/long time".PadRight(26) + "{0:G}\n" +
             "(default)".PadRight(26) + "{0}(default = 'G')\n" +
             "Month".PadRight(26) + "{0:M}\n" +
             "RFC1123".PadRight(26) + "{0:R}\n" +
             "Sortable".PadRight(26) + "{0:s}\n" +
             "Universal sortable".PadRight(26) + "{0:u} (invariant)\n" +
             "Universal full date/time".PadRight(26) + "{0:U}\n" +
             "Year".PadRight(26) + "{0:Y}\n", hoje);
            Console.WriteLine(datas);
            Console.WriteLine();
            #endregion
        }
    }
}


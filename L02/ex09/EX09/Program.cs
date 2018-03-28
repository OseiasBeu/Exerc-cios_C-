using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09
{
    class Program
    {
        static void Main(string[] args)
        {





            //Calcule o itens solicitados a seguir usando os operadores na forma reduzida.

            //a)Se o salario de um funcionário á de mil unidades
            //monetárias e recebeu dez unidades de aumento qual o salario atual.
            
            //b)Se o valor de total das vendas foram de cem unidades
            //monetárias e os impostos foram de vinte
            //unidades qual o valor líquido.
           
            //c)Se você investiu um capital de mil unidades monetárias
            //e ao final do investimento recebeu cinco porcento
            //qual o total do capital ao final do investimento.
           
            //d)Se você possuía 10 unidades montarias e as dividiu
            //igualmente entre seus três colegas, ficando com o
            //resto, com quanto você ficou.

            #region itemA            float salario = 1000f;
            int aumento = 10;
            salario += aumento;
            Console.WriteLine("ITEM A");
            Console.WriteLine(salario);
            Console.WriteLine("~~~###########~~##########~~###########");


            #endregion
            #region itemB

            float total = 100f;
            float impostos = 20;
            total -= impostos;
            Console.WriteLine("ITEM B");
            Console.WriteLine("O valor liquído é de:" + total);
            Console.WriteLine("~~~###########~~##########~~###########");


            #endregion

            #region itemC
            float capital = 1000f;
            float pc = 0.05f;
            float totaf;
            totaf = capital * pc;
            totaf += capital;
            Console.WriteLine("ITEM C");
            Console.WriteLine("O total final é de:"+ totaf);
            Console.WriteLine("~~~###########~~##########~~###########");

            #endregion

            #region itemD
            float unidades = 10f;
            float amigos = 3f;
            unidades = unidades % amigos;
            Console.WriteLine("ITEM D");
            Console.WriteLine("Restaram-lhe:{0} unidades", unidades);
            Console.WriteLine("~~~###########~~##########~~###########");


            #endregion
        }
    }
}

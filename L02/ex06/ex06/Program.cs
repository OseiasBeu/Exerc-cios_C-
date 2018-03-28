using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            //O programa deve atribuir e exibir o valor das variáveis apresentadas a seguir. 
            //Faça uma investigação do significado de inteiros sem sinal e com sinal.
            //a) sbyte S = -34;
            //b) byte B1 = 250;
            //c) short SH = 32000;
            //d) ushort U = 60000;
            //e) int I = 1000000012;
            //f) uint UI = 3500000000;
            //g) long L = 1532333333334581239;
            //h) ulong UL = 14532333333334581239;
            //i) float F = 345.3456f;
            //j) double D = 6.89765432127866;
            //k) decimal DE = 1234567897654300.14567896543m;
            //l) char C =’O’;
            //m)string ST =”FCP é o Maior”;
            //n) bool LV = true;
            //o) bool LF = false;

            #region [TIPOS DE DADOS]
            #region [NUMEROS INTEIROS]

            Console.WriteLine("Tipos de dados".ToUpper());
            sbyte S = -34;
            byte B1 = 250;
            short SH = 32000;
            ushort U = 60000;
            int I = 1000000012;
            uint UI = 3500000000;
            long L = 1532333333334581239;
            ulong UL = 14532333333334581239;
            Console.WriteLine("~##############//###############//##############");
            Console.WriteLine("Numeros inteiros");
            Console.WriteLine("S + < + B1 + < + SH + < + U + < ");
            Console.WriteLine(S + "<" + B1 + "<" + SH + "<" + U + "<");
            Console.WriteLine("I + < + L + < + UI + < + UL");
            Console.WriteLine(I + "<" + L + "<" + UI + "<" + UL);
            #endregion
            #region [NUMEROS REAIS]
            float F = 345.3456f; //NOTE O F NO FINAL DA DECLARAÇÃO
            double D = 6.89765432127866;
            decimal DE = 1234567897654300.14567896543m;
            Console.WriteLine("~##############//###############//##############");
            Console.WriteLine("Números reais:");
            Console.WriteLine("F + < + D + < + DE");
            Console.WriteLine(F + "<" + D + "<" + DE);
            #endregion
            #region [DADOS ALFANUMERICOS E LOGICOS]
            char C = 'O';
            string ST = "FCP é o Maior";
            bool LV = true;
            bool LF = false;
            Console.WriteLine("~##############//###############//##############");
            Console.WriteLine("Dados alfanuméricos e lógicos");
            Console.WriteLine("C + + ST");
            Console.WriteLine(C + " " + ST);
            Console.WriteLine("LV +  ou  + LF");
            Console.WriteLine(LV + " ou " + LF);
            #endregion
            #endregion

        }
    }
}

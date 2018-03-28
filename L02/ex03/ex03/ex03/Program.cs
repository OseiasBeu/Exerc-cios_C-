using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
    class Program
    {
        //Exercício 3.
        //O programa deve executar as seguintes funções matemáticas.
        //a) Seno de 30◦; 
        //b) Raiz quadrada de 4;
        static void Main(string[] args)
        {
            //Funções matemáticas

            double angulo= 30;           
            double angRadian = angulo * Math.PI / 180;
           

            //Seno, Cosseno e Tangente recebem o ângulo em radianos.
            double  valorA = Math.Sin(angRadian);
            double  valorB = Math.Cos(angRadian);
            double  valorC = Math.Tan(angRadian);

            Console.WriteLine("Ângulo= " + angulo.ToString());
            Console.WriteLine("Em Radianos=" + angRadian.ToString());
            Console.WriteLine("Seno= " + valorA.ToString());
            Console.WriteLine("Cosseno= " + valorB.ToString());
            Console.WriteLine("Tangente= " + valorC.ToString());

            Console.ReadKey();


        }
    }
}

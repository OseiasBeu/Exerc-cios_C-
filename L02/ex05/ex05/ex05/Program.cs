﻿using System;
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
            string frase = "Ordem e progresso";
            Console.WriteLine(frase);
            Console.WriteLine("Comprimetno:"+ frase.Length + "Caracteres"); // Comprimento da string
            Console.WriteLine("#########--##########--#########--#############--############");

            Console.WriteLine("A capital do Brasil" + "é Brasília"); /*Concatenação de strings.*/
            Console.WriteLine("#########--##########--#########--#############--############");

            string frase2 = "no futuro teremos o homem ter uma base em marte";
            Console.WriteLine("#########--##########--#########--#############--############");

            string frase3 = "A velocidadeda luz não é o limite";
            Console.WriteLine("#########--##########--#########--#############--############");

            Console.WriteLine("#########--##########--#########--#############--############");
            Console.WriteLine("Primeira comparação");
            Console.WriteLine(frase5.CompareTo("Goias")); /*Comparação de strings. Se o retorno for 0 (zero), significa que a comparação é verdadeira;
            se o retorno for 1 (um), significa que a comparação é falsa*/
            Console.WriteLine("Segunda comparação");
            Console.WriteLine("Piau".CompareTo("Goias"));
            Console.WriteLine("terceira comparação");
            Console.WriteLine("Piau".CompareTo("Piau"));
            Console.WriteLine("#########--##########--#########--#############--############");

            string frase6 = "    a lua alteras as marés   ";
            Console.WriteLine("#########--##########--#########--#############--############");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{

    //Construa um programa onde exista uma classe publica
    //de nome Funcionario.A classe Funcionario deve ter
    //um atributo publico do tipo inteiro e de nome NumeroMatricula.
    //Ainda na classe Funcionario crie um
    //construtor com um argumento do tipo inteiro de nome
    //Matricula, no interior do construtor inicialize o atributo
    //NumeroMatricula com o valor do parˆametro Matricula.
    //No programa crie um objeto de nome funcionario
    //da classe Funcionario passando o valor 10 para o construtor,
    //em seguida exiba o numero de matricula na tela
    //do console.

    class Funcionario
    {
        public int NumeroMatricula;
        int Matricula()
        {
            NumeroMatricula = 10;
        }
    }
}

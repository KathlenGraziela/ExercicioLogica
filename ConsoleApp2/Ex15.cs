using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//15 – Utilizando a estrutura ‘FOR’, escreva um algoritmo para imprimir os números de 1 (inclusive) a 10(inclusive) em
//ordem crescente. 

namespace ExercicioLogica
{
    public class Ex15 : IExercicio
    {
        public void Exercicio()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

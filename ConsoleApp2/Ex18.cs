using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//18 - Escreva um algoritmo para imprimir os 10 primeiros números inteiros maiores que 100. 

namespace ExercicioLogica
{
    public class Ex18 : IExercicio
    {
        int i = 100;
        public void Exercicio()
        {
            while (i < 110)
            {
                i++;
                Console.WriteLine(i);
            }
        }
    }
}

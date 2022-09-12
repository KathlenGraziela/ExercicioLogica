using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//21 - Escreva um algoritmo que calcule e imprima a tabuada do 8 (1 a 10). 

namespace ExercicioLogica
{
    public class Ex21 : IExercicio
    {
        public void Exercicio()
        {
            Console.WriteLine("Tabuada de 8: ");
            int res = 0;

            for(int i = 0; i <=10; i++)
            {
                res = 8 * i;
                Console.WriteLine($"8 * {i} = {res}");
            }
        }
    }
}

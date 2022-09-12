using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//17 – Repita o exercício 15 utilizando a estrutura ‘DO’. 

namespace ExercicioLogica
{
    public class Ex17 : IExercicio
    {
        public void Exercicio()
        {
            int i = 0;

            do
            {
                i++;
                Console.WriteLine(i);
            } while (i < 10);
        }
    }
}

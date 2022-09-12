using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16 – Repita o exercício 15 utilizando a estrutura ‘WHILE’.

namespace ExercicioLogica
{
    public class Ex16 : IExercicio
    {
        public void Exercicio()
        {
            int i = 0;

            while (i<10)
            {
                i++;
                Console.WriteLine(i);
            }
        }
    }
}

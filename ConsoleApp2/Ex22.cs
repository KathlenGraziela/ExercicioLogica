using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//22 - Ler 10 valores e após isso escrever quantos desses valores lidos são NEGATIVOS 

namespace ExercicioLogica
{

    public class Ex22 : IExercicio
    {
        public void Exercicio()
        {
            int n=0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Informe um número: ");
                if (Convert.ToInt32(Console.ReadLine()) < 0)
                    n++;
            }
            Console.WriteLine($"São {n} Números Negativos");
        }
    }
}

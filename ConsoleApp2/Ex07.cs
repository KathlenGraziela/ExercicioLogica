using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//7 - Ler dois valores(considere que não serão lidos valores iguais) e escrevê-los em ordem crescente. 

namespace ExercicioLogica
{
    public class Ex07 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Escreva valor 01: ");
            int valor01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escreva valor 02: ");
            int valor02 = Convert.ToInt32(Console.ReadLine());

            if (valor01 < valor02)
                Console.WriteLine($"{valor01}\n{valor02}");
            else
                Console.WriteLine($"{valor02}\n{valor01}");
        }
    }
}

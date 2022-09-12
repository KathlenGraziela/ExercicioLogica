using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//6 - Ler dois valores(considere que não serão lidos valores iguais) e escrever o maior deles. 

namespace ExercicioLogica
{
    public class Ex06 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Escreva valor 01: ");
            int valor01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escreva valor 02: ");
            int valor02 = Convert.ToInt32(Console.ReadLine());

            if(valor01 > valor02)
                Console.WriteLine($"Valor maior {valor01}");
            else
                Console.WriteLine($"Valor maior {valor02}");
        }
    }
}

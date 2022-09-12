using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2 - Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo). 
//int numero = 0;

namespace ExercicioLogica
{
    public class Ex02 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 0)
                Console.WriteLine("Numero é positivo");
            else
                Console.WriteLine("Numero negativo");
        }
    }
}

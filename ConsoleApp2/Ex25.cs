using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//25 - Escreva um algoritmo para ler 10 números e ao final da leitura escrever a soma total dos 10 números lidos. 

namespace ExercicioLogica
{
    public class Ex25 : IExercicio
    {
        public void Exercicio()
        {
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe um número: ");
                soma += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Soma Total: {soma}");
        }
    }
}

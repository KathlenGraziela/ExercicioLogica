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
            int[] numeros = new int[10];
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe um número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                soma = soma + numeros[i];
            }
            Console.WriteLine($"Soma Total: {soma}");
        }
    }
}

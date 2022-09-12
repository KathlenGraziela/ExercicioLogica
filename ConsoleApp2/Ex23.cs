using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23 - Ler 10 valores e escrever quantos desses valores lidos estão no intervalo [10,20] (incluindo os valores 10 e 20 no
//intervalo) e quantos deles estão fora deste intervalo 

namespace ExercicioLogica
{
    public class Ex23 : IExercicio
    {
        public void Exercicio()
        {
            int[] numeros = new int[10];
            int n = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe um número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] >=10 && numeros[i] <=20)
                    n++;
            }
            Console.WriteLine($"São {n} número entre 10 e 20, e são {10-n} fora de 10 à 20 ");
        }
    }
}

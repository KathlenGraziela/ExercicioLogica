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
            
            int[] numeros = new int[10];
            int n=0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Informe um número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i <10; i++)
            {
                if (numeros[i] < 0)
                    n++;
            }
            Console.WriteLine($"São {n} Números Negativos");
        }
    }
}

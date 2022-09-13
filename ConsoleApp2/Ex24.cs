using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//24 - Ler 10 valores, calcular e escrever a média aritmética desses valores lidos. 

namespace ExercicioLogica
{
    public class Ex24 : IExercicio
    {
        public void Exercicio()
        {
            double[] numeros = new double[10];
            double soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe um número: ");
                soma += Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"Soma Total: {soma/10}");
        }
    }
}

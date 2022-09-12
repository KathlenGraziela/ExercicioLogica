using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//19 - Ler um valor N e imprimir todos os valores inteiros entre 1 (inclusive) e N(inclusive). Considere que o N será
//sempre maior que ZERO. 

namespace ExercicioLogica
{
    public class Ex19 : IExercicio
    {
        public void Exercicio()
        {
            int i = 1;

            Console.Write("Informe um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= numero);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//20 - Modifique o exercício anterior para aceitar somente valores maiores que 0 para N. Caso o valor informado (para
//N) não seja maior que 0, deverá ser lido um novo valor para N 

namespace ExercicioLogica
{
    public class Ex20 : IExercicio
    {
        public void Exercicio()
        {
            int numero = 0;

            while (numero <= 0)
            {
                Console.Write("Informe um numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= numero; i++)
                Console.WriteLine(i);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1 - Ler um valor e escrever a mensagem ‘É MAIOR QUE 10!’, se o valor lido for maior que 10, caso contrário escrever
//‘NÃO É MAIOR QUE 10!’ 

namespace ExercicioLogica
{
    public class Ex01 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 10)
                Console.WriteLine("Numero é maior que 10");
            else
                Console.WriteLine("Numero não é maior que 10");
        }
    }
}

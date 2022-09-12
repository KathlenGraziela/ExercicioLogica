using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//4 - Ler as notas da 1a.e 2a.avaliações de um aluno. Calcular a média aritmética simples e escrever uma mensagem
//que diga se o aluno foi ou não aprovado (considerar que nota igual ou maior que 6 o aluno é aprovado). Escrever
//também a média calculada. 

namespace ExercicioLogica
{
    public class Ex04 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Informar nota 01: ");
            double notas01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informar nota 02: ");
            double notas02 = Convert.ToDouble(Console.ReadLine());

            double media = (notas01 + notas02) / 2;

            if(media >= 6)
                Console.WriteLine($"Aluno aprovado, média: {media}");
            else
                Console.WriteLine($"Aluno reprovado, média: {media}");
        }
    }
}

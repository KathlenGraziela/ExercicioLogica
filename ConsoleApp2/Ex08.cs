using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8 - Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos) e
//calcule a duração do jogo em horas. 

namespace ExercicioLogica
{
    public class Ex08 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Informe hora inicio: ");
            int horaInicio = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe hora final: ");
            int horaFinal = Convert.ToInt32(Console.ReadLine());

            int total = horaFinal - horaInicio;
            
            Console.Write($"Total: {total}");

        }
    }
}

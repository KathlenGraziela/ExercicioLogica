using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//12 - Ler o nome de 2 times e o número de gols marcados na partida (para cada time). Escrever o nome do vencedor.
//Caso não haja vencedor deverá ser impressa a palavra EMPATE. 

namespace ExercicioLogica
{
    public class Ex12 : IExercicio
    {
        public void Exercicio()
        {
            string time01 = "";
            string time02 = "";

            Console.Write("Informe nome time 01: ");
            time01 = Console.ReadLine();
            Console.Write("Informe a quantidade de gol do time 01: ");
            int golTime01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe nome time 02: ");
            time02 = Console.ReadLine();
            Console.Write("Informe a quantidade de gol do time 02: ");
            int golTime02 = Convert.ToInt32(Console.ReadLine());

            if(golTime01 > golTime02)
                Console.WriteLine($"Time vencendor {time01}");
            else if (golTime01 < golTime02)
                Console.WriteLine($"Time vencendor {time02}");
            else
                Console.WriteLine("EMPATE");
        }
        
    }
}

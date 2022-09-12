using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//11 - Faça um algoritmo para ler: quantidade atual em estoque, quantidade máxima em estoque e quantidade mínima
//em estoque de um produto. Calcular e escrever a quantidade média ((quantidade média = quantidade máxima +
//quantidade mínima) / 2). Se a quantidade em estoque for maior ou igual a quantidade média escrever a mensagem
//'Não efetuar compra', senão escrever a mensagem 'Efetuar compra'. 

namespace ExercicioLogica
{
    public class Ex11 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Informe a quantidade atual em estoque: ");
            int qtdAtual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a quantidade máxima em estoque: ");
            int qtdMaxima = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a quantidade mínima em estoque: ");
            int qtdMinima = Convert.ToInt32(Console.ReadLine());

            int qtdMedia = (qtdMaxima + qtdMinima) / 2;

            if(qtdAtual >= qtdMedia)
                Console.WriteLine("Não Efetuar compra");
            else
                Console.WriteLine("Efetuar compra");
        }
    }
}

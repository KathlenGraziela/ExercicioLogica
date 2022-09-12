using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//10 - Faça um algoritmo para ler: número da conta do cliente, saldo, débito e crédito. Após, calcular e escrever o saldo
//atual (saldo atual = saldo - débito + crédito). Também testar se saldo atual for maior ou igual a zero escrever a
//mensagem 'Saldo Positivo', senão escrever a mensagem 'Saldo Negativo'. 

namespace ExercicioLogica
{
    public class Ex10 : IExercicio
    {
        public void Exercicio()
        {
            Console.Write("Digite o número da Conta: ");
            int numeroConta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor do Saldo: ");
            double saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do débito: ");
            double debito = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do credito: ");
            double credito = Convert.ToDouble(Console.ReadLine());

            double saldoAtual = saldo - debito + credito;
            Console.WriteLine($"Saldo R$ {saldoAtual.ToString("0.00")}");

            if (saldoAtual < 0)
                Console.WriteLine("Saldo negativo!");
            else
                Console.WriteLine("Saldo positivo!");

        }
    }
}

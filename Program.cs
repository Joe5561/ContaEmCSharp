﻿namespace Conta {
    internal class Program {
        static void Main(string[] args) {
            
            int opcao = 0;
            int opStar = 0;

            do {

                Conta conta = new Conta();
                Console.WriteLine();
                Console.WriteLine("Bem vindo ao programa!");
                Console.WriteLine();
                Console.Write("Escolha a opção, digite 1 para entrar no sistema ou 0 para sair: ");
                opStar = int.Parse(Console.ReadLine());

                if (opStar == 1) {
                    Console.Write("Digite o número da conta: ");
                    int numeroConta = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o nome: ");
                    string nome = Console.ReadLine();

                    

                    Console.Write("Saldo em conta: " + conta.getSaldo() + " Nome: " + nome); 
                    Console.WriteLine();                    

                    Console.Write("Entre com o valor do depósito: ");
                    int valorDeposito = int.Parse(Console.ReadLine());
                    conta.depositar(valorDeposito);
                    Console.WriteLine();
                    Console.Write("Saldo atualizado para: " + conta.getSaldo() + " Nome: " + nome);
                    Console.WriteLine();

                    Console.Write("Deseja efetuar um saque? Digite 1 para SIM ou 0 para NÃO: ");
                    opcao = int.Parse((string)Console.ReadLine());

                    if (opcao == 1) {
                        Console.Write("Digite o valor a ser retirado: ");
                        double sacarValor = double.Parse(Console.ReadLine());
                        conta.sacar(sacarValor);
                        Console.Write("Saldo atualizado para: " + conta.getSaldo() + " Nome: " + nome);
                    } else {
                        Console.Write("Saldo de: " + conta.getSaldo());
                    }

                } else {
                    System.Environment.Exit(0); 
                }


            } while (opStar == 1); 
        }
    }
}
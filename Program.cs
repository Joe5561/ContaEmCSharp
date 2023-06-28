namespace Conta {
    internal class Program {
        static void Main(string[] args) {

            do {

                Console.WriteLine();
                Console.WriteLine("Bem vindo ao programa!");
                Console.WriteLine();
                Console.Write("Escolha a opção, digite 1 para entrar no sistema ou 0 para sair: ");
                int opStar = int.Parse(Console.ReadLine());

                if (opStar == 1) {
                    Console.Write("Digite o número da conta: ");
                    int numeroConta = int.Parse(Console.ReadLine());
                    Console.Write("Entre com o nome: ");
                    string nome = Console.ReadLine().ToUpper();
                    Conta conta = new Conta(numeroConta, nome);



                    Console.Write("Saldo em conta: " + conta.Saldo + " Nome: " + conta.Nome);
                    Console.WriteLine();

                    Console.Write("Entre com o valor do depósito: ");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.depositar(valorDeposito);
                    Console.WriteLine();
                    Console.Write("Saldo atualizado para: " + conta.Saldo + " Nome: " + conta.Nome);
                    Console.WriteLine();

                    Console.Write("Deseja efetuar um saque? Digite 1 para SIM ou 0 para NÃO: ");
                    int opcao = int.Parse((Console.ReadLine()));

                    if (opcao == 1) {
                        Console.Write("Digite o valor a ser retirado: ");
                        double sacarValor = double.Parse(Console.ReadLine());
                        conta.sacar(sacarValor);
                        Console.Write("Saldo atualizado para: " + conta.Saldo
                            + " Nome: " + conta.Nome);
                        Console.WriteLine();
                    } else {
                        Console.WriteLine("Saldo de: " + conta.Saldo);
                        Console.WriteLine();
                    }

                } else if (opStar == 0) {
                    System.Environment.Exit(0);
                } else {
                    Console.Write("Opção inválida!! Digite 1 para iniciar ou 0 para sair");
                    Console.WriteLine();
                }
            } while (true);
        }
    }
}
using System.Globalization;
namespace Conta {
    internal class Conta {

        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string nome, double saldo) : this(numero, nome) {
            Saldo = saldo;
        }

        public Conta(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public double depositar(double amount) {
            if (amount >= 10000) {
                double desconto = amount * 0.01;
                amount += desconto;
            }

           return Saldo+= amount;
           
        }

        public double sacar(double amaunt) {
            return Saldo -= amaunt + 5.0;
        }

        public override string ToString() {
            return "Conta: "
                + Numero
                + "Titular: "
                + Nome
                + "Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }        
}

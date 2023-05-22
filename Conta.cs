namespace Conta {
    internal class Conta {

        private int numero;
        private string nome;
        private string cpf;
        private double saldo;

        public Conta(int numero, string nome, string cpf, double saldoInicial) {
            this.numero = numero;
            this.nome = nome;
            this.cpf = cpf;
            depositar(saldoInicial);
        }

        public Conta(int numero, string nome, string cpf) {
            this.numero = numero;
            this.nome = nome;
            this.cpf = cpf;
        }


        public Conta() {
        }

        public string getNome() {

            return nome;

        }
        public void setNome(string nome) {

            this.nome = nome;

        }
        public string getCpf() {

            return cpf;

        }
        public double getSaldo() {

            return saldo;

        }
        public int getNumero() {

            return numero;

        }
        public void sacar(double quantia) {

            saldo -= quantia + 5.0;

        }
        public void depositar(double quantia) {

            saldo += quantia;
            if (quantia >= 10000) {
                double acrecimo = quantia * 0.01;
                saldo += acrecimo;
            }
        }
    }
}

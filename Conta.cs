namespace Conta {
    internal class Conta {

        private int numero;
        private String nome;
        private double saldo;

        public Conta(int numero, string nome, double saldoInicial) {
            this.numero = numero;
            this.nome = nome;
            depositar(saldoInicial);            
        }

        public Conta(int numero, string nome) {
            this.numero = numero;
            this.nome = nome;
        }



        public Conta() {
        }

        public String getNome() {
            return nome;
        }

        public void setNome(String nome) {
            this.nome = nome;
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
        }   
    }
}

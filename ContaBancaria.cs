using System.Globalization;

namespace cap5
{
    class ContaBancaria
    {
        private int _numeroConta;
        private string nomeTitular;
        private double saldoConta;
        public double deposito;
        public double saque;
        public static double taxa = 5.00;

        //Construtor da classe
        public ContaBancaria(int numeroConta, string nomeTitular, double saldoConta)
        {
            _numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.saldoConta = saldoConta;
        }

        //Estudo de encapsulamento PRIVATE
        public int NumeroConta
        {
            get { return _numeroConta; }
            set { _numeroConta = value; }
        }

        public string NomeTitular
        {
            get { return nomeTitular; }
            set { nomeTitular = value; }
        }

        public double SaldoConta
        {
            get { return saldoConta; }
            set { saldoConta = value; }
        }

        public double AdicionarSaldo()
        {
            return saldoConta = saldoConta + deposito;
        }

        public double RemoverSaldo()
        {
            return saldoConta = saldoConta - saque - taxa;
        }

        public override string ToString()
        {
            return $"\tNúmero da Conta: {_numeroConta}\n\tNome do titular: {nomeTitular}\n\tsaldo da conta: R$ {saldoConta.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

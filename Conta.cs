using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao.Construtores.Sobrecargas.Encapsulamento
{
    class ContaBanco 
    {
        public int Conta { get; set; }
        public string  Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBanco()
        {

        }

        public ContaBanco(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBanco(int conta, string titular, double saldo) : this( conta, titular)
        {
            Saldo = saldo;
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
            
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia + 5.0;
        }


        public override string ToString()
        {    
            return "Conta: " + Conta + 
                ", Titular: " + Titular + 
                ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

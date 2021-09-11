using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Endereco endereco = new Endereco("Rua Adriano Coutinho", "14305-164", "Batatais", "SP");
                Cliente cliente = new Cliente("Maurício", "12345", "123456", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta: " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "abc123aaaaa33";
                conta.Abrir(senha);
                Console.WriteLine("Conta: " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Sacar(10, senha );

                Console.WriteLine("Saldo " + conta.Saldo);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            
            
        }
    }
}

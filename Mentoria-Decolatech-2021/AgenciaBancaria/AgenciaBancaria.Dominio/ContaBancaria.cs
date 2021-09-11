using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    //abstract -> não pode ser instanciada, mas, pode ser herdada
    public abstract class ContaBancaria
    {

        public ContaBancaria( Cliente cliente )
        {
            Random random = new Random();
            NumeroConta = random.Next(50000, 100000);
            DigitoVerificador = random.Next(0, 9);


            Situacao = SituacaoConta.Criada;

            Cliente = cliente ?? throw new Exception("Cliente deve ser informado.");

        }

        public void Abrir(string senha)
        {

            SetaSenha(senha);

            Situacao = SituacaoConta.Aberta;

            DataAbertura = DateTime.Now;

        }

        private void SetaSenha(string senha)
        {
            senha = senha.ValidaStringVazia();

            //regex -> 8 caracteres + 1 letra + 1 número
            if( !Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*[0-9]).{8,}$") )
            {
                throw new Exception("Senha inválda!");
            }

            Senha = senha;

        }

        public virtual void Sacar(decimal valor, string senha)
        {
            if (Senha != senha)
            {
                throw new Exception("Senha inválida!"); 

            }


            if ( Saldo < valor )
            {
                throw new Exception("Saldo insuficiente!");

            }
            Saldo -= valor;

        }


        public int NumeroConta { get; init; }

        public int DigitoVerificador { get; init; }

        public decimal Saldo { get; protected set; }

        //quando coloco DateTime? (interrogação) quero dizer que a informação pode ser nula
        public DateTime? DataAbertura { get; private set; }

        public DateTime? DataEncerramento { get; private set; }

        public SituacaoConta Situacao { get; private set; }

        public string Senha { get; private set; }

        public Cliente Cliente { get; init; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{ 
    public static class Validacoes
    {
        //this -> estamos tornando o método de extensão
        public static string ValidaStringVazia(this string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ?
                          throw new Exception("Informação não pode ser vazia ou nula!")
                          : texto;
        }

    }
}

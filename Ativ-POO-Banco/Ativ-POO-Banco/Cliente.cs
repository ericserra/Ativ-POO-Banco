using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO_Banco
{
    class Cliente
    {
        public double CPF { get; set; }
        public string Nome { get; set; }
        public Conta conta;
        public Endereco endereco;
    }
}

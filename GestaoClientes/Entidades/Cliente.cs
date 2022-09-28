using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoClientes.Entidades
{
    class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public string Sexo { get; set; }
        public SituacaoCliente SituacaoCliente { get; set; }




        public Cliente(int id, string nome, string cpf, TipoCliente tipo_cliente, string sexo, SituacaoCliente situacao_cliente)
        {


            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoCliente = tipo_cliente;
            Sexo = sexo;
            SituacaoCliente = situacao_cliente;

        }
    }
}
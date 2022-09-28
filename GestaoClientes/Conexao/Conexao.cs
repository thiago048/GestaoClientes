using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoClientes.Entidades;
using System.Data.SqlClient;
using System.Data;



namespace GestaoClientes.Conexao
{
    internal class Conexao
    {


            SqlConnection conexao;
			SqlCommand comando;
			SqlDataAdapter da;
			SqlDataReader dr;
			String stringSQL;

		


		public void SelecionarCliente(int? id, SituacaoCliente? situacao_cliente)

		{
			conexao = new SqlConnection(@"Server = DESKTOP-VLB4U84\MSSQLSERVER01; Database = GestaoProjetos; Trusted_Connection = True;");

			if (id != 0)
			{
				stringSQL = "[dbo].[Proc_Consulta_cliente] @cliente_id = id";


			}

			else if (situacao_cliente != null)
			{
				stringSQL = "[dbo].[Proc_Consulta_cliente] @Situacao = situacao_cliente";

			}

			else
			{
				stringSQL = "[dbo].[Proc_Consulta_cliente]";

			}


			comando = new SqlCommand(stringSQL, conexao);

			conexao.Open();

			comando.ExecuteNonQuery();








		}

	}
}

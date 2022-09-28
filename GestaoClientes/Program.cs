using System;
using GestaoClientes.Entidades;
using GestaoClientes.Conexao;
using System.Data.SqlClient;

namespace GestaoClientes
{

    class Program
    {

        static void Main(string[] args)
        {
           


            Console.WriteLine("Olá, Seja bem vindo ao sistema de Gestão de Clientes!\n" +
                  "Escolha uma das opções: ");



            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Selecionar Clientes");
            Console.WriteLine("2 - Inserir Clientes");
            Console.WriteLine("3 - Alterar Clientes");
            Console.WriteLine("4 - Excluir Clientes");
            

            switch (Console.ReadLine())
            {
                case "1":
                    Cliente cliente = new Cliente();

                    break;

                case "2":
                    Console.WriteLine(); ;
                    break;

                case "3":
                    Console.WriteLine(); ;
                    break;

                case "4":
                    Console.WriteLine(); ;
                    break;

               
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadLine();
        }


    }

}

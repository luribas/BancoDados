using BancoDados.DAL;
using BancoDados.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.ResetColor();
                Console.WriteLine("* BANCO  DE  DADOS *");
                Console.WriteLine("\n1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Buscar produto por nome");
                Console.WriteLine("4 - Remover");
                Console.WriteLine("5 - Editar");
                Console.WriteLine("0 - Sair");
                Console.Write("\nDigite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto.Renderizar();
                        Console.Write("\nPressione qualquer tecla para sair... ");
                        Console.ReadKey();
                        break;
                    case 2:
                        ListarProdutos.Renderizar();
                        Console.Write("\nPressione qualquer tecla para sair... ");
                        Console.ReadKey();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }

            } while (opcao != 0);

        }

    }
}

using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Views
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.Clear();
            Console.WriteLine(" CADASTRAR PRODUTO");
            Console.WriteLine("Nome do produtor: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço do produto: ");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade em estoque: ");
            p.Quant = Convert.ToInt32(Console.ReadLine());
            ProdutoDAO.CadastrarProduto(p);

        }
    }
}

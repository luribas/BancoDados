using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Context = BancoDados.Models.Context;

namespace BancoDados.DAL
{
    class ProdutoDAO
    {
        private static Context ctx = new Context();

        public static void CadastrarProduto(Produto p)
        {
            ctx.Produtos.Add(p);
            ctx.SaveChanges();
        }
        public static List<Produto> ListarProdutos() => ctx.Produtos.ToList();
         
    }
}

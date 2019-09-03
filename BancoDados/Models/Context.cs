using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Models
{
    class Context : DbContext
    {
        public Context() : base("DBProdutos") { }

        //Definir as classes que vão virar tabelas no bd
        public DbSet<Produto> Produtos { get; set; }

    }
}

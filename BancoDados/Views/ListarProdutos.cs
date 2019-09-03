﻿using BancoDados.DAL;
using BancoDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Views
{
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.Clear();
            Console.WriteLine(" LISTAR PRODUTOS");
            foreach(Produto produtoCadastrado in ProdutoDAO.ListarProdutos())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}

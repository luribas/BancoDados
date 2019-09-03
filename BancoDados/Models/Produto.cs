using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Models
{
    [Table("Produtos")] //Define  nome da tabela o bd

    class Produto
    {

        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int idProduto { get; set; }
        public string Nome { get; set; }
        public int Quant { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

        public String Categoria { get; set; }

        public override string ToString()
        {
            return "Nome:" + Nome + " | Preço:" + Preco + " | Quantidade:" + Quant;
        }

    }
}

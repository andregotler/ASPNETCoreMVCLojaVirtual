using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Models {
    public class Imagem {
        public int id { get; set; }
        public string Caminho { get; set; }

        //Banco de dados
        public int ProdutoID { get; set; }

        //POO
        [ForeignKey("ProdutoID")]
        public virtual Produto Produto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        
        //frete - correio

        public double Peso { get; set; }
        public int Largura { get; set; }
        public int Altura { get; set; }
        public int Comprimento { get; set; }
            
        //banco de dados - relacionamento entre tabela
        public int CategoriaId { get; set; }

        //Programação orientada a objetos
        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }

        /*EF - ORM - Biblioteca unir - Banco de dados e POO. (ORM - Mapeamento de Objetos <-> Relacionamento)
         * Fluent API - Attributes*/

        public virtual ICollection<Imagem> Imagens { get; set; }
    }
}

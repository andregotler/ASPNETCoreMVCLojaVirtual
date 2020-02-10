using PrimeiroProjeto.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Models
{
    public class Categoria
    {
        [Display(Name= "Código")]
        public int id { get; set; }

        [Display(Name = " ")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }
        /*
         * Nome:Telefone sem fio
         * Slug: telefone-sem-fio
         * URL normal: www.lojavirtual/categoria/5
         * URL Amigavél e com Slug: www.lojavirtual/categoria/informatica {url amigável}
         */
        [Display(Name = " ")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Slug { get; set; }

        /*
         * Auto-Relacionamento
         * {permite que tenha sub-categorias}
         * 1 - Informatica - P:null
         * - 2- Mouse P:1
         * -- 3-Mouse sem fio P:2
         * -- 4-Mouse Gamer P:2
         */
        [Display(Name = "Categoria Pai")]
        public int? CategoriaPaiId { get; set; }

        /*
         * ORM - EntityFrameworkCore
         */
        [ForeignKey("CategoriaPaiId")]
        public virtual Categoria CategoriaPai { get; set; }

        

    }
}

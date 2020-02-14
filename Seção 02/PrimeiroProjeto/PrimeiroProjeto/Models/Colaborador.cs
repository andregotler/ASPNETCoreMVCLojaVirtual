using PrimeiroProjeto.Libraries.Lang;
using PrimeiroProjeto.Libraries.Validacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Models
{
    public class Colaborador
    {
        
        public int id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(8, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E004")]
        [EmailUnicoColaborador]
        public string Email { get; set; }
        [Display(Name = "Senha")]
        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(8, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Senha { get; set; }


        [Display(Name = "ConfirmarSenha")]
        [Compare("Senha", ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E005"),]
        [NotMapped/*Não é salvo no banco */]
        public string ConfirmacaoSenha { get; set; }

        /*
         * TIPO = ColaboradorTipoConstant
         */
        
        public string Tipo { get; set; }

    }
}

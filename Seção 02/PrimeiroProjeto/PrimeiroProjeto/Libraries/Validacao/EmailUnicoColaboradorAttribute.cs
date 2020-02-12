using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Libraries.Validacao {
    public class EmailUnicoColaboradorAttribute : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            //pegar o valor do campo E-mail, fazer verificação
            string Email = (value as string).Trim();
            // obter repository do colaborador
            IColaboradorRepository _colaboradorRepository = (IColaboradorRepository)validationContext.GetService(typeof(IColaboradorRepository));
            List<Colaborador> colaborador = _colaboradorRepository.ObterTodosColaboradorPorEmail(Email);

            Colaborador objColaborador = (Colaborador)validationContext.ObjectInstance;

            
            //TODO - colaborador > 1 = REJEITAR

            if(colaborador.Count > 1) {
                return new ValidationResult("E-mail já existente!");
            }
            //TODO - colaborador == 1 && objColaborador.id != colaboradores[0].id = REJEITAR;

            if(colaborador.Count == 1 && objColaborador.id != colaborador[0].id) {
                return new ValidationResult("E-mail já existente!");
            }

            return ValidationResult.Success;
        }
    }
}

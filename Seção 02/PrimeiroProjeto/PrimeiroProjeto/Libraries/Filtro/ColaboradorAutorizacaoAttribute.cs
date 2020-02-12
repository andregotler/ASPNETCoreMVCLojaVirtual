﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PrimeiroProjeto.Libraries.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Libraries.Filtro {
    public class ColaboradorAutorizacaoAttribute : Attribute, IAuthorizationFilter {
        private string _tipoColaboradorAutorizado;
        public ColaboradorAutorizacaoAttribute(string TipoColaboradorAutorizado = "C") {
            _tipoColaboradorAutorizado = TipoColaboradorAutorizado;
        }

        LoginColaborador _LoginColaborador;
        public void OnAuthorization(AuthorizationFilterContext context) {
            _LoginColaborador = (LoginColaborador)context.HttpContext.RequestServices.GetService(typeof(LoginColaborador));
            Models.Colaborador colaborador = _LoginColaborador.PegarColaborador();
            if (colaborador == null) {
                context.Result = new RedirectToActionResult("Login", "home", null);
            }
            else {
                if(colaborador.Tipo == "C" && _tipoColaboradorAutorizado == "G") {
                    context.Result = new ForbidResult();
                }
            }
        }
    }
}

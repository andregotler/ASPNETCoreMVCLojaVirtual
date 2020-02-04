using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PrimeiroProjeto.Libraries.Login;
using PrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Libraries.Filtro
{
    /*
     * Tipos de filtros:
     * - Autorização -  IAuthorizationFilter
     * - Recursos - IResourceFilter
     * - Ação - IActionFilter
     * - Exceção - IExceptionFilter
     * - Resultado - IResultFilter
     */
    public class ClienteAutorizacaoAttribute : Attribute, IAuthorizationFilter
    {
        LoginCliente _LoginCliente;
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _LoginCliente = (LoginCliente)context.HttpContext.RequestServices.GetService(typeof(LoginCliente));
            Cliente cliente = _LoginCliente.PegarCliente();
            if (cliente == null)
            {
                context.Result = new ContentResult() { Content = "Acesso negado" };
            }
        }
    }
}

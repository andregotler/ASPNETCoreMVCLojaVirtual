using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Libraries.Filtro;
using PrimeiroProjeto.Libraries.Login;
using PrimeiroProjeto.Repositories.Contracts;

namespace PrimeiroProjeto.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
    
    public class HomeController : Controller
    {
        private IColaboradorRepository _repositoryColaborador;
        private LoginColaborador _LoginColaborador;
        public HomeController(IColaboradorRepository repositoryColaborador, LoginColaborador LoginColaborador)
        {
            _repositoryColaborador = repositoryColaborador;
            _LoginColaborador = LoginColaborador;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm]Models.Colaborador colaborador)
        {
            Models.Colaborador colaboradorDB = _repositoryColaborador.Login(colaborador.Email, colaborador.Senha);

            if (colaboradorDB != null)
            {

                _LoginColaborador.Login(colaboradorDB);

                return new RedirectResult(Url.Action(nameof(Painel)));

            }
            else
            {
                ViewData["MSG_E"] = "Usuário não encontrado, verifique o e-mail e senha digitado!";
                return View();
            }
        }

        [ColaboradorAutorizacao]
        [ValidateHttpReferer]
        public IActionResult Logout()
        {
            _LoginColaborador.Logout();
            return RedirectToAction("Login", "Home");
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }
        public IActionResult CadastrarNovaSenha()
        {
            return View();
        }

        [ColaboradorAutorizacao]
        public IActionResult Painel()
        {
            return View();
        }
    }
}
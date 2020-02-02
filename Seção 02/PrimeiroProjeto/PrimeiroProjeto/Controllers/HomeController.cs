using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Libranes.Email;
using PrimeiroProjeto.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PrimeiroProjeto.DataBase;
using PrimeiroProjeto.Repositories.Contracts;
using Microsoft.AspNetCore.Http;

namespace PrimeiroProjeto.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepository _RepositoryCliente;
        private INewsletterRepository _RepositoryNewsletter;
        public HomeController(IClienteRepository repositoryCliente, INewsletterRepository repositorynewsletter)
        {
            _RepositoryCliente = repositoryCliente;
            _RepositoryNewsletter = repositorynewsletter;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm]NewsletterEmail newsletter)
        {
            if (ModelState.IsValid)
            {
                _RepositoryNewsletter.Cadastrar(newsletter);

                TempData["MSG_S"] = "E-mail cadastrado! Agora você receberá promoções especiais no seu e-mail, fique atento as novidades!";

                return RedirectToAction/*<-- redireciona para alguma ação|| Forma para direcionar sem errar -->*/(nameof(Index));
            }
            {
                return View();
            }
        }
        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult ContatoAcao()
        {
            try
            {
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];

                var ListaMensagem = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, ListaMensagem, true);

                if (isValid)
                {
                    ContatoEmail.EnviarContatoEmail(contato);

                    ViewData["MSG_S"] = "Mensagem de contato enviada com successo!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var texto in ListaMensagem)
                    {
                        sb.Append(texto.ErrorMessage + "<br/>");
                    }
                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }

            }
            catch (Exception)
            {
                ViewData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";

                //TODO - implementar log
            }

            return View("Contato");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm]Cliente cliente)
        {
            if (cliente.Email == "dedezinhogotler@gmail.com" && cliente.Senha == "1234")
            {
                HttpContext.Session.Set("ID", new byte[] { 52 });
                HttpContext.Session.SetString("Email", cliente.Email);
                HttpContext.Session.SetInt32("Idade", 12);

                return new ContentResult() { Content = "Logado!" };

            }
            else
            {
                return new ContentResult() { Content = "Não Logado!" };
            }
        }
        [HttpGet]
        public IActionResult Painel()
        {
            byte[] UsuarioID;
            if (HttpContext.Session.TryGetValue("ID", out UsuarioID))
            {
                return new ContentResult() { Content = "Usuário " + UsuarioID[0] + ", Logado!" };
            }
            else
            {
                return new ContentResult() { Content = "Acesso negado" };
            }
        }
        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _RepositoryCliente.Cadastrar(cliente);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                return RedirectToAction(nameof(CadastroCliente));
            }

            return View();
        }
        public IActionResult CarrinhoCompras()
        {
            return View();
        }

    }
}
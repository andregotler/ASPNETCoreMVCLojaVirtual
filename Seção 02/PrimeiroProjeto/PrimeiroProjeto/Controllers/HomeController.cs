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
using PrimeiroProjeto.Libraries.Login;
using PrimeiroProjeto.Libraries.Filtro;
using PrimeiroProjeto.Repositories;
using PrimeiroProjeto.Models.ViewModels;

namespace PrimeiroProjeto.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepository _RepositoryCliente;
        private INewsletterRepository _RepositoryNewsletter;
        private LoginCliente _LoginCliente;
        private GerenciarEmail _gerenciaremail;
        private IProdutoRepository _produtoRepository;
        public HomeController(IProdutoRepository produtoRepository, IClienteRepository repositoryCliente, INewsletterRepository repositorynewsletter, LoginCliente loginCliente, GerenciarEmail gerenciaremail)
        {
            _LoginCliente = loginCliente;
            _RepositoryCliente = repositoryCliente;
            _RepositoryNewsletter = repositorynewsletter;
            _gerenciaremail = gerenciaremail;
            _produtoRepository = produtoRepository;
        }
        [HttpGet]
        public IActionResult Index(int? pagina, string pesquisa, string ordenacao)
        {
            var viewModel = new IndexViewModel() { lista = _produtoRepository.ObterTodosProdutos(pagina, pesquisa, ordenacao) };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Index(int? pagina, string pesquisa, string ordenacao, [FromForm] NewsletterEmail newsletter)
        {
            if (ModelState.IsValid)
            {
                _RepositoryNewsletter.Cadastrar(newsletter);

                TempData["MSG_S"] = "E-mail cadastrado! Agora você receberá promoções especiais no seu e-mail, fique atento as novidades!";

                return RedirectToAction/*TODO - <-- redireciona para alguma ação|| Forma para direcionar sem errar -->*/(nameof(Index));
            }
            else
            {
                var viewModel = new IndexViewModel() { lista = _produtoRepository.ObterTodosProdutos(pagina, pesquisa, ordenacao) };
                return View(viewModel);
            }
        }

        public IActionResult Categoria()
        {
            return View();
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
                    _gerenciaremail.EnviarContatoEmail(contato);

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
        public IActionResult Login([FromForm] Cliente cliente)
        {
            Cliente clienteDB = _RepositoryCliente.Login(cliente.Email, cliente.Senha);

            if (clienteDB != null)
            {
                _LoginCliente.Login(clienteDB);

                return new RedirectResult(Url.Action(nameof(Painel)));

            }
            else
            {
                ViewData["MSG_E"] = "Usuário não encontrado, verifique o e-mail e senha digitado!";
                return View();
            }
        }
        [HttpGet]
        [ClienteAutorizacao]
        public IActionResult Painel()
        {
            return new ContentResult() { Content = "Este é o Painel do Cliente!" };
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
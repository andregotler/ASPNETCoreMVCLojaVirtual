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

namespace PrimeiroProjeto.Controllers
{
    public class HomeController : Controller
    {
        private LojaVirtualContext _banco;
        public HomeController(LojaVirtualContext banco)
        {
            _banco = banco;
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
                _banco.NewletterEmail.Add(newsletter);
                _banco.SaveChanges();

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
            catch(Exception )
            {
                ViewData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";

                //TODO - implementar log
            }
           
            return View("Contato");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Cliente cliente)
        {
            return View();
        }
        public IActionResult CarrinhoCompras()
        {
            return View();
        }
        
    }
}
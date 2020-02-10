using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrimeiroProjeto.Libranes.Email;
using PrimeiroProjeto.Libraries.Filtro;
using PrimeiroProjeto.Libraries.Lang;
using PrimeiroProjeto.Libraries.Texto;
using PrimeiroProjeto.Repositories.Contracts;
using X.PagedList;

namespace PrimeiroProjeto.Areas.Colaborador.Controllers {
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class ColaboradorController : Controller {

        private GerenciarEmail _gerenciaremail;
        private IColaboradorRepository _colaboradorRepository;
        public ColaboradorController(IColaboradorRepository colaboradorRepository, GerenciarEmail gerenciaremail) {
            _colaboradorRepository = colaboradorRepository;
            _gerenciaremail = gerenciaremail;
        }


        public IActionResult Index(int? pagina) {
            IPagedList<Models.Colaborador> colaboradores = _colaboradorRepository.ObterTodosColaboradores(pagina);
            return View(colaboradores);
        }
        [HttpGet]
        public IActionResult Cadastrar() {

            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm]Models.Colaborador colaborador) {

            if (ModelState.IsValid) {

                colaborador.Tipo = "C";
                _colaboradorRepository.Cadastrar(colaborador);
                _gerenciaremail.EnviarSenhaParaColaboradorPorEmail(colaborador);
                TempData["MSG_S"] = Mensagem.MSG_S003;
                return RedirectToAction(nameof(Index));

            }

            return View();
        }
        [HttpGet]
        public IActionResult GerarSenha(int id) {
            Models.Colaborador colaborador = _colaboradorRepository.ObterColaborador(id);
            colaborador.Senha = KeyGenerator.GetUniqueKey(8);

            _colaboradorRepository.Atualizar(colaborador);

            _gerenciaremail.EnviarSenhaParaColaboradorPorEmail(colaborador);

            TempData["MSG_S"] = Mensagem.MSG_S003;
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Atualizar(int id) {
            Models.Colaborador colaborador = _colaboradorRepository.ObterColaborador(id);
            return View(colaborador);
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm]Models.Colaborador colaborador, int id) {

            if (ModelState.IsValid) {

                _colaboradorRepository.Atualizar(colaborador);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int Id) {

            _colaboradorRepository.Excluir(Id);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Index));
        }
    }
}

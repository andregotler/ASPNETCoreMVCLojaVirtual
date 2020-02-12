using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrimeiroProjeto.Libraries.Filtro;
using PrimeiroProjeto.Libraries.Lang;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories.Contracts;

namespace PrimeiroProjeto.Areas.Colaborador.Controllers {
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class CategoriaController : Controller {
        private ICategoriaRepository _categoriaRepository;
        public CategoriaController(ICategoriaRepository categoriaRepository) {
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index(int? pagina) {

            var categoria = _categoriaRepository.ObterTodasCategorias(pagina);
            return View(categoria);
        }
        [HttpGet]
        public IActionResult Cadastrar() {
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Categoria categoria) {
            
            if (ModelState.IsValid) {
                _categoriaRepository.Cadastrar(categoria);
                TempData["MSG_S"] = Mensagem.MSG_S001;
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.id.ToString()));
            return View();
        }
        [HttpGet]
        public IActionResult Atualizar(int id) {
            var categoria = _categoriaRepository.ObterCategoria(id);
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Where(a=>a.id !=id).Select(a => new SelectListItem(a.Nome, a.id.ToString()));
            return View(categoria);
        }
        [HttpPost]
        IActionResult Atualizar([FromForm] Categoria categoria, int id) {

            if (ModelState.IsValid) {
                _categoriaRepository.Atualizar(categoria);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Where(a => a.id != id).Select(a => new SelectListItem(a.Nome, a.id.ToString()));
            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int Id) {
            _categoriaRepository.Excluir(Id);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Index));
        }
        
        
    }
}
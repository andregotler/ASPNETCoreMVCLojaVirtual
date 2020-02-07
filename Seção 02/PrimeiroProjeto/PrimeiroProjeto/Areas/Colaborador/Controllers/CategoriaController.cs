using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Libraries.Filtro;
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
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Categoria categoria) {
            
            if (ModelState.IsValid) {
                _categoriaRepository.Cadastrar(categoria);
                TempData["MSG_S"] = "Registro salvo com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Atualizar(int id) {
            return View();
        }
        [HttpPost]
        IActionResult Atualizar([FromForm] Categoria categoria) {
            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int Id) {
            return View();
        }
        
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories.Contracts;

namespace PrimeiroProjeto.Areas.Colaborador.Controllers {
    public class CategoriaController : Controller {
        private ICategoriaRepository _categoriaRepository;
        public CategoriaController(ICategoriaRepository categoriaRepository) {
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index() {
           
           List <Categoria> categoria = _categoriaRepository.ObterTodasCategorias().ToList();
            return View(categoria);
        }
        [HttpGet]
        public IActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Categoria categoria) {

            return View();
        }
        [HttpGet]
        public IActionResult Atualizar() {
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
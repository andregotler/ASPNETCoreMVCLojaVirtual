using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PrimeiroProjeto.Libraries.Arquivo;
using PrimeiroProjeto.Libraries.Filtro;
using PrimeiroProjeto.Libraries.Lang;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories;
using PrimeiroProjeto.Repositories.Contracts;

namespace PrimeiroProjeto.Areas.Colaborador.Controllers {
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class ProdutoController : Controller {
        private IProdutoRepository _produtoRepository;
        private ICategoriaRepository _categoriaRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository) {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa) {
            var produtos = _produtoRepository.ObterTodosProdutos(pagina, pesquisa);
            return View(produtos);
        }
        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult Cadastrar() {
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.id.ToString()));
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar (Produto produto) {
            if(ModelState.IsValid) {

                _produtoRepository.Cadastrar(produto);

                
               List<string> ListaCaminhoDef = GerenciadorArquivo.MoverImagensProduto(new List<string>(Request.Form["imagem"]), produto.Id.ToString());
                //TODO - caminhoTemp -> Mover a Imagem para o caminho definitivo
                //TODO - Salvar o Caminho Definitivo no banco de dados

                TempData["MSG_S"] = Mensagem.MSG_S001;
                return RedirectToAction(nameof(Index));

            }
            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.id.ToString()));

            return View();
        }
        [HttpGet]
        public IActionResult Atualizar(int id) {

            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.id.ToString()));
            Produto produto = _produtoRepository.ObterProduto(id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult Atualizar(Produto produto, int id) {

            if (ModelState.IsValid) {
                _produtoRepository.Atualizar(produto);

                TempData["MSG_S"] = Mensagem.MSG_S001;

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categorias = _categoriaRepository.ObterTodasCategorias().Select(a => new SelectListItem(a.Nome, a.id.ToString()));
            return View();
        }

        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult Excluir(int id) {
            _produtoRepository.Excluir(id);
            TempData["MSG_S"] = Mensagem.MSG_S002;
            return RedirectToAction(nameof(Index));
        }

    }
}
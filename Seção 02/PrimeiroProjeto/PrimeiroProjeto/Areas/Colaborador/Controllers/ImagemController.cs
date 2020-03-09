using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Libraries.Arquivo;

namespace PrimeiroProjeto.Areas.Colaborador.Controllers
{
    public class ImagemController : Controller
    {
        [Area("Colaborador")]
        [HttpPost]
        public IActionResult Armazenar(IFormFile file)
        {
           var Caminho =  GerenciadorArquivo.CadastrarImagemProduto(file);
            if(Caminho.Length > 0) {
                return Ok(new { caminho = Caminho });//JSON -> JavaScript -> Javascript Object Notation
            }
            else {
                return new StatusCodeResult(500);
            }
        }

        public IActionResult Deletar(string caminho) 
        {
            if (GerenciadorArquivo.ExcluirImagemProduto(caminho)) {
                return Ok();
            }
            else {
                return  BadRequest();
            }
        }
    }
}
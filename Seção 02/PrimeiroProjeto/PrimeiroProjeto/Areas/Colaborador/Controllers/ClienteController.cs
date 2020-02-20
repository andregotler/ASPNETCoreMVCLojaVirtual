using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Libraries.Filtro;
using PrimeiroProjeto.Libraries.Lang;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Models.Constante;
using PrimeiroProjeto.Repositories.Contracts;
using X.PagedList;

namespace PrimeiroProjeto.Areas.Colaborador.Controllers {
    [Area("Colaborador")]
    [ColaboradorAutorizacao]
    public class ClienteController : Controller {

        private IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository) {
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa) {
            IPagedList<Cliente> cliente = _clienteRepository.ObterTodosClientes(pagina, pesquisa);
            return View(cliente);
        }

        [ValidateHttpReferer]
        public IActionResult AtivarDesativar(int id) {

            Cliente cliente = _clienteRepository.ObterCliente(id);

            //cliente.Situacao = (cliente.Situacao = SituacaoConstant.Ativo) ? cliente.Situacao = SituacaoConstant.Inativo : cliente.Situacao = SituacaoConstant.Ativo;

            if (cliente.Situacao == SituacaoConstant.Ativo) {

                cliente.Situacao = SituacaoConstant.Inativo;
            }
            else {
                cliente.Situacao = SituacaoConstant.Ativo;
            }

            _clienteRepository.Atualizar(cliente);

            TempData["MSG_S"] = Mensagem.MSG_S001;

            return RedirectToAction(nameof(Index));
        }
    }
}
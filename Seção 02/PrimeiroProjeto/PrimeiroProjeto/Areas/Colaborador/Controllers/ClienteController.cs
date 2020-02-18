using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjeto.Libraries.Filtro;
using PrimeiroProjeto.Models;
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

        public IActionResult Index(int? pagina) {
            IPagedList<Cliente> cliente = _clienteRepository.ObterTodosClientes(pagina);
            return View(cliente);
        }
        public IActionResult AtivarDesativar() {

            return View();
        }
    }
}
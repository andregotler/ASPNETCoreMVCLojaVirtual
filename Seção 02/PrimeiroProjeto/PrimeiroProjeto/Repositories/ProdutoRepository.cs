using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrimeiroProjeto.DataBase;
using PrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PrimeiroProjeto.Repositories {
    public class ProdutoRepository : IProdutoRepository {

        private IConfiguration _config;
        private LojaVirtualContext _banco;

        public ProdutoRepository(LojaVirtualContext banco, IConfiguration configuration) {
            _banco = banco;
            _config = configuration;
        }

        public void Atualizar(Produto produto) {
            _banco.Update(produto);
            _banco.SaveChanges();
        }

        public void Cadastrar(Produto produto) {

            _banco.Produtos.Add(produto);
            _banco.SaveChanges();
        }

        public void Excluir(int Id) {
            Produto produto = ObterProduto(Id);
            _banco.Remove(produto);
            _banco.SaveChanges();
        }

        public Produto ObterProduto(int Id) {

            return _banco.Produtos.Include(a=> a.Imagens).OrderBy(a=> a.Nome).Where(a=> a.Id == Id).FirstOrDefault();
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa)
        {
            return ObterTodosProdutos(pagina, pesquisa, "A");
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa, string ordenacao)
        {

            int RegistroPorPagina = _config.GetValue<int>("RegistroPorPagina");
            int NumeroPagina = pagina ?? 1;

            var bancoProduto = _banco.Produtos.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {

                bancoProduto = bancoProduto.Where(a => a.Nome.Contains(pesquisa.Trim()));
            }
            if (ordenacao == "A") {
                bancoProduto = bancoProduto.OrderBy(a => a.Nome);            
            }
            if (ordenacao == "ME") {
                bancoProduto = bancoProduto.OrderBy(a => a.Valor);
            }
            if (ordenacao == "MA") {
                bancoProduto = bancoProduto.OrderByDescending(a => a.Valor);
            }


            return _banco.Produtos.Include(a => a.Imagens).ToPagedList<Produto>(NumeroPagina, RegistroPorPagina);
        }
    }
}


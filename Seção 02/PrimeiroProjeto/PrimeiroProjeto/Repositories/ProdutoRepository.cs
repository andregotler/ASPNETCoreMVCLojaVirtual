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

            return _banco.Produtos.Find(Id);
        }

        public IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa) {


            int RegistroPorPagina = _config.GetValue<int>("RegistroPorPagina");
            int NumeroPagina = pagina ?? 1;

            var bancoProduto = _banco.Produtos.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa)) {

                bancoProduto = bancoProduto.Where(a => a.Nome.Contains(pesquisa.Trim()));
            }

            return _banco.Produtos.ToPagedList<Produto>(NumeroPagina, RegistroPorPagina);
        }
    }
}


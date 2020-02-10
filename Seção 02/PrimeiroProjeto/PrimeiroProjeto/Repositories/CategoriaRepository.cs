using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrimeiroProjeto.DataBase;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PrimeiroProjeto.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private IConfiguration _config;
        private LojaVirtualContext _banco;

        public CategoriaRepository(LojaVirtualContext banco, IConfiguration configuration)
        {
           _banco = banco;
            _config = configuration;
        }
        public void Atualizar(Categoria categoria)
        {
            _banco.Update(categoria);
            _banco.SaveChanges();
        }

        public void Cadastrar(Categoria categoria)
        {
            _banco.Categoria.Add(categoria);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Categoria categoria = ObterCategoria(Id);
            _banco.Remove(categoria);
            _banco.SaveChanges();
        }

        public Categoria ObterCategoria(int Id)
        {
            return _banco.Categoria.Find(Id);
        }

        public IPagedList<Categoria> ObterTodasCategorias(int? pagina) {
            int RegistroPorPagina = _config.GetValue<int>("RegistroPorPagina");
            int NumeroPagina = pagina ?? 1;
            return _banco.Categoria.Include(a=>a.CategoriaPai).ToPagedList<Categoria>(NumeroPagina, RegistroPorPagina); 
        }

        public IEnumerable<Categoria> ObterTodasCategorias() {
            return _banco.Categoria;
        }
    }
}

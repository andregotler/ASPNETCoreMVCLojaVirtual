using PrimeiroProjeto.DataBase;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private LojaVirtualContext _banco;

        public CategoriaRepository(LojaVirtualContext banco)
        {
            _banco = banco;
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

        public IEnumerable<Categoria> ObterTodasCategorias()
        {
            return _banco.Categoria.ToList();

        }
    }
}

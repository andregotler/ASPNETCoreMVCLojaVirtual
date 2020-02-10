using Microsoft.Extensions.Configuration;
using PrimeiroProjeto.DataBase;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PrimeiroProjeto.Repositories {
    public class ColaboradorRepository : IColaboradorRepository {

        private LojaVirtualContext _banco;
        private IConfiguration _config;
        public ColaboradorRepository(LojaVirtualContext banco, IConfiguration configuration) {
            _banco = banco;
            _config = configuration;
        }

        public void Atualizar(Colaborador colaborador) {
            _banco.Update(colaborador);
            _banco.SaveChanges();
        }

        public void Cadastrar(Colaborador colaborador) {
            _banco.Colaboradores.Add(colaborador);
            _banco.SaveChanges();
        }

        public void Excluir(int Id) {
            Colaborador colaborador = ObterColaborador(Id);
            _banco.Remove(colaborador);
            _banco.SaveChanges();
        }

        public Colaborador Login(string Email, string Senha) {
            Colaborador colaborador = _banco.Colaboradores.Where(m => m.Email == Email && m.Senha == Senha).FirstOrDefault();
            return colaborador;
        }

        public Colaborador ObterColaborador(int Id) {
            return _banco.Colaboradores.Find(Id);
        }

        public IPagedList<Colaborador> ObterTodosColaboradores(int? pagina) {
            int RegistroPorPagina = _config.GetValue<int>("RegistroPorPagina");
            int NumeroPagina = pagina ?? 1;
            return _banco.Colaboradores.Where(a => a.Tipo != "G").ToPagedList<Colaborador>(NumeroPagina, RegistroPorPagina);
        }
    }
}

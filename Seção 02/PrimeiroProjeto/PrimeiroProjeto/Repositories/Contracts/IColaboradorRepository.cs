using PrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PrimeiroProjeto.Repositories.Contracts
{
    public interface IColaboradorRepository
    {
        Colaborador Login(String Email, String Senha);
        void Cadastrar(Colaborador colaborador);
        void Atualizar(Colaborador colaborador);
        void AtualizarSenha(Colaborador colaborador);
        void Excluir(int Id);
        //CRUD
        Colaborador ObterColaborador(int Id);
        IPagedList<Colaborador> ObterTodosColaboradores(int? pagina);
        List<Colaborador> ObterTodosColaboradorPorEmail(string email);
    }
}

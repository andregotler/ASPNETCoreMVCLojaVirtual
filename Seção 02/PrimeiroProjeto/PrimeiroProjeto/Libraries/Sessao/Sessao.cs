using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Libraries.Sessao
{
    public class Sessao
    {
        private IHttpContextAccessor _context;
        public Sessao(IHttpContextAccessor context)
        {
            _context = context;
        }
        /*
         * CRUD - Cadastrar/Atualizar/Consultar/Remover - RemoverTodos/Exist
        */
        public void Cadastrar(string Key, String Valor)
        {
            _context.HttpContext.Session.SetString(Key, Valor);
        }
        public void Atualizar(string Key, String Valor)
        { 
            /*Se seção existe, apagar
             *Senão, atualizar sessão
             */
            if (Existe(Key))
            {
                _context.HttpContext.Session.Remove(Key);
            }
            _context.HttpContext.Session.SetString(Key, Valor);
        }
        public void Remover(String Key)
        {
            _context.HttpContext.Session.Remove(Key);
        }
        public String Consultar(string Key)
        {
            return _context.HttpContext.Session.GetString(Key);
        }
        public bool Existe(String Key)
        {
            if (_context.HttpContext.Session.GetString(Key) == null)
            {
                return false;
            }
            return true;
        }
        public void RemoverTodos()
        {
            _context.HttpContext.Session.Clear();
        }
    }
}

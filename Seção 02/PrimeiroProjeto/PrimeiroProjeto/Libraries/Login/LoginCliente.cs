using PrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrimeiroProjeto.Libraries.Login
{
    public class LoginCliente
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Cliente cliente)
        {
            //serializar
            string clienteJSONString = JsonConvert.SerializeObject(cliente);
            _sessao.Cadastrar(Key, clienteJSONString);
        }
        public  Cliente PegarCliente()
        {
            //Deserializar
            string clienteJSONString = _sessao.Consultar(Key);
            return JsonConvert.DeserializeObject<Cliente>(clienteJSONString);
            
        }
        public void Logout()
        {
            _sessao.RemoverTodos();
        }

    }
}

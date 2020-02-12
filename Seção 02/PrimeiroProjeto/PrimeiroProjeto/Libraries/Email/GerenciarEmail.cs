using Microsoft.Extensions.Configuration;
using PrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Libranes.Email
{
    public class GerenciarEmail
    {
        private SmtpClient _smtp;
        private IConfiguration _configuration;
        public GerenciarEmail(SmtpClient smtp, IConfiguration configuration) {
            _smtp = smtp;
            _configuration = configuration;
        }
        public  void EnviarContatoEmail(Contato contato)
        {

            string corpoMensagem = string.Format($"<h2>Contato - Loja Virtual </h2>" +
                $"<b>Nome: </b>{contato.Nome} </br>"+
                $"<b>E-mail: </b>{contato.Email}</br>"+
                $"<b>Texto: </b>{contato.Texto}</br>" +
                "s</br> E-mail enviado automaticamente do site LojaVirtual."
                );
            
            
            
            //MailMessage -> Construir a mensagem
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:UserName"));
            mensagem.To.Add(contato.Email);
            mensagem.Subject = "Contato - Loja Virtual - E-mail " + contato.Email;
            mensagem.Body = corpoMensagem;
            mensagem.IsBodyHtml = true;
           _smtp.Send(mensagem);
        }
        public void EnviarSenhaParaColaboradorPorEmail(Colaborador colaborador) {


            string corpoMensagem = string.Format($"<h2>Colaborador - Loja Virtual </h2>" +
              "Sua Senha é: " + $"{colaborador.Senha}");


            //MailMessage -> Construir a mensagem
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:UserName"));
            mensagem.To.Add(colaborador.Email);
            mensagem.Subject = $"Colaborador - Loja Virtual - Senha do Colaborador{colaborador.Nome}";
            mensagem.Body = corpoMensagem;
            mensagem.IsBodyHtml = true;
            _smtp.Send(mensagem);
        }
    }
}

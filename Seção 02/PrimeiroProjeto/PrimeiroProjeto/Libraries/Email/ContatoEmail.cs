using PrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Libranes.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoEmail(Contato contato)
        {
            // SMTP -> Servidor que vai enviar a mensagem.
            SmtpClient smtp = new SmtpClient ("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            //aqui escreva o email para o qual vai enviar a mensagem.
            smtp.Credentials = new NetworkCredential(/*Aqui vai o e-mail*/"",/*Aqui vai a senha do e-mail*/"");
            smtp.EnableSsl = true;

            string corpoMensagem = string.Format($"<h2>Contato - Loja Virtual </h2>" +
                $"<b>Nome: {contato.Nome}</b> </br>"+
                $"<b>E-mail: {contato.Email}</b></br>"+
                $"<b>Texto: {contato.Texto}</b></br>"+
                "</br> E-mail enviado automaticamente do site LojaVirtual."
                );
            
            
            
            //MailMessage -> Construir a mensagem
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(/*Aqui vai o e-mail*/"");
            mensagem.To.Add(/*Aqui vai o e-mail*/"");
            mensagem.Subject = "Contato - Loja Virtual - E-mail" + contato.Email;
            mensagem.Body = corpoMensagem;
            mensagem.IsBodyHtml = true;
            smtp.Send(mensagem);
        }
    }
}

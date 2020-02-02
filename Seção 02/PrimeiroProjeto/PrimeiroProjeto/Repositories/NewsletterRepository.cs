using PrimeiroProjeto.DataBase;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Repositories
{
    public class NewsletterRepository : INewsletterRepository
    {
        private LojaVirtualContext _banco;

        public NewsletterRepository(LojaVirtualContext banco)
        {
            _banco = banco;
        }
        public void Cadastrar(NewsletterEmail newsletter)
        {
            _banco.NewsletterEmail.Add(newsletter);
            _banco.SaveChanges();

        }

        public IEnumerable<NewsletterEmail> ObterTodasNewsletter()
        {
            return _banco.NewsletterEmail.ToList();
        }
    }
}

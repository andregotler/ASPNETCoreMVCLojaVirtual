﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimeiroProjeto.Models;

namespace PrimeiroProjeto.DataBase
{
    public class LojaVirtualContext: DbContext
    {
        /*
         * EF Core - ORM
         * ORM -> Biblioteca que mapeia objetos para banco de Dados Relacionais
         */
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options):base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<NewsletterEmail> NewsletterEmail { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
    }
}

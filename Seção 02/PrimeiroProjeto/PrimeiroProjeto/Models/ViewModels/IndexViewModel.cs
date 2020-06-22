﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PrimeiroProjeto.Models.ViewModels
{
    public class IndexViewModel
    {
        public NewsletterEmail newsletter { get; set; }
        public IPagedList<Produto> lista { get; set; } 
        public List<SelectListItem> ordenacao { get {
                return new List<SelectListItem>() { 
                    new SelectListItem("Alfabética", "A"),
                    new SelectListItem("Menor Preço", "ME"),
                    new SelectListItem("Maior Preço", "MA"),                };
            } private set { } }

    }
}

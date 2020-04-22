using Microsoft.Extensions.Configuration;
using PrimeiroProjeto.DataBase;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Repositories {
    public class ImagemRepository : IImagemRepository {


        private IConfiguration _config;
        private LojaVirtualContext _banco;

        public ImagemRepository(LojaVirtualContext banco, IConfiguration configuration) {
            _banco = banco;
            _config = configuration;
        }
        public void CadastrarImagens(List<Imagem> ListaImagens, int ProdutoId) {
            if (ListaImagens != null && ListaImagens.Count > 0) {
                foreach (var imagem in ListaImagens) {
                    Cadastrar(imagem);
                }
            }
        }
        public void Cadastrar(Imagem imagem) {

            _banco.Add(imagem);
            _banco.SaveChanges();
        }

        public void Excluir(int Id) {
            Imagem imagem = _banco.Imagens.Find(Id);
            _banco.Remove(imagem);
            _banco.SaveChanges();
        }

        public void ExcluirImagensDoProduto(int ProdutoID) {
            List<Imagem> imagens = _banco.Imagens.Where(a => a.ProdutoID == ProdutoID).ToList();
            foreach (Imagem imagem in imagens) {
                _banco.Remove(imagem);
            }
            _banco.SaveChanges();
        }


    }
}

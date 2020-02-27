using PrimeiroProjeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Repositories.Contracts {
    public interface IImagemRepository {
        void Cadastrar(Imagem imagem);
        void Excluir(int Id);
        void ExcluirImagensDoProduto(int ProdutoID);
    }
}

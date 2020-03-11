using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroProjeto.Libraries.Arquivo {
    public class GerenciadorArquivo {

        public static string CadastrarImagemProduto(IFormFile file) {

            var NomeArquivo = Path.GetFileName(file.FileName);
            var Caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload/Temp", NomeArquivo);

            using (var stream = new FileStream(Caminho, FileMode.Create)) {
                file.CopyTo(stream);
            }
            //
            return Path.Combine("/Upload/Temp", NomeArquivo).Replace("\\", "/");
        }
        public static bool ExcluirImagemProduto(string caminho) {

            //C:/LojaVirtual/wwwroot//upload/temp/arquivo.jpg
            string Caminho = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", caminho.TrimStart('/'));
            if (File.Exists(Caminho)) {
                File.Delete(Caminho);
                return true;
            }
            else {
                return false;
            }
        }

        public static List<string> MoverImagensProduto(List<string> listaCaminhoTemp, string ProdutoId) {

            //Cruia a pasta do produto
            var CaminhoDefinitivoPastaProduto = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads", ProdutoId);
            if (!Directory.Exists(CaminhoDefinitivoPastaProduto)) {
                Directory.CreateDirectory(CaminhoDefinitivoPastaProduto);
            }
            //Mover a Imagem da Pasta Temp para a pasta definitiva

            List<string> ListaCaminhoDef = new List<string>();
            foreach (var CaminhoTemp in listaCaminhoTemp) {

                if (string.IsNullOrEmpty(CaminhoTemp)) {

                    // /upload/temp/mouse-cosair.jpg
                    var NomeArquivo = Path.GetFileName(CaminhoTemp);
                    var CaminhoAbsolutoTemp = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", CaminhoTemp);
                    var CaminhoAbsolutoDef = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Upload", ProdutoId, NomeArquivo);

                    if (File.Exists(CaminhoAbsolutoTemp)) {
                        File.Copy(CaminhoAbsolutoTemp, CaminhoAbsolutoDef);
                        if (File.Exists(CaminhoAbsolutoDef)) {
                            File.Delete(CaminhoAbsolutoTemp);
                        }
                        ListaCaminhoDef.Add(Path.Combine("/Upload", ProdutoId, NomeArquivo).Replace("\\", "/"));
                    }
                    else {
                        return null;
                    }
                }
            }
            return ListaCaminhoDef;
        }
    }
}

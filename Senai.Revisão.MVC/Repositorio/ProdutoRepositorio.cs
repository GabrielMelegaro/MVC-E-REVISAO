using System;
using System.IO;
using Senai.Revisão.MVC.ViewModel;

namespace Senai.Revisão.MVC.Repositorio
{
    public class ProdutoRepositorio
    {
        public ProdutoViewModel Inserir(ProdutoViewModel produto){

                produto.Id = 1;
                produto.DataCriacao = DateTime.Now;

                StreamWriter sw = new StreamWriter("Produtos.csv", true);

                sw.WriteLine($"{produto.Id};{produto.Nome};{produto.Descricao};{produto.Categoria};{produto.DataCriacao};{produto.IdResponsavel}");

                sw.Close();
                return produto;
        }//fim inserir
    }
}
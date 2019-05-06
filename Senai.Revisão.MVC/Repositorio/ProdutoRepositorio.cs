using System;
using System.Collections.Generic;
using System.IO;
using Senai.Revisão.MVC.ViewModel;

namespace Senai.Revisão.MVC.Repositorio
{
    public class ProdutoRepositorio
    {
        public ProdutoViewModel Inserir(ProdutoViewModel produto){
                List<ProdutoViewModel> listaDeProdutos = Listar();
                int contador = 0;
                if(listaDeProdutos != null){
                    contador = listaDeProdutos.Count;
                }
                produto.Id = contador + 1;
                produto.DataCriacao = DateTime.Now;

                StreamWriter sw = new StreamWriter("Produtos.csv", true);
                sw.WriteLine($"{produto.Id};{produto.Nome};{produto.Descricao};{produto.Categoria};{produto.DataCriacao};{produto.Preco};{produto.IdResponsavel}");

                sw.Close();
                return produto;
        }//fim inserir
    
        public List<ProdutoViewModel> Listar(){
            List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
            ProdutoViewModel produto;
            if(!File.Exists("Produtos.csv")){
                return null;
            }
            string[] produtos = File.ReadAllLines("produtos.csv");

            foreach (var item in produtos){
                string[] dadosDoProduto = item.Split(";");
                produto = new ProdutoViewModel();
                produto.Id = int.Parse(dadosDoProduto[0]);
                produto.Nome = dadosDoProduto[1];
                produto.Descricao = dadosDoProduto[2];
                produto.Categoria = dadosDoProduto[3];
                produto.DataCriacao = DateTime.Parse(dadosDoProduto[4]);
                produto.Preco = float.Parse(dadosDoProduto[5]);
                produto.IdResponsavel = int.Parse(dadosDoProduto[6]);
                listaDeProdutos.Add(produto);
            }
            return listaDeProdutos;

        }//Fim Listar    

    }
}
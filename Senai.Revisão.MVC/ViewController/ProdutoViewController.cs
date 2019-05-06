using System;
using System.Collections.Generic;
using Senai.Revisão.MVC.Repositorio;
using Senai.Revisão.MVC.ViewModel;

namespace Senai.Revisão.MVC.ViewController
{
    public class ProdutoViewController
    {

        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto(UsuarioViewModel usuario){
            string nome, descricao, categoria;
            float preco;

            Console.WriteLine("Digite o nome do produto");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite o descrição do produto");
            descricao = Console.ReadLine();
            
            Console.WriteLine("Digite a Categoria do produto");
            categoria = Console.ReadLine();
            
            Console.WriteLine("Digite o preço do produto");
            preco = float.Parse(Console.ReadLine());

            ProdutoViewModel produto = new ProdutoViewModel();

            produto.Nome = nome;
            produto.Categoria = categoria;
            produto.Descricao = descricao;
            produto.Preco = preco;
            produto.IdResponsavel = usuario.Id;

            produtoRepositorio.Inserir(produto);

            Console.WriteLine("Produto Cadastrado com sucesso!");


        }//fim cadastrar Produto

        public static void Listar(){
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();
            foreach (var item in listaDeProdutos){
                if(item != null){
                    Console.WriteLine($"ID: {item.Id} - Nome: {item.Nome} - Criador: {item.IdResponsavel}");
                }
            }
        }
    }
}
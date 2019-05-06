using System;
using Senai.Revisão.MVC.Utils;
using Senai.Revisão.MVC.ViewController;
using Senai.Revisão.MVC.ViewModel;

namespace Senai.Revisão.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            do{
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch(opcaoDeslogado){
                    case 1:
                        //Cadastrar novo usuario
                        UsuarioViewController.CadastrarUsuario();
                        break;
                    case 2:
                        //Listar todos os usuarios
                        UsuarioViewController.ListarUsuario();
                    break;
                    case 3:
                        //Efetuar Login
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                        if(usuarioRecuperado != null){
                            Console.WriteLine($"Bem-Vindo {usuarioRecuperado.Nome}");
                            int opcaoLogado = 0;
                            do{
                                MenuUtil.MenuLogado();
                                opcaoLogado = int.Parse(Console.ReadLine());
                                
                                switch (opcaoLogado){
                                    case 1:
                                    //Cadastrar Produto
                                    ProdutoViewController.CadastrarProduto(usuarioRecuperado);
                                    break;
                                    case 2:
                                    //Listar Produtos
                                    ProdutoViewController.Listar();
                                    break;
                                    case 3:
                                    //Buscar Produto por Id
                                    break;
                                    case 0:
                                    //Sair
                                    Console.WriteLine("Tchau, Até Mais!");
                                    break;
                                    default:
                                    Console.WriteLine("Opção Inváida!");
                                    break;
                                }

                            }while(true);
                        }
                    break;
                    case 0:
                        Console.WriteLine("Tchau, Até Mais");
                    break;
                    default:
                    Console.WriteLine("Opção Inválida!");
                    break;
                }
            }while(opcaoDeslogado != 0);
        }
    }
}

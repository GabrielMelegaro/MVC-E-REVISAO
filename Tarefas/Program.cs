using System;
using Tarefas.Utils;
using Tarefas.ViewController;
using Tarefas.ViewModel;

namespace Tarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
           do{
               //Menu Deslogado
               MenuUtil.MenuDeslogado();
               opcaoDeslogado = int.Parse(Console.ReadLine());

               switch (opcaoDeslogado){
                   case 1:
                   //Cadastrar Usuario
                   UsuarioViewController.CadastrarUsuario();
                   break;
                   //fim cadastrar usuario
                   case 2:
                   //listar usuario
                   UsuarioViewController.ListarUsuario();
                   break;
                   case 0:
                   //Sair
                   Console.WriteLine("Tchau, Até Mais");
                   break;
                   //fim sair
                   default:
                   System.Console.WriteLine("Opção Inválida!");
                   break;
                }
            }while(opcaoDeslogado != 0);
        }//fim switch
    }
}
using System;
using Senai.PastelStore.MVC.Utils;
using Senai.PastelStore.MVC.ViewController;
using Senai.PastelStore.MVC.ViewModel;

namespace Senai.PastelStore.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
             int opçãoDeslogado = 0;
            do{
                //Menu Deslogado
                MenuUtil.MenuDeslogado();
                opçãoDeslogado = int.Parse(Console.ReadLine());

                switch (opçãoDeslogado){
                    case 1:
                    //Cadastrar Usuario
                    UsuarioViewController.CadastrarUsuario();
                    break;
                    case 2:
                    //Efetuar Login
                    UsuarioViewModel usuarioRetornado = UsuarioViewController.EfetuarLogin();
                    Console.WriteLine($"Bem-Vindo {usuarioRetornado.Nome}");
                    
                    break;
                    case 3:
                    //Listar usuarios cadastrados
                    UsuarioViewController.ListarUsuario();
                    break;
                    case 9:
                    //Sair
                    break;
                    default:
                    Console.WriteLine("Opção Inválida");
                    break;
                }
            }while (opçãoDeslogado != 0);
        }
    }
}

using System;
using System.Collections.Generic;
using Tarefas.Repositorio;
using Tarefas.Utils;
using Tarefas.ViewModel;

namespace Tarefas.ViewController
{
    public class UsuarioViewController
    {
        //Instanciar o repositorio
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario(){
            string nome, email, senha, tipo, confirmarSenha;

            do{
                Console.WriteLine("Digite o nome do usuário");
                nome = Console.ReadLine();

                if(string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido!");
                }
            }while(string.IsNullOrEmpty(nome));

            do{
                Console.WriteLine("Digite o E-mail");
                email = Console.ReadLine();
                
                if(!ValidacoesUtil.ValidadorDeEmail(email)){
                    Console.WriteLine("Email Inválido!");
                }
            }while(!ValidacoesUtil.ValidadorDeEmail(email));

            do{
                Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();
                
                Console.WriteLine("Confirme a senha");
                confirmarSenha = Console.ReadLine();
                
                if(!ValidacoesUtil.ValidadorDeSenha(senha, confirmarSenha)){
                    Console.WriteLine("Senha Inválida!");
                }
            }while(!ValidacoesUtil.ValidadorDeSenha(senha, confirmarSenha));


            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.Tipo = tipo;

            usuarioRepositorio.Inserir(usuarioViewModel);

            Console.WriteLine("Usuario Cadastrado com sucesso");
        }//fim cadastro de usuario

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeUsuarios){
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} Tipo:{item.Tipo} - Data de Criação {item.DataCriacao}");
            }
        }//fim listar usuario

         public static UsuarioViewModel EfetuarLogin(){
            string email, senha;
             do{
                 Console.WriteLine("Digite o email");
                 email = Console.ReadLine();

                 if(ValidacoesUtil.ValidadorDeEmail(email)){
                     Console.WriteLine("Email Inválido");
                }
             }while(!ValidacoesUtil.ValidadorDeEmail(email));

             Console.WriteLine("Digite sua senha:");
             senha = Console.ReadLine();
            
             UsuarioViewModel usuarioRetornado = usuarioRepositorio.BuscarUsuario(email,senha);

             if(usuarioRetornado != null){
                 return usuarioRetornado;
             }else{
                 Console.WriteLine($"Usuario ou senha Inválido");
                 return null;
            }
        }//fim efetuar login
    }
}
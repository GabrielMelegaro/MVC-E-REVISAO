using System;

namespace Tarefas.Utils
{
    public class MenuUtil
    {
        
        public static void MenuDeslogado(){

        /// <summary>
        ///Mostra as opções do usuário deslogado
        ///</summary>
        Console.WriteLine("---------------------------------------------");  
        Console.WriteLine("-------Bem-Vindo ao Sistema de Tarefas-------");
        Console.WriteLine("-------------------Usuário-------------------");
        Console.WriteLine("-----------(1) - Cadastrar Usuario-----------");
        Console.WriteLine("------------(2) - Listar Usuarios-------------");
        Console.WriteLine("-----------------(0) - Sair------------------");
        Console.WriteLine("---------------------------------------------");
        }
    }
}
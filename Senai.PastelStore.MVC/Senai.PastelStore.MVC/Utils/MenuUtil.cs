using System;

namespace Senai.PastelStore.MVC.Utils
{
    public class MenuUtil{
            
       /// <summary>
       /// Mostra como as opções do usuário deslogado
       /// </summary>
       public static void MenuDeslogado(){

          Console.WriteLine("---------------------------------------------");
          Console.WriteLine("-----------Restaurante PastelStore-----------");
          Console.WriteLine("---------------     Conta     ---------------"); 
          Console.WriteLine("---------------------------------------------"); 
          Console.WriteLine("          (1) Cadastrar Produto              "); 
          Console.WriteLine("          (2) Listar todos os produtos       "); 
          Console.WriteLine("          (3) Buscar produto por ID          "); 
          Console.WriteLine(" --------------------------------------------"); 
          Console.WriteLine("          (0) Sair                           ");
          Console.WriteLine("---------------------------------------------"); 
          Console.WriteLine("            Escolha uma opção                ");  
        }
    }
}
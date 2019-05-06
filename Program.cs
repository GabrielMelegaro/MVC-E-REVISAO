using System;

namespace Senai.PastelStore.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Id = 1;
            usuario.Nome = "Gabriel";
            
            ProdutoViewModel produto = new ProdutoViewModel();
            produto.Id = 1;
            produto.Nome = "Paxtel de Flango";
        }
    }
}

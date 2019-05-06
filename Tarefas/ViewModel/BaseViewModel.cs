using System;

namespace Tarefas.ViewModel
{
    public class BaseViewModel
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public DateTime DataCriacao {get;set;}
        public string Tipo {get;set;}
    }
}
namespace Senai.Revisão.MVC.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidacaoEmail(string email){
            if(email.Contains("@") && email.Contains(".")){
                return true;
            }
                return false;
        }//fim validação email

        public static bool ValidacaoSenha(string senha, string confirmacaoSenha){
            if(senha.Equals(confirmacaoSenha)){
                return true;
            }
            return false;
        }
    }
}
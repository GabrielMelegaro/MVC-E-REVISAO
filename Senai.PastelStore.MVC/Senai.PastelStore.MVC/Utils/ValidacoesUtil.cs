namespace Senai.PastelStore.MVC.Utils
{
    public class ValidacoesUtil
    {
        /// <summary>Valida o email do usuario, Verifica se o mesmo possui @ e . e contém ao menos 6 caracteres</summary>
        /// <param name="email">description</param>
        /// <returns>Retorna True caso o email seja válido caso contrário retorna false</returns>
        public static bool ValidadorDeEmail(string email){
            if(email.Contains("@") && email.Contains(".")){
                return true;
            }
            return false;
        }

        public static bool ValidadorDeSenha(string senha, string confirmarSenha){
            if(senha.Equals(confirmarSenha) && senha.Length > 5){
                return true;
            }
            return false;
        }
    }
}
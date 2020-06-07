namespace Aula_08__Abstração
{
    public class Cartao
    {
        protected string token = "dlkjifudbfe"; //chave de acesso
        public string bandeira { get; set; }
        public string titular { get; set; }
        public string numero { get; set; }
        public string cvv { get; set; }

        public bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}
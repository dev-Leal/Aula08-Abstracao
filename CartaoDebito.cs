namespace Aula_08__Abstração
{
    public class CartaoDebito : Cartao
    {
         //Atributos
        public float saldo;

        //Métodos
        public string Transferir(float valor){
            return "Transferência efetuada com sucesso!";
        }
        public string PagarTitulo(){
            return "Titulo pago com sucesso!";
        }



    }
}
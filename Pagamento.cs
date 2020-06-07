namespace Aula_08__Abstração
{
    public class Pagamento
    {
        public int DateTime { get; set; } 
        public int valor { get; set; }

        public string Pagar( float valor ){
            return "O valor a ser pago é R$ "+valor;
        }

        public string Cancelar(){
            return "Pagamento cancelado";
        }
    }
}
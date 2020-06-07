namespace Aula_08__Abstração
{
        public class CartaoCredito : Cartao

    {
    
        public float limite { get; set; }
        public void AumentarLimite(float acrescimo){
            limite = limite + acrescimo;
        }

    }
}
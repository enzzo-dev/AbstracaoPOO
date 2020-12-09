namespace AbstracaoPOO
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }
        public float acrescimo { get; set; }

        public float AumentarLimite(float limiteAtual, float acrescimo){
            return limiteAtual + acrescimo;
        }
        public string BloquearCartaoDeCredito(){
            return "Cartão de Crédito bloqueado";
        }
    }
}
using System;

namespace AbstracaoPOO
{
    public class Pagamento
    {
        //get = permissão de leitura da variável
        //set = permissão de escrita da variável

        public DateTime data { get; set; }
        public float valor { get; set; }

        public string Pagar(){
            return "Pagamento efetuado";
        }
        public string CancelarPagamento(){
            return "Pagamento cancelado";
        }
    }
}
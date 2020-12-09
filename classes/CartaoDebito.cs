namespace AbstracaoPOO.classes
{
    class CartaoDebito
    {
        private string cartaoDebito;

        private float saldoConta = 600;

        void Pagar(float valor){
            if(saldoConta >= valor){
                System.Console.WriteLine("Pagamento realizado com sucesso!");
            } else {
                System.Console.WriteLine("Falha no pagamento!");
            }
        }

        
    }
}

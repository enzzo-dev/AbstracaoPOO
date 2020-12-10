namespace AbstracaoPOO.classes
{
    public class Boleto : Pagamento
    {
        public int codigoDeBarras;

        void Registrar(){
            System.Console.WriteLine("Registrado!");
        }
    }
}
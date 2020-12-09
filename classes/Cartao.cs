namespace AbstracaoPOO
{
    public class Cartao
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set;}
        public string cvv { get; set; }
        private string token = "d23f132f1a335fEW1W2Ff2WE";

        
        public bool validarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

    }
}
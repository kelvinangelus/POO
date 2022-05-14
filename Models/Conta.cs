namespace POO.Models
{
    public abstract class Conta
    {
        protected double saldo; //"protected" permite acesso pelas classes derivadas
    
        public abstract void Creditar(double valor); //"abstract" indica que o método não tem implementação 
                                                     //classes derivadas são obrigadas a implementar este método  
        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}
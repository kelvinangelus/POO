namespace POO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor) 
        {
            base.saldo = valor;
            //this.saldo = valor; //Outra opção
        } 
    }
}
namespace POO.Models
{
    public class Pessoa
    {
        public string Nome{get;set;}

        public int Idade{get;set;}

        public string Documento{get;set;}

        public virtual void Apresentar() //virtual permite que o método seja 
        {                                //sobrescrito pelas classes derivadas           
            Console.WriteLine($"Olá, meu nome é {Nome} e minha idade é {Idade} anos");
        }
    }
}
namespace POO.Models
{
    public class Professor : Pessoa
    {
        public double Salario{get;set;}

        public  override void Apresentar()
        {
            {
                Console.WriteLine($"Olá, meu nome é {Nome} e sou um professor. Meu salario é {Salario}");
            }
        }
    }
}
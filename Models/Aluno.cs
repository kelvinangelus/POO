namespace POO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota{get;set;}

        public override void Apresentar() //override sobrescreve o método "Apresentar" definido na classe Base
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}");
        }
    }
}
using POO.Models;

/*
Pessoa p1 = new Pessoa();
p1.Nome = "Kelvin";
p1.Idade = 30;
p1.Apresentar();

Aluno a1 = new Aluno();
a1.Nome = "Kelvin";
a1.Idade = 30;
a1.Nota = 10;
a1.Apresentar();

Professor p2 = new Professor();
p2.Nome = "Kelvin";
p2.Salario = 3000;
p2.Apresentar(); 
*/

/*
Calculadora calc1 = new Calculadora();
System.Console.WriteLine("Resultado da primeira soma: " + calc1.Somar(10,10));
System.Console.WriteLine("Resultado da segunda soma: " + calc1.Somar(10,10,10));
*/

//Conta conta = new Conta(); //Não permitido pois a classe é abstract
Corrente c = new Corrente();
c.Creditar(100);

c.ExibirSaldo();
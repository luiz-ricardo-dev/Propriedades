//Referenciando a classe 
using Propriedades.Models;
// //Criando um objeto
// Pessoa p1 = new Pessoa();
// //Atribuindo valores
// p1.Nome = "Jose";
// p1.Sobrenome = "Fulano";
// p1.Idade = 14;
// //Chamando o método da classe
// p1.Apresentar();


Pessoa p1 = new Pessoa();
p1.Nome = "Thiago";
p1.Sobrenome = "Lopes";

Pessoa p2 = new Pessoa();
p2.Nome = "Leonardo";
p2.Sobrenome = "Algusto";

Pessoa p3 = new Pessoa();
p3.Nome = "Wesley";
p3.Sobrenome = "Matheus";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();
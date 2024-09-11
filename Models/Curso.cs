using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.Models
{
    public class Curso
    {
        //Construtor
        public Curso(){}

        //Propriedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Métodos da classe
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunos()
        {
            return Alunos.Count;
        }

        public void RemoverAluno(Pessoa aluno)
        {
           Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);    
            }
        }
    }
}
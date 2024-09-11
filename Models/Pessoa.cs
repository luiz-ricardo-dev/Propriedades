using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades.Models
{
    public class Pessoa
    {  //Criando um Construtor
        public Pessoa(){} //Vazio
        public Pessoa(string nome, string sobrenome) //Com Propriedades
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        
         //Criando as propridades
        private string _nome;
        private int _idade;

        public string Nome 
        { //Realizando validaçôes
            get => _nome.ToUpper(); //Retornar todo em maiusculo
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser Vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
         { 
            get => _idade;
            
            set
            {
                if(value <= 0){
                    throw new ArgumentException("A idade nao pode ser menor que zero");
                }
                _idade = value;
            }
            
         }
        //Criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
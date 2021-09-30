using System;
namespace Matheus.Mangas
{
    public class Manga : EntidadeBase
    {  
        //Atributos
        private Genero Genero {get; set; }

        private string Titulo {get; set; }

        private int Ano {get; set; }

        private int Volume {get; set; }

        private int Capitulo {get; set; }   

        private string Descricao {get; set; }

        private bool Excluido {get; set; }

        //Métodos

        public Manga(int id, Genero genero, string titulo, int ano, string descricao)   
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Ano = ano;
            //this.Volume = volume;
            //this.Capitulo = capitulo;
            this.Descricao = descricao;
            this.Excluido = false;
        }  

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine; 
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            //retorno += "Vôlume: " + this.Volume + Environment.NewLine;
           // retorno += "Capitulo: " + this.Capitulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornoTitulo()
        {
            return this.Titulo;
         }

        public int retornoId()
        {
            return this.Id;
        }

        public void Excluir(){
            this.Excluido = true;
        }

    }
}
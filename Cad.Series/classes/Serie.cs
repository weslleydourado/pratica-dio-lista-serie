using System;

namespace Cad.Series
{
    public class Serie : EntidadeBase
    {
        //Declaração de atributos
        private Genero Genero {get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        private bool Excluído {get; set;}

        //Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano) // Construtor
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluído = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: "  + this.Genero + Environment.NewLine;
            retorno += "Titulo: "  + this.Genero + Environment.NewLine;
            retorno += "Descrição: "  + this.Genero + Environment.NewLine;
            retorno += "Ano: "  + this.Genero + Environment.NewLine;
            return retorno; 
        }

        public string retornaTitulo(){
            return this.Titulo;
        }
        
        
        public int retornaId(){
            return this.Id  ;
        }

        public void Excluir(){
             this.Excluído = true;
        }
    }
}
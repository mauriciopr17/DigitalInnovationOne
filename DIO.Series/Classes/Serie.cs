using System;

namespace DIO.Series
{
  //herdando da EntidadeBase
  public class Serie : EntidadeBase
  {

    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }

    //método  construtor
    public Serie(int Id, Genero genero, string titulo, string descricao, int ano)
    {
      this.Id = Id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;

    }

    public override string ToString()
    {
      //Enviroment = ambiente, identifica de acordo com SO para pular a linha
      string retorno = "";
      retorno += "Gênero: " + this.Genero + Enviroment.NewLine;
      retorno += "Título: " + this.Titulo + Enviroment.NewLine;
      retorno += "Descrição: " + this.Descricao + Enviroment.NewLine;
      retorno += "Ano de Início: " + this.Ano;
      return retorno;
    }

    //escapsulamento
    public int retornaTitulo()
    {
      return this.Titulo;

    }

    public int retornaID()
    {
      return this.Id;
    }

  }
}
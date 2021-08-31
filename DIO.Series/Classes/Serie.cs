using System;

namespace DIO.Series
{
  //herdando da EntidadeBase
  public class Serie : EntidadeBase
  {

    public Serie(Genero genero, string titulo, string descricao, int ano)
    {
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;

    }
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }
    private bool Excluido { get; set; }

    //método  construtor
    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
      this.Id = id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Excluido = false;

    }

    public override string ToString()
    {
      //Enviroment = ambiente, identifica de acordo com SO para pular a linha
      string retorno = "";
      retorno += "Gênero: " + this.Genero + Environment.NewLine;
      retorno += "Título: " + this.Titulo + Environment.NewLine;
      retorno += "Descrição: " + this.Descricao + Environment.NewLine;
      retorno += "Ano de Início: " + this.Ano;
      return retorno;
    }

    //escapsulamento
    public string retornaTitulo()
    {
      return this.Titulo;

    }

    public int retornaID()
    {
      return this.Id;
    }

    public void Excluir()
    {
      this.Excluido = true;
    }

  }
}
using System;
using System.IO.Pipes;
using System.Linq;
using System.Threading;
using System.Globalization;


namespace DIO.Series
{
  class Program
  {

    static SerieRepositorio repositorio = new SerieRepositorio();

    static void Main(string[] args)
    {

      Console.Clear();
      string opcaoUsuario = ObterOpcaoUsuario();
   
      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            ListarSeries();
            break;
          case "2":
            InserirSerie();
            break;
          case "3":
            AtualizarSerie();
            break;
          case "4":
            ExcluirSerie();
            break;
          case "5":
            VisualizarSerie();
            break;
          case "C":
            Console.Clear();
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = ObterOpcaoUsuario();
      }
    }

    private static  void ListarGeneros(){

      Console.WriteLine(Environment.NewLine);
      foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
      }

    }

    private static void InserirSerie()
    {
      
      Console.WriteLine("**************************************");
      Console.WriteLine("Inserir nova série: " + Environment.NewLine);

      ListarGeneros();

      Console.Write("Digite o Gênero entre as opções acima: ");
      int entradaGenero = int.Parse(Console.ReadLine());

      Console.Write("Digite o Título da Série: ");
      string entradaTitulo = Console.ReadLine();

      Console.Write("Digite o Ano da Série: ");
      int entradaAno = int.Parse(Console.ReadLine());

      Console.Write("Digite a descrição da Série: ");
      string entradaDescricao = Console.ReadLine();

      Serie novaSerie = new Serie(id: repositorio.ProximoId(),
      genero: (Genero)entradaGenero,
      titulo: entradaTitulo,
      ano: entradaAno,
      descricao: entradaDescricao);

      repositorio.Insere(novaSerie);

    }

   private static void AtualizarSerie(){
     
     Console.WriteLine("Digite a série para atualizar:");
     int idSerie = int.Parse(Console.ReadLine());

     foreach (int i in Enum.GetValues(typeof(Genero)))
      {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
      }

     Console.Write("Digite o Gênero entre as opções acima: ");
      int entradaGenero = int.Parse(Console.ReadLine());

      Console.Write("Digite o Título da Série: ");
      string entradaTitulo = Console.ReadLine();

      Console.Write("Digite o Ano da Série: ");
      int entradaAno = int.Parse(Console.ReadLine());

      Console.Write("Digite a descrição da Série: ");
      string entradaDescricao = Console.ReadLine();

      Serie atualizarSerie = new Serie( id: idSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo:entradaTitulo,
                                        descricao:entradaDescricao,
                                        ano: entradaAno);

    repositorio.Atualiza(idSerie, atualizarSerie);

   }

  private static void ExcluirSerie(){
    Console.WriteLine("Digite a Série para exculsão:");

    int idSerie = int.Parse(Console.ReadLine());
    repositorio.Exclui(idSerie);

  }

   private static void VisualizarSerie(){
     Console.WriteLine("Digite o ID da série para visualizar:");

     int idSerie = int.Parse(Console.ReadLine());

     var serie = repositorio.RetornarPorId(idSerie);

     Console.WriteLine(serie);
     

   }

    private static void ListarSeries()
    {
      Console.WriteLine("**************************************");
      Console.WriteLine("Listar Séries");

      var lista = repositorio.Lista();

      if (lista.Count == 0)
      {
        Console.WriteLine("Nenhuma série encontrada.");
        return;
      }

      foreach (var serie in lista)
      {
        Console.WriteLine("#ID {0}: - {1} *Excluído* {2}", serie.retornaID(), serie.retornaTitulo(), serie.retornaExcluido());
      }

    }

    private static string ObterOpcaoUsuario()
    {

      Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR", false);
      DateTime data = DateTime.Now;
      Console.WriteLine("Data " + data + " " + data.Day.ToString("D2") + "/" + data.Month.ToString("D2") +"/"+data.Year);

      Console.WriteLine();
      Console.WriteLine("DIO Séries a seu dispor!!!" + Environment.NewLine);
      Console.WriteLine("Informe a opção desejada:" + Environment.NewLine);

      Console.WriteLine("1 - Listar Séries");
      Console.WriteLine("2 - Inserir nova Série");
      Console.WriteLine("3   - Atualizar Série");
      Console.WriteLine("4 - Excluir Série");
      Console.WriteLine("5 - Visualizar Série");
      Console.WriteLine("C - Limpar Tela");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine().ToUpper();
      Console.WriteLine();
      return opcaoUsuario;

    }
  }
}

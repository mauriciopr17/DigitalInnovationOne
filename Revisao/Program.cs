
using System;

namespace Revisao
{
  class Program
  {

    static void Main(string[] args)
    {

      Aluno[] alunos = new Aluno[5];
      var indiceAluno = 0;
      string opcaoUsuario = ObterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {

        switch (opcaoUsuario)
        {
          //TODO: Adicionar Aluno
          case "1":
            Console.WriteLine("Informe o nome do aluno:");
            var aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno:");

            //var -> inferência de tipo, não preciso declarar o tipo da variável que ele entende
            //var nota = decimal.Parse(Console.ReadLine());

            // TryParse, ele tenta fazer a conversão do que foi digitado para
            //decimal, caso ele consiga, ele declara a variável nota
            //para receber o valor e retornar ele
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
              aluno.Nota = nota;
            }
            else
            {
              throw new ArgumentException("Valor da nota deve ser decimal");
            }

            alunos[indiceAluno] = aluno;
            indiceAluno++;

            break;
          //TODO: Listar Alunos
          case "2":
            foreach (var lerVetor in alunos)
            {
              //se o nome não for nulo e nem vazio
              if (!string.IsNullOrEmpty(lerVetor.Nome))
              {
                Console.WriteLine($"Aluno: { lerVetor.Nome} Nota: {lerVetor.Nota }");
              }

            }
            break;
          //TODO: Calcular média geral
          case "3":

            decimal notaTotal = 0;
            var qtdAlunos = 0;

            for (int i = 0; i < alunos.Length; i++)
            {
              if (!string.IsNullOrEmpty(alunos[i].Nome))
              {
                notaTotal = notaTotal + alunos[i].Nota;
                qtdAlunos++;
              }

            }

            var mediaGeral = notaTotal / qtdAlunos;
            // enum
            Conceito conceitoGeral;

            if (mediaGeral < 2)
            {
              conceitoGeral = Conceito.E;
            }
            else if (mediaGeral < 4)
            {
              conceitoGeral = Conceito.D;
            }
            else if (mediaGeral < 6)
            {
              conceitoGeral = Conceito.C;
            }
            else if (mediaGeral < 8)
            {
              conceitoGeral = Conceito.B;
            }
            else
            {
              conceitoGeral = Conceito.A;
            }
            Console.WriteLine($"Média Geral: {mediaGeral} Conceito: {conceitoGeral}");
            break;

          default:
            throw new ArgumentOutOfRangeException();

        }

        opcaoUsuario = ObterOpcaoUsuario();

      }

    }

    private static string ObterOpcaoUsuario()
    {
      string opcaoUsuario;

      Console.WriteLine();
      Console.WriteLine("Informe a opção desejada");
      Console.WriteLine("1 - Inserir novo aluno");
      Console.WriteLine("2 - Listar alunos");
      Console.WriteLine("3 - Calcular média geral");
      Console.WriteLine("X - Sair");


      opcaoUsuario = Console.ReadLine();
      Console.WriteLine();
      return opcaoUsuario;
    }
  }
}

using System;
using Desafio_DIO_APP_series;

namespace DIO.Series
{
	class Program
	{
		static SerieRepositorio repositorio = new SerieRepositorio();
		static FilmeRepositorio repositorioF = new FilmeRepositorio();
		static void Main(string[] args)
		{

			string opcaoMenu = ObterOpcaoMenu();

			while (opcaoMenu.ToUpper() != "X")
			{
				switch (opcaoMenu)
				{
					case "S":
						switch (ObterOpcaoSerie())
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
							case "L":
								Console.Clear();
								break;
							case "R":
								ObterOpcaoMenu();
								break;
							default:
								throw new ArgumentOutOfRangeException();						
						}
						break;
					case "F":
						switch (ObterOpcaoFilme())
						{
							case "1":
								ListarFilme();
								break;
							case "2":
								InserirFilme();
								break;
							case "3":
								AtualizarFilme();
								break;
							case "4":
								ExcluirFilme();
								break;
							case "5":
								VisualizarFilme();
								break;
							case "L":
								Console.Clear();
								break;
							case "R":
								ObterOpcaoMenu();
								break;
							default:
								throw new ArgumentOutOfRangeException();
						}
						break;
				}
			}
			Console.WriteLine(" Good Bye! :) ");
			Console.ReadLine();

		}
		private static void ExcluirSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}
		private static void VisualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}
		private static void AtualizarSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie, genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
		private static void ListarSeries()
		{
			Console.WriteLine("Listar séries:");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in lista)
			{
				var excluido = serie.retornaExcluido();

				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? " - Excluído" : ""));
			}
		}
		private static void InserirSerie()
		{
			Console.WriteLine("Inserir nova série");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}
		//filmes
		private static void ExcluirFilme()
		{
			Console.Write("Digite o id do Filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			repositorioF.Exclui(indiceFilme);
		}
		private static void VisualizarFilme()
		{
			Console.Write("Digite o id do Filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			var filme = repositorioF.RetornaPorId(indiceFilme);

			Console.WriteLine(filme);
		}
		private static void AtualizarFilme()
		{
			Console.Write("Digite o id do Filme: ");
			int indiceFilme = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGeneroF = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTituloF = Console.ReadLine();

			Console.Write("Digite o Ano de Início do Filme: ");
			int entradaAnoF = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Filme: ");
			string entradaDescricaoF = Console.ReadLine();

			Filme atualizaFilme = new Filme(id: indiceFilme, genero: (Genero)entradaGeneroF, titulo: entradaTituloF, ano: entradaAnoF, descricao: entradaDescricaoF);

			repositorioF.Atualiza(indiceFilme, atualizaFilme);
		}
		private static void ListarFilme()
		{
			Console.WriteLine("Listar Filmes:");

			var lista = repositorioF.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum Filme cadastrado.");
				return;
			}

			foreach (var filme in lista)
			{
				var excluido = filme.retornaExcluido();

				Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? " - Excluído" : ""));
			}
		}
		private static void InserirFilme()
		{
			Console.WriteLine("Inserir novo Filme");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGeneroF = int.Parse(Console.ReadLine());

			Console.Write("Digite o Título do Filme: ");
			string entradaTituloF = Console.ReadLine();

			Console.Write("Digite o Ano de Início do Filme: ");
			int entradaAnoF = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição do Filme: ");
			string entradaDescricaoF = Console.ReadLine();

			Filme novoFilme = new Filme(id: repositorioF.ProximoId(), genero: (Genero)entradaGeneroF, titulo: entradaTituloF, ano: entradaAnoF, descricao: entradaDescricaoF);

			repositorioF.InsereF(novoFilme);
		}

		private static string ObterOpcaoSerie()
		{
			Console.WriteLine();
			Console.WriteLine("Informe a opção desejada:");
			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("L- Limpar Tela");
			Console.WriteLine("R- Retornar menu");
			Console.WriteLine();

			string opcaoSerie = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoSerie;
		}
		private static string ObterOpcaoMenu()
		{
			Console.WriteLine();
			Console.WriteLine("-    DIO Séries/Filmes  -");
			Console.WriteLine("Informe a opção desejada:");
			Console.WriteLine("S - Cadastrar série");
			Console.WriteLine("F - Cadastrar filme");
			Console.WriteLine("X - Sair");
			Console.WriteLine();

			string opcaoMenu = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoMenu;
		}
		private static string ObterOpcaoFilme()
		{
			Console.WriteLine();
			Console.WriteLine("Informe a opção desejada:");
			Console.WriteLine("1- Listar filme");
			Console.WriteLine("2- Inserir novo filme");
			Console.WriteLine("3- Atualizar filme");
			Console.WriteLine("4- Excluir filme");
			Console.WriteLine("5- Visualizar filme");
			Console.WriteLine("L- Limpar Tela");
			Console.WriteLine("R- Retornar menu");
			Console.WriteLine();

			string opcaoFilme = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoFilme;
		}
	}
}
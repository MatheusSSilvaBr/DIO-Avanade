using System;

namespace Matheus.Mangas
{
    class Program
    {
        static MangaRepositorio repositorio = new MangaRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarMangas();
                        break;
                    case "2":
                        InserirManga();
                        break;
                    case "3":
                         AtualizarManga();
                        break;
                    case "4":
                         ExcluirManga();
                        break;
                    case "5":
                        VizualizarManga();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                 opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarMangas()
        {
            Console.WriteLine("Listar Mangá");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Mangá cadastrado.");
                return;
            }

            foreach (var manga in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", manga.retornoId(), manga.retornoTitulo());
            }
        }

        private static void InserirManga()
        {
            Console.WriteLine("Inserir um novo Manga");
            
            foreach (int i in Enum.GetValues(typeof(Genero)))     
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Titulo do Manga: ");
            string entradaTitulo = Console.ReadLine();

             Console.WriteLine("Digite Ano do Inicio do Manga: ");
            int entradaAno = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a Descrição do Manga: ");
            string entradaDescricao = Console.ReadLine();

            Manga novoManga = new Manga (id: repositorio.ProximoId(),
                                         genero: (Genero)entradaGenero,
                                         titulo: entradaTitulo,
                                         ano: entradaAno,
                                         descricao: entradaDescricao);  

            repositorio.Insere(novoManga);

             
        }

        private static void AtualizarManga()
        {
            Console.Write("Digite o id da série: ");
            int indiceManga = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))     
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Titulo do Manga: ");
            string entradaTitulo = Console.ReadLine();

             Console.WriteLine("Digite Ano do Inicio do Manga: ");
            int entradaAno = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a Descrição do Manga: ");
            string entradaDescricao = Console.ReadLine();

            Manga novoManga = new Manga (id: indiceManga,
                                         genero: (Genero)entradaGenero,
                                         titulo: entradaTitulo,
                                         ano: entradaAno,
                                         descricao: entradaDescricao);  

            repositorio.atualiza(indiceManga, novoManga);
        }
        private static void ExcluirManga()
        {
            Console.Write("Digite o id da série: ");
            int indiceManga = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceManga);
        }

        private static void VizualizarManga()
        {
            Console.Write("Digite o id da série: ");
            int indiceManga = int.Parse(Console.ReadLine());

            var manga = repositorio.RetornaPorId(indiceManga);

            Console.WriteLine(manga);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao Matheus Mangá!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar Mangás");
            Console.WriteLine("2- Inserir Novo Manga");
            Console.WriteLine("3- Atualizar Manga");
            Console.WriteLine("4- Excluir Manga");
            Console.WriteLine("5- Visualizar Manga");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}

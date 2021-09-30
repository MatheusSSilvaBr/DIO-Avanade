using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Manga[] mangas = new Manga [5];
            var indiceManga = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do manga: ");
                        var manga = new Manga();
                        manga.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do manga: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            manga.Nota = nota;
                        }
                        else 
                        {
                            throw new ArgumentOutOfRangeException("Valor da Nota deve ser decimal!");
                        }

                        mangas[indiceManga] = manga;
                        indiceManga++;

                        break;
                    case "2":
                        foreach(var m in mangas)
                        {
                            if (!string.IsNullOrEmpty(m.Nome))
                            {
                                 Console.WriteLine($"Manga:{m.Nome} - Nota:{m.Nota}");
                            }                          
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                 opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo manga");
            Console.WriteLine("2 - Listar manga");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}

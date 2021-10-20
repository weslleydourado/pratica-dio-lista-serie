using System;
using Cad.Series.classes;

namespace Cad.Series
{    
    class Program
    {
        static SerieRepo repositorio = new SerieRepo();
        static void Main(string[] args)
        {
           string opUsuario = ObterOpUsuario();

           while (opUsuario.ToUpper()!= "X")
           {
               switch (opUsuario)
               {
                case "1":
                    ListarSerie();
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

           }

           
        }


        private static void ListarSerie()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();

            if (lista.Count ==0)
            {
                Console.WriteLine("Nenhuma série encontrada.");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: {1} ", serie.retornaId(), serie.retornaTitulo());
                
            }
        }

         private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série a lista.");

            foreach (int i in Enum.GetValues(typeof (Genero)))
            {
            Console.WriteLine("{0} - {1} ", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Qual gênero entre as opções: ");
            int recebeGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o título da série.");
            string recebeTitulo = Console.ReadLine();

            Console.WriteLine("Breve descrição.");
            string recebeDescricao = Console.ReadLine();

            Console.WriteLine("Ano de lançamento.");
            int recebeAno = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero) recebeGenero,
                                        titulo: recebeTitulo,
                                        ano: recebeAno,
                                        descricao: recebeDescricao);

            repositorio.Insere(novaSerie);


        }

        private static void AtualizarSerie(){
            Console.WriteLine("Informe o ID da série.");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof (Genero)))
            {
                Console.WriteLine("{0} - {1} ", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Qual gênero entre as opções: ");
            int recebeGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o título da série.");
            string recebeTitulo = Console.ReadLine();

            Console.WriteLine("Breve descrição.");
            string recebeDescricao = Console.ReadLine();

            Console.WriteLine("Ano de lançamento.");
            int recebeAno = int.Parse(Console.ReadLine());

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero) recebeGenero,
                                        titulo: recebeTitulo,
                                        ano: recebeAno,
                                        descricao: recebeDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);

        }

        private static void ExcluirSerie(){
            Console.WriteLine("Informe o ID da série s excluir.");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);


        }

        private static void VisualizarSerie(){
            Console.WriteLine("Informe o ID da série s excluir.");
            int indiceSerie = int.Parse(Console.ReadLine());
            
            var serie = repositorio.RetornaId(indiceSerie);
            
            Console.WriteLine(serie);
        }


        

        private static string ObterOpUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Sua lista de séries!!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1- Listar séries.");
            Console.WriteLine("2- Inserir nova série a lista.");
            Console.WriteLine("3- Atualizar lista.");
            Console.WriteLine("4- Excluir série da lista.");
            Console.WriteLine("5- Visualizar minha lista.");
            Console.WriteLine("C- Limpar Tela.");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            string opUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opUsuario;            
        }
    }
}

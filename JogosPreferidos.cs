using Consumir_API.Modelos;
using System.Text.Json;

namespace Consumir_API
{
    public class JogosPreferidos
    {

        public string? Nome { get; set; }
        public List<Jogo> ListaJogosPreferidos { get; set; }

        public JogosPreferidos(string nome)
        {
            Nome = nome;
            ListaJogosPreferidos = new List<Jogo>();
        }

        public void AdicionarJogos(Jogo jogo)
        {
            ListaJogosPreferidos.Add(jogo);
        }

        public void ExibirJogosPreferidos()
        {
            Console.WriteLine($"Jogos Preferidos de {Nome}");
            Console.WriteLine("");

            foreach (Jogo jogo in ListaJogosPreferidos)
            {
                Console.WriteLine($"Nome: {jogo.titulo}");
                Console.WriteLine($"MetaCritic: {jogo.metacritic}");
                Console.WriteLine($"Nota Steam: {jogo.steamRate}");
            }
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                jogos = ListaJogosPreferidos
            });

            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            // Criando o arquivo
            File.WriteAllText(nomeDoArquivo, json);

            Console.WriteLine($"Json criado com sucesso! Caminho: {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}

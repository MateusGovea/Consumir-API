using Consumir_API.Modelos;
using System.Text.Json;

namespace Consumir_API
{
    public class ConsumirAPI
    {

        public ConsumirAPI()
        {

        }

        // Conexão com API e GET resultados
        public static async Task<string> ColetarDadosAPI()
        {
            using (HttpClient client = new HttpClient())
            {

                string resposta = "";

                try
                {
                    resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.ToString()}");
                }

                return resposta;
            }
        }

        // Transcrever resultados em uma lista de objetos da classe
        public static List<Jogo> Desserializar(Task<string> resposta)
        {
            var jogos = JsonSerializer.Deserialize<List<Jogo>>(resposta.Result)!;
            return jogos;
        }
    }
}

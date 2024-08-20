using System.Text.Json.Serialization;

namespace Consumir_API.Modelos
{
    public class Jogo
    {

        // Transcrição dos Atributos da API
        [JsonPropertyName("title")]
        public string? titulo { get; set; }

        [JsonPropertyName("metacriticScore")]
        public string? metacritic { get; set; }

        [JsonPropertyName("steamRatingText")]
        public string? steamRate { get; set; }


        public void ExibirJogo()
        {
            Console.WriteLine($"Nome: {titulo}");
            Console.WriteLine($"Metacritic: {metacritic}");
            Console.WriteLine($"Steam Rating: {steamRate}");
        }
    }
}

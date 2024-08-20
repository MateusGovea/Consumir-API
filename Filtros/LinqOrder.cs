using Consumir_API.Modelos;

namespace Consumir_API.Filtros
{
    public class LinqOrder
    {
        public static void OrdenarNotas(List<Jogo> jogos)
        {
            var notasOrdenadas = jogos
                .OrderBy(jogo => int.Parse(jogo.metacritic!))
                .Select(jogo => jogo.metacritic)
                .Distinct()
                .ToList();

            Console.WriteLine("----- Notas Ordenadas -----");

            foreach (var jogo in notasOrdenadas)
            {
                Console.WriteLine($"-> {jogo}");
            }

        }
    }
}

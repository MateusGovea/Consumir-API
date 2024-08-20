using Consumir_API.Modelos;

namespace Consumir_API.Filtros
{
    public class LinqFilter
    {
        public static void FiltrarNotaAltaMetacritic(List<Jogo> jogos)
        {

            var notasAltas = jogos
                .Select(notas => int.Parse(notas.metacritic!))
                .Where(notas => notas > 50)
                .ToList();

            Console.WriteLine("----- Notas Filtradas -----");

            foreach (var nota in notasAltas)
            {
                Console.WriteLine($"-> {nota}");
            }
        }

        public static void FiltrarPorNotaMixed(List<Jogo> jogos, string notaSteam)
        {
            var jogosMixed = jogos
                .Where(jogo => jogo.steamRate!.Contains(notaSteam))
                .ToList();

            Console.WriteLine("----- Jogos Mixed -----");

            foreach (var jogo in jogosMixed!)
            {
                Console.WriteLine($"-> {jogo}");
            }
        }
    }
}

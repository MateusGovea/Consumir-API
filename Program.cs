using Consumir_API.Modelos;
using static Consumir_API.ConsumirAPI;
using static Consumir_API.Filtros.LinqFilter;
using static Consumir_API.Filtros.LinqOrder;
public class Program
{
    public static void Main(string[] args)
    {
        Task<string> resultados = ColetarDadosAPI();

        List<Jogo> jogos = Desserializar(resultados);

        jogos[0].ExibirJogo();

        FiltrarNotaAltaMetacritic(jogos);

        OrdenarNotas(jogos);

        //FiltrarPorNotaMixed(jogos, "Mixed");

    }
}

#region Exemplo Direto
/*using (HttpClient client = new HttpClient())
{
    try
    {
        string resultados = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resultados);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}*/
#endregion
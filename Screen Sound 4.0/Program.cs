using System.Text.Json;
using Screen_Sound_4._0.Modelos;
using Screen_Sound_4._0.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1696].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Kanye West");

        var musicasPreferidasDoDaniel = new MusicasPreferidas("Gabriel");
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1696]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1696]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1696]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1696]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1696]);



    }
    catch (Exception ex)
    {
        Console.WriteLine($"Sabe oq acontece? tem um pobrema: {ex.Message}");
    }
}
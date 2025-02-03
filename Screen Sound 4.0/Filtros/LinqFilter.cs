using System.Linq;
using Screen_Sound_4._0.Modelos;

namespace Screen_Sound_4._0.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-{genero}-");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Ta ai os vagabundo q vc pediu pra eu mostra");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"-{artista}-");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine($"Ta ai as musicas do artista q vc pediu pra eu mostra");
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"-{musica.Nome}-");
        }
    }

    public static void FiltrarMusicasPorTom(List<Musica> musicas, string tom)
    {
        var musicasPorTom = musicas.Where(musica => musica.Tom.Equals(tom)).ToList();
        Console.WriteLine($"Ta ai as musicas no tom q vc pediu pra eu mostra\r");
        foreach (var musica in musicasPorTom)
        {
            Console.WriteLine($"-{musica.Nome}-");
        }
    }

    public static string ConverterNumeroParaTom(int? Numero)
    {
        var tom = new Dictionary<int, string>
    {
        {0, "C"}, {1, "C#"}, {2, "D"}, {3, "D#"}, {4, "E"}, {5, "F"},
        {6, "F#"}, {7, "G"}, {8, "G#"}, {9, "A"}, {10, "A#"}, {11, "B"}
    };

        return tom[Numero.Value];
    }
}

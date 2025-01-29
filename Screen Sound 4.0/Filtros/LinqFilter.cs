using System.Linq;
using Screen_Sound_4._0.Modelos;

namespace Screen_Sound_4._0.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica>musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-{genero}-");
        }
    }
}

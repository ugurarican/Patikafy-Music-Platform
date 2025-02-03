using Patikafy_Music_Platform;
using System.Runtime.Intrinsics.X86;

List<Artist> artists = new List<Artist>
{
    new Artist("Ajda Pekkan", "Pop", 1968, 20),
    new Artist("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10),
    new Artist("Fudna Arar", "Pop", 1971, 3),
    new Artist("Sertap Erener", "Pop", 1994, 5),
    new Artist("Sıla", "Pop", 2009 , 3),
    new Artist("Serdar Ortaç", "Pop", 1994, 10),
    new Artist("Tarkan", "Pop", 1992, 40),
    new Artist("Hande Yener", "Pop", 1999, 7),
    new Artist("Hadise", "Pop", 2005, 5),
    new Artist("Gülben Ergen","Pop / Türk Halk Müziği", 1997, 10),
    new Artist("Neşet Ertaş","Türk Halk Müziği", 1960, 2)
};
Console.WriteLine("Adı S ile başlayan sanatçılar:");
var sArtist = artists.Where(a => a.ArtistNameSurname.StartsWith("S"));
foreach (var artist in sArtist)
{
    Console.WriteLine(artist.ArtistNameSurname);
}
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
var top10SellingArtist = artists.Where(b => b.SalesAmount > 10);
foreach (var artist in top10SellingArtist)
{
    Console.WriteLine(artist.ArtistNameSurname + " " + artist.SalesAmount + " M");
}
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile:");
var filteredArtists = artists.Where(c => c.ReleaseYear < 2000 && c.MusicGenre.StartsWith("Pop"))
                             .OrderBy(d => d.ArtistNameSurname)
                             .GroupBy(e => e.ReleaseYear);
foreach (var group in filteredArtists)
{
    Console.WriteLine($"Year: {group.Key}");
    foreach (var artist in group)
    {
        Console.WriteLine(artist);
    }
}
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("En çok albüm satan sanatçı:");
var topSellingArtist = artists.OrderByDescending(a => a.SalesAmount).FirstOrDefault();

if (topSellingArtist != null)
{
    Console.WriteLine(topSellingArtist.ArtistNameSurname + " " + topSellingArtist.SalesAmount + " M");
}
else
{
    Console.WriteLine("Sanatçı bulunamadı.");
}
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı:");
var newestArtist = artists.OrderByDescending(a => a.ReleaseYear).FirstOrDefault();
if (newestArtist != null)
{
    Console.WriteLine(newestArtist.ArtistNameSurname);
}
else Console.WriteLine("Sanatçı bulunamadı.");

var oldesArtist = artists.OrderBy(b => b.ReleaseYear).FirstOrDefault();
if (oldesArtist != null)
{
    Console.WriteLine(oldesArtist.ArtistNameSurname);
}
else Console.WriteLine("Sanatçı bulunamadı.");
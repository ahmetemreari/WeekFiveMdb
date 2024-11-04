using System;
using System.Collections.Generic;

class Film
{
    public double ImdbPuani { get; set; }
    public   string Ismi { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        //liste oluştur
        List<Film> filmListesi = new List<Film>();

        while (true)
        // film ismi ve imdb puanı al , yeni film ekleyip eklemyeceğini sor
        {
            Film yeniFilm = new Film();
            //film ismi
            Console.Write("Film ismi: ");
            yeniFilm.Ismi = Console.ReadLine();

            Console.Write("IMDb puanı: ");
            yeniFilm.ImdbPuani = double.Parse(Console.ReadLine());

            filmListesi.Add(yeniFilm);

            Console.WriteLine("Yeni bir film eklemek ister misiniz? (evet/hayır)");
            string cevap = Console.ReadLine().ToLower();
            // eğer evet se döngü devam etsin, değilse döngüyü kır
            if (cevap != "evet")
            {
                break;
            }
        }

        // Bütün filmleri listele
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmListesi)
        // var ile kendi string , int gibi seçimi yapar
        {
            Console.WriteLine($"Film: {film.Ismi}, IMDb Puanı: {film.ImdbPuani}");
        }

        // IMDb puanı 4 ile 9 arasında olan filmleri listele
        Console.WriteLine("\nIMDb Puanı 4 ile 9 arasında olan Filmler:");
        foreach (var film in filmListesi)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film: {film.Ismi}, IMDb Puanı: {film.ImdbPuani}");
            }
        }

        // İsmi 'A' ile başlayan filmleri listele
        Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
        foreach (var film in filmListesi)
        {
            if (film.Ismi.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film: {film.Ismi}, IMDb Puanı: {film.ImdbPuani}");
            }
        }
    }
}

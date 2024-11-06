using System;
using System.Collections.Generic;

public class Kitap
{
    // Kitap özellikleri
    public string Ad { get; private set; }
    public string Yazar { get; private set; }
    public int YayinYili { get; private set; }

    // Yapıcı metot
    public Kitap(string ad, string yazar, int yayinYili)
    {
        Ad = ad;
        Yazar = yazar;
        YayinYili = yayinYili;
    }

    // Kitap bilgisi metodu
    public string KitapBilgisi()
    {
        return $"Ad: {Ad}, Yazar: {Yazar}, Yayın Yılı: {YayinYili}";
    }
}

public class Kutuphane
{
    // Özellikler
    public List<Kitap> Kitaplar { get; private set; }

    // Yapıcı metot: Kitaplar listesi boş olarak başlatılır
    public Kutuphane()
    {
        this.Kitaplar = new List<Kitap>();
    }

    // Kitap ekleme metodu
    public void KitapEkle(Kitap yeniKitap)
    {
        this.Kitaplar.Add(yeniKitap);
        Console.WriteLine($"{yeniKitap.Ad} kütüphaneye eklendi.");
    }

    // Kitapları listeleme metodu
    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki Kitaplar:");
        foreach (var kitap in this.Kitaplar)
        {
            Console.WriteLine(kitap.KitapBilgisi());
        }
    }
}

// Kullanım örneği
class Program
{
    static void Main(string[] args)
    {
        // Kütüphane nesnesi oluşturma
        Kutuphane kutuphane = new Kutuphane();

        // Kitapları ekleme
        Kitap kitap1 = new Kitap("kürk mantolu madonna", "sabahattin ali", 1995);
        Kitap kitap2 = new Kitap("Sefiller", "Victor Hugo", 1862);

        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);

        // Kitapları listeleme
        kutuphane.KitaplariListele();
    }
}

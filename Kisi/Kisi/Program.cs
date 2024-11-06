using System;

public class Kisi
{
    // Özellikler
    public string Ad { get; private set; }
    public string Soyad { get; private set; }
    public string TelefonNumarasi { get; private set; }

    // Yapıcı Metot
    public Kisi(string ad, string soyad, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }

    // KisiBilgisi Metodu
    public string KisiBilgisi()
    {
        return $"Ad Soyad: {Ad} {Soyad}, Telefon: {TelefonNumarasi}";
    }
}

// Kullanım örneği
class Program
{
    static void Main(string[] args)
    {
        // Bir kişi oluşturma
        Kisi kisi = new Kisi("Hilal", "Arıboğa", "0507 3710669");

        // Kişi bilgilerini görüntüleme
        Console.WriteLine(kisi.KisiBilgisi());
    }
}

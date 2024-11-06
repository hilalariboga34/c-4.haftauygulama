using System;

public class KiralikArac
{
    // Özellikler
    public string Plaka { get; private set; }
    public decimal GunlukUcret { get; private set; }
    public bool MusaitMi { get; private set; }

    // Yapıcı Metot
    public KiralikArac(string plaka, decimal gunlukUcret)
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
        MusaitMi = true; // Varsayılan olarak araç müsait
    }

    // Aracı Kirala Metodu
    public void AraciKirala()
    {
        if (MusaitMi)
        {
            MusaitMi = false;
            Console.WriteLine($"{Plaka} plakalı araç kiralandı.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plakalı araç zaten kirada.");
        }
    }

    // Aracı Teslim Et Metodu
    public void AraciTeslimEt()
    {
        if (!MusaitMi)
        {
            MusaitMi = true;
            Console.WriteLine($"{Plaka} plakalı araç teslim edildi.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plakalı araç zaten müsait durumda.");
        }
    }
}

// Kullanım örneği
class Program
{
    static void Main(string[] args)
    {
        // Kiralık araç oluşturma
        KiralikArac arac = new KiralikArac("34ABC123", 150);

        // Aracı kirala
        arac.AraciKirala();    // Kiralandı
        arac.AraciKirala();    // Zaten kirada

        // Aracı teslim et
        arac.AraciTeslimEt();  // Teslim edildi
        arac.AraciTeslimEt();  // Zaten müsait
    }
}

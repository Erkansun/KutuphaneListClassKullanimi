using Sinif;

namespace KutuphaneListClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap()
            {
                Adi = "C# Eğitim Kitabı",
                BasimYili = 2020,
                YazarAdi = "Murat Yücedağ",
                Stok = 5
            };

            Kitap kitap2 = new Kitap()
            {
                Adi = "10 Adımda Yazılım Geliştirme",
                BasimYili = 2015,
                YazarAdi = "Kadir Çamoğlu",
                Stok = 3
            };

            Kitap kitap3 = new Kitap();
            kitap3.Adi = "Borsa'da Tek Başına";
            kitap3.BasimYili = 2022;
            kitap3.YazarAdi = "Peter Lynch";
            kitap3.Stok = 4;


            List<Kitap> kitaplar = new List<Kitap>();
            kitaplar.Add(kitap1);
            kitaplar.Add(kitap2);
            kitaplar.Add(kitap3);

            for (int i = 0; i < kitaplar.Count; i++)
            {
                var kitap = kitaplar[i];

                Console.WriteLine($"{i+1}. Kitap Bilgisi");
                Console.WriteLine("------------------");
                Console.WriteLine($"Adı: {kitap.Adi}");
                Console.WriteLine($"Basım Yılı: {kitap.BasimYili}");
                Console.WriteLine($"Yazar Adı: {kitap.YazarAdi}");
                Console.WriteLine($"Stok: {kitap.Stok}");
                Console.WriteLine();
            }
            
           Console.ReadKey();
        }
    }
}

using System.Security.Cryptography.X509Certificates;

namespace Sinif
{
    public class Kitap
    {
        public string Adi { get; set; } = "";
        public int BasimYili { get; set; } = 2025;
        public string YazarAdi { get; set; } = "";
        public int Stok { get; set; } = 1;
    }
}

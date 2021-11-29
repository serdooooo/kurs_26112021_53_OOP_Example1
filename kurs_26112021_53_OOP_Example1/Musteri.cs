using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_26112021_53_OOP_Example1
{
    class Musteri
    {
        //properties

        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyetler Cinsiyeti { get; set; }
        public UrunSepeti MusterininUrunSepeti { get; set; }

        //Metotlar

        public bool MusterininDogumGunumu()
        {
            bool kontrol = false;
            kontrol = (DogumTarihi.Day == DateTime.Now.Day && DogumTarihi.Month == DateTime.Now.Month) ? true : false;
            return kontrol;
        }
        public void MusteriBilgileriYazdir()
        {
            Console.WriteLine($"Müşteri No:{MusteriId} - {MusteriAdi} {MusteriSoyadi}");
        }
        public void MusterininSepetiniYazdir()
        {
            if (MusterininUrunSepeti.UrunlerListesi.Count > 0)
            {
                //Listeyi yazdırmadan önce doğum günü durumuna bakmanız gerekiyor.
                if (MusterininDogumGunumu()==true)
                {
                    MusterininUrunSepeti.DogumGunuHediyesiEkle();
                    Console.WriteLine("Doğum gününüz. Gofret hediyeniz sepete eklendi.");
                }
                int sayac = 1;
                foreach (var item in MusterininUrunSepeti.UrunlerListesi)
                {
                    Console.WriteLine(sayac + ". ürünümüz: " + item.UrunAdi);
                    sayac++;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4Odev
{
    class Ogrenci
    {

        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int finalNotu;
        private string okulIsmi;


        public Ogrenci(int ogrenciNo, string isim, string soyisim, int vize1, int vize2, int finalNotu, string okulIsmi)
        {
            this.ogrenciNo = ogrenciNo;
            this.isim = isim;
            this.soyisim = soyisim;
            this.vize1 = vize1;
            this.vize2 = vize2;
            this.finalNotu = finalNotu;
            this.okulIsmi = okulIsmi;
        }


        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine($"Öğrenci No: {ogrenciNo}");
            Console.WriteLine($"İsim: {isim}");
            Console.WriteLine($"Soyisim: {soyisim}");
            Console.WriteLine($"Vize 1: {vize1}");
            Console.WriteLine($"Vize 2: {vize2}");
            Console.WriteLine($"Final Notu: {finalNotu}");
            Console.WriteLine($"Okul İsmi: {okulIsmi}");
        }


        public double ogrenciOrtalamasiBul()
        {
            return (vize1 * 0.3 + vize2 * 0.3 + finalNotu * 0.4);
        }


        public string okulGetir()
        {
            return okulIsmi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci(123, "Ferhat", "Çalışkan", 85, 90, 88, "Karabük Üniversitesi");

            bool cikis = false;
            while (!cikis)
            {

                Console.WriteLine("\nLütfen bir işlem seçin:");
                Console.WriteLine("1- Öğrenci Bilgileri Göster");
                Console.WriteLine("2- Öğrenci Ortalamasını Göster");
                Console.WriteLine("3- Öğrencinin Okulunu Öğren");
                Console.WriteLine("4- Çıkış Yap");

                int secim = int.Parse(Console.ReadLine());


                switch (secim)
                {
                    case 1:
                        ogrenci.ogrenciBilgileriGoster();
                        break;
                    case 2:
                        double ortalama = ogrenci.ogrenciOrtalamasiBul();
                        Console.WriteLine($"Öğrencinin Ortalaması: {ortalama}");
                        break;
                    case 3:
                        string okulIsmi = ogrenci.okulGetir();
                        Console.WriteLine($"Öğrencinin Okuduğu Okul: {okulIsmi}");
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        cikis = true;
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız, lütfen tekrar deneyin.");
                        break;
                }
            }
        }
    }
}

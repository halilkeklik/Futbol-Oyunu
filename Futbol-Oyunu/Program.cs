using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Futbol_Oyunu
{
    class Futbolcu//burada Futbolcu sınıfını oluşurdum.
    {
        public string adSoyad;//burada ise futolcu sınıfın temel özelliklerini oluşurtudum futbolcudan kalıtım alacak sınıflar olduğundan bir çoğunu protected tanımladım.
        public int formaNo;
        protected double hiz;
        protected double dayaniklilik;
        protected double pas;
        protected double sut;
        protected double yetenek;
        protected double dogalForm;
        protected double sans;
        protected double kararlilik;
        protected double PasSansi;
        protected double GolSansi;
        Random rastgele = new Random();

        public virtual bool PasVer()//burada Futbolcu sınfının Pas ver metodunu tanımladm Pas Şansı Futbolcu özel olarak hesplarınır.
        {
            PasSansi = pas * 0.3 + yetenek * 0.3 + dayaniklilik * 0.1 + dogalForm * 0.1 + sans * 0.2;

            if (PasSansi > 60)
            {
                Console.WriteLine("Rastgele olarak " + formaNo + " nolu oyuncuya pas atıldı.");
                return true;
            }
            else
            {
                Console.WriteLine("Pas basarisiz");
                return false;
            }

        }
        public virtual bool GolVur() //burada Futbolcu sınfının Gol Vur metodunu tanımladm Gol Şansı Futbolcu özel olarak hesplarınır.
        {
            GolSansi = yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + hiz * 0.1 + sans * 0.2;
            if (GolSansi > 70)
            {
                Console.WriteLine("GOLLLL " + adSoyad + " " + formaNo);
                return true;
            }
            else
            {
                Console.WriteLine("Daglara Taslara Kactı!!!!");
                return false;
            }
        }

        public Futbolcu(string ad, int no)// futbolcu Kurucu metodu oluşturulur ve Özelliklerine random değerler atanır.
        {
            adSoyad = ad;
            formaNo = no;
            hiz = rastgele.Next(50, 101);
            dayaniklilik = rastgele.Next(50, 101);
            pas = rastgele.Next(50, 101);
            sut = rastgele.Next(50, 101);
            yetenek = rastgele.Next(50, 101);
            kararlilik = rastgele.Next(50, 101);
            dogalForm = rastgele.Next(50, 101);
            sans = rastgele.Next(50, 101);
        }

    }

    class Forvet : Futbolcu//burada Forvet tanımladım Futboldan kalıtım aldı ve Futbolcuya özel özellikleri private olarak tanımladım.
    {
        Random rastgele = new Random();
        private double Bitiricilik;
        private double IlkDokunus;
        private double Kafa;
        private double OzelYetenek;
        private double Sogukkanlilik;

        public virtual bool PasVer() //burada Forvet sınfının Pas ver metodunu tanımladm Pas Şansı Forvete özel olarak hesplarınır.
        {
            PasSansi = pas * 0.3 + yetenek * 0.2 + OzelYetenek * 0.2 + dayaniklilik * 0.1 + dogalForm * 0.1 + sans * 0.1;

            if (PasSansi > 60)
            {
                Console.WriteLine("Rastgele olarak " + formaNo + " nolu oyuncuya  pas atıldı.");
                return true;
            }
            else
            {
                Console.WriteLine("Pas basarisiz");
                return false;
            }
        }
        public virtual bool GolVur() //burada Forvet sınfının Gol Vur metodunu tanımladm Gol Şansı Forvete özel olarak hesplarınır.
        {
            GolSansi = yetenek * 0.2 + OzelYetenek * 0.2 + sut * 0.1 + Kafa * 0.1 + IlkDokunus * 0.1 + Bitiricilik * 0.1 + Sogukkanlilik * 0.1 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.1;
            if (GolSansi > 70)
            {
                Console.WriteLine("GOLLLL " + adSoyad + " " + formaNo);
                return true;
            }
            else
            {
                Console.WriteLine("Daglara Taslara Kactı!!!!");
                return false;
            }
        }

        public Forvet(string ad, int no) : base(ad, no)// forvete özgü özelleklere random değerler atanır.
        {
            adSoyad = ad;
            formaNo = no;
            hiz = rastgele.Next(50, 101);
            dayaniklilik = rastgele.Next(50, 101);
            pas = rastgele.Next(50, 101);
            sut = rastgele.Next(50, 101);
            yetenek = rastgele.Next(50, 101);
            kararlilik = rastgele.Next(50, 101);
            dogalForm = rastgele.Next(50, 101);
            sans = rastgele.Next(50, 101);
            Bitiricilik = rastgele.Next(70, 101);
            IlkDokunus = rastgele.Next(70, 101);
            Kafa = rastgele.Next(70, 101);
            OzelYetenek = rastgele.Next(70, 101);
            Sogukkanlilik = rastgele.Next(70, 101);
        }
    }
    class OrtaSaha : Futbolcu// burada futbolcudan kalıtım alan Orata saha sınıfı oluşturdum ve kendine özgü özellikleri tanımladım.
    {
        private double uzunTop;
        private double ilkDokunus;
        private double uretkenlik;
        private double topSurme;
        private double ozelYetenek;
        Random rastgele = new Random();
        public virtual bool PasVer() //burada OrataSsha sınfının Pas ver metodunu tanımladm Pas Şansı OrataSahaya özel olarak hesplarınır.
        {
            PasSansi = pas * 0.3 + yetenek * 0.2 + ozelYetenek * 0.2 + dayaniklilik * 0.1 + dogalForm * 0.1 + uzunTop * 0.1 + topSurme * 0.1 + sans * 0.1;

            if (PasSansi > 60)
            {
                Console.WriteLine("Rastgele olarak " + formaNo + " nolu oyuncuya pas atıldı.");
                return true;
            }
            else
            {
                Console.WriteLine("Pas basarisiz");
                return false;
            }

        }
        public virtual bool GolVur() //burada OrtaSaha  sınfının Gol Vur  metodunu tanımladm Gol Şansı OrtaSahaya  özel olarak hesplarınır.
        {
            GolSansi = yetenek * 0.3 + ozelYetenek * 0.2 + sut * 0.2 + ilkDokunus * 0.1 + kararlilik * 0.1 + dogalForm * 0.1 + sans * 0.1;
            if (GolSansi > 70)
            {
                Console.WriteLine("GOLLLL " + adSoyad + " " + formaNo);
                return true;
            }
            else
            {
                Console.WriteLine("Daglara Taslara Kactı!!!!");
                return false;
            }
        }

        public OrtaSaha(string ad, int no) : base(ad, no)//OrtaSaha sınıfının kurucu metodu kuruldu ve kendi  özelliklerine Göre random değeler atandı.
        {
            adSoyad = ad;
            formaNo = no;
            hiz = rastgele.Next(50, 101);
            dayaniklilik = rastgele.Next(50, 101);
            pas = rastgele.Next(50, 101);
            sut = rastgele.Next(50, 101);
            yetenek = rastgele.Next(50, 101);
            kararlilik = rastgele.Next(50, 101);
            dogalForm = rastgele.Next(50, 101);
            sans = rastgele.Next(50, 101);
            uzunTop = rastgele.Next(60, 101);
            ilkDokunus = rastgele.Next(60, 101);
            uretkenlik = rastgele.Next(60, 101);
            topSurme = rastgele.Next(60, 101);
            ozelYetenek = rastgele.Next(60, 101);
        }
    }
    class Defans : Futbolcu//Futbolcudan kalıtım alan Defans sınıfı oluturdum ve kendi has özelliklerini tanımladım.
    {
        private double pozisyonAlma;
        private double kafa;
        private double sicrama;
        Random rastgele = new Random();
        public virtual bool PasVer()//burada Defans sınfının Pas ver metodunu tanımladm Pas Şansı Defansa özel olarak hesplarınır.
        {
            PasSansi = pas * 0.3 + yetenek * 0.3 + dayaniklilik * 0.1 + dogalForm * 0.1 + pozisyonAlma * 0.1 + sans * 0.2;
            if (PasSansi > 60)
            {
                Console.WriteLine("Rastgele olarak " + formaNo + " nolu oyuncuya pas atıldı.");
                return true;
            }
            else
            {
                Console.WriteLine("Pas basarisiz");
                return false;
            }

        }
        public virtual bool GolVur()//burada Defans sınfının Gol Vur metodunu tanımladm Gol Şansı Defansa özel olarak hesplarınır.
        {
            GolSansi = yetenek * 0.3 + sut * 0.2 + kararlilik * 0.1 + dogalForm * 0.1 + kafa * 0.1 + sicrama * 0.1 + sans * 0.1;
            if (GolSansi > 70)
            {
                Console.WriteLine("GOLLLL " + adSoyad + " " + formaNo);
                return true;
            }
            else
            {
                Console.WriteLine("Daglara Taslara Kactı!!!!");
                return false;
            }
        }

        public Defans(string ad, int no) : base(ad, no)//Defansın kurucu metodunu tanımladım ve kendi özelliklerine random değerler atandı.
        {
            adSoyad = ad;
            formaNo = no;
            hiz = rastgele.Next(50, 101);
            dayaniklilik = rastgele.Next(50, 101);
            pas = rastgele.Next(50, 101);
            sut = rastgele.Next(50, 101);
            yetenek = rastgele.Next(50, 101);
            kararlilik = rastgele.Next(50, 101);
            dogalForm = rastgele.Next(50, 101);
            sans = rastgele.Next(50, 101);
            pozisyonAlma = rastgele.Next(50, 91);
            kafa = rastgele.Next(50, 91);
            sicrama = rastgele.Next(50, 91);


        }
    }
    class Program
    {
        public static List<Futbolcu> takim = new List<Futbolcu>();//takım listesi oluturuldu.
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            //takım üyeleri oluşturuldu 4 defans ,4 ortasaha,2 forvet ,1 futbolcu oluşturuldu.
            takim.Add(new Futbolcu("Ahmet Cakir", 1));
            takim.Add(new Defans("Ido Cakir", 2));
            takim.Add(new Defans("Polat Alemdar ", 3));
            takim.Add(new Defans("Husnu Coban ", 4));
            takim.Add(new Defans("Ahmet Hayri Kelik", 5));
            takim.Add(new OrtaSaha("Ahsafmet Cankıran", 6));
            takim.Add(new OrtaSaha("Halil Keklik", 7));
            takim.Add(new OrtaSaha("Emma Watson", 8));
            takim.Add(new OrtaSaha("Rihhanna Ayla", 9));
            takim.Add(new Forvet("ALi Hasan Taha  Cal", 10));
            takim.Add(new Forvet("Ketün Ahmet", 11));

            int FormaNo = rastgele.Next(1, 11);
            Console.WriteLine("Rastgele olarak " + takim[FormaNo].formaNo + " Nolu oyuncu secildi.");//İlk Oyuncu rastgele seçildi.


            Boolean gololabilir = true;
            //For Döngüsü 3 kere döndürülerek 3 kere pas vermeyi saladık
            for (int i = 1; i <= 3; i++)
            {
                //tanımladığım kontrol pas atan oyuncu kendne pas atmasın diye kontrol edilmesi için Tanımlandı 
                int Kontrol = FormaNo;
                FormaNo = rastgele.Next(1, 11);
                //while döngüsü oyuncu kendine pas atamasını engellmek için var 
                while (Kontrol == FormaNo)
                {
                    FormaNo = rastgele.Next(1, 11);
                }
                //bu if bloğu pas ver baarısız olursa Gol atma ihtimalini iptal etmek için var.
                if (!takim[FormaNo].PasVer())
                {
                    gololabilir = false;
                    break;
                }
            }

            if (gololabilir)//Buda 3 kere Pas atıldığı takdirde GolVur Metodunu çağırmak için.
            {

                takim[FormaNo].GolVur();
            }
            Console.ReadKey();

        }
    }
}
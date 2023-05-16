using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230407_1_GenelAlistirma
{
    public static class Menu
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();

        public static void Islemler(ConsoleKey key) // 2
        {
            switch (key) // 2
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Ekle("Öğrenci Ekle");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Listele("Öğrencileri Listele");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Sil("Öğrenci Sil");
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Ortalama("Öğrencilerin Genel Not Ortalaması");
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    YasOrtalamasi("Öğrencilerin Yaş Ortalaması");
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    BaslikYazdir("Toplan Öğrenci Sayısı");
                    AnaMenuyeDon(string.Format("Listede Toplam {0} Öğrenci Vardır", ogrenciler.Count));
                    break;
            }
        }

        private static void YasOrtalamasi(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Count > 0)
            {
                int toplamYas = 0;
                foreach (var ogrenci in ogrenciler)
                {
                    toplamYas += ogrenci.Yas;
                }
                double yasOrtalamasi = (double)toplamYas / ogrenciler.Count;
                AnaMenuyeDon(string.Format("Toplam {0} adet öğrencinin yaş ortalaması {1}", ogrenciler.Count, Math.Round(yasOrtalamasi,2)));
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunmamaktadır.");
            }
        }

        private static void Ortalama(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Count > 0)
            {
                double genelToplam = 0;
                foreach (var ogrenci in ogrenciler)
                {
                    genelToplam += ogrenci.Ortalama;
                }
                double genelOrtalama = genelToplam / ogrenciler.Count;
                AnaMenuyeDon(string.Format("Toplam {0} adet öğrencinin genel not ortalaması {1}", ogrenciler.Count, Math.Round(genelOrtalama, 2)));
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunmamaktadır");
            }
        }

        private static void Sil(string v)
        {
            BaslikYazdir(v);
            if (ogrenciler.Count > 0)
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                Console.WriteLine();
                int siraNo = Metodlar.GetInt("Silmek istediğiniz öğrencinin sıra numarasını giriniz.\nİşlemi iptal etmek için 0'a basınız: ", 0, ogrenciler.Count);
                if (siraNo == 0)
                {
                    AnaMenuyeDon("Silme işlemi iptal edildi");
                }
                else
                {
                    int indexNo = siraNo - 1;
                    Console.Write(ogrenciler[indexNo].TamAd + " öğrencisini silmek istediğinize emin misiniz?(e) ");
                    if (Console.ReadKey().Key == ConsoleKey.E)
                    {
                        string silinen = ogrenciler[indexNo].TamAd;
                        ogrenciler.RemoveAt(indexNo);
                        AnaMenuyeDon(string.Format("{0} öğrencisi başarı ile silindi", silinen));
                    }
                    else
                    {
                        AnaMenuyeDon("Silme işlemi iptal edildi");
                    }
                }
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunmamaktadır");
            }
        }

        private static void Listele(string v) // Öğrencileri Listele
        {
            BaslikYazdir(v); // Öğrencileri Listele
            if (ogrenciler.Count > 0)
            {
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    ogrenciler[i].Yazdir(i + 1);
                }
                AnaMenuyeDon(string.Format("Toplam {0} adet öğrenci listelenmiştir", ogrenciler.Count));
            }
            else
            {
                AnaMenuyeDon("Listede öğrenci bulunmamaktadır");
            }
        }

        private static void Ekle(string v)
        {
            BaslikYazdir(v); // Öğrenci Ekle
            Ogrenci o = new Ogrenci();
            o.Ad = Metodlar.GetString("Adı Giriniz: ", 2, 20);
            o.Soyad = Metodlar.GetString("Soyadı Giriniz: ", 2, 15);
            o.N1 = Metodlar.GetDouble("1. Not: ", 0,100);
            o.N2 = Metodlar.GetDouble("2. Not: ", 0, 100);
            o.DogumTarihi = Metodlar.GetDateTime("Doğum Tarihi: ", 1983, 2011);
            ogrenciler.Add(o);
            AnaMenuyeDon(string.Format("{0} öğrencisi listeye başarı ile eklendi", o.TamAd));
        }

        private static void AnaMenuyeDon(string v)
        {
            Console.WriteLine();
            Console.WriteLine(v);
            Console.WriteLine("Ana Menüye Dönmek İçin Bir Tuşa Basınız");
            Console.ReadKey();
        }

        private static void BaslikYazdir(string v)
        {
            Console.Clear();
            Console.WriteLine(v);
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }
    }
}

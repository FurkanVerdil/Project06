﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230407_1_GenelAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÖĞRENCİ KAYIT PROGRAMI
            // ----------------------
            // 1- Öğrenci Ekle (Ad, Soyad, DogumTarihi, N1, N2)
            // 2- Öğrencileri Listele
            // 3- Öğrenci Sil
            // 4- Öğrencilerin Genel Not Ortalaması
            // 5- Öğrencilerin Genel Yaş Ortalaması
            // 6- Toplam Öğrenci Sayısı
            // 0- Çıkış

            // string, DateTime, double, int

            ConsoleKey cevap;
            do
            {
                Console.Clear();
                Console.WriteLine("ÖĞRENCİ KAYIT PROGRAMI");
                Console.WriteLine("----------------------");
                Console.WriteLine("1- Öğrenci Ekle");
                Console.WriteLine("2- Öğrencileri Listele");
                Console.WriteLine("3- Öğrenci Sil");
                Console.WriteLine("4- Öğrencilerin Genel Not Ortalaması");
                Console.WriteLine("5- Öğrencilerin Genel Yaş Ortalaması");
                Console.WriteLine("6- Toplam Öğrenci Sayısı");
                Console.WriteLine("0- Çıkış");

                Console.WriteLine();
                Console.Write("Hangi işlemi yapmak istersiniz? ");
                cevap = Console.ReadKey().Key;
                Menu.Islemler(cevap);
            } while (cevap != ConsoleKey.D0 && cevap != ConsoleKey.NumPad0);

            Console.Clear();
            Console.WriteLine("Programı kullandığınız için teşekkür ederiz");
            Console.WriteLine("Programı kapatmak için bir tuşa basınız");

            Console.ReadKey(); 
        }
    }
}

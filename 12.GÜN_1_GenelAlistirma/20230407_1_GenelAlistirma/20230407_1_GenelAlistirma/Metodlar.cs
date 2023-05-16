using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _20230407_1_GenelAlistirma
{
    public static class Metodlar
    {

        public static string GetString(string metin, int min = 1, int max = 500) // "Adı Giriniz: ", 2, 20
        {
            string txt = string.Empty;
            bool hata = false;
            do
            {
                Console.Write(metin); // "Adı Giriniz: "
                txt = Console.ReadLine();
                if (string.IsNullOrEmpty(txt))
                {
                    Console.WriteLine("Boş bir değer giremezsiniz");
                    hata = true;
                }
                else
                {
                    if (txt.Length < min ||txt.Length > max)
                    {
                        Console.WriteLine("Lütfen min. {0} max. {1} karakter uzunluğunda metin giriniz.", min,max);
                        hata = true;
                    }
                    else
                    {
                        int sayac = 0;
                        foreach (var item in txt)
                        {
                            try
                            {
                                Convert.ToInt32(Char.ToString(item));
                                sayac++;
                            }
                            catch
                            {
                            }
                        }
                        if (sayac > 0)
                        {
                            Console.WriteLine("Lütfen sayısal değer kullanımayınız...");
                            hata = true; // Hakan
                        }
                        else
                        {
                            hata = false;
                        }
                    }
                }
            } while (hata);
            return txt; // Hakan
        }

        //-------------------------------------------------------------

        public static int GetInt (string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min. {0}, max. {1} arasında bir değer giriniz", min,max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return sayi;
        }

        //-------------------------------------------------------------

        public static double GetDouble(string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi = 0;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen min. {0}, max. {1} arasında bir değer giriniz", min, max);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return sayi;
        }

        //-------------------------------------------------------------

        public static DateTime GetDateTime(string metin, int minYear, int maxYear)
        {
            DateTime date = DateTime.Now;
            bool hata = false;
            do
            {
                Console.Write(metin);
                try
                {
                    date = DateTime.Parse(Console.ReadLine());
                    if (date.Year <= maxYear && date.Year >= minYear)
                    {
                        hata = false;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen {0} ile {1} yılları arasında bir tarih giriniz", minYear, maxYear);
                        hata = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hata = true;
                }
            } while (hata);
            return date;
        }
        
    }
}

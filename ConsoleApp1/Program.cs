using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//örnek Ales,KPSS,KPDS puan uygulaması
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ales, uds, kpds, i, sn;
            Console.Write("ALES NOTUNUZU  GİRİNİZ");
            ales = Convert.ToInt32(Console.ReadLine());
            if ((ales >= 60) && (ales <= 100))
            {
                while (true)
                {
                    Console.WriteLine("BÖLÜM KODUNUZU GİRİNİZ>>>");

                    Console.Write("İNGİLİZCE İCİN  1  TÜRKCE İÇİN 0 GİRİNİZ");
                    i = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        Console.Write("ÜDS NOTUNUZU GİRİNİZ>>>");
                        uds = Convert.ToInt32(Console.ReadLine());
                        Console.Write("KPDS NOTUNUZU GİRİNİZ>>");
                        kpds = Convert.ToInt32(Console.ReadLine());
                        if ((uds >= 60) && (kpds >= 60))
                        {
                            Console.Write("LÜTFEN ÜNİVERSİTEMİZİN SINAVINDAN ALDIGINIZ NOTU GİRİNİZ>");
                            sn = Convert.ToInt32(Console.ReadLine());
                            if ((sn >= 60) && (sn <= 100))
                            {
                                Console.Write("TEBRİKLER ÜNİVERSİTEMİZDE YÜKSEK LİSANS YAPABİLİRSİNİZ  ");
                                Console.Read();
                                break;
                            }
                            else
                            {
                                Console.Write("BASVURUNUZ RED EDİLMİSTİR");
                                Console.Read();
                                break;
                            }
                        }
                        else
                        {
                            Console.Write("UDS VEYA KPDS NOTUNUZ YÜZÜNDEN OLMADI");
                            Console.Read();
                            break;
                        }
                    }
                    else if (i == 0)
                    {

                        Console.Write("ÜDS NOTUNUZU GİRİNİZ>>>");
                        uds = Convert.ToInt32(Console.ReadLine());
                        Console.Write("KPDS NOTUNUZU GİRİNİZ>>");
                        kpds = Convert.ToInt32(Console.ReadLine());
                        if ((uds >= 30) && (kpds >= 30))
                        {
                            Console.Write("LÜTFEN ÜNİVERSİTEMİZİN SINAVINDAN ALDIGINIZ NOTU GİRİNİZ>");
                            sn = Convert.ToInt32(Console.ReadLine());
                            if ((sn >= 60) && (sn <= 100))
                            {
                                Console.Write("TEBRİKLER ÜNİVERSİTEMİZDE YÜKSEK LİSANS YAPABİLİRSİNİZ ");
                                Console.Read();
                                break;
                            }
                            else
                            {
                                Console.Write("BASVURUNUZ RED EDİLMİSTİR");
                                Console.Read();
                                break;
                            }
                        }
                        else
                        {
                            Console.Write("UDS VEYA KPDS NOTUNUZ YÜZÜNDEN OLMADI");
                            Console.Read();
                            break;
                        }

                    }

                    else
                    {
                        Console.Write("LÜTFEN OKUL KODUNUZU DOGRU GİRİNİZ");

                    }
                }
            }
            else
            {
                Console.Write("ALES PUANINIZ YÜZÜDEN YÜKSEK LİSANS YAPAMAZSINIZ");
                Console.Read();
            }
        }
    }

}

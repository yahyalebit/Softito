using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon
{
    internal class Program
    {
        static void Main()
        {
            string[] masalar = { "boş", "boş", "boş", "boş", "boş", "boş", "boş" };

            string[,] menu = {
                 { "Adana Kebap", "Pirzola","Çay", "Kahve", "Sıcak Çikolata","Pizza", "Pizza2","Su", "Soda"  },
                 { "300", "500","50","100","150","100","200","20","40" },

            };
            int[][] anlikSiparisler = new int[7][];
            int[][] tumSiparisler = new int[7][];
            int[] aktifSiparis = new int[0];

            for (int i = 0; i < tumSiparisler.Length; i++)
            {
                tumSiparisler[i] = new int[0];
                anlikSiparisler[i] = new int[0];

            }

            while (true)
            {
                x:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n\t ANA MENÜ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Masa Aç        [1]");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Masa İşlem     [2]");
                Console.WriteLine("Masa Hesap     [3]");
                Console.WriteLine("Kasa İşlemleri [4]");
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("ÇIKIŞ YAP      [0]");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();
                Console.ResetColor();

                if (secim == "1")
                {
                    y:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("----------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t MASA AÇ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("----------------------------------");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (int i = 0; i < masalar.Length; i++)
                    {
                        Console.WriteLine($" {i + 1}. Masa \t [{masalar[i]}]");
                    }
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("----------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(" ANA MENÜ [ESC]");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("----------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Masa açmak için masa ID giriniz: ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        Console.Clear(); 
                        continue; 
                    }

                    string giris = keyInfo.KeyChar.ToString();
                    int masaId;
                    try
                    {
                        masaId = Convert.ToInt32(giris);
                        if (masaId > 0 && masaId <= 7 && masalar[masaId - 1] == "boş")
                        {
                            masalar[masaId - 1] = "dolu";
                            Console.WriteLine($"{giris}. Masa açıldı!");
                            goto y;
                        }
                        else
                        {
                            
                            Console.WriteLine("\nGeçersiz seçim veya masa zaten dolu!");
                            Console.ReadLine();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nGeçersiz giriş! Lütfen bir sayı giriniz.");
                        Console.ReadLine();
                    }
                }
                else if (secim == "2")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (int i = 0; i < masalar.Length; i++)
                    {
                        if (masalar[i] == "dolu")
                        {
                            Console.WriteLine($" {i + 1}. Masa \t [{masalar[i]}]");
                        }
                        
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Sipariş eklemek için masa ID giriniz: ");
                    string giris = Console.ReadLine();
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("-------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\t    MASA AÇ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("-------------------------------------------");
                    int masaId;
                    try
                    {
                        masaId = Convert.ToInt32(giris);
                        if (masaId > 0 && masaId <= 7 && masalar[masaId - 1] == "dolu")
                        {
                            masaId--;
                            z:
                            Console.WriteLine("\t     MENÜ");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(" YEMEKLER    \t\tİÇECEKLER");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine(" ET YEMEKLERİ    \tSICAK İÇECEKLER");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(" Adana Kebap  [1]    \tÇay            [3]");
                            Console.WriteLine(" Pirzola      [2]    \tKahve          [4]");
                            Console.WriteLine("    \t\t\tSıcak Çikolata [5]");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine(" PİZZALAR    \t\tSOĞUK İÇECEKLER");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(" Karışık P    [6]    \tSu             [8]");
                            Console.WriteLine(" Margarita P  [7]   \tSoda           [9]");

                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("-------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"\t   {masaId+1}. MASA - SİPARİŞLERİ");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("-------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("ONAYLA [SPACE]");
                            Console.WriteLine("ANA MENÜ [ESC]");
                            Console.WriteLine("GERİ GİT [BACKSPACE]");
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("-------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            for (int i = 0; i < aktifSiparis.Length; i++)
                            {
                                int urunIndex = aktifSiparis[i];
                                Console.WriteLine($"{i + 1}. {menu[0, urunIndex]} - {menu[1, urunIndex]} TL");
                            }
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("Ürünleri giriniz: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            while (true)
                            {
                                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                                if (char.IsDigit(inputKey.KeyChar))
                                {
                                    int rakam = (int)char.GetNumericValue(inputKey.KeyChar);
                                    Console.WriteLine($"{aktifSiparis.Length + 1}.{menu[0, rakam - 1]} - {menu[1, rakam - 1]} TL");

                                    Array.Resize(ref aktifSiparis, aktifSiparis.Length + 1);
                                    aktifSiparis[aktifSiparis.Length - 1] = rakam - 1;

                                   

                                }
                                else if (inputKey.Key == ConsoleKey.Backspace)
                                {
                                    Array.Resize(ref aktifSiparis, aktifSiparis.Length - 1);
                                    
                                    Console.Clear();
                                    goto z;

                                }
                                else if (inputKey.KeyChar == ' ')
                                {
                                    foreach(int siparis in aktifSiparis)
                                    {
                                        Array.Resize(ref anlikSiparisler[masaId], anlikSiparisler[masaId].Length + 1);
                                        anlikSiparisler[masaId][anlikSiparisler[masaId].Length - 1] = siparis;

                                        Array.Resize(ref tumSiparisler[masaId], tumSiparisler[masaId].Length + 1);
                                        tumSiparisler[masaId][tumSiparisler[masaId].Length - 1] = siparis;
                                    }
                                    aktifSiparis = new int[0];
                                    goto x;
                                }
                                else if (inputKey.Key == ConsoleKey.Escape)
                                {
                                    anlikSiparisler[masaId] = new int[0];
                                    goto x;

                                }

                            }

                        }
                        else
                        {
                            Console.WriteLine("\nGeçersiz seçim veya masa boş!");
                            Console.ReadLine();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nGeçersiz giriş! Lütfen bir sayı giriniz.");
                        Console.ReadLine();
                    }
                }
                else if (secim == "3")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.Write("Hesap almak için masa ID giriniz: ");
                    string giris = Console.ReadLine();
                    int masaId;
                    try
                    {
                        masaId = Convert.ToInt32(giris);
                        int totalPrice = 0;

                        if (masaId > 0 && masaId <= 7 && masalar[masaId - 1] == "dolu")
                        {
                            masaId--;
                            Console.WriteLine($"Masa {masaId + 1} Siparişleri:");
                            foreach (var urunIndex in anlikSiparisler[masaId])
                            {
                                Console.WriteLine($"{menu[0, urunIndex]} - {menu[1, urunIndex]} TL");
                                totalPrice += Convert.ToInt32(menu[1, urunIndex]);
                            }
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine($"TOPLAM : {totalPrice} TL");
                            masalar[masaId] = "boş";
                            Console.WriteLine("Hesap ödendi, masa boşaltıldı!");
                            anlikSiparisler[masaId] = new int[0];
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("\nGeçersiz seçim veya masa zaten boş!");
                            Console.ReadLine();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nGeçersiz giriş! Lütfen bir sayı giriniz.");
                        Console.ReadLine();
                    }
                }
                else if (secim == "4")
                {
                    Console.Clear();
                    try
                    {
                        int[] totalPrices = new int[7];
                        int totalPrice = 0;
                        for (int i = 0; i < 7; i++)
                        {
                            foreach (var urunIndex in tumSiparisler[i])
                            {
                                totalPrice += Convert.ToInt32(menu[1, urunIndex]); ;
                            }
                            totalPrices[i] = totalPrice;
                            totalPrice = 0;
                        }
                        Console.WriteLine("MASA TOPLAMLARI");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine($"MASA {i + 1} : {totalPrices[i]} TL");
                            Console.WriteLine("-----------------------------------------------");
                        }
                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("\nGeçersiz giriş! Lütfen bir sayı giriniz.");
                        Console.ReadLine();
                    }
                }
                else if (secim == "0")
                {
                    break;
                }
            }
        }
    }
}

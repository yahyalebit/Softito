using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region çift tek
            //int sayi;
            //int cifttoplam = 0;
            //int tektoplam = 0;

            //Console.WriteLine("Lütfen bir sayı girin:");
            //sayi = Convert.ToInt32(Console.ReadLine());

            //int i = 0;
            //while (i <= sayi)
            //{
            //    cifttoplam += i;
            //    Console.Write(i + " ");
            //    i += 2;
            //}

            //Console.WriteLine("\nÇift Sayıların toplamı: " + cifttoplam);

            //int j = 1;
            //while (j <= sayi)
            //{
            //    tektoplam += j;
            //    Console.Write(j + " ");
            //    j += 2;
            //}

            //Console.WriteLine("\nTek Sayıların toplamı: " + tektoplam);

            //----------------------------------------------------------------

            //Console.WriteLine("Bir sayı girin: ");
            //int sayi = int.Parse(Console.ReadLine());

            //int ciftToplam = 0;
            //int tekToplam = 0;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    ciftToplam += (i % 2 == 0) ? i : 0;
            //    tekToplam += (i % 2 != 0) ? i : 0;
            //}

            //Console.WriteLine($"Çift sayılar toplamı: {ciftToplam}");
            //Console.WriteLine($"Tek sayılar toplamı: {tekToplam}");
            //Console.ReadLine();

            #endregion

            #region sayı kadar
            int sayi;

            Console.WriteLine("Lütfen bir sayı girin:");
            sayi = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= sayi)
            {
                int j = sayi;
                while (j >= i)
                {
                    Console.Write(i);
                    j--;
                }
                i++;
            }

            Console.ReadLine();
            #endregion

            #region * dan piramit

            int body = int.Parse(Console.ReadLine());
            int satir = (body * 2) - 1;

            int i = 1;
            while (i <= satir)
            {
                Console.WriteLine();
                int bosluk = (satir - i) / 2;
                int j = 0;
                while (j < bosluk)
                {
                    Console.Write(" ");
                    j++;
                }
                j = 0;
                while (j < i)
                {
                    Console.Write("*");
                    j++;
                }
                i += 2;
            }

            #endregion

            #region * dan ok

            int body = int.Parse(Console.ReadLine());
            int satir = (body * 2) - 1;

            int i = 1;
            while (i <= satir)
            {
                Console.WriteLine();
                int bosluk = (satir - i) / 2;
                int j = 0;
                while (j < bosluk)
                {
                    Console.Write(" ");
                    j++;
                }
                j = 0;
                while (j < i)
                {
                    Console.Write("*");
                    j++;
                }
                i += 2;
            }
            i = 0;
            while (i < ((satir - 1) / 2))
            {
                Console.WriteLine();
                int j = 0;
                while (j < ((satir - 3) / 2))
                {
                    Console.Write(" ");
                    j++;
                }
                int m = 0;
                while (m < 3)
                {
                    Console.Write("*");
                    m++;
                }
                i++;
            }
            #endregion

            #region elmas *

            int bosluk;
            int yildiz;
            Console.WriteLine("Orta satırdaki * sayısını girin (tek sayı)");

            x:
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.Write("Lütfen tek sayı girin:  ");
                goto x;
            }
            else
            {
                int i = 1;
                while (i <= n)
                {
                    bosluk = (n - i) / 2;
                    yildiz = i;

                    int j = 0;
                    while (j < bosluk)
                    {
                        Console.Write(" ");
                        j++;
                    }

                    j = 0;
                    while (j < yildiz)
                    {
                        Console.Write("*");
                        j++;
                    }

                    Console.WriteLine();
                    i += 2;
                }

                i = n - 2;
                while (i >= 1)
                {
                    bosluk = (n - i) / 2;
                    yildiz = i;

                    int j = 0;
                    while (j < bosluk)
                    {
                        Console.Write(" ");
                        j++;
                    }

                    j = 0;
                    while (j < yildiz)
                    {
                        Console.Write("*");
                        j++;
                    }

                    Console.WriteLine();
                    i -= 2;
                }
            }

            #endregion

            #region Fibonacci

            int a = 1;
            int b = 1;
            Console.Write("Gösterilecek Fibonacci Adım Sayısını Girin: ");
            int sayi = int.Parse(Console.ReadLine());

            int i = 0;
            while (i < sayi)
            {
                Console.Write(a + " ");
                int adim = a + b;
                a = b;
                b = adim;
                i++;
            }

            #endregion

            #region asal sayılar

            Console.Write("Sayı Gir: ");
            int num = int.Parse(Console.ReadLine());

            int i = 2;
            while (i <= num)
            {
                bool isPrime = true;
                int y = 2;

                while (y < i)
                {
                    if (i % y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    y++;
                }

                if (isPrime)
                {
                    Console.Write($"{i} ");
                }

                i++;
            }

            #endregion

            #region 1000 sayısının bölenleri

            int i = 1;
            while (i <= 1000)
            {
                if (1000 % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            #endregion

            #region  3 kere giriş hakkı  para çekme, para gönderme, bakiye kontrol, çıkış,

            int bakiye = 10000;
            string sifre = "1234";
            string girilen;
            int hak = 3;

            while (hak > 0)
            {
                Console.WriteLine("Şifrenizi Girin: ");
                girilen = Console.ReadLine();

                if (girilen == sifre)
                {
                    Console.Clear();
                    Console.WriteLine("Giriş başarılı!");
                    break;
                }
                else
                {
                    hak--;
                    Console.Clear();
                    Console.WriteLine("Hatalı kullanıcı adı veya şifre. Kalan giriş hakkı: " + hak);
                    if (hak == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Giriş hakkınız bitti. Programdan çıkılıyor.");
                        return;
                    }
                }
            }

            bool cikisYapildi = false;

            while (!cikisYapildi)
            {
                Console.WriteLine("1. Para Çekme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Bakiye Kontrol");
                Console.WriteLine("4. Çıkış");
                Console.Write("Yapmak istediğiniz işlemi seçin: ");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Çekmek istediğiniz tutarı girin: ");
                        int cekilecektutar = int.Parse(Console.ReadLine());

                        if (cekilecektutar <= bakiye)
                        {
                            bakiye -= cekilecektutar;
                            Console.WriteLine($"Başarıyla {cekilecektutar} TL çekildi. Güncel bakiye: {bakiye} TL");
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz bakiye.");
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Yatırmak istediğiniz tutarı girin: ");
                        int yatiralacaktutar = int.Parse(Console.ReadLine());

                        if (yatiralacaktutar <= bakiye)
                        {
                            bakiye += yatiralacaktutar;
                            Console.WriteLine($"Başarıyla {yatiralacaktutar} TL gönderildi. Güncel bakiye: {bakiye} TL");
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz bakiye.");
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Güncel bakiyeniz: {bakiye} TL");
                        break;

                    case "4":
                        Console.Clear();
                        cikisYapildi = true;
                        Console.WriteLine("Çıkış yapılıyor. Hoşçakalın!");
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                        break;
                }
            }

            #endregion

            #region 4 ve katı olan sayılar gelene kadar topla

            Console.WriteLine("sayi giriniz");
            int sayi = 1;
            int toplam = 0;
            int i = 0;
            while (sayi % 4 != 0)
            {
                i++;
                Console.Write(i + " . sayı : ");
                sayi = int.Parse(Console.ReadLine());
                toplam += sayi;

            }
            Console.WriteLine("Toplam : " + toplam);

            #endregion

            #region 10*10 tablo

            int i = 1;
            int j;
            while (i <= 10)
            {
                j = 1;
                while (j <= 10)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                    ++j;
                }
                ++i;
                if (i == 11)
                {
                    break;
                }
                Console.WriteLine("------------------");
            }

            #endregion

            #region 10 a kadar olan sayıları yazdır 8 olmasın

            int i = 1;
            while (i <= 10)
            {
                if (i == 8)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }

            #endregion
        }
    }
}

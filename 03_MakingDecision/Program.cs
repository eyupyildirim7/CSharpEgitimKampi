using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lutfen 4 haneli sifrenizi giriniz: ");

            //string password;

            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifreniz Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifrenizi Yanlis Girdiniz , Lutfen Tekrar giriniz.");
            //}


            //string capital, country;
            //Console.Write("Baskentinizi giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ulkenizi giriniz: ");

            //country = Console.ReadLine();
            //if (capital=="ankara" & country =="turkey")
            //{
            //    Console.WriteLine("Basarili bir sekilde giris yaptiniz ");
            //}
            //else
            //{
            //    Console.WriteLine("Hatali Giris yaptiniz.");
            //}


            //int exam1, exam2, exam3, average;

            //Console.Write("Birinci Sinav Notunuzu Giriniz.");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Ikinci Sinav Notunuzu Giriniz.");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("Ucuncu Sinav Notunuzu Giriniz.");
            //exam3 =int.Parse(Console.ReadLine());

            //average=(exam1+exam2+exam3)/3;

            //if (average>0 & average <= 50)
            //{
            //    Console.WriteLine("Sinav ortalama notunuz: "+average+"Harf karsligi:FF");
            //}
            //if (average > 51 & average <= 70)
            //{
            //    Console.WriteLine("Sinav ortalama notunuz: " + average + "Harf karsligi:CC");
            //}
            //if (average > 71 & average <= 80)
            //{
            //    Console.WriteLine("Sinav ortalama notunuz: " + average + "Harf karsligi:BB");
            //}
            //if (average > 81 & average <= 100)
            //{
            //    Console.WriteLine("Sinav ortalama notunuz: " + average + " Harf karsligi: AA");
            //}


            //string city;
            //Console.Write("Lutfen Ikamet ettiginiz sehrinizi giriniz.    ");
            //city= Console.ReadLine();

            //if (city == "ankara" | city == "Istanbul" | city == "izmir")
            //{
            //    Console.WriteLine("Buyuk Sehirlerde Ikemat etmektesiniz.  ");
            //}
            //else
            //{
            //    Console.WriteLine("3 buyuk sehir disinda ikemat etmektesiniz.  ");
            //}






            #endregion


            #region
            //Console.WriteLine("*****C# Egitim Kampi Restorant");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1-Ana Yemekler ");
            //Console.WriteLine("2-Çorbalar ");
            //Console.WriteLine("3-Pizzalar ");
            //Console.WriteLine("4-Icecekler ");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("-----------------------------------");


            //int menu;
            //Console.Write("Detayini Gormek istediginiz Menu secimini yapiniz...");
            //menu= int.Parse(Console.ReadLine());
            //if (menu == 1) {
            //    Console.WriteLine();
            //    Console.WriteLine("------- ANA YEMEKLER -------");
            //    Console.WriteLine("1-Lahmacun");
            //    Console.WriteLine("2-Adana kebab");
            //    Console.WriteLine("3-Kusleme kebab");
            //    Console.WriteLine("4-Patlican kebab");

            //}
            //if (menu == 2)
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("------- CORBALAR -------");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Beyran");
            //    Console.WriteLine("3-Yayla corbasi");
            //    Console.WriteLine("4-Paca corbasi");

            //}
            //if (menu == 3)
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("------- PIZZALAR -------");
            //    Console.WriteLine("1-Karisik pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Napolyon pizza");

            //}
            //if (menu == 4)
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("------- ICECEKLER -------");
            //    Console.WriteLine("1-AYRAN");
            //    Console.WriteLine("2-KOLA");
            //    Console.WriteLine("3-SALGAM");
            //    Console.WriteLine("4-SU");

            //}
            //if (menu == 5)
            //{
            //    Console.WriteLine();

            //    Console.WriteLine("------- TATLILAR -------");
            //    Console.WriteLine("1-Kazan dibi");
            //    Console.WriteLine("2-Sutlac");
            //    Console.WriteLine("3-Baklava");
            //    Console.WriteLine("4-Prefetorol");
            //    int menu2;
            //    Console.Write("Hangi tatliyi istersiniz");
            //    menu2=int.Parse(Console.ReadLine());


            //    if (menu2 == 1)
            //    {
            //        Console.WriteLine();
            //        Console.Write("Siparisiniz Hazirlaniyor...");
            //        Console.WriteLine("1-Kazan dibi");
            //    }
            //    if (menu2 == 2)
            //    {
            //        Console.WriteLine();
            //        Console.Write("Siparisiniz Hazirlaniyor...");
            //        Console.WriteLine("2-Sutlac");
            //    }

            //    if (menu2 == 3)
            //    {
            //        Console.WriteLine();
            //        Console.Write("Siparisiniz Hazirlaniyor...");
            //        Console.WriteLine("3-Baklava");


            //    }

            //    if (menu2 == 4)
            //    {
            //        Console.WriteLine();
            //        Console.Write("Siparisiniz Hazirlaniyor...");
            //        Console.WriteLine("4-Prefetorol");
            //    }



            //}




            #endregion

            #region

            int sayi1, sayi2, result;
            char symbol;

            Console.Write("Birinci sayiyi giriniz: ");
            sayi1 =int.Parse(Console.ReadLine());

            Console.Write("Ikinci sayiyi giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Birinci sayiyi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol) {
                case '+':
                result = sayi1+sayi2;
                    Console.WriteLine("Toplam: " + result);
                  break;
                case '-':
                    result = sayi1 - sayi2;
                    Console.WriteLine("Cikarma: " + result);
                    break;
                case '/':
                    result = sayi1 / sayi2;
                    Console.WriteLine("Bolum: " + result);
                    break;
                case '*':
                    result = sayi1 * sayi2;
                    Console.WriteLine("Carpim: " + result);
                    break;
                    default:
                    Console.WriteLine("Hatali giris yaptiniz.");
                    break;


            }



            #endregion

            Console.Read();
        }
    }
}

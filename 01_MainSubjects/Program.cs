using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdirma komutlari
            //Console.Write("Merhaba, Dunya ");
            //Console.WriteLine("Hello , World!");
            //;
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Corbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soguk Baslangiclar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("6-Icecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion


            #region String  Degiskenler
            //string
            //degisken_turu degisken_adi;

            //string name;
            //name = "Eyup Yildirim";
            //Console.WriteLine(name);


            //string customersName;
            //string customersSurname;
            //string customersPhone;
            //string customersEmail, district, city;


            //customersName = "Salih";
            //customersSurname = "Kisa";
            //customersPhone = "111111111";
            //customersEmail = "salih@mail.com";
            //district = "Sehitkamil";
            //city = "Gaziantep";

            //Console.WriteLine("**** Rezarvasyon Karti ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Musteri: " + customersName + " " + customersSurname);
            //Console.WriteLine("iletisim " +customersPhone);
            //Console.WriteLine("Email " +customersEmail);
            //Console.WriteLine("Adres " + district+" / " +city);
            //Console.WriteLine("---------------------------------------------------");


            //customersName = "Aysegul";
            //customersSurname = "Kaya";
            //customersPhone = ("123456789");
            //customersEmail = ("aysekaya@mail.com");
            //district = ("Sapanca");
            //city = ("Sakarya");


            //Console.WriteLine("Musteri: " + customersName + " " + customersSurname);
            //Console.WriteLine("iletisim " + customersPhone);
            //Console.WriteLine("Email " + customersEmail);
            //Console.WriteLine("Adres " + district + " / " + city);
            //Console.WriteLine("---------------------------------------------------");


            #endregion


            #region Int Degiskenler

            //int
            //int number = 24;
            //Console.WriteLine(number);


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine("***** Restoran Menu Fiyati *****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyati:" + hamburgerPrice+" Tl ");
            Console.WriteLine("----Kola Fiyati:" + cokePrice + " Tl ");
            Console.WriteLine("----Su Fiyati:" + waterPrice + " Tl ");
            Console.WriteLine("----Atistirmaliklar Fiyati:" + friesPrice + " Tl ");
            Console.WriteLine("----Pizza Fiyati:" + pizzaPrice + " Tl ");
            Console.WriteLine("----Limonata Fiyati:" + lemonadePrice + " Tl ");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;  
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalhamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;    
            int totalPizzaPrice = 0;
            int totallemonadePrice = 0;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;



            totalhamburgerPrice = hamburgerCount * hamburgerPrice ;
            totalCokePrice = cokeCount * cokePrice ;
            totalWaterPrice= waterCount * waterPrice ;
            totallemonadePrice = lemonadeCount * lemonadePrice ;
            totalFriesPrice= friesPrice*friesCount ;
            totalPizzaPrice= pizzaPrice*pizzaCount ;



            Console.WriteLine("----------------------");
            Console.WriteLine("Hamburger Tutari:" + totalhamburgerPrice+" TL ");
            Console.WriteLine("Pizza Tutari: " + totalPizzaPrice+" TL "); 
            Console.WriteLine("Kizartma Tutari: " + totalFriesPrice+" TL "); 
            Console.WriteLine("Kola Tutari: " + totalCokePrice+" TL "); 
            Console.WriteLine("Limonata Tutari: " + totallemonadePrice+" TL "); 
            Console.WriteLine("Su Tutari: " + totalWaterPrice+" TL ");

            Console.WriteLine();
            int totalPrice =totalCokePrice+totalFriesPrice+totalWaterPrice+totallemonadePrice+totalhamburgerPrice+totalPizzaPrice;
            Console.WriteLine("Toplam Odenecek tutar: "+totalPrice+" Tl");

            #endregion

            Console.Read();
        }
    }
}

//Yazdirma Komutlari

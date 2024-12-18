using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double appelPrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //appelPrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma  Birim Fiyati:" + appelPrice+" Tl");
            //Console.WriteLine("---- Portakal  Birim Fiyati:" + orangePrice + " Tl");
            //Console.WriteLine("---- Cilek  Birim Fiyati:" + strawberryPrice + " Tl");
            //Console.WriteLine("---- Patetes  Birim Fiyati:" + potatoPrice + " Tl");
            //Console.WriteLine("---- Domates  Birim Fiyati:" + tomatoPrice + " Tl");
            //Console.WriteLine();

            //double appelGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appelGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appelTotalPrice = appelPrice * appelGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alinan Urun: Elma : " +" Birim Fiyat:" + appelPrice + " -Gramaj:" + appelGram + " - Toplam Tutar:"+ appelTotalPrice);
            //Console.WriteLine("Alinan Urun: Portakal : " +" Birim Fiyat:" + orangePrice + " -Gramaj:" + orangeGram + " - Toplam Tutar:"+ orangeTotalPrice);
            //Console.WriteLine("Alinan Urun: Cilek : " +" Birim Fiyat:" + strawberryPrice + " -Gramaj:" + strawberryGram + " - Toplam Tutar:"+ strawberryTotalPrice);
            //Console.WriteLine("Alinan Urun: Patates : " +" Birim Fiyat:" + potatoPrice + " -Gramaj:" + potatoGram + " - Toplam Tutar:"+ potatoTotalPrice);
            //Console.WriteLine("Alinan Urun: Domates : " +" Birim Fiyat:" + tomatoPrice + " -Gramaj:" + tomatoGram + " - Toplam Tutar:"+ tomatoTotalPrice);

            //double shoppingTotalPrice=appelTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alisveris Toplam Tutar:"+ shoppingTotalPrice+" TL");



            #endregion

            #region Char Degiskenler

            //ABCDEFGH
            //DEF....
            //Toplanti saat 20:00'de 
            //char tek tirnak ile tanimlanir
            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region klavyeden veri girisleri String Degiskenler

            //Console.WriteLine("***** Csharp Hava Yollari Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adi: ");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadi ");
            //passengerSurname =Console.ReadLine();

            //Console.Write("Ilce Bilgisi:");
            //passengerDistrict =Console.ReadLine();
            //Console.Write("Sehir Bilgisi");
            //passengerCity =Console.ReadLine();
            //Console.Write("Yolcu Yasi:");
            //passengerAge =Console.ReadLine();
            //Console.Write("Yolcu Kimlik Numarasi:");
            //passengerIdentityNumber =Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Yolcu Adi : " + passengerName+" "+passengerSurname +"Yolcu Il ve Ilce bilgisi"+passengerCity+passengerDistrict+"Yolcu Yasi:"+passengerAge+"Yolcu Kimlik Numarasi:"+passengerIdentityNumber);


            #endregion

            #region Klavyeden Tam sayi Girisleri ve Donusumler

            ////ABC12D
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount , computerCount , chairCount , tvCount ;

            //Console.Write("Lutfen aldiginiz ayakkabi sayisini giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz Bilgisayar sayisini giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz Sandalye sayisini giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz Televizyon sayisini giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount*shoesPrice+computerCount*computerPrice+chairCount*tvPrice+tvPrice;
            //Console.WriteLine("Alisveris Toplan tutariniz: "+totalPrice);

            #endregion

            #region klavyeden Ondalikli Sayi Islemleri

            //double exam1, exam2, exam3,examResult;

            //Console.Write("Lutfen Birinci Sinav Notunuzu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lutfen Ikinci Sinav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lutfen Ucuncu Sinav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //examResult = (exam1+exam2+exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sinav Ortalamaniz: "+examResult);


            #endregion

            #region Klavyeden karekter Girisleri

            //char gender;
            //Console.Write("Lutfen Cinsiyetinizi Seciniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Sectiginiz Cinsiyet: "+gender);


            #endregion

            Console.Read(); 
        }
    }
}

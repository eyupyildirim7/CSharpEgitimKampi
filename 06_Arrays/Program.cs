using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Ornekleri 
            //2.4.6.8
            //sari,kirmizi,mavi,turuncu,beyaz

            //degisken turu [] diziAdi = new Degiskenturu[eleman sayisi]

            //string[] colars = new string[4];
            //colars[0] = "kirmizi";
            //colars[1] = "beyaz";
            //colars[2] = "sari";
            //colars[3] = "lajivert";

            //Console.WriteLine(colars[2]);

            //string[] cites = new string[5];
            //cites[0] = "istanbul";
            //cites[1] = "ankara";
            //cites[2] = "izmir";
            //cites[3] = "antalya";
            //cites[4] = "Gaziantep";


            //Console.WriteLine(cites[4]);


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;


            //Console.WriteLine(numbers[5]);

            //string[] cities = { "istanbul", "kahramanmaras", "Sanliurfa", "izmir", "antalya" };
            //Console.WriteLine(cities[3]);



            #endregion

            #region Dizideki Tum Elemanlari Kullanma
            //string[] colors = { "Sari", "Kirmizi", "Beyaz", "Mavi", "Yesil", "Turuncu", "Pembe" };

            //for (int i=0; i<colors.Length; i++) { Console.WriteLine(colors[i]); }



            //int[] numbers = { 4, 85, 96,75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++){
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] sembols = { 'a','b','c','*','/','-'};
            //for (int i = 0; i < sembols.Length; i++)
            //{
            //    Console.WriteLine(sembols[i]);
            //}



            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber=myArray[0];


            //for (int i = 0; i < myArray.Length; i++) { 

            //if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];

            //    }

            //}
            //Console.WriteLine(maxNumber);




            #endregion

            #region Dizi Metotlari

            //int[] numbers= { 122, 223, 1233, 14, 345, 56, 87, 68, 09, 10, 911, 6712, 313, 214, 315 };

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) {  Console.WriteLine(numbers[i]); }

            //string[] customers = { "ali", "merve", "ayse", "salih", "kemal" };
            //int index = Array.IndexOf(customers, "salih");
            //Console.WriteLine(index);

            //int[] numbers = { 122, 223, 1233, 14, 345, 56, 87, 68, 09, 10, 911, 6712, 313, 214, 315 };
            //Console.WriteLine("Dizinin En buyuk elemani: "+numbers.Max()+" Dizinin en kucuk elemani: "+numbers.Min());






            #endregion

            #region Kullanicidan Deger Alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++) {
            //    Console.Write($"Lutfen{i + 1}. Gezmek istediginiz sehiri yaziniz: ");
            //    cities[i] =Console.ReadLine();
            //}
            //Console.WriteLine("Yarismaya Katilan Arkadasimiz Buralari gezmek Istiyormus.");

            //for (int i = 0; i < cities.Length; i++) {
            //    Console.WriteLine( cities[i]);
            //}


            #endregion

            //Console.Read();




        }
    }
}

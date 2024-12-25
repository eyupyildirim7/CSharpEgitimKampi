using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Doreach  Dongusu
            //foreach(1;2;3;4)

            //1:Degisken turu
            //2:Degisken adi
            //3:In
            //4:Liste,Koleksiyon ,Dizi


            //string[] cities = { "roma", "milano", "new york ", "budapeste", "istanbul" };

            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            #endregion


            #region Ornek Sinav Sistemi Uygulamasi
            Console.WriteLine("***** C# Egitim Kampi Sinav Uygulamasi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Siniftaki Ogrenci sayisini kullanicidan alma
            Console.WriteLine("---------------------------------");
            Console.Write("Sinifinizda Kac Ogrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            // Ogrenci isimlerini ve not ortalamalarini saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Ogrencinin ismini giriniz ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her ogrenci icin 3 sinav notu girisi

                for (int j = 0; j < 3; j++) {
                    Console.Write($"{studentNames[i]} isimli ogrencinin {j + 1}. sinav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //notlari topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sinav ortalamalari

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adli ogrenicin ortalamasi: {studentExamAvg[i]}");

                // ogrencilerin ortalamasi ve gecip kalma durumlari 
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adli ogrenci dersi gecti.");

                }else
                {
                    Console.WriteLine($"{studentNames[i]} adli ogrenci dersten kaldi.");

                }
                Console.WriteLine("---------------------------------");





                #endregion
                Console.Read();









            }
        }
    }
}

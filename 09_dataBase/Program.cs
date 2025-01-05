using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_dataBase
{
    internal class Program
    {
        static void Main(string[] args)
        { // Ado .net

            Console.WriteLine("***** C# Veri Tabanli Urun-Kategori Bilgi Sistemi ***** ");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;
           

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Urunler");
            Console.WriteLine("3-Siparisler");
            Console.WriteLine("4-Cikis Yap");
            Console.Write("Lutfen Getirmek Istediginiz tablo numarasini giriniz:  ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EPMBJ8I\\SQLEXPRESS;initial " +
                "Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable= new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow  row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kategori Ekleme Islemi
            ////Crud --> Create- Read- Update-Delete

            //Console.WriteLine("***** Menu Siparis Islem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------");
            //Console.Write("Eklemek istediginiz Kategori Adi: ");
            //string categoryName=Console.ReadLine();



            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-EPMBJ8I\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);

            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.Write("Kategori Basariyla Eklendi...");
            #endregion

            #region Urun Ekleme Islemi
            //Console.WriteLine("***** Menu Siparis Islem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------");
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Urun adi: ");
            //productName =Console.ReadLine();
            //Console.Write("Urun fiyati: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-EPMBJ8I\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus)values(@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Urun eklemesi Basarili...");
            #endregion

            #region Urun Listeleme islemi

            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-EPMBJ8I\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) {
            //    foreach (var item in row.ItemArray) {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}


            //connection.Close();

            #endregion

            #region Urun Silme Islemi
            //Console.Write("Silmek istediginiz urun id sini giriniz. ");
            //int productId=int.Parse(Console.ReadLine());




            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-EPMBJ8I\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");



            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme Islemi Yapildi ...");

            #endregion

            #region Urun Guncelleme islemi

            //Console.Write("Guncellenecek Urun id:");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Guncellenecek Urun Adi:");
            //string productName =Console.ReadLine();

            //Console.Write("Guncellenecek Urun Adi:");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            
            //SqlConnection connection = new SqlConnection("Data source=DESKTOP-EPMBJ8I\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
           
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);

            //command.Parameters.AddWithValue("productName", productName);
            //command.Parameters.AddWithValue("productPrice", productPrice);
            //command.Parameters.AddWithValue("productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();
            //Console.WriteLine("Guncelleme Basarili..");

            #endregion



            //Console.Read();


        }


    }
}

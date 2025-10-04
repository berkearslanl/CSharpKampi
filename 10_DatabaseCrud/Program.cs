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

            //crud --> create-read-update-delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();

            Console.WriteLine("------------------------");

            #region kategori ekleme işlemi
            //Console.Write("Eklemek İstediğiniz Kategoriyi Giriniz : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5Q1ARH5E;initial catalog=EgitimKampiDB;integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values(@p1)",connection);//ekleme komutu
            //command.Parameters.AddWithValue("@p1", categoryName);//parametreyi kullanıcıdan alınan değere eşleştirdik
            //command.ExecuteNonQuery();//koşulsuz bir şekilde sorguyu çalıştır. istisna olmadan.
            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region ürün, fiyat ve durum ekleme

            //string productName;
            //decimal productPrice;
            //bool productStatus;//bool : true-false döndürür

            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5Q1ARH5E; initial catalog = EgitimKampiDB; integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values(@p1,@p2,@p3)",connection);
            //command.Parameters.AddWithValue("@p1",productName);
            //command.Parameters.AddWithValue("@p2",productPrice);
            //command.Parameters.AddWithValue("@p3",true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı!");
            #endregion

            #region ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5Q1ARH5E; initial catalog = EgitimKampiDB; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);//verileri çekmek için köprü görevi görüyor
            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //foreach (DataRow row in table.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region ürün silme işlemi

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //Console.Write("Silinecek ürün ID giriniz : ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5Q1ARH5E; initial catalog = EgitimKampiDB; integrated security = true");
            //connection.Open();

            //SqlCommand delete = new SqlCommand("Delete from TblProduct where ProductId=@pId",connection);
            //delete.Parameters.AddWithValue("@pID", productID);
            //delete.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi başarılı!");

            #endregion

            #region ürün güncelleme işlemi

            Console.Write("Güncellenecek ürün id : ");
            int productID = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek ürün adı : ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek ürün fiyat : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5Q1ARH5E; initial catalog = EgitimKampiDB; integrated security = true");
            connection.Open();
            SqlCommand guncelle = new SqlCommand("update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productID", connection);
            //şart koymazsak tüm verileri günceller. where ile productID şartı koyduk.

            guncelle.Parameters.AddWithValue("@productName", productName);
            guncelle.Parameters.AddWithValue("@productPrice", productPrice);
            guncelle.Parameters.AddWithValue("@productId", productID);
            guncelle.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme Başarılı!");
            #endregion
            Console.Read();
        }
    }
}

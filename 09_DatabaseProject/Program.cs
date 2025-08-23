using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Product-Category Bilgi Sistemi");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış");

            Console.WriteLine("");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            string tableNo = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            SqlConnection connection = new SqlConnection("Data Source=EXCALIBURAY\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine("Kategori Id: {0} - Kategori Adı: {1}", row["CategoryId"], row["CategoryName"]);
            }

            connection.CreateCommand();

            Console.Read();
        }
    }
}

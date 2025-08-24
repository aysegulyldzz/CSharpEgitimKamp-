using System;
using System.Data;
using System.Data.SqlClient;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crud --> Create Read Update Delete

            Console.WriteLine("***** C# Veri Tabanlı Menü Sipariş İşem Paneli *****");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");

            #region CategoryName Ekleme

            Console.WriteLine("");
            Console.Write("Eklemek istediğiniz kategori adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=EXCALIBURAY\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCategory values(@categoryName)", connection);
            command.Parameters.AddWithValue("@categoryName", categoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Kategori ekleme işlemi başarılı.");

            #endregion

            #region CategoryName Güncelleme

            Console.WriteLine("");
            Console.Write("Güncellemek istediğiniz kategori id'si: ");
            int categoryId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yeni kategori adı: ");
            string newCategoryName = Console.ReadLine();

            connection.Open();
            SqlCommand updateCommand = new SqlCommand("update TblCategory set CategoryName=@newCategoryName where CategoryId=@categoryId", connection);
            updateCommand.Parameters.AddWithValue("@newCategoryName", newCategoryName);
            updateCommand.Parameters.AddWithValue("@categoryId", categoryId);
            updateCommand.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Kategori güncelleme işlemi başarılı.");

            #endregion

            #region CategoryName Silme

            Console.WriteLine("");
            Console.Write("Silmek istediğiniz kategori id'si: ");
            int deleteCategoryId = Convert.ToInt32(Console.ReadLine());

            connection.Open();
            SqlCommand deleteCommand = new SqlCommand("delete from TblCategory where CategoryId=@deleteCategoryId", connection);
            deleteCommand.Parameters.AddWithValue("@deleteCategoryId", deleteCategoryId);
            deleteCommand.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Kategori silme işlemi başarılı.");

            #endregion

            #region Product Ekleme

            Console.WriteLine("");
            Console.Write("Eklemek istediğiniz ürün adı: ");
            string productName = Console.ReadLine();
            Console.Write("Ürün fiyatı: ");
            decimal productPrice = Convert.ToDecimal(Console.ReadLine());
            bool productState = true;

            connection.Open();
            SqlCommand productCommand = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductState) values(@productName, @productPrice, @productState)", connection);
            productCommand.Parameters.AddWithValue("@productName", productName);
            productCommand.Parameters.AddWithValue("@productPrice", productPrice);
            productCommand.Parameters.AddWithValue("@productState", productState);
            productCommand.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün ekleme işlemi başarılı.");

            #endregion

            #region Product Listeleme

            Console.WriteLine("");
            Console.WriteLine("Product table listesindeki veriler:");

            connection.Open();

            SqlCommand listcommand = new SqlCommand("select * from TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(listcommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            connection.Close();

            Console.WriteLine("Product listeleme işlemi başarılı.");

            #endregion

            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    internal class Program
    {
        private static object adapter;

        static void Main(string[] args)
        {
            Console.WriteLine("DataBase Kodlari");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1 - HAREKET");
            Console.WriteLine("2 - KATEGORI");
            Console.Write("Getirmek Istediginiz tablo numarasini giriniz : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=ALICAN\\SQLEXPRESS;initial Catalog=SatisVT;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TBLHAREKET",connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
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

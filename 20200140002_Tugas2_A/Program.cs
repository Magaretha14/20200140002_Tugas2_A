using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140002_Tugas2_A
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-N3UNMQ7P;database=Puput;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Pemilik (NIK_Pemilik char(7) not null primary key, Nama_Pemilik varchar(50) not null, No_Hp char(12), Alamat varchar(50))"
                    + "create table Penyewa (NIK_Penyewa char(7) not null primary key, Nama_Penyewa varchar(50) not null, No_Hp char(12), Alamat varchar(50))"
                    + "create table Transaksi (Id_Transaksi char(5) not null primary key, NIK_Pemilik char(7) FOREIGN KEY REFERENCES Pemilik(NIK_Pemilik), NIK_Penyewa char(7) FOREIGN KEY REFERENCES Penyewa(NIK_Penyewa), Waktu varchar(20), TempoKontrak varchar(50), Alamat_Toko varchar(50), Harga varchar(50))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }catch (Exception e)
            {
                Console.WriteLine("Sepertinya Tabelmu gagal :("+e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-N3UNMQ7P;database=Puput;Integrated Security = TRUE");
                con.Open();
            }
        static void Main(string[] args)
        {
            new Program().CreateTable();

        }
    }
}

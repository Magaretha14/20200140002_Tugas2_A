using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _20200140002_Tugas2_A
{
    class Program
    {
        public SqlDataReader dataread;

        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-N3UNMQ7P;database=Puput;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Pemilik (NIK_Pemilik char(7) not null primary key, Nama_Pemilik varchar(50) not null, No_Hp char(12), Alamat varchar(50))"
                    + "create table Penyewa (NIK_Penyewa char(7) not null primary key, Nama_Penyewa varchar(50) not null, No_Hp char(12), Alamat varchar(50))"
                    + "create table Toko (Id_Toko varchar(4) not null primary key, Nama_Toko varchar(50) not null, Alamat varchar(50))"
                    + "create table Transaksi (Id_Transaksi char(5) not null primary key, Id_Toko varchar(4) FOREIGN KEY REFERENCES Toko(Id_Toko), NIK_Pemilik char(7) FOREIGN KEY REFERENCES Pemilik(NIK_Pemilik), NIK_Penyewa char(7) FOREIGN KEY REFERENCES Penyewa(NIK_Penyewa), Waktu varchar(20), TempoKontrak varchar(50), Alamat_Toko varchar(50), Harga varchar(50))", con);
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

                SqlCommand cm = new SqlCommand("insert into Pemilik (NIK_Pemilik, Nama_Pemilik, No_Hp, Alamat) values ('6285781','Suharti','082255068191','Jakarta')"
                    + "insert into Pemilik (NIK_Pemilik, Nama_Pemilik, No_Hp, Alamat) values ('6285782','Sukamto','082255068192','Bekasi')"
                    + "insert into Pemilik (NIK_Pemilik, Nama_Pemilik, No_Hp, Alamat) values ('6285783','Sujandono','082255068193','Yogyakarta')"
                    + "insert into Pemilik (NIK_Pemilik, Nama_Pemilik, No_Hp, Alamat) values ('6285784','Maria','082255068194','Kalimantan')"
                    + "insert into Pemilik (NIK_Pemilik, Nama_Pemilik, No_Hp, Alamat) values ('6285785','Birbida','082255068195','Tangerang')"
                    + "insert into Penyewa (NIK_Penyewa, Nama_Penyewa, No_Hp, Alamat) values ('6265931','Reyna','082255065821','Tangsel')"
                    + "insert into Penyewa (NIK_Penyewa, Nama_Penyewa, No_Hp, Alamat) values ('6265932','Valen','082255065822','Bogor')"
                    + "insert into Penyewa (NIK_Penyewa, Nama_Penyewa, No_Hp, Alamat) values ('6265933','Didu','082255065823','Medan')"
                    + "insert into Penyewa (NIK_Penyewa, Nama_Penyewa, No_Hp, Alamat) values ('6265934','Didan','082255065824','Batam')"
                    + "insert into Penyewa (NIK_Penyewa, Nama_Penyewa, No_Hp, Alamat) values ('6265935','Puput','082255065825','Kalteng')"
                    + "insert into Toko (Id_Toko, Nama_Toko, Alamat) values ('T1BA','Toko Sari','Toko 1 Blok A')"
                    + "insert into Toko (Id_Toko, Nama_Toko, Alamat) values ('T2BB','Toko Pini','Toko 2 Blok B')"
                    + "insert into Toko (Id_Toko, Nama_Toko, Alamat) values ('T3BC','Toko Kili','Toko 3 Blok C')"
                    + "insert into Toko (Id_Toko, Nama_Toko, Alamat) values ('T4BD','Toko Lako','Toko 4 Blok D')"
                    + "insert into Toko (Id_Toko, Nama_Toko, Alamat) values ('T5BE','Toko Labo','Toko 5 Blok E')"
                    + "insert into Transaksi (Id_Transaksi, Id_Toko, NIK_Pemilik, NIK_Penyewa, Waktu, TempoKontrak, Alamat_Toko, Harga) values ('20541','T1BA','6285781','6265931','04 April 2022','6 Bulan','Toko 1 Blok A','Rp 12.000.000,00')"
                    + "insert into Transaksi (Id_Transaksi, Id_Toko, NIK_Pemilik, NIK_Penyewa, Waktu, TempoKontrak, Alamat_Toko, Harga) values ('20542','T2BB','6285782','6265932','05 Maret 2022','1 Tahun','Toko 2 Blok B',' Rp 60.000.000,00 ')"
                    + "insert into Transaksi (Id_Transaksi, Id_Toko, NIK_Pemilik, NIK_Penyewa, Waktu, TempoKontrak, Alamat_Toko, Harga) values ('20543','T3BC','6285783','6265933','06 Mei 2022','9 Bulan','Toko 3 Blok C','Rp 45.000.000,00 ')"
                    + "insert into Transaksi (Id_Transaksi, Id_Toko, NIK_Pemilik, NIK_Penyewa, Waktu, TempoKontrak, Alamat_Toko, Harga) values ('20544','T4BD','6285784','6265934','14 Juni 2022','3 Tahun','Toko 4 Blok D','Rp 180.000.000,00 ')"
                    + "insert into Transaksi (Id_Transaksi, Id_Toko, NIK_Pemilik, NIK_Penyewa, Waktu, TempoKontrak, Alamat_Toko, Harga) values ('20545','T5BE','6285785','6265935','07 Juli 2022','7 Bulan','Toko 5 Blok E',' Rp 35.000.000,00 ')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        static void Main(string[] args)
        {
            new Program().CreateTable();
            new Program().InsertData();

        }
    }
}

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

            }
            
        }
        static void Main(string[] args)
        {
        }
    }
}

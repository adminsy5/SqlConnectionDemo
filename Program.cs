//Programm of connect SqlSever Datbase to Ado.net
using System.Data;
using System.Data.SqlClient;
using System.Threading.Channels;

namespace SqlConnectiondemo
{
    class Demo
    {
        public static void Main(String[] args)
        {
           ConnectionDemo();
            Console.ReadLine();
        }

       static void ConnectionDemo()
        {
            String ConnectionString = "Data Source=MPIYUSH3510-AMD;Initial Catalog=vbdb23;Integrated Security=true";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //try
            //{
            //    conn.Open();

            //    if (conn.State == ConnectionState.Open)
            //    {
            //        Console.WriteLine("Connected successfully!");
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if(conn.State==ConnectionState.Open)
            //    {
            //        conn.Close();
            //            Console.WriteLine("Connection Closed !");
            //    }
            //}
            SqlConnection connection;
            using (connection = new SqlConnection(ConnectionString))//to autoclosed connection
            {
                connection.Open();
            }
            if(connection.State== ConnectionState.Closed)
            {
                Console.WriteLine("Connection closed default");
            }
        }
    }
}
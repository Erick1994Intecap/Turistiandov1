using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Servicios.DB
{
    public class ConnectionManager
    {
        private readonly SqlConnection conn = new SqlConnection();
        public SqlConnection GetConnection()
        {
            try
            {
                conn.ConnectionString = @"Server=35.193.52.85;Database=Turistiando;user=sqlserver;password=R3st@I12022*";
                conn.Open();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return conn;
        }
    }
}

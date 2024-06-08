using System;
using System.Data;
using System.Data.SqlClient;
using RentalManagement.Utils;

namespace RentalManagement.DAO
{
    public class ContractDAO
    {
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        public DataTable getAll()
        {
            try
            {
                cmd = new SqlCommand(DBCommands.CONTRACT_QUERY_GET_ALL, DBConnect.GetConnection());
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (SqlException)
            {
                throw new Exception("Error when reading data from database.");
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (reader != null)
                {
                    reader.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }
    }
}

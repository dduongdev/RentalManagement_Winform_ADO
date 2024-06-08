using System;
using System.Data;
using System.Data.SqlClient;
using RentalManagement.Utils;
using RentalManagement.Entities;

namespace RentalManagement.DAO
{
    public class HomeDAO
    {
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;

        public DataTable getAll()
        {
            try
            {
                cmd = new SqlCommand(DBCommands.HOME_QUERY_GET_ALL, DBConnect.GetConnection());
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
                if(cmd != null)
                {
                    cmd.Dispose();
                }

                if(reader != null)
                {
                    reader.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }

        public bool saveHome(Home home)
        {
            try
            {
                cmd = new SqlCommand(DBCommands.HOME_QUERY_SAVE, DBConnect.GetConnection());
                cmd.Parameters.AddWithValue("@pr1", home.HomeId);
                cmd.Parameters.AddWithValue("@pr2", home.HomeOwnerName);
                cmd.Parameters.AddWithValue("@pr3", home.RentalPrice);
                cmd.Parameters.AddWithValue("@pr4", home.IsRenting);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch(SqlException)
            {
                throw new Exception("Error while saving to database.");
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }

        public bool isExist(string homeId)
        {
            try
            {
                cmd = new SqlCommand(DBCommands.HOME_QUERY_CHECK_EXIST, DBConnect.GetConnection());
                cmd.Parameters.AddWithValue("@pr1", homeId);

                return (bool)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(cmd != null)
                {
                    cmd.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }

        public bool updateHome(Home home)
        {
            try
            {
                cmd = new SqlCommand(DBCommands.HOME_QUERY_UPDATE, DBConnect.GetConnection());
                cmd.Parameters.AddWithValue("@pr1", home.HomeId);
                cmd.Parameters.AddWithValue("@pr2", home.HomeOwnerName);
                cmd.Parameters.AddWithValue("@pr3", home.RentalPrice);
                cmd.Parameters.AddWithValue("@pr4", home.IsRenting);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (SqlException)
            {
                throw new Exception("Error while updating to database.");
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }

        public bool deleteHome(string homeId)
        {
            try
            {
                cmd = new SqlCommand(DBCommands.HOME_QUERY_DELETE, DBConnect.GetConnection());
                cmd.Parameters.AddWithValue("@pr1", homeId);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                return false;
            }
            catch (SqlException)
            {
                throw new Exception("Error while deleting from database.");
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                DBConnect.CloseConnection();
            }
        }
    }
}

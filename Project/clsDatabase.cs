﻿using System.Data.SqlClient;

namespace Project
{
    internal class clsDatabase
    {
        public static SqlConnection con = new SqlConnection();

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server = TUONGVI\\SQLEXPRESS; database = project; Integrated Security = true");
                con.Open();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

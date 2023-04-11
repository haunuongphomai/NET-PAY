using System.Data.SqlClient;

namespace Project
{
    internal class clsDatabase
    {
        public static SqlConnection con = new SqlConnection();

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Data Source=TUFGAMING;Initial Catalog=project;Integrated Security=True");
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

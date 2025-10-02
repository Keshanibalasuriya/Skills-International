using System.Data.SqlClient;

namespace SkillTrack
{
    internal class Connection
    {
        private string connString = "Data Source=LAPTOP-VTLPEAPH;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }

        public bool TestConnection()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}

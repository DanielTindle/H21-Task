using System.Data;
using System.Data.SqlClient;

namespace H21Task.Models
{
    public class Person
    {
        public void SaveUser(string FullName, string DateOfBirth, string TelePhone, string Email)
        {
            string connectionString = "Data Source =DANIELSPC\\SQLEXPRESS; Initial Catalog =Task;Integrated Security = true";
            
            

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand sqlCommand = new SqlCommand("SaveUser", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@FullName", FullName));
            sqlCommand.Parameters.Add(new SqlParameter("@DateOfBirth", DateOfBirth));
            sqlCommand.Parameters.Add(new SqlParameter("@TelePhone", TelePhone));
            sqlCommand.Parameters.Add(new SqlParameter("@Email", Email));
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }
    }
}

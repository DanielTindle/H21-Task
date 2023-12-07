using H21Task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration.CommandLine;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace H21Task.Pages
{
    
    public class usersModel : PageModel
    {
       public List<UserInfo> UsersList = new List<UserInfo>();
       
        public void OnGet()
        {
            UserInfo users = new UserInfo();
            string connectionString = "Data Source =DANIELSPC\\SQLEXPRESS; Initial Catalog =Task;Integrated Security = true";

            string sqlQuery = "SELECT * FROM Person";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserInfo userInfo = new UserInfo();
                        userInfo.id = reader.GetInt32(0);
                        userInfo.FullName = reader.GetString(1);
                        userInfo.DateOfBirth = reader.GetDateTime(2).ToString("dd/MM/yyyy");
                        userInfo.Telephone = reader.GetString(3);
                        userInfo.Email = reader.GetString(4);

                        UsersList.Add(userInfo);

                    }
                }

            }
         

            sqlCommand.ExecuteNonQuery();
            con.Close();

            

     }
        // It's not quite working this is not something i have done before and struggeling just to get it to fill the rows. i have tried for hours now and just can't quite get it.
        public FileResult OnPostExport()
        {
            var builder = new StringBuilder();
            builder.AppendLine("id,FullName,DateOfBirth,Telephone,Email");
            foreach (UserInfo users in UsersList)
            {
                builder.AppendLine($"{users.id},{users.FullName},{users.DateOfBirth},{users.Telephone},{users.Email}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "users.csv");
        }


    }

    
   
    
    
}
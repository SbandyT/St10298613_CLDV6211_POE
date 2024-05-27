using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace KhumaloCraft.Models
{
    public class Users 
    {
        public static string con_string = "Server=tcp:st10298613.database.windows.net,1433;Initial Catalog=Khumalocraft-sql-server;Persist Security Info=False;User ID=Khano;Password=Forogo16!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static SqlConnection con = new SqlConnection(con_string);

       
        
            public int UserId { get; set; }
            public string? Username { get; set; }
            public string? Email { get; set; }
            public string? PasswordHash { get; set; }
            public string? Role { get; set; }
        


    }
}

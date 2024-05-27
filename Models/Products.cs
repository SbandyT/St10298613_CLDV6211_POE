using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace KhumaloCraft.Models
{
    public class Products 
    {
        public static string con_string = "Server=tcp:st10298613.database.windows.net,1433;Initial Catalog=Khumalocraft-sql-server;Persist Security Info=False;User ID=Khano;Password=Forogo16!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static SqlConnection con = new SqlConnection(con_string);

        public int ProductId { get; set; }
        public  string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
        public bool Availability { get; set; }
        public string? ImageUrl { get; set; }
    }
}

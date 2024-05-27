using Microsoft.AspNetCore.Mvc;
using static KhumaloCraft.Models.Users;
using static KhumaloCraft.Models.Products;
using System.Data.SqlClient;

namespace KhumaloCraft.Models
{
    public class Order  
    {
        public static string con_string = "Server=tcp:st10298613.database.windows.net,1433;Initial Catalog=Khumalocraft-sql-server;Persist Security Info=False;User ID=Khano;Password=Forogo16!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static SqlConnection con = new SqlConnection(con_string);

        public int OrderId { get; set; }
            public  string? UserId { get; set; }
            public int ProductId { get; set; }
            public int Quantity { get; set; }
            public DateTime OrderDate { get; set; }

            public  Users? User { get; set; }
            public  Products? Product { get; set; }

        
    }
}

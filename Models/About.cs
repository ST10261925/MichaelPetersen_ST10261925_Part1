using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace PoePart1.Models
{
    public class About : Controller
    {
        public static String con_String = "Server=tcp:cldv-p1-server.database.windows.net,1433;Initial Catalog=cldvp1-db;Persist Security Info=False;User ID=Michael;Password=Palkeegilded60;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"
        
        public static SqlConnection com = new SqlConnection(con_String);

        public IActionResult Index()
        {
            return View();
        }
    }
}

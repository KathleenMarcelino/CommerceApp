//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace CommerceApp.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        /** public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        **/

        public string name;
        public string email;

        public void OnGet()
        {
            string connectionString = "Data Source=LAPTOP-34KSHRJA;Initial Catalog=commerce;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sqlQuery = "select * from clientes where Id = 1";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader rd = cmd.ExecuteReader();

            if(rd.Read())
            {
                name = rd["Name"].ToString();
                email = rd["Email"].ToString();
            }

            con.Close();

        }
    }
}
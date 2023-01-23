

using Microsoft.Data.SqlClient;

namespace CommerceApp.Models
{
    public class Clientes
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List <Clientes> GetClientes()
        {
            string connectionString = "Data Source=LAPTOP-34KSHRJA;Initial Catalog=commerce;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
        }

        public void OnGet()
        {
           
            string sqlQuery = "select * from clientes where Id = 1";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader rd = cmd.ExecuteReader();

            <Clientes> clientesList = new List<Clientes>();

            while (rd.Read())
            {
                Clientes clientes= new Clientes();

                Clientes.name = dr["FName"].ToString();
                Clientes.email = dr["Email"].ToString();

                clientesList.Add(clientes);

            }

            con.Close();
            return clientesList;

        }
    }
}

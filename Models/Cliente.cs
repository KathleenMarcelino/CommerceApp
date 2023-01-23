

using Microsoft.Data.SqlClient;

namespace CommerceApp.Models
{
    public class Cliente
    {
		public int Id { get; set; }
		public string Name { get; set; }
        public string Email { get; set; }

        public List <Cliente> GetClientes()
        {
            string connectionString = "Data Source=LAPTOP-34KSHRJA;Initial Catalog=commerce;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

			string sqlQuery = "select * from clientes";
			SqlCommand cmd = new SqlCommand(sqlQuery, con);
			SqlDataReader dr = cmd.ExecuteReader();


			List<Cliente> clienteList = new List<Cliente>();

			Cliente cliente = null;
			while (dr.Read())
			{
				cliente = new Cliente();
				cliente.Id = Convert.ToInt32(dr["Id"]);
				cliente.Name = dr["Name"].ToString();
				cliente.Email = dr["Email"].ToString();

				clienteList.Add(cliente);

			}

			con.Close();
			return clienteList;
        }

        public void saveCliente(string name, string email)
		{
			string connectionString = "Data Source=LAPTOP-34KSHRJA;Initial Catalog=commerce;Integrated Security=True;TrustServerCertificate=True;";
			SqlConnection con = new SqlConnection(connectionString);
			con.Open();

			string sqlQuery = "INSERT INTO clientes (Name, Email) VALUES ('"+name+"', '"+email+"')";
			SqlCommand cmd = new SqlCommand(sqlQuery, con);
			int result = cmd.ExecuteNonQuery();
			con.Close();

		}

		public void deleteCliete(int id)
		{
			string connectionString = "Data Source=LAPTOP-34KSHRJA;Initial Catalog=commerce;Integrated Security=True;TrustServerCertificate=True;";
			SqlConnection con = new SqlConnection(connectionString);
			con.Open();

			string sqlQuery = "DELETE FROM clientes where id="+id;
			SqlCommand cmd = new SqlCommand(sqlQuery, con);
			int result = cmd.ExecuteNonQuery();
			con.Close();
		}
	}
}

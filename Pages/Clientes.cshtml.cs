using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using CommerceApp.Models;

namespace CommerceApp.Pages
{
    public class ClientesModel : PageModel
    {
        public List<Clientes> ClientesList = new List<Clientes>;
       
        public void OnGet()
        {
            Clientes clientes = new Clientes();

            ClientesList = clientes.GetClientes();


        }

        }
    }


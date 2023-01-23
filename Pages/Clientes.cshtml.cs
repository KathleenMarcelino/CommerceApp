using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using CommerceApp.Models;

namespace CommerceApp.Pages
{
    public class ClientesModel : PageModel
    {
        public List<Cliente> clienteList = new List<Cliente>();
       
        public void OnGet()
        {
            Cliente cliente = new Cliente();

            clienteList = cliente.GetClientes();


        }

    }
}


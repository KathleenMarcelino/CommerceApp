using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CommerceApp.Models;

namespace CommerceApp.Pages
{
    public class CadastroModel : PageModel
    {
        public void OnPost()
        {
            string nameCliente = Request.Form["name"];
            string emailCliente = Request.Form["email"];

            Cliente cliente= new Cliente();

            cliente.saveCliente(nameCliente, emailCliente);
            Response.Redirect("https://localhost:7146/Clientes");
            

		}
    }
}

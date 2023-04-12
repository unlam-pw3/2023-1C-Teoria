using Microsoft.AspNetCore.Mvc;
using AspNetMVCClase1.Models.Servicios;
using AspNetMVCClase1.Models.Entidades;

namespace AspNetMVCClase1.Controllers
{
    
    public class ClienteController : Controller
    {
        public ClienteServicio ServicioCliente { get; set; }

        public ClienteController()
        {
            ServicioCliente = new ClienteServicio();
        }

        public IActionResult Index()
        {
            List<Cliente> clientes = ServicioCliente.GetClientes(); 

            return View(clientes);
        }


        public IActionResult Mostrar(int id)
        {
            Cliente? cli = ServicioCliente.GetById(id);

            return View(cli);
        }


        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        /// <summary>
        /// Bindeo Manual
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        //[HttpPost]
        //public IActionResult Crear(FormCollection form)
        //{
        //    Cliente cli = new Cliente();
        //    cli.RazonSocial = form["RazonSocial"];
        //    cli.Id = int.Parse(form["Id"]);
        //    cli.Edad = int.Parse(form["Edad"]);

            
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult Crear(Cliente cliente)
        {

            ServicioCliente.SaveCliente(cliente);
            return RedirectToAction("Index");
        }




    }
}

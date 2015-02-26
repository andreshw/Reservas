
using Reservas.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reservas.Web.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        public ActionResult Index()
        {
            List<Cliente> clientes = ClienteRepositorio.ObtenerClientes();
            return View(clientes);
        }

        public ActionResult BuscarClientes(string nombre)
        {
            List<Cliente> clientes = ClienteRepositorio.ObtenerClientes();

            // si no se indica el nombre del cliente listarlos todos.
            if (!string.IsNullOrEmpty(nombre))
            {
                clientes = clientes.Where(c => c.Nombre.StartsWith(nombre)).ToList();
            }
            return View(clientes);
        }

        public ActionResult CrearCliente()
        {
            return View();        
        }
	}
}

using Reservas.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositorioDBF = Reservas.RepositorioDBF;

namespace Reservas.Web.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        public ActionResult Index()
        {
            RepositorioDBF.ClienteRepositorio repositorio = new RepositorioDBF.ClienteRepositorio();
            List<RepositorioDBF.Clientes> clientes = repositorio.ObtenerClientes();
            return View(clientes);
        }

        public ActionResult BuscarClientes(string nombre)
        {
            //List<Cliente> clientes = ClienteRepositorio.ObtenerClientes();

            //// si no se indica el nombre del cliente listarlos todos.
            //if (!string.IsNullOrEmpty(nombre))
            //{
            //    clientes = clientes.Where(c => c.Nombre.StartsWith(nombre)).ToList();
            //}
            //return View(clientes);
            return View();
        }

        public ActionResult CrearCliente()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CrearCliente(RepositorioDBF.Clientes cliente)
        {
            if(!String.IsNullOrEmpty(cliente.Nombre))
            { 
                RepositorioDBF.ClienteRepositorio repositorio = new RepositorioDBF.ClienteRepositorio();
                repositorio.GuardarCliente(cliente);
                return RedirectToAction("Index");
            }
            return View();
        }
	}
}
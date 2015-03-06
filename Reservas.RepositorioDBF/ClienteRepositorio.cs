using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.RepositorioDBF
{
    public class ClienteRepositorio
    {
        public List<Clientes> ObtenerClientes()
        {
            ReservasBdTradicionalEntities contexto = new ReservasBdTradicionalEntities();
            return contexto.Clientes.ToList();
        }

        public void GuardarCliente(Clientes cliente)
        {
            ReservasBdTradicionalEntities contexto = new ReservasBdTradicionalEntities();
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }
    }
}

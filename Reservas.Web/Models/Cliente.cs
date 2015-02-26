using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reservas.Web.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Calificacion { get; set; }
    }
}
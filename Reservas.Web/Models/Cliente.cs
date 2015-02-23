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

        public static List<Cliente> ObtenerClientes()
        {
            return new List<Cliente>{
                new Cliente{
                    Id = 1,
                    Nombre = "Katerine",
                    Ciudad = "Apartadó",
                    Calificacion = 8
                },
                new Cliente{
                    Id = 2,
                    Nombre = "Manuela",
                    Ciudad = "Amalfi",
                    Calificacion = 7
                },
                new Cliente{
                    Id = 3,
                    Nombre = "Laura",
                    Ciudad = "Medellin",
                    Calificacion = 9
                },
                new Cliente{
                    Id = 4,
                    Nombre = "Ana Maria",
                    Ciudad = "Medellin",
                    Calificacion = 8
                }
            };
        }
    }
}
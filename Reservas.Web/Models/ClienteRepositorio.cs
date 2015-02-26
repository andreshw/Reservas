using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Reservas.Web.Models
{
    public class ClienteRepositorio
    {
        public static List<Cliente> ObtenerClientes()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select * from clientes", conexion);
            List<Cliente> clientes = new List<Cliente>();
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    clientes.Add(new Cliente
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Ciudad = reader["Ciudad"].ToString(),
                        Calificacion = Convert.ToInt32(reader["Califcacion"])
                    });
                }
            }
            conexion.Close();
            return clientes;
        }
    }
}
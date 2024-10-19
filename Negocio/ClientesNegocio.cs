using AccesoADatos;
using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClientesNegocio
    {
        List<Cliente> listaClientes = new List<Cliente>();
        AccesoDatos datos = new AccesoDatos();
        public Cliente clienteById(int id) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT IdCliente, Dni, Nombre, Apellido, Celular, Preferencia, Email, FechaAlta, IdUbicacion, Comentario FROM Clientes WHERE IdCliente=@id");
                datos.setearParametro("@id", id);
                datos.ejecutarLectura();

                SqlDataReader lector = datos.Lector ;
                Cliente aux = new Cliente();

                if (lector.Read()) // Si se encuentra un registro
                {
                    aux.IdCliente = (int)lector["IdCliente"];
                    aux.DNI = (string)lector["Dni"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Apellido = (string)lector["Apellido"];
                    aux.Celular = (string)lector["Celular"];
                    aux.Email = (string)lector["Email"];
                    aux.FechaAlta = (DateTime)lector["FechaAlta"];
                    aux.ubicacion = new Ubicacion();
                    aux.ubicacion.IdUbicacion = (int)lector["IdUbicacion"];

                    // Campos que pueden ser NULL
                    aux.Preferencia = lector["Preferencia"] is DBNull ? null : (string)lector["Preferencia"];
                    aux.Comentarios = lector["Comentario"] is DBNull ? null : (string)lector["Comentario"];
                }
                else
                {
                    aux.IdCliente = -1; // Cliente no encontrado
                }

                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

using AccesoADatos;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio
{
    public class AgentesNegocio
    {

        List<Agente> lista = new List<Agente>();
        AccesoDatos datos = new AccesoDatos();
        public List<Agente> Listar(string id = "")
        {

            try
            {
                
                datos.setearConsulta("SELECT IdAgente, RolGerente, Nombre, Apellido, Celular, Email, Antiguedad, Estado, Experiencia, Especialidad, Comision, Comentarios FROM Agentes");

                // Si se proporciona un ID, se ajusta la consulta
                //para precargar un agente existente
                if (!string.IsNullOrEmpty(id))
                {
                    datos.setearConsulta("SELECT IdAgente, RolGerente, Nombre, Apellido, Celular, Email, Antiguedad, Estado, Experiencia, Especialidad, Comision, Comentarios FROM Agentes WHERE IdAgente = " + id);
                }

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Agente aux = new Agente
                    {
                        IdAgente = (int)datos.Lector["IdAgente"],
                        RolGerente = (bool)datos.Lector["RolGerente"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Apellido = (string)datos.Lector["Apellido"],
                        Celular = (string)datos.Lector["Celular"],
                        Email = (string)datos.Lector["Email"],
                        Antiguedad = (int)datos.Lector["Antiguedad"],
                        Estado = (string)datos.Lector["Estado"],
                        Experiencia = (int)datos.Lector["Experiencia"],
                        Especialidad = (string)datos.Lector["Especialidad"],
                        Comision = (decimal)datos.Lector["Comision"],
                        Comentarios = (string)datos.Lector["Comentarios"]
                    };

                    lista.Add(aux);
                }
                return lista;
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

        public void Agregar(Agente agente)
        {
            try
            {
                datos.setearConsulta("INSERT INTO Agentes (IdPropiedad, IdCliente, RolGerente, Nombre, Apellido, Celular, Email, Antiguedad, Estado,"+ 
                    "Experiencia, Especialidad, Comision, Comentarios) OUTPUT INSERTED.IdAgente "+
                    "VALUES (@IdPropiedad, @IdCliente, @RolGerente, @Nombre, @Apellido, @Celular, @Email, @Antiguedad, @Estado, @Experiencia, @Especialidad, @Comision, @Comentarios);");

                datos.setearParametro("@IdPropiedad", agente.IdPropiedad);
                datos.setearParametro("@RolGerente", agente.RolGerente);
                //ETC, igual esto se va a ir modificando...

                agente.IdAgente = datos.ejecutarAccionScalar();


                
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


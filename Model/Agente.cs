using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Agente
    {
        public int IdAgente { get; set; }
        public bool RolGerente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int Antiguedad { get; set; }
        public string Estado { get; set; }   // Activo, Inactivo
        public int Experiencia { get; set; }
        public string Especialidad { get; set; } // Ventas, Alquileres
        public decimal Comision { get; set; }
        public string Comentarios { get; set; }

        public int IdPropiedad { get; set; }

        public int IdCliente { get; set; }
    }
}

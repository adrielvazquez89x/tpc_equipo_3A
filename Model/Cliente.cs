using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cliente
    {
        public int IdCliente { get; set; }           
        public string Nombre { get; set; }            
        public string Apellido { get; set; }         
        public string Celular { get; set; }          
        public string Preferencia { get; set; } // Tipo de propiedad
        public string Email { get; set; }             
        public DateTime FechaAlta { get; set; }       
        public string DNI { get; set; }

        // Propiedades de Ubicación
        public int IdUbicacion { get; set; }
    }
}

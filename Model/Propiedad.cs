using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Propiedad
    {
        public int IdPropiedad { get; set; }       
        public int IdEstado { get; set; }           
        public int IdAgente { get; set; }           
        public int IdUbicacion { get; set; }       
        public decimal Precio { get; set; }        
        public string Tipo { get; set; }    //casa,dpto,etc
        public int Ambientes { get; set; }          
        public bool Ascensor { get; set; }          
        public int Habitaciones { get; set; }      
        public int Banios { get; set; }              
        public decimal SuperficieTotal { get; set; } 
        public int Antiguedad { get; set; }        
        public bool Cochera { get; set; }           
        public bool Jardin { get; set; }            
        public bool Balcon { get; set; }            
        public DateTime FechaAlta { get; set; }    
        public bool Disponibilidad { get; set; }    
        public string DescripcionBreve { get; set; } 
        public string DescripcionAmplia { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ubicacion
    {
        public int IdUbicacion { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string Barrio { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string CP { get; set; }             
        public int Piso { get; set; }                  
        public string Unidad { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Perfil
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string UrlImgPerfil { get; set; }
        public bool admin { get; set; }
        public bool PrimerAcceso { get; set; }
        public string Celular { get; set; }

    }
}

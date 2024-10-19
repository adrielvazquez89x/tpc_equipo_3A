using Model;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tpc_equipo3a_inmobiliaria
{
    public partial class DatosDeCuenta : System.Web.UI.Page
    {
        public Perfil perfil= new Perfil();
        protected void Page_Load(object sender, EventArgs e)
        {
            PerfilesNegocio negocio = new PerfilesNegocio();
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
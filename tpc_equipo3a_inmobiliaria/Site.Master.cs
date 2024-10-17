using Model;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace tpc_equipo3a_inmobiliaria
{
    public partial class SiteMaster : MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Enlace> enlaces = new List<Enlace>
                {
                    new Enlace { Nombre = "Inicio", Url = "Default.aspx", Icono ="bi-house", Activo= false },
                    new Enlace { Nombre = "Inmuebles", Url = "Inmuebles.aspx", Icono="bi-building", Activo= false  },
                    new Enlace { Nombre = "Agentes", Url = "Agentes.aspx", Icono="bi-people", Activo= false  }
                };

                RepeaterSidebar.DataSource = enlaces;
                RepeaterSidebar.DataBind();
            }
        }
    }
}
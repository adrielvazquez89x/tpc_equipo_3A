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
    public partial class Agentes : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarAgentes();
            }
            
        }

        public void CargarAgentes()
        {
            AgentesNegocio negocio = new AgentesNegocio();
            List<Agente> agentes = negocio.Listar();
            dgvAgentes.DataSource = agentes;
            dgvAgentes.DataBind();
        }
    }
}
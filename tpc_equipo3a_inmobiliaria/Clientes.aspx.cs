using Model;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace tpc_equipo3a_inmobiliaria
{
    public partial class Clientes : System.Web.UI.Page
    {
        public Cliente cliente = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {

            ClientesNegocio negocio = new ClientesNegocio();
            //Cliente aux = (Cliente)Session["Cliente"]; //El cliente ya debe estar guardado en sesion, esto es momentaneo
            //esto luego no va ya que lo traerá en sesion:
            Cliente aux = new Cliente();
            aux = negocio.clienteById(1); // de momento solo para mostrar que la BD está

            cargarDatos(aux); //validar si hay cliente en sesion...
        }

        protected void cargarDatos(Cliente cliente)
        {
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCelular.Text = cliente.Celular;
            txtEmail.Text = cliente.Email;
            txtDNI.Text = cliente.DNI;
            txtProvincia.Text = cliente.ubicacion.Provincia;
            //txtLocalidad.Text = cliente.ubicacion.Localidad;
            //TxtBarrio.Text= cliente.ubicacion.Barrio;
            //txtCalle.Text= cliente.ubicacion.Calle;
            //txtCP.Text = cliente.ubicacion.CP;
            //txtAltura.Text = cliente.ubicacion.Altura.ToString();

            //En realidad este grado de detalle deberia ir para las propiedades, no para los clientes... (revisar que incluso faltan algunos atributos en ese caso)
        }
    }
}
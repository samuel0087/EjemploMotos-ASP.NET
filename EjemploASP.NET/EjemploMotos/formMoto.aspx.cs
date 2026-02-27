using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace EjemploMotos
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlColores.Items.Add("Negro");
                ddlColores.Items.Add("Blanco");
                ddlColores.Items.Add("Rojo");
                ddlColores.Items.Add("Gris");

                ddlMarcas.Items.Add("Motomel");
                ddlMarcas.Items.Add("Royal Enfield");
                ddlMarcas.Items.Add("Benelli");
                ddlMarcas.Items.Add("Honda");
                ddlMarcas.Items.Add("Yamaha");
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Moto nueva = new Moto();
            nueva.IdMoto = int.Parse(txtId.Text);
            nueva.Marca = ddlMarcas.SelectedValue;
            nueva.Modelo = txtModelo.Text;
            nueva.Descripcion = txtDescripcion.Text;
            nueva.Color = ddlColores.SelectedValue;
            nueva.FechaFabricacion = DateTime.Parse(txtFecha.Text).ToString("dd/MM/yyyy");
            nueva.Usado = chkUsado.Checked;
            nueva.Importado = chkImportado.Checked;

            ((List<Moto>)Session["listaMotos"]).Add(nueva);
            Response.Redirect("Default");

        }
    }
}
using System;
using System.Collections;
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
                ddlMarcas.Items.Add("Zanella");
                ddlMarcas.Items.Add("Royal Enfield");
                ddlMarcas.Items.Add("Benelli");
                ddlMarcas.Items.Add("Honda");
                ddlMarcas.Items.Add("Yamaha");

                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"].ToString());
                    Moto seleccionado = ((List<Moto>)Session["listaMotos"]).Find(x => x.IdMoto == id);
                    txtId.Text = seleccionado.IdMoto.ToString();
                    ddlMarcas.SelectedValue = seleccionado.Marca;
                    txtModelo.Text = seleccionado.Modelo;
                    txtDescripcion.Text = seleccionado.Descripcion;
                    ddlColores.SelectedValue = seleccionado.Color;
                    txtFecha.Text = seleccionado.FechaFabricacion.ToString("yyyy-MM-dd");
                    chkUsado.Checked = seleccionado.Usado;
                    chkImportado.Checked = seleccionado.Importado;

                }
            }



        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            List<Moto> lista = (List<Moto>)Session["listaMotos"];

            Moto nueva = new Moto();
            nueva.IdMoto = int.Parse(txtId.Text);
            nueva.Marca = ddlMarcas.SelectedValue;
            nueva.Modelo = txtModelo.Text;
            nueva.Descripcion = txtDescripcion.Text;
            nueva.Color = ddlColores.SelectedValue;
            nueva.FechaFabricacion = DateTime.Parse(txtFecha.Text);
            nueva.Usado = chkUsado.Checked;
            nueva.Importado = chkImportado.Checked;

            if(Request.QueryString["id"] == null){
                lista.Add(nueva);
            }
            else
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                int index = lista.FindIndex(x => x.IdMoto == id);

                if (index > -1)
                {
                    lista[index] = nueva;
                }
            }

            Response.Redirect("Default");
        }
    }
}
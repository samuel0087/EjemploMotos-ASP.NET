using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace EjemploMotos
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaMotos"] == null)
            {
                MotoNegocio negocio = new MotoNegocio();
                Session.Add("listaMotos", negocio.listar());
            }

            dgvMotos.DataSource = Session["listaMotos"];
            dgvMotos.DataBind();

        }

        protected void dgvMotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvMotos.SelectedDataKey.Value.ToString();
            Response.Redirect("formMoto?id=" + id);
        }
    }
}
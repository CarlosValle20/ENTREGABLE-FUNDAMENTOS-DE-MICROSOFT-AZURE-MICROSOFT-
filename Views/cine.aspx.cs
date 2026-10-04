using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webCinestar_WebForms_202620.Models;

namespace webCinestar_WebForms_202620.Views
{
    public partial class Cine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (id == null) Response.Redirect("index.aspx");

            var controller = new Controllers.CinestarController();

            fvCine.DataSource = controller.getCine(id);
            fvCine.DataBind();

            rptTarifas.DataSource = controller.getCineTarifas(id);
            rptTarifas.DataBind();

            rptHorarios.DataSource = controller.getCinePeliculas(id);
            rptHorarios.DataBind();

            if (fvCine.DataSource == null)
                Response.Redirect("index.aspx");
        }
    }
}
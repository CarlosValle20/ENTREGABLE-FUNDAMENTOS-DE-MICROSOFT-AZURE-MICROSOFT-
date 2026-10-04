using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webCinestar_WebForms_202620.Views
{
    public partial class Pelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            if (id == null) Response.Redirect("index.aspx");

            fvPelicula.DataSource = new Controllers.CinestarController().getPelicula(id);
            fvPelicula.DataBind();

            if (fvPelicula.DataSource == null)
                Response.Redirect("index.aspx");
        }
    }
}
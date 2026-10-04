using System;

namespace webCinestar_WebForms_202620.Views

{
    public partial class cines : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptCines.DataSource = new Controllers.CinestarController().getCinesList();
                rptCines.DataBind();
                if (rptCines.DataSource == null) Response.Redirect("index.aspx");
            }
        }
    }
}
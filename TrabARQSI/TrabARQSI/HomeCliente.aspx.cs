using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabARQSI
{
    public partial class HomeCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblusr.Text = Session["user"].ToString();
            if (Session["user"] == null && Session["tipo"] != "user")
            {
                Response.Redirect("login.aspx", true);
            }
        }

        

       

    }
}
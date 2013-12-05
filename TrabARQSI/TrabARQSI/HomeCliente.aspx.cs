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
            if (Session["user"] == null && Session["tipo"].ToString() != "user")
            {
                Response.Redirect("login.aspx", true);
            }
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session["tipo"] = null;
            Response.Redirect("login.aspx", true);
        }

        protected void btncarrinho_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuCarrinho.aspx", true);
        }

        

       

    }
}
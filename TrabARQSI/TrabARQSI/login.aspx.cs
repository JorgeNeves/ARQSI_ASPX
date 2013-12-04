using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabARQSI.App_Code
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            string user = txtUser.Text;
            string pw = txtUser.Text;
            if (us.isValidUser(user,pw))
            {
                Label1.Text = "Utilizador logado";
            }
            else
            {
                Label1.Text = "Utilizador invalido";
            }

            Session["user"] = user;
            Session["tipo"] = us.validUser(user);
            
            if (Session["tipo"].ToString() == "gestor")
            {
                Response.Redirect("HomeGestor.aspx", true);
            }

        }

        protected void btnsignin_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistarUser.aspx", true);
        }
    }
}
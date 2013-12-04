using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabARQSI
{
    public partial class RegistarUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblverificausername.Text = "";
        }

        protected void btnregistar_Click(object sender, EventArgs e)
        {
            if (txtpw.Text == txtpw2.Text)
            {
                
                Table_Model.BLL.User us = new Table_Model.BLL.User();
                if (us.registarUser(TextBox1.Text, txtpw.Text,TextBox2.Text))
                {
                    lblverificausername.Text = "Registo com sucesso!";
                }
                else
                {
                    lblverificausername.Text = "Utilizador já existe!";
                }
                
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx", true);
        }
    }
}
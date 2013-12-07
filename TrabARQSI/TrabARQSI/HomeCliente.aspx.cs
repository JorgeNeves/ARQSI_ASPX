using System;
using System.Collections.Generic;
using System.Data;
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
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            Table_Model.BLL.Produto prdt = new Table_Model.BLL.Produto();
            string nuser = Session["user"].ToString();

            DataTable produtoatual = prdt.GetProdutos();
            GridView1.DataSource = produtoatual;
            GridView1.DataBind();
           
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

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuCompras.aspx", true);
        }
        

        

       

    }
}
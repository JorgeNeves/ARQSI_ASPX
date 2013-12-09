using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnviarMAILS
{
    public partial class MenuEncomendas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx", true);
            }
            if (Session["tipo"].ToString() != "user")
            {
                Response.Redirect("login.aspx", true);
            }
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            Table_Model.BLL.Encomenda enc = new Table_Model.BLL.Encomenda();
            //Table_Model.BLL.Carrinho car = new Table_Model.BLL.Carrinho();
            string nuser = Session["user"].ToString();
            int iduser = us.getidUser(nuser);
            //int ncarrinhos = car.ncarrinhos(iduser);
            DataTable encomendas = enc.getEncomendas(iduser);
            if (encomendas.Rows.Count == 0)
            {
                lblvazio.Visible = true;
                GridView1.Visible = false;
            }
            else
            {
                GridView1.DataSource = encomendas;
                GridView1.DataBind();
            }
        }
    }
}
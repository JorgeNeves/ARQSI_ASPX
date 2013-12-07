using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabARQSI
{
    public partial class HomeAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null && Session["tipo"].ToString() == "administrador")
            {
                atualizar();
                Button1.Enabled = false;
            }
            else
            {
                Response.Redirect("login.aspx", true);
            }
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session["tipo"] = null;
            Response.Redirect("login.aspx", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)GridView1.SelectedDataKey.Value;
            GridViewRow row = GridView1.SelectedRow;
            string tipo = row.Cells[3].Text;
            if (tipo == "user")
            {
                Button1.Text = "Promover";
            }
            else
            {
                Button1.Text = "Despromover";
            }
            Button1.Enabled = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = (int)GridView1.SelectedDataKey.Value;
            string tipo;
            if (Button1.Text == "Promover")
            {
                tipo = "gestor";
            }
            else
            {
                tipo = "user";
            }
            Table_Model.BLL.User userBLL = new Table_Model.BLL.User();
            userBLL.alterarTipo(id, tipo);
            Button1.Enabled = false;
            atualizar();
        }

        private void atualizar()
        {
            Table_Model.BLL.User userBLL = new Table_Model.BLL.User();
            GridView1.DataSource = userBLL.GetUsers();
            GridView1.DataBind();
        }
    }
}
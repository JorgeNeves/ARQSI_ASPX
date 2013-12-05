using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabARQSI
{
    public partial class HomeGestor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Session["tipo"].ToString() != "gestor")
            {
                Response.Redirect("login.aspx", true);
            }
            lbuser.Text = Session["user"].ToString();
        }

        protected void btInserir_Click(object sender, EventArgs e)
        {
            string nome = txNome.Text;
            string precof = txPreco.Text;
            int quantidade = int.Parse(txQuantidade.Text);
            string genero = txGenero.Text;
            string edicao = txEdicao.Text;
            Table_Model.BLL.Produto p = new Table_Model.BLL.Produto();
            p.inserirProduto(nome, precof, quantidade, genero, edicao);
            GridView1.DataBind();

            txNome.Text="";
            txPreco.Text="";
            txQuantidade.Text="";
            txGenero.Text="";
            txEdicao.Text="";

        }

        protected void btlogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session["tipo"] = null;
            Response.Redirect("login.aspx", true);
        }
    }
}
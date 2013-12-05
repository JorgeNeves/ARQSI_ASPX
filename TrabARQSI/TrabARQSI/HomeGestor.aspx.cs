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
            if (Session["user"] == null && Session["tipo"] != "gestor")
            {
                Response.Redirect("login.aspx", true);
            }
        }

        protected void btInserir_Click(object sender, EventArgs e)
        {
            string nome = txNome.Text;
            string preco = txPreco.Text;
            string quantidade = txQuantidade.Text;
            string genero = txGenero.Text;
            string edicao = txEdicao.Text;


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace EnviarMAILS
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

            Table_Model.BLL.Produto pbll = new Table_Model.BLL.Produto();
            DataTable dt = pbll.GetProdutos();
            GridView1.DataSource = dt;
            GridView1.DataBind();
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
            atualizar();
            

        }

        protected void btlogout_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Session["tipo"] = null;
            Response.Redirect("login.aspx", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GridViewRow row = GridView1.SelectedRow;
            txNome.Text = row.Cells[4].Text;
            txPreco.Text = row.Cells[2].Text;
            txQuantidade.Text = row.Cells[3].Text;
            txGenero.Text = row.Cells[5].Text;
            txEdicao.Text = row.Cells[6].Text;
        

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Table_Model.BLL.Produto produtBll = new Table_Model.BLL.Produto();
            int id = (int)GridView1.SelectedDataKey.Value;
            produtBll.alterarProduto(id, txNome.Text, txPreco.Text, int.Parse(txQuantidade.Text), txGenero.Text, txEdicao.Text);
            atualizar();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = (int)GridView1.SelectedDataKey.Value;
            Table_Model.BLL.Produto p = new Table_Model.BLL.Produto();
            p.removerProduto(id);
            atualizar();
        }

        private void atualizar()
        {
            Table_Model.BLL.Produto p = new Table_Model.BLL.Produto();
            DataTable dt = p.GetProdutos();
            GridView1.DataSource = dt;
            GridView1.DataBind();

            txNome.Text = "";
            txPreco.Text = "";
            txQuantidade.Text = "";
            txGenero.Text = "";
            txEdicao.Text = "";
        }
    }
}
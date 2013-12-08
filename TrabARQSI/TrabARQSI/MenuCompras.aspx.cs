using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnviarMAILS
{
    public partial class MenuCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbluser.Text = Session["user"].ToString();
            if (Session["user"] == null && Session["tipo"].ToString() != "user")
            {
                Response.Redirect("login.aspx", true);
            }
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            Table_Model.BLL.Produto prdt = new Table_Model.BLL.Produto();
            string nuser = Session["user"].ToString();

            DataTable produtoatual = prdt.GetProdutossemid();
            GridView1.DataSource = produtoatual;
            GridView1.DataBind();
        }

        protected void btncarrinho_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuCarrinho.aspx", true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeCliente.aspx", true);
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            lblqtdd.Visible = true;
            txtqtdd.Visible = true;
            btnOK.Visible = true;
            btncancel.Visible = true;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {

                if (int.Parse(txtqtdd.Text) > 0)
                {
                    GridViewRow row = GridView1.SelectedRow;
                    string nome = row.Cells[3].Text;
                    string edicao = row.Cells[5].Text;
                    Table_Model.BLL.User us = new Table_Model.BLL.User();
                    Table_Model.BLL.Carrinho car = new Table_Model.BLL.Carrinho();
                    string nuser = Session["user"].ToString();
                    int iduser = us.getidUser(nuser);
                    int idcarrinho = car.getidcarrinho(iduser);
                    car.addelementoCarrinho(iduser, idcarrinho, nome, edicao, int.Parse(txtqtdd.Text));
                    lblqtdd.Visible = false;
                    txtqtdd.Visible = false;
                    btnOK.Visible = false;
                    btncancel.Visible = false;
                    Page_Load(null, null);
                }
            }

        }
    }

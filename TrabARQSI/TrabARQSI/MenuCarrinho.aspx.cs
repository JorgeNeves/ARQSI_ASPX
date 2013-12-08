using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabARQSI
{
    public partial class MenuCarrinho : System.Web.UI.Page
    {
        protected void GridViewCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnQuantidade.Visible = true;
            btnremoversel.Visible = true;
            
            
        }

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
            Table_Model.BLL.Carrinho car=new Table_Model.BLL.Carrinho();
            string nuser=Session["user"].ToString();
            int iduser = us.getidUser(nuser);
            DataTable carrinhoatual = car.getElementosCarrinho(iduser);
            if (carrinhoatual.Rows.Count==0){
                lblVazio.Visible=true;
            }
            GridViewCarrinho.DataSource =carrinhoatual;
            GridViewCarrinho.DataBind();


        }

        protected void btnEliminarCarrinho_Click(object sender, EventArgs e)
        {
            Table_Model.BLL.Carrinho car = new Table_Model.BLL.Carrinho();
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            string nuser = Session["user"].ToString();
            int iduser = us.getidUser(nuser);
            car.eliminarelementosCarrinho(iduser);
            Page_Load(null, null);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            lblpreco.Visible = true;
            lbldist.Visible = true;
            dropLogistica.Visible = true;
            btnenc.Visible = true;
        }    

        protected void btnremoversel_Click(object sender, EventArgs e)
        {
            GridViewRow row = GridViewCarrinho.SelectedRow;
            string nome = row.Cells[3].Text;
            string edicao = row.Cells[5].Text;
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            Table_Model.BLL.Carrinho car = new Table_Model.BLL.Carrinho();
            string nuser = Session["user"].ToString();
            int iduser = us.getidUser(nuser);
            int idcarrinho = car.getidcarrinho(iduser);
            car.eliminarelementoCarrinho(iduser, idcarrinho, nome, edicao);
            btnQuantidade.Visible = false;
            btnremoversel.Visible = false;
            Page_Load(null,null);
        }

        protected void btnQuantidade_Click(object sender, EventArgs e)
        {
            lblqntidade.Visible = true;
            txtqtidade.Visible = true;
            btnconfirmar.Visible = true;
            btncancelar.Visible = true;
        }

        protected void btncancelar_Click(object sender, EventArgs e)
        {
            btnremoversel.Visible = false;
            btnQuantidade.Visible = false;
            btncancelar.Visible = false;
            btnconfirmar.Visible = false;
            txtqtidade.Visible = false;
            lblqntidade.Visible = false;
            Page_Load(null, null);
        }

        protected void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtqtidade.Text) > 0)
            {
                GridViewRow row = GridViewCarrinho.SelectedRow;
                string nome = row.Cells[3].Text;
                string edicao = row.Cells[5].Text;
                Table_Model.BLL.User us = new Table_Model.BLL.User();
                Table_Model.BLL.Carrinho car = new Table_Model.BLL.Carrinho();
                string nuser = Session["user"].ToString();
                int iduser = us.getidUser(nuser);
                int idcarrinho = car.getidcarrinho(iduser);

                car.atualizaquantidadeproduto(iduser, idcarrinho, nome, edicao, int.Parse(txtqtidade.Text));
                btnremoversel.Visible = false;
                btnQuantidade.Visible = false;
                btncancelar.Visible = false;
                btnconfirmar.Visible = false;
                txtqtidade.Visible = false;
                lblqntidade.Visible = false;
                Page_Load(null, null);
            }
        }

        protected void btninicial_Click(object sender, EventArgs e)
        {
           Response.Redirect("HomeCliente.aspx", true);
        }

        protected void DropDist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Calcular quantidade de livros/revistas
            int quantidade = 20;
            if (dropLogistica.SelectedValue.ToString() == "LogisticaSA")
            {
                LogisticaSA.ServiceLogisticaSAClient logisticaSA = new LogisticaSA.ServiceLogisticaSAClient();
                
                lblpreco.Text = logisticaSA.custo(quantidade).ToString();
            }
            else
            {
                ShippingAll.servicenamePortTypeClient ShippingAll = new ShippingAll.servicenamePortTypeClient();
                lblpreco.Text = ShippingAll.custo(quantidade).ToString();
            }
        }
        
    }
}
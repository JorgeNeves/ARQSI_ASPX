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

            GridViewRow row = GridViewCarrinho.SelectedRow;
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            Table_Model.BLL.Carrinho car=new Table_Model.BLL.Carrinho();
            string nuser=Session["user"].ToString();
            int iduser = us.getidUser(nuser);
            DataTable carrinhoatual = car.getElementosCarrinho(iduser);
            if (carrinhoatual.Rows.Count==0){
                lblVazio.Visible=true;
            }
            GridViewCarrinho.DataSourceID = null;
            GridViewCarrinho.DataSource =carrinhoatual;
            
        }

        

        protected void btnEliminarCarrinho_Click(object sender, EventArgs e)
        {
            Table_Model.BLL.Carrinho car = new Table_Model.BLL.Carrinho();
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            string nuser = Session["user"].ToString();
            int iduser = us.getidUser(nuser);
            car.eliminarCarrinho(iduser);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            lblpreco.Visible = true;
            lbldist.Visible = true;
            DropDist.Visible = true;
            btnenc.Visible = true;
        }

        
        

        
    }
}
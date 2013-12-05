using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabARQSI
{
    public partial class MenuCarrinho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table_Model.BLL.User us = new Table_Model.BLL.User();
            string nuser=Session["user"].ToString();
            int iduser = us.getidUser(nuser);
            Label1.Text = ""+iduser;
            string conn="Data Source=gandalf.dei.isep.ipp.pt\\sqlexpress;Initial Catalog=ARQSI056;Persist Security Info=True;User ID=ARQSI056;Password=ARQSI056";
            string sql = "Select Preço,Quantidade,Nome,Genero,Ediçao FROM ProdutosCarrinhoView where IdCarrinho = (Select IdCarrinho From Carrinho where IdUser="+iduser+" and Atual=1)";
            SqlDataSource carrinhoatual = new SqlDataSource(conn,sql);
            carrinhoatual.DataBind();
            GridViewCarrinho.DataSourceID = null;
            GridViewCarrinho.DataSource =carrinhoatual;
            
        }

        

        
    }
}
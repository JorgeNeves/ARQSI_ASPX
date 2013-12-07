using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace Table_Model.DAL
{
    public class CarrinhoGateway : BaseGateway
    {
        public CarrinhoGateway()
        {

        }
        public void atualizarquantidadeproduto(int iduser,int idcar,string nome,string edicao,int novaqtdd)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql = "Select IdProduto From Produto where Nome='" + nome + "' and Ediçao=" + edicao;
            DataSet ds = ExecuteQuery(cnx, sql);
            int idprod = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            sql = "Update CarrinhoProduto set Quantidade=" + novaqtdd + " where idCarrinho=" + idcar + " and IdProduto=" + idprod;
            ExecuteNonQuery(cnx, sql);
        }
        public void addelementocarrinho(int iduser, int idcar, string nome, string edicao,int quantidade)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql = "Select IdProduto From Produto where Nome='" + nome + "' and Ediçao=" + edicao;
             DataSet ds = ExecuteQuery(cnx, sql);
            int idprod = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            sql = "Insert into CarrinhoProduto Values ("+idcar+","+idprod+","+quantidade+")";
            ExecuteNonQuery(cnx, sql);
        }
        public int getidcarrinho(int iduser)
        {
            String sql = "Select IdCarrinho FROM Carrinho where IdUser=" + iduser + " and Atual=1";
            OleDbConnection cnx = GetConnection(true);
            DataSet ds = ExecuteQuery(cnx, sql);
            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }
        public DataTable getElementos(int iduser)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql = "Select Preço,Quantidade,Nome,Genero,Ediçao FROM ProdutosCarrinhoView where IdCarrinho = (Select IdCarrinho From Carrinho where IdUser=" + iduser + " and Atual=1)";
            DataSet ds = ExecuteQuery(cnx,sql);
            return ds.Tables[0];

        }
        public void removerelementoCarrinho(int iduser, int idcar, string nome, string edicao)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql="Select IdProduto From Produto where Nome='"+nome+"' and Ediçao="+edicao;
            DataSet ds = ExecuteQuery(cnx, sql);
            int idprod=Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            sql="Delete From CarrinhoProduto where IdCarrinho="+idcar+" and IdProduto="+idprod;
            ExecuteNonQuery(cnx, sql);
        }
        public void removerelementosCarrinho(int iduser)
        {
            String sql = "Select IdCarrinho FROM Carrinho where IdUser="+iduser+" and Atual=1";
            OleDbConnection cnx = GetConnection(true);
            DataSet ds=ExecuteQuery(cnx, sql);
            int idcar=Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            sql = "Delete FROM CarrinhoProduto where IdCarrinho="+idcar+"";
            ExecuteNonQuery(cnx, sql);
         }
        
        public int removerProduto(int id)
        {
            string sql = "DELETE FROM Carrinho WHERE IdProduto=" + id;
            OleDbConnection cnx = GetConnection(true);
            return ExecuteNonQuery(cnx, sql);
        }


        internal void addelementoCarrinho(int idUser, int idCar, string nome, string edicao, int quantidade)
        {
            throw new NotImplementedException();
        }
    }
}
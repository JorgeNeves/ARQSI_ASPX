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
        public int ncarrinhos(int iduser)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql = "Select Count(*) FROM Carrinho where idUser="+iduser+" and Atual=1";
            DataSet ds = ExecuteQuery(cnx, sql);
            return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        }
        public void atualizarquantidadeproduto(int iduser,int idcar,string nome,string edicao,int novaqtdd)
        {
            try
            {
                OleDbConnection cnx = GetConnection(true);
                string sql = "Select IdProduto From Produto where Nome='" + nome + "' and Ediçao='" + edicao + "'";
                DataSet ds = ExecuteQuery(cnx, sql);
                int idprod = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                sql = "Update CarrinhoProduto set Quantidade=" + novaqtdd + " where idCarrinho=" + idcar + " and IdProduto=" + idprod;
                ExecuteNonQuery(cnx, sql);
            }
            catch (Exception )
            {
                throw new Exception("Erro a atualizar quantidade do produto no carrinho de compras");
            }
            
        }
        public void addelementocarrinho(int iduser, int idcar, string nome, string edicao,int quantidade)
        {
            try
            {
                OleDbConnection cnx = GetConnection(true);
                string sql = "Select IdProduto From Produto where Nome='" + nome + "' and Ediçao=" + edicao;
                DataSet ds = ExecuteQuery(cnx, sql);
                int idprod = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                sql = "Insert into CarrinhoProduto Values (" + idcar + "," + idprod + "," + quantidade + ")";
                ExecuteNonQuery(cnx, sql);
            }
            catch (Exception )
            {
                throw new Exception("Erro ao adicionar elemento no carrinho");
            }
        }
        public int getidcarrinho(int iduser)
        {
            try{
                String sql = "Select IdCarrinho FROM Carrinho where IdUser=" + iduser + " and Atual=1";
                OleDbConnection cnx = GetConnection(true);
                DataSet ds = ExecuteQuery(cnx, sql);
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
           }
            catch (Exception )
            {
                throw new Exception("Erro ao fazer get id carrinho");
            }

        }
        public DataTable getElementos(int iduser)
        {
            try{
            OleDbConnection cnx = GetConnection(true);
            string sql = "Select Preço,Quantidade,Nome,Genero,Ediçao FROM ProdutosCarrinhoView where IdCarrinho = (Select IdCarrinho From Carrinho where IdUser=" + iduser + " and Atual=1)";
            DataSet ds = ExecuteQuery(cnx,sql);
            return ds.Tables[0];
            }
            catch (Exception )
            {
                throw new Exception("Erro ao selecionar elementos do carrinho na base de dados");
            }

        }
        public void novocarrinho(int iduser)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql = "Insert Into Carrinho(IdUser,Atual) Values("+iduser+",1)";
            ExecuteNonQuery(cnx, sql);

        }
        public void removerelementoCarrinho(int iduser, int idcar, string nome, string edicao)
        {
            try{
            OleDbConnection cnx = GetConnection(true);
            string sql="Select IdProduto From Produto where Nome='"+nome+"' and Ediçao="+edicao;
            DataSet ds = ExecuteQuery(cnx, sql);
            int idprod=Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            sql="Delete From CarrinhoProduto where IdCarrinho="+idcar+" and IdProduto="+idprod;
            ExecuteNonQuery(cnx, sql);
            }
            catch (Exception )
            {
                throw new Exception("Erro ao remover elemento no carrinho");
            }
        }
        public void removerelementosCarrinho(int iduser)
        {
            try{
            String sql = "Select IdCarrinho FROM Carrinho where IdUser="+iduser+" and Atual=1";
            OleDbConnection cnx = GetConnection(true);
            DataSet ds=ExecuteQuery(cnx, sql);
            int idcar=Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            sql = "Delete FROM CarrinhoProduto where IdCarrinho="+idcar+"";
            ExecuteNonQuery(cnx, sql);
            }
            catch (Exception )
            {
                throw new Exception("Erro ao remover todos os elementos do carrinho");
            }
         }
        
        public int removerProduto(int id)
        {
            try{
            string sql = "DELETE FROM Carrinho WHERE IdProduto=" + id;
            OleDbConnection cnx = GetConnection(true);
            return ExecuteNonQuery(cnx, sql);
            }
            catch (Exception )
            {
                throw new Exception("Erro ao remover produto no carrinho");
            }
        }




        public void setfalse(int idcar)
        {
            String sql = "Update Carrinho set Atual=0 where IdCarrinho=" + idcar;
            OleDbConnection cnx = GetConnection(true);
            ExecuteNonQuery(cnx, sql);
        }
    }
}
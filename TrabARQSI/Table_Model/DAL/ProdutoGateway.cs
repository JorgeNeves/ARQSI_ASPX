using System;
using System.Data;
using System.Data.OleDb;

namespace Table_Model.DAL
{
    public class ProdutoGateway:BaseGateway
    {
        public ProdutoGateway() { }

        public bool insereProduto(string nome, string preco, int quantidade, string genero, string edicao)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql = "INSERT INTO Produto VALUES('" + preco + "'," + quantidade + ",'"+nome +"','" + genero + "','"+edicao+"')";
            OleDbCommand sqlcmd = new OleDbCommand(sql, cnx);
            sqlcmd.ExecuteNonQuery();
            return true;
        }

        public DataTable GetProdutos()
        {
            OleDbConnection cnx = GetConnection(true);
            DataSet ds = ExecuteQuery(cnx, "SELECT * FROM Produto");
            return ds.Tables[0];
        }
    }

    
}

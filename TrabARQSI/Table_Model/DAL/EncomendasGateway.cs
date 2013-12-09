using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace Table_Model.DAL
{
    class EncomendasGateway:BaseGateway
    {
        public EncomendasGateway() { }
        public void add(int iduser, int idcar)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql = "Insert into Encomenda(IdUser,IdCarrinho) Values(" + iduser + "," + idcar + ")";
            ExecuteNonQuery(cnx, sql);
            
        }
        public DataTable getEncomendas(int iduser)
        {
            OleDbConnection cnx = GetConnection(true);
            string sql = "Select IdEncomenda as CodigoEncomenda FROM Encomenda where IdUser="+iduser;
            DataSet ds = ExecuteQuery(cnx, sql);
            return ds.Tables[0];
        }
    }
}

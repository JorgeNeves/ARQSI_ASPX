using System;
using System.Data;
using System.Data.OleDb;


namespace Table_Model.DAL
{
    public class UserGateway : BaseGateway
    {
        public UserGateway()
        {

        }

        public bool registarUser(string user, string pw,string email)
        {

           OleDbConnection cnx = GetConnection(true);
           string sqlCount = "select * from Utilizadores where username ='" + user+"'";
           DataSet s = GetDataSet(sqlCount);
                    
           
           if (s.Tables[0].Rows.Count == 0)
           {
               string sql = "INSERT INTO Utilizadores VALUES('" + user + "','" + pw + "','user' ,'"+email+"')";
               OleDbCommand sqlcmd = new OleDbCommand(sql, cnx);
               sqlcmd.ExecuteNonQuery();
               return true;
           }
           else
           {
               return false;
           }
        }

        public bool validUser(string user, string pw)
        {
           string sql = "select * from Utilizadores where username ='" + user +"'";
           DataSet s = GetDataSet(sql);
           if (s.Tables[0].Rows[0]["password"].ToString() == pw)
           {
               return true;
           }
           else
           {
               return false;
           }
        }

        public string getTipoUser(string user)
        {
            string sqlCount = "select tipo from Utilizadores where username ='" + user + "'";
            DataSet s = GetDataSet(sqlCount);
            return (string)s.Tables[0].Rows[0]["tipo"];

        }

        public int getiduser(string user)
        {
            string sqlid = "select idUser from Utilizadores where username='" + user + "'";
            DataSet s = GetDataSet(sqlid);
            return (int)s.Tables[0].Rows[0]["idUser"];
        }

        public DataTable GetUsers()
        {
            OleDbConnection cnx = GetConnection(true);
            DataSet ds = ExecuteQuery(cnx, "SELECT IdUser,username,tipo FROM Utilizadores where tipo!='administrador'");
            return ds.Tables[0];
        }

        public void alterarTipo(int id, string tipo)
        {
            string sql = "UPDATE Utilizadores SET Tipo='" + tipo + "' WHERE IdUser=" + id;
            OleDbConnection cnx = GetConnection(true);
            ExecuteNonQuery(cnx, sql);
        }
    }


}

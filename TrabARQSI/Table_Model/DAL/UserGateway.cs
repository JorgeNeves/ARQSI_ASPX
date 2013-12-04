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

        public bool registarUser(string user, string pw)
        {

           OleDbConnection cnx = GetConnection(true);
           string sqlCount = "select * from Utilizadores where username ='" + user+"'";
           DataSet s = GetDataSet(sqlCount);
                    
           
           if (s.Tables[0].Rows.Count == 0)
           {
               string sql = "INSERT INTO Utilizadores VALUES('" + user + "','" + pw + "','user')";
               OleDbCommand sqlcmd = new OleDbCommand(sql, cnx);
               sqlcmd.ExecuteNonQuery();
               return true;
           }
           else
           {
               return false;
           }
        }
    }


}

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

        public int registarUser(string user, string pw)
        {
           //OleDbConnection connection = GetConnection(true);
            /*OleDbCommand con = new OleDbCommand("select MAX(IdUser) from User");
            int id = (int)con.ExecuteScalar();
            */
            //OleDbConnection conn = GetConnection(true);/*
          /* OleDbCommand sqlcmd = new OleDbCommand("INSERT INTO User (IdUser,username,password,tipo) VALUES ("+1+","+user+","+pw+",user)", CurrentTransaction.Connection, CurrentTransaction);
           ExecuteNonQuery(CurrentTransaction, sqlcmd);*/
            //return true;


            OleDbConnection cnx = GetConnection(true);
            OleDbCommand sqlcmd =
                new OleDbCommand("INSERT INTO User (IdUser,username,password) VALUES(?,?,?)",
                    CurrentTransaction.Connection, CurrentTransaction);
            sqlcmd.Parameters.Add(1);
            sqlcmd.Parameters.Add(user);
            sqlcmd.Parameters.Add(pw);
            return ExecuteNonQuery(CurrentTransaction, sqlcmd);
        }
    }


}

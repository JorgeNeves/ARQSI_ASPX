﻿using System;
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
    }


}

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
            OleDbConnection connection = GetConnection(true);
            OleDbCommand con = new OleDbCommand("select MAX(IdUser) from User");
            int id = (int)con.ExecuteScalar();

            OleDbCommand cnx = new OleDbCommand("INSERT INTO User (idUser,username,password,tipo) VALUES (?,?,?,user)");
            cnx.Parameters.AddWithValue("@id", id);
            cnx.Parameters.AddWithValue("@user", user);
            cnx.Parameters.AddWithValue("pw", pw);
            cnx.ExecuteNonQuery();
            return true;
        }
    }


}

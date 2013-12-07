using System.Data;

namespace Table_Model.BLL
{
    public class User{

        public User()
        {

        }

        public bool isValidUser(string user,string pw)
        {
            DAL.UserGateway dal = new DAL.UserGateway();
            return dal.validUser(user, pw);
        }

        public bool registarUser(string user, string pw,string email)
        {
            DAL.UserGateway dal = new DAL.UserGateway();
            return dal.registarUser(user, pw,email);
        }

        public string validUser(string user)
        {
            DAL.UserGateway dal = new DAL.UserGateway();
            return dal.getTipoUser(user);
        }
        public int getidUser(string user)
        {
            DAL.UserGateway dal = new DAL.UserGateway();
            return dal.getiduser(user);
        }

        public DataTable GetUsers()
        {
            DAL.UserGateway p = new DAL.UserGateway();
            return p.GetUsers();
        }

        public void alterarTipo(int id, string tipo){
            DAL.UserGateway p = new DAL.UserGateway();
            p.alterarTipo(id, tipo);
        }
    }
}
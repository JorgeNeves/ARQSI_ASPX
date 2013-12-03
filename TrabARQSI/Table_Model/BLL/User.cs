

namespace Table_Model.BLL
{
    public class User{

        public User()
        {

        }

        public bool isValidUser()
        {
            return true;
        }

        public bool registarUser(string user, string pw)
        {
            DAL.UserGateway dal = new DAL.UserGateway();
            return dal.registarUser(user, pw);
        }
    }
}
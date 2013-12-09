using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Model.BLL
{
   public class Encomenda
    {
        public Encomenda()
        {
        }
        public void add(int iduser, int idcar)
        {
            DAL.EncomendasGateway encg = new DAL.EncomendasGateway();
            encg.add(iduser, idcar);
        }
        public DataTable getEncomendas(int idUser)
        {
            DAL.EncomendasGateway encg = new DAL.EncomendasGateway();
            return encg.getEncomendas(idUser);
        }
    }
}

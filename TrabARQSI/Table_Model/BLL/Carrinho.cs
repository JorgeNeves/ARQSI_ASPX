using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Table_Model.BLL
{
   public class Carrinho
    {
        public Carrinho(){}
        public DataTable getElementosCarrinho(int idUser){
            DAL.CarrinhoGateway cg =new DAL.CarrinhoGateway();
            return cg.getElementos(idUser);
        }
        public void eliminarCarrinho(int idUser)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            cg.removerCarrinho(idUser);
        }
    }
}

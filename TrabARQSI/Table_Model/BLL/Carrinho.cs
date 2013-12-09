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
        public int ncarrinhos(int idUser)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            return cg.ncarrinhos(idUser);
        }
        public void novocarrinho(int idUser)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            cg.novocarrinho(idUser);
        }
        public void eliminarelementosCarrinho(int idUser)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            cg.removerelementosCarrinho(idUser);
        }
        public int getidcarrinho(int idUser)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            return cg.getidcarrinho(idUser);
        }
        public void eliminarelementoCarrinho(int idUser, int idCar, string nome, string edicao)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            cg.removerelementoCarrinho(idUser, idCar, nome, edicao);

        }
        public void atualizaquantidadeproduto(int idUser, int idCar, string nome, string edicao, int novaqtdd)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            cg.atualizarquantidadeproduto(idUser, idCar, nome, edicao, novaqtdd);
        }
        public void addelementoCarrinho(int idUser, int idCar, string nome, string edicao,int quantidade)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            cg.addelementocarrinho(idUser, idCar, nome, edicao, quantidade);
        }

        public void setfalse(int idcar)
        {
            DAL.CarrinhoGateway cg = new DAL.CarrinhoGateway();
            cg.setfalse(idcar);

        }
    }
}

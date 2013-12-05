using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_Model.BLL
{
    public class Produto
    {
        public Produto() { }

        public bool inserirProduto(string nome, string preco, int quantidade, string genero, string edicao)
        {
            DAL.ProdutoGateway p = new DAL.ProdutoGateway();
            return p.insereProduto(nome, preco, quantidade, genero, edicao);
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
namespace TrabARQSI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnviaProdutos" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EnviaProdutos.svc or EnviaProdutos.svc.cs at the Solution Explorer and start debugging.
    public class EnviaProdutos : IEnviaProdutos
    {
        public void DoWork()
        {
        }

        public void enviaProdutos()
        {
            string[][] envio = null;
            Table_Model.BLL.Produto p = new Table_Model.BLL.Produto();
            DataTable dt = p.GetProdutos();
            var stringArr = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            
        }
    }
}

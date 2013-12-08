using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TrabARQSI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnviaProdutos" in both code and config file together.
    [ServiceContract]
    public interface IEnviaProdutos
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        void enviaProdutos();
    }
}

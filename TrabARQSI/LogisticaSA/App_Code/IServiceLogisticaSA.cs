using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceLogisticaSA" in both code and config file together.
[ServiceContract]
public interface IServiceLogisticaSA
{
	[OperationContract]
	void DoWork();

    [OperationContract]
    float custo(int quantidade);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLogisticaSA" in code, svc and config file together.
public class ServiceLogisticaSA : IServiceLogisticaSA
{
	public void DoWork()
	{
	}

    public float custo(int quantidade)
    {
        if (quantidade > 5)
        {
            return (float)(quantidade * 0.90);
        }
        else
        {
            return (float)(quantidade * 1.80);
        }
        
    }
}

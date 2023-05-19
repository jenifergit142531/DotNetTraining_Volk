using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface ICalculator
{
	[OperationContract]
	int sum(int x, int y);

    [OperationContract]
    int sub(int x, int y);

    [OperationContract]
    int multiple(int x, int y);

    [OperationContract]
    int divide(int x, int y);


	
}

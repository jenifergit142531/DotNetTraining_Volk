using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public List<EStock> GetStocks()
    {
        DemoEntities1 de = new DemoEntities1();
        var result = from i in de.EStocks
                     select i;
        return result.ToList<EStock>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class CalculatorService: ICalculator
{
    public int divide(int x, int y)
    {
        return x / y;
    }

    public int multiple(int x, int y)
    {
        return x * y;
    }

    public int sub(int x, int y)
    {
        return x - y;
    }

    public int sum(int x, int y)
    {
        return x + y;
    }
}


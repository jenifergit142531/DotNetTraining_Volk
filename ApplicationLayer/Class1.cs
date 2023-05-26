using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace ApplicationLayer
{
    public class Class1
    {
        
    }
    public class ApplicationLayer1

    {
        DatabaseLayer1 dl = new DatabaseLayer1();

        public void InsertGame(int gid,string gname)
        {
            dl.add(gid, gname);
        }


        public DataTable SelectGame()
        {
            return dl.select();
        }


    }
}

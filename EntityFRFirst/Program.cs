using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFRFirst.Model;
using System.Data.SqlClient;

namespace EntityFRFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (mcsContext db = new mcsContext())
            {
                foreach (var stopReason in db.TablesStopReasons)
                {
                    Console.WriteLine(stopReason.intStopReason + " " + stopReason.strReason);
                }
            }
        }
    }
}

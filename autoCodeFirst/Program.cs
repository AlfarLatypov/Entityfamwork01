using autoCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MCS db = new MCS())
            {
                foreach (var stopReason in db.AccessTab)
                {
                    Console.WriteLine(stopReason.TabId + " " + stopReason.TabName);
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFRFirst.Model
{
    public class mcsContext : DbContext
    {
        public mcsContext() : base ("name=MCS")
        {
             
        }
        public virtual DbSet<TablesStopReason> TablesStopReasons { get; set; }
    }
}

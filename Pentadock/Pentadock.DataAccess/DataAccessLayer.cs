using Pentadock.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentadock.DataAccess
{
    public class DataAccessLayer : DbContext
    {
        public DataAccessLayer() : base("PentadockContext")
        {
        }

        public DbSet<Kiddo> Kiddos { get; set; }
        public DbSet<WeeklyAllowance> WeeklyAllowances { get; set; }
        public DbSet<WeeklyStatus> WeeklyStatuses { get; set; }
    }
}

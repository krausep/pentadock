using Pentadock.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentadock.DataAccess
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DataAccessLayer>
    {
        protected override void Seed(DataAccessLayer context)
        {
            var kiddos = new List<Kiddo>
             {
                 new Kiddo{ Id = 1, Name = "David", WeeklyAllowance = new WeeklyAllowance{ Id = 1, Amount = 4.0M } },
                 new Kiddo{ Id = 2, Name = "Nathan", WeeklyAllowance = new WeeklyAllowance{ Id = 2, Amount = 3.0M } }
             };

            foreach (var k in kiddos)
                context.Kiddos.Add(k);
            
        }
    }
}

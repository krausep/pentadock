using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentadock.Models
{
    public class Kiddo
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual WeeklyAllowance WeeklyAllowance { get; set; }

        public virtual ICollection<WeeklyStatus> WeeklyStatuses { get; set; }

    }
}

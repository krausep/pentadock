using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentadock.Models
{
    public class WeeklyStatus
    {
        public int Id { get; set; }
        public DateTime WeekBeginning { get; set; }
        public double AmountEarned { get; set; }
    }
}

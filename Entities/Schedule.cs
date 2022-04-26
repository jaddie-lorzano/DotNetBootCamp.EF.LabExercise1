using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        [Column(TypeName = "date")]
        public DateTime Day { get; set; }
        public int ShiftID { get; set; }
        public int EmployeeID { get; set; }
        [Column(TypeName = "money")]
        public decimal HourlyWage { get; set; }
        public bool OverTime { get; set; }
    }
}

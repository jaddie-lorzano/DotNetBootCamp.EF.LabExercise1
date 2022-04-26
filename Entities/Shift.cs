using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        public int ShiftID { get; set; }
        public int PlacementContractID { get; set; }
        public int DayOfWeek { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan StartTime { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan EndTime { get; set; }
        [Column(TypeName = "tinyint")]
        public int NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        [Column(TypeName = "nvarchar(100) (null)")]
        public string Notes { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
